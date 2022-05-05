using MX_Target_Projetos.Configurations;
using System;

namespace MX_Target_Projetos.Menus
{
    public class AboutMe
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(0, ""));
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(25, "   =================================================================  "));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(25, "|| Nome: Eduardo B. C. Queiroz                                        "));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(25, "|| Idade: 26                                                          "));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(25, "|| Formação: Letras e ADS - FACAP                                     "));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(25, "|| Idiomas: Inglês e Português                                        "));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(25, "|| Hobbies: Leitura e Artes                                           "));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(25, "|| 0. Voltar                                                          "));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(25, "   =================================================================  "));
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