using MX_Target_Projetos.Configurations;
using MX_Target_Projetos.Entities;
using MX_Target_Projetos.ValueObjects;
using System;

namespace MX_Target_Projetos.ProjetosMedios
{
    public class MediaProcess
    {
        public static void Load()
        {
            GetStudent();
        }

        private static void GetStudent()
        {

            GlobalConfig.Center("Digite o nome do aluno: ");
            string firstName = Console.ReadLine();

            GlobalConfig.Center("Digite o sobrenome do aluno: ");
            string lastName = Console.ReadLine();

            GlobalConfig.Center("Digite a idade do aluno: ");
            int age = int.Parse(Console.ReadLine());

            GlobalConfig.Center("Digite o documento do aluno: ");
            string studentDocument = Console.ReadLine();

            GlobalConfig.Center("Digite o número do documento escolar: ");
            var schoolDocument = Console.ReadLine();

            GetMedia(firstName, lastName, age, studentDocument, schoolDocument);
        }

        protected static void GetMedia(string firstName, string lastName, int age, string studentDocument, string schoolDocument)
        {
            Console.Clear();
            Name name = new Name(firstName, lastName);
            Document document = new Document(studentDocument, Enums.EDocumentType.CPF);
            SchoolDocument studentSchoolDocument = new SchoolDocument(schoolDocument, Enums.ESchoolDocumentType.Publico);
            Student student = new Student(name, age, document, studentSchoolDocument);

            double? n1 = null;
            while (n1 == null)
            {
                try
                {
                    GlobalConfig.Center("Digite a primeira nota: ");
                    n1 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    GlobalConfig.Center("Primeira nota inválida. Digite novamente.");
                }
            }

            double? n2 = null;
            while (n2 == null)
            {
                try
                {
                    GlobalConfig.Center("Digite a segunda nota: ");
                     n2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    GlobalConfig.Center("Segunda nota inválida. Digite novamente.");
                }
            }

            double? n3 = null;
            while (n3 == null)
            {
                try
                {
                    GlobalConfig.Center("Digite a terceira nota: ");
                    n3 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    GlobalConfig.Center("Terceira nota inválida. Digite novamente.");
                }
            }


            if (n1 < 0 || n2 < 0 || n3 < 0)
            {
                Console.WriteLine("Números de notas não podem ser negativos.");
                Console.ReadKey();
                GetStudent();
            }
            else
            {
                int md = Convert.ToInt32((n1 + n2 + n3) / 3);
                if (md < 5)
                {
                    GlobalConfig.Center($"Aluno: {firstName}");
                    GlobalConfig.Center($"Sobrenome: {lastName}");
                    GlobalConfig.Center($"Idade: {age}");
                    GlobalConfig.Center($"Documento: {studentDocument}");
                    GlobalConfig.Center($"Documento Escolar: {schoolDocument}");
                    GlobalConfig.Center($"Reprovado. A média foi: {md}");
                    Console.ReadKey();
                }
                else if (md >= 7)
                {
                    GlobalConfig.Center($"Aluno: {firstName}");
                    GlobalConfig.Center($"Sobrenome: {lastName}");
                    GlobalConfig.Center($"Idade: {age}");
                    GlobalConfig.Center($"Documento: {studentDocument}");
                    GlobalConfig.Center($"Documento Escolar: {schoolDocument}");
                    GlobalConfig.Center($"Aprovado. A média foi: {md}");
                    Console.ReadKey();
                }
                else
                {
                    GlobalConfig.Center($"Aluno: {firstName}");
                    GlobalConfig.Center($"Sobrenome: {lastName}");
                    GlobalConfig.Center($"Idade: {age}");
                    GlobalConfig.Center($"Documento: {studentDocument}");
                    GlobalConfig.Center($"Documento Escolar: {schoolDocument}");
                    GlobalConfig.Center($"Em recuperação. A média foi: {md}");
                    Console.ReadKey();
                }
            }
        }
    }
}