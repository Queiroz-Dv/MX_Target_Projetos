using MX_Target_Projetos.Interfaces;
using MX_Target_Projetos.ValueObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace MX_Target_Projetos.Core
{
    public abstract class Base : IPerson
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

        public Name Name;
        public int Age;
        public string Phone;
        public Document Document;

        public void SetName(Name name) { Name = name; }
        public void SetAge(int age) { Age = age; }
        public void SetPhone(string phone) { Phone = phone; }
        public void SetDocument(Document document) { Document = document; }


        public virtual void Save()
        {
            var data = this.Reader();
            data.Add(this);

            StreamWriter writer = new StreamWriter(FilePath());
            writer.WriteLine("name;age;phone;document");
            foreach (Base personData in data)
            {
                var line = $"{personData.Name.FirstName} ; {personData.Age} ; {personData.Phone} ; {personData.Document} ;";

                writer.WriteLine(line);
            }

            writer.Close();
        }

        public virtual List<IPerson> Reader()
        {
            var data = new List<IPerson>();

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

                        var basePerson = (IPerson)Activator.CreateInstance(this.GetType());
                        basePerson.SetName(baseFile[0]);
                        basePerson.SetPhone(baseFile[1]);
                        basePerson.SetDocument(baseFile[2]);

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
