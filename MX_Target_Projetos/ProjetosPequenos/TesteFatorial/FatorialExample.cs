using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteFatorial
{
    public class FatorialExample
    {
        public static void Load()
        {
            Console.WriteLine("Agora irei te mostrar um exemplo do que eu faço!");
            Console.ReadKey();
            Example();
            Console.ReadKey();
        }

        private static void Example()
        {
            int fat = 1;
            int v = 6;
            for (int i = 2; i <= v; i++)
            {
                fat *= i;
                Console.WriteLine("Fator: " + fat);
            }
            Console.WriteLine("O fatorial de " + v + " é igual a " + fat);
        }
    }
}