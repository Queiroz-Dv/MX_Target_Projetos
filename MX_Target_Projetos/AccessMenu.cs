using MX_Target_Projetos.Configurations;
using MX_Target_Projetos.ProjetosPequenos.TesteContinuo;
using MX_Target_Projetos.ProjetosPequenos.TestePularNumero;
using MX_Target_Projetos.ProjetosPequenos.TesteSequencial;
using System;

namespace MX_Target_Projetos
{
    public static class AccessMenu
    {
        public static void Load()
        {
            AccessMenuConfig config = new AccessMenuConfig();
            Console.Clear();
            GlobalConfig.Center("==== Bem Vindo ao Portfólio de Sistemas Realizados por E.Queiroz ====\n");
            GlobalConfig.Center("Hoje é " + DateTime.Now.ToLongDateString());
            Console.BackgroundColor = ConsoleColor.DarkGray;
            GlobalConfig.DrawLine();

            MenuOption();
            var opt = short.Parse(Console.ReadLine());
            LoadOptions(opt);
        }

        private static void MenuOption()
        {
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(0, ""));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "  ==================================================   "));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| Projetos e Testes de Pequena Complexidade         ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 0. Próxima página >>                              ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 1. Teste Contador Sequencial                      ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 2. Teste Pular Números                            ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 3. Teste Contínuo                                 ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 4. Teste Tabuada                                  ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 5. Teste Fatorial                                 ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 6. Teste Fibonacci                                ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 7. Teste If Complexo                              ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 8. Teste Switch Complexo                          ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 9. Teste Validade                                 ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 10. Fechar diário                                 ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "  =================================================="));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(0, ""));
            GlobalConfig.DrawLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n{0}", GlobalConfig.AlignText(36, "Escolha uma das opções de estudos realizados : ", "Left"));
        }

        private static void LoadOptions(short opt)
        {
            
            switch (opt)
            {
                case 1:
                    Sequential.Load();
                    break;
                case 2:
                    JumpNumber.Load();
                    break;
                case 3:
                    Counter.Load();
                    break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default:
                    //Show();
                    break;
            }
        }
    }
}