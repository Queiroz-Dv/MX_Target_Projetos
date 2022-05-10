using MX_Target_Projetos.Entities;
using MX_Target_Projetos.Enums;
using MX_Target_Projetos.ValueObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace MX_Target_Projetos.Core
{
    public abstract class Base
    {
        protected Base(Name name, int age, string phone, Document document)
        {
            Name = name;
            Age = age;
            Phone = phone;
            Document = document;
        }

        public Base()
        {

        }

        private Name _Name;
        public Name Name
        {
            get
            {
                return _Name;
            }
            set
            {
                //_Name = value;
                if (value.FirstName.Length < 3)
                    Console.WriteLine("Nome deve conter pelo menos 3 caracteres");

                if (value.LastName.Length > 40)
                    Console.WriteLine("Nome deve conter pelo menos 40 caracteres");
            }
        }

        private Document _Document;

        public Document Document
        {
            get
            {
                return _Document;
            }
            set
            {
                if (value.Type == EDocumentType.CNPJ && value.Number.Length == 14)
                    _Document = value;

                if (value.Type == EDocumentType.CPF && value.Number.Length == 11)
                    _Document = value;

                throw new ArgumentOutOfRangeException("É necessário que o número digitado esteja entre 11 e 14.");
            }
        }

        public int Age;
        public string Phone;

        public virtual void Save()
        {
            var data = this.Reader();
            //data.Add(new );
            // data.Add(this);

            StreamWriter writer = new StreamWriter(FilePath());
            writer.WriteLine("name;age;phone;document");
            IList list = data;
            for (int i = 0; i < list.Count; i++)
            {
                Base personData = (Base)list[i];
                var line = $"{personData.Name} ; {personData.Age} ; {personData.Phone} ; {personData.Document} ;";

                writer.WriteLine(line);
            }

            writer.Close();
        }

        public virtual List<Person> Reader()
        {
            var data = new List<Person>();

            if (File.Exists(FilePath()))
            {
                using (StreamReader file = File.OpenText(FilePath()))
                {
                    string line;
                    int i = 0;
                    while ((line = file.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var baseFile = line.Split(';');

                        var basePerson = (Person)Activator.CreateInstance(this.GetType());
                        //basePerson.SetName(baseFile[0]);
                        //basePerson.SetName(new Name(baseFile[0], baseFile[1]));
                        this.Name = new Name(baseFile[0], baseFile[1]);
                        this.Age = Convert.ToInt32(baseFile[2]);
                        this.Phone = baseFile[3];
                        this.Document = new Document(baseFile[4], EDocumentType.CPF);
                        //basePerson.SetPhone(baseFile[1]);
                        //basePerson.SetDocument(baseFile[2]);

                        data.Add(basePerson);
                    }
                }

            }

            return data;
        }

        public string FilePath()
        {
            //var teste = ConfigurationManager.AppSettings["PathFiles"] + this.GetType().Name + ".txt";
            return ConfigurationManager.AppSettings["PathFiles"] + this.GetType().Name + ".txt";
        }
    }
}
