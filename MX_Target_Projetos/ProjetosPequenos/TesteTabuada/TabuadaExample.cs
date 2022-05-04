using MX_Target_Projetos.Configurations;
using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteTabuada
{
    public class TabuadaExample
    {
        public static void Load()
        {
            GlobalConfig.Center("Agora irei calcular a multiplicação do número nove como exemplo");
            Console.ReadKey();
            Example();
            GlobalConfig.Center("Aperte qualquer tecla para continuar.");
            Console.ReadKey();
        }

        private static void Example()
        {
            int nine = 9;
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + " x " + nine + " = ");
                Console.WriteLine(i * nine);
            }
        }
    }
}