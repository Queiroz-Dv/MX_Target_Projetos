using MX_Target_Projetos.Configurations;
using MX_Target_Projetos.Menus;
using System;

namespace MX_Target_Projetos.ProjetosMedios
{
    public class MediaMenu
    {
        public static void Load()
        {
            while (true)
            {
                Console.Clear();
                GlobalConfig.Center("Bem-vindo ao Projeto de Média");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                GlobalConfig.DrawLine();
                Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 1. Testar                       ||"));
                Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 0. Voltar                       ||"));
                GlobalConfig.DrawLine();
                Console.BackgroundColor = ConsoleColor.Black;
                short res = short.Parse(Console.ReadLine());
                if (res == 1)
                {
                    MediaProcess.Load();
                }
                else if (res == 0)
                {
                    ProjetosMediosMenu.Load();
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
