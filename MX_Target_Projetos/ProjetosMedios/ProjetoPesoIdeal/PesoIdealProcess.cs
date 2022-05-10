using MX_Target_Projetos.Configurations;
using MX_Target_Projetos.Entities;
using MX_Target_Projetos.ValueObjects;
using System;

namespace MX_Target_Projetos.ProjetosMedios.ProjetoPesoIdeal
{
    public class PesoIdealProcess
    {
        public static void Load()
        {
            Console.Clear();
            GetData();
        }

        private static void GetData()
        {
            
            GlobalConfig.Center("Digite seu nome: ");
            string firstName = Console.ReadLine();

            GlobalConfig.Center("Digite seu sobrenome: ");
            string lastName = Console.ReadLine();

            GlobalConfig.Center("Digite o seu sexo: ");
            var gender = Console.ReadLine();

            GlobalConfig.Center("Digite sua data de nascimento: ");
            string birthdate = Console.ReadLine();
            
            GlobalConfig.Center("Digite sua altura: ");
            string height = Console.ReadLine();

            var name = new Name(firstName, lastName);
            new ImcPerson(name,birthdate, height, gender);
            
            ProcessData(name, gender, birthdate, height);
        }

        private static void ProcessData(Name name, string gender, string birthdate, int weight, string height)
        {
            GlobalConfig.Center($"Dados de {name}");
            Console.WriteLine("");
            GlobalConfig.Center($"Data de Nascimento: {birthdate}");
        }
    }
}