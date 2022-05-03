using MX_Target_Projetos.Configurations;
using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteTabuada
{
    public class TabuadaMenu
    {
        public TabuadaMenu()
        {
            Console.Title = "Tabuada";
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Load()
        {
            while (true)
            {
                Console.Clear();
                GlobalConfig.Center("Bem-vindo a Tabuada");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                GlobalConfig.DrawLine();
                Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 1. Exemplo                             ||"));
                Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 2. Multiplicação                       ||"));
                Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 3. Adição                              ||"));
                Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 4. Subtração                           ||"));
                Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 5. Divisão                             ||"));
                Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 6. Voltar                              ||"));
                GlobalConfig.DrawLine();
                Console.BackgroundColor = ConsoleColor.Black;

                short res = short.Parse(Console.ReadLine());
                switch (res)
                {
                    case 1: TabuadaExample.Load();  break;
                    case 2: Multiplicar.Load();     break;
                    case 3: Adicao.Load();          break;
                    case 4: Subtracao.Load();       break;
                    case 5: Divisao.Load();         break;
                    case 0: AccessMenu.Load();      break;

                    default:
                            GlobalConfig.Center("Valor inválido, aperte qualquer tecla para retorna");
                            Console.ReadKey();
                            continue;
                }
            }
        }
    }
}
