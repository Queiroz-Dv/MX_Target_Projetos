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

            GlobalConfig.Center("Digite a primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());

            GlobalConfig.Center("Digite a segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());

            GlobalConfig.Center("Digite a terceira nota: ");
            double n3 = double.Parse(Console.ReadLine());

            if (n1 == -1 || n2 == -1 || n3 == -1)
            {
                Console.WriteLine("Números inválidos.");
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