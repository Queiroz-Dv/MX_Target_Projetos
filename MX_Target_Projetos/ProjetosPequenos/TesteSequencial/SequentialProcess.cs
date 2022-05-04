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
            GlobalConfig.Center("Digite um número inicial para que eu possa contar: ");
            int firstNumber = int.Parse(Console.ReadLine());
            GlobalConfig.Center("Até quanto você quer que eu conte?");
            int lastNumber = int.Parse(Console.ReadLine());

            ProcessData(firstNumber, lastNumber);
        }

        private static void ProcessData(int firstNumber, int lastNumber)
        {
            new ProcessNumber(firstNumber, lastNumber);
        }
    }
}