using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteFibonacci
{
    public class FibonacciExample
    {
        public static void Load()
        {
            Example();
        }

        private static void Example()
        {
            Console.WriteLine("Veja o exemplo abaixo");
            Console.ReadKey();
            int f = 1;
            for (int i = 0, c = 0; c < 15; c++)
            {
                Console.WriteLine("Exemplo: " + i);
                i = i + f;
                f = i - f;
            }
            Console.ReadKey();
        }
    }
}