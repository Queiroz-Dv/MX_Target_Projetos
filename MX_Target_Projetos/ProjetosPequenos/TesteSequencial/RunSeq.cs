using MX_Target_Projetos.Configurations;
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

                Decrement(firstNumber, lastNumber, out fNumber, out lNumber);
            }
            else
            {
                Increment(firstNumber, lastNumber, out fNumber, out lNumber);
            }
        }


        private static void Decrement(int firstNumber, int lastNumber, out int fNumber, out int lNumber)
        {
            fNumber = firstNumber + 1;
            lNumber = lastNumber + 1;
            while (fNumber >= lNumber)
            {
                --fNumber;
                Console.WriteLine(fNumber);
            }
            GlobalConfig.Center("Aperte qualquer tecla para continuar");
            Console.ReadKey();
        }

        private static void Increment(int firstNumber, int lastNumber, out int fNumber, out int lNumber)
        {
            fNumber = firstNumber - 1;
            lNumber = lastNumber - 1;
            while (fNumber <= lNumber)
            {
                fNumber = ++fNumber;
                Console.WriteLine(fNumber);
            }
            GlobalConfig.Center("Aperte qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}