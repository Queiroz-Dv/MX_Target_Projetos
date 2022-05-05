using MX_Target_Projetos.Configurations;
using System;

namespace MX_Target_Projetos.Menus
{
    public class AboutMe
    {
        public static void Show()
        {
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(0, ""));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "   =================================================================   "));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| Nome: Eduardo B. C. Queiroz                                                          ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| Idade: 26                                                         ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| Formação: Letras e ADS - FACAP                                    ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| Idiomas: Inglês e Português                                       ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| Hobbies: Leitura e Artes                                          ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 0. Voltar                                                         ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "   =================================================================   "));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(0, ""));
            GlobalConfig.DrawLine();
            Console.BackgroundColor = ConsoleColor.Black;
            var opt = short.Parse(Console.ReadLine());
            if (opt == 0)
            {
                Home.Load();
            }
        }
    }
}