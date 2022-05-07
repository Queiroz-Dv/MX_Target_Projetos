using MX_Target_Projetos.Configurations;
using MX_Target_Projetos.Entities;
using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteSequencial
{
    public class SequentialProcess
    {
        public static void Load()
        {

            Console.Clear();
            int? firstNumber = null;
            while (firstNumber == null)
            {
                try
                {
                    GlobalConfig.Center("Digite um número inicial para que eu possa contar: ");
                    firstNumber = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    GlobalConfig.Center("Número digitado inválido. Digite novamente.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            int? lastNumber = null;
            while (lastNumber == null)
            {
                try
                {
                    GlobalConfig.Center("Até quanto você quer que eu conte?");
                    lastNumber = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    GlobalConfig.Center("Número digitado inválido. Digite novamente.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            ProcessData(firstNumber, lastNumber);
        }

        private static void ProcessData(int? firstNumber, int? lastNumber)
        {
            new ProcessNumber(firstNumber, lastNumber);
        }
    }
}