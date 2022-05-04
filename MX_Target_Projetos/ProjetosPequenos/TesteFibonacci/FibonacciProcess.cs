using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteFibonacci
{
    public class FibonacciProcess
    {
        public static void Load()
        {
            int number = GetNumber();
            int f = 1;
            GenerateResult(number, f);
            Console.ReadKey();
        }

        private static int GetNumber()
        {
            Console.WriteLine("Digite um número:");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("Número inválido. Tente novamente");
                Console.ReadKey();
                Console.Clear();
            }
            return number;
        }

        private static void GenerateResult(int number, int f)
        {
            for (int i = 0, j = 0; j <= number; j++)
            {
                Console.WriteLine("Resultado: " + i);
                i = i + f;
                f = i - f;
            }
        }
    }
}