using MX_Target_Projetos.Configurations;
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
            int fNumber = firstNumber;
            int jumpNum = jumper;
            int lNumber = lastNumber;

            if (fNumber <= lNumber)
            {
                for (int x = 0; fNumber < lNumber; x++)
                {
                    fNumber = fNumber + lNumber;
                    Console.WriteLine(fNumber);
                }
                Console.WriteLine("Contagem finalizada!");
                GlobalConfig.Center("Aperte qualquer tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Você descobriu o modo secreto de decremento!");
                Console.WriteLine("Iremos contar diminuindo os números!");
                Console.ReadKey();
                while (fNumber > lNumber)
                {
                    fNumber = fNumber - lNumber;
                    Console.WriteLine(fNumber);
                }
                Console.WriteLine("Contagem finalizada!");
                GlobalConfig.Center("Aperte qualquer tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}