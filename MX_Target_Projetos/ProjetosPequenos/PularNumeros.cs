using MX_Target_Projetos.Configuratios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MX_Target_Projetos.ProjetosPequenos
{
    public class PularNumeros
    {
        public PularNumeros()
        {
            Console.Title = "Pular Números";
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Load()
        {
            while (true)
            {
                Console.Clear();
                GlobalConfig.Centralizar("Bem-vindo ao Teste de Pular Números");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                GlobalConfig.Linha();
                Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "|| 1. Exemplo                      ||"));
                Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "|| 2. Testar                       ||"));
                Console.WriteLine("|{0}|", GlobalConfig.AlinhaTexto(35, "|| 0. Voltar                       ||"));
                GlobalConfig.Linha();
                Console.BackgroundColor = ConsoleColor.Black;
                short res = short.Parse(Console.ReadLine());
                if (res == 1)
                {
                    ExemploInicial();
                }
                else if (res == 2)
                {
                    TesteUsuario();
                }
                else if (res == 0)
                {
                    MenuAcesso.Load();
                    break;
                }
                else
                {
                    GlobalConfig.Centralizar("Valor inválido, aperte qualquer tecla para retorna");
                    Console.ReadKey();
                }
            }
        }

        private static void TesteUsuario()
        {
            Console.Clear();
            GetDados(out int numeroInicial, out int pularNumero, out int numeroFinal);
        }

        private static void GetDados(out int numeroInicial, out int pularNumero, out int numeroFinal)
        {
            throw new NotImplementedException();
        }

        private static void ExemploInicial()
        {
            GlobalConfig.Centralizar("Agora irei de dois em dois para você como exemplo");
            Console.ReadKey();
            for (int x = 1; x < 100; x += 2)
            {
                Console.WriteLine(x);
            }
            GlobalConfig.Centralizar("Digite alguma tecla para continuar!");
            Console.ReadKey();
        }
    }
}
