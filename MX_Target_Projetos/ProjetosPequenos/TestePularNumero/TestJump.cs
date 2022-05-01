using MX_Target_Projetos.Configurations;
using System;

namespace MX_Target_Projetos.ProjetosPequenos.TestePularNumero
{
    public class TestJump
    {
        public static void Load()
        {
            GlobalConfig.Center("Agora irei contar de dois em dois para você como exemplo.");
            Example();
            GlobalConfig.Center("Digite alguma tecla para continuar!");
            Console.ReadKey();
        }

        private static void Example()
        {
            Console.ReadKey();
            for (int x = 1; x < 100; x += 2)
            {
                Console.WriteLine(x);
            }
        }
    }
}