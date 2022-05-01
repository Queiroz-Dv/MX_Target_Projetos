using MX_Target_Projetos.Configurations;
using System;

namespace MX_Target_Projetos.ProjetosPequenos.TestePularNumero
{
    public class JumpNumber
    {
        public JumpNumber()
        {
            Console.Title = "Pular Números";
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Load()
        {
            while (true)
            {
                Console.Clear();
                GlobalConfig.Center("Bem-vindo ao Teste de Pular Números");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                GlobalConfig.DrawLine();
                Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 1. Exemplo                      ||"));
                Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 2. Testar                       ||"));
                Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 0. Voltar                       ||"));
                GlobalConfig.DrawLine();
                Console.BackgroundColor = ConsoleColor.Black;
                short res = short.Parse(Console.ReadLine());
                if (res == 1)
                {
                    TestJump.Load();
                }
                else if (res == 2)
                {
                    RunJump.Load();
                }
                else if (res == 0)
                {
                    AccessMenu.Load();
                    break;
                }
                else
                {
                    GlobalConfig.Center("Valor inválido, aperte qualquer tecla para retorna");
                    Console.ReadKey();
                }
            }
        }
    }
}
