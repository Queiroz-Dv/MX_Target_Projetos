using MX_Target_Projetos.Configurations;
using MX_Target_Projetos.Entities;
using System;

namespace MX_Target_Projetos.ProjetosPequenos.TestePularNumero
{
    public class JumpProcess
    {
        public static void Load()
        {
            GlobalConfig.Center("Digite o número a ser contado:");
            int firstNumber = int.Parse(Console.ReadLine());

            GlobalConfig.Center("Digite de quanto em quanto quer que eu conte?");
            int jumper = int.Parse(Console.ReadLine());

            GlobalConfig.Center("Digite até quanto quer que eu conte: ");
            int lastNumber = int.Parse(Console.ReadLine());

            ProcessData(firstNumber, jumper, lastNumber);
        }

        private static void ProcessData(int firstNumber, int jumper, int lastNumber)
        {
            Console.Clear();
            var process = new ProcessNumber(firstNumber,jumper, lastNumber);
        }
    }
}