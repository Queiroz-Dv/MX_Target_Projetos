using MX_Target_Projetos.Configurations;
using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteSequencial
{
    public class TestExample
    {
        public static void Load()
        {
            Example();
        }

        private static void Example()
        {
            GlobalConfig.Center("Agora eu irei contar de 10 a 25 como exemplo");
            Console.ReadKey();
            int n = 10;
            while (n <= 24)
            {
                n++;
                Console.WriteLine(n);
            }
            GlobalConfig.Center("Aperte qualquer tecla para continuar.");
            Console.ReadKey();
        }
    }
}
