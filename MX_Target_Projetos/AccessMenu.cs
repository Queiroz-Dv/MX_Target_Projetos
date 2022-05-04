using MX_Target_Projetos.Configurations;
using MX_Target_Projetos.ProjetosPequenos.TesteFatorial;
using MX_Target_Projetos.ProjetosPequenos.TesteFibonacci;
using MX_Target_Projetos.ProjetosPequenos.TestePularNumero;
using MX_Target_Projetos.ProjetosPequenos.TesteSequencial;
using MX_Target_Projetos.ProjetosPequenos.TesteTabuada;
using System;

namespace MX_Target_Projetos
{
    public static class AccessMenu
    {
        public static void Load()
        {
            new AccessMenuConfig();
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
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "   ==================================================   "));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| Projetos e Testes de Pequena Complexidade         ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 0. Próxima página >>                              ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 1. Teste Contador Sequencial                      ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 2. Teste Pular Números                            ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 3. Teste Tabuada                                  ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 4. Teste Fatorial                                 ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 5. Teste Fibonacci                                ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 6. Teste If Complexo                              ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 7. Teste Switch Complexo                          ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 8. Teste Validade                                 ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 9. Fechar diário                                  ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "   ==================================================   "));
            Console.WriteLine("|{0}|", GlobalConfig.AlignText(0, ""));
            GlobalConfig.DrawLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n{0}", GlobalConfig.AlignText(36, "Escolha uma das opções de estudos realizados : ", "Left"));
        }

        private static void LoadOptions(short opt)
        {
            switch (opt)
            {
                case 1: SequentialMenu.Load(); break;
                case 2: JumpMenu.Load();       break;
                case 3: TabuadaMenu.Load();    break;
                case 4: FatorialMenu.Load();   break;
                case 5: FibonacciMenu.Load();  break;
                case 0: Environment.Exit(0);   break;
                default: break;
            }
        }
    }
}