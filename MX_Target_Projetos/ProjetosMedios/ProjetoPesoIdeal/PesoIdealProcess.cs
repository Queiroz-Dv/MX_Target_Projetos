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
            string firstName = null;
            string lastName = null;
            string gender = null;
            string birthdate = null;
            double? height = null;

            while (firstName == null || lastName == null || gender == null || birthdate == null || height == null)
            {
                try
                {
                    GlobalConfig.Center("Digite seu nome: ");
                    firstName = Console.ReadLine();

                    GlobalConfig.Center("Digite seu sobrenome: ");
                    lastName = Console.ReadLine();

                    GlobalConfig.Center("Digite o seu sexo: ");
                    gender = Console.ReadLine();

                    GlobalConfig.Center("Digite sua data de nascimento: ");
                    birthdate = Console.ReadLine();

                    GlobalConfig.Center("Digite sua altura: ");
                    height = Convert.ToDouble(Console.ReadLine());

                   var imcPerson = new ImcPerson(new Name(firstName, lastName), birthdate, height, gender);
                }
                catch (Exception)
                {
                    GlobalConfig.Center("Dados incorretos. Digite novamente.");
                    Console.ReadKey();
                }
            }
        }

    }
}