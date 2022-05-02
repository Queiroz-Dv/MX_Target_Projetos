using MX_Target_Projetos.Configurations;
using MX_Target_Projetos.Entities;
using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteSequencial
{
    public class RunSeq
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
            int fNumber = firstNumber;
            int lNumber = lastNumber;
            if (fNumber >= lNumber)
            {
                GlobalConfig.Center("Esse é o modo secreto de decremento!");
                GlobalConfig.Center("Iremos contar em ordem decrescente!");
                GlobalConfig.Center("Aperte qualquer tecla para prosseguir");
                Console.ReadKey();
                ProcessNumber.Decrement(fNumber, lNumber);
                GlobalConfig.Center("Aperte qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                ProcessNumber.Increment(fNumber, lNumber);
                GlobalConfig.Center("Aperte qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}