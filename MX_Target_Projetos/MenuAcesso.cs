using MX_Target_Projetos.Configuratios;
using MX_Target_Projetos.ProjetosPequenos;
using System;

namespace MX_Target_Projetos
{
    public static class MenuAcesso
    {
        public static void Load()
        {
            MenuAcessoConfig config = new MenuAcessoConfig();
            Console.Clear();
            GlobalConfig.Centralizar("==== Bem Vindo ao Portfólio de Sistemas Realizados por E.Queiroz ====\n");
            GlobalConfig.Centralizar("Hoje é " + DateTime.Now.ToLongDateString());
            Console.BackgroundColor = ConsoleColor.DarkGray;
            GlobalConfig.Linha();

            WriterOptions();
            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        private static void WriterOptions()
        {
            Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(0, ""));
            Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "  =================================================="));
            Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "|| Projetos e Testes de Pequena Complexidade         ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "|| 0. Próxima página >>                              ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "|| 1. Teste Contador Sequencial                      ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "|| 2. Teste Pular Números                            ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "|| 3. Teste Contínuo                                 ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "|| 4. Teste Tabuada                                  ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "|| 5. Teste Fatorial                                 ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "|| 6. Teste Fibonacci                                ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "|| 7. Teste If Complexo                              ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "|| 8. Teste Switch Complexo                          ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "|| 9. Teste Validade                                 ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "|| 10. Fechar diário                                 ||"));
            Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "  =================================================="));
            Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(0, ""));
            GlobalConfig.Linha();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n{0}", GlobalConfig.AlinhaTexto(36, "Escolha uma das opções de estudos realizados : ", "Esquerda"));
        }

        private static void HandleMenuOption(short option)
        {
            
            switch (option)
            {
                case 1:
                    Sequencial.Load();
                    break;
                case 2:
                    Console.WriteLine("View");
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