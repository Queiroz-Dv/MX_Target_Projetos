using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteContinuo
{
    public class CounterExample
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Agora irei contar até cem para você!");
            Console.ReadKey();
            RunExample();
        }

        private static void RunExample()
        {
            for (int x = 0; x < 100; x++)
            {
                Console.WriteLine(x);
            }
        }
    }
}