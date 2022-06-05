using MX_Target_Projetos.Configurations;
using MX_Target_Projetos.ProjetosMedios.CalculoSalarial;
using MX_Target_Projetos.ProjetosMedios.ProjetoMedia;
using MX_Target_Projetos.ProjetosMedios.ProjetoPesoIdeal;
using System;

namespace MX_Target_Projetos.Menus
{
    public class ProjetosMediosMenu
    {
        public static void Load()
        {
            Console.Clear();
            MenuOption();
        }

        private static void MenuOption()
        {
            Console.Clear();
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(0, ""));
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "   ==================================================   "));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| Projetos e Testes de Pequena Complexidade         ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 1. Sistema de Média                               ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 2. Sistema de IMC                                 ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 0. Voltar                                         ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "   ==================================================   "));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(0, ""));
            GlobalConfig.DrawLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n{0}", GlobalConfig.AlignText(36, "Escolha uma das opções de estudos realizados : ", "Left"));
            var opt = short.Parse(Console.ReadLine());
            LoadOptions(opt);
        }

        private static void LoadOptions(short opt)
        {
            switch (opt)
            {
                case 1: MediaMenu.Load();                       break;
                case 2: PesoIdealMenu.Load();                   break;
                case 3: CalculoSalario.Load();                  break;
                case 0: Home.Load();                            break;
                default:
                    Console.Clear();
                    MenuOption();
                    break;
            }
        }
    }      
}