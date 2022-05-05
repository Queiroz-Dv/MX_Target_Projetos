using MX_Target_Projetos.Configurations;
using System;

namespace MX_Target_Projetos.Menus
{
    public class Home
    {
        public static void Load()
        {
            new AccessMenuConfig();
            Console.Clear();
            GlobalConfig.Center("==== Bem Vindo ao Portfólio de Sistemas Realizados por E.Queiroz ====\n");
            GlobalConfig.Center("Hoje é " + DateTime.Now.ToLongDateString());
            Console.BackgroundColor = ConsoleColor.DarkGray;
            GlobalConfig.DrawLine();

            MenuOptions();
            var opt = short.Parse(Console.ReadLine());
            LoadOptions(opt);
        }

        private static void MenuOptions()
        {
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(0, ""));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "   =================================================================   "));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 1. Sobre                                                          ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 2. Projetos de Baixa Complexidade                                 ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 3. Projetos de Média Complexidade                                 ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 4. Projetos de Grande Complexidade                                ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 0. Sair                                                           ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "   =================================================================   "));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(0, ""));
            GlobalConfig.DrawLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n{0}", GlobalConfig.AlignText(36, "Escolha uma das opções: ", "Left"));
        }

        private static void LoadOptions(short opt)
        {
            switch (opt)
            {
                case 1: AboutMe.Show();                 break;
                case 2: ProjetosPequenosMenu.Load();    break;
                case 3: ProjetosMediosMenu.Load();      break;
                case 4: ProjetosGrandesMenu.Load();     break;
                case 0: Environment.Exit(0);            break;
                default:                                break;
            }
        }
    }
}
