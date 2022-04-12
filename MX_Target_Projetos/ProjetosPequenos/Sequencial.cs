using MX_Target_Projetos.Configuratios;
using System;

namespace MX_Target_Projetos.ProjetosPequenos
{
    public class Sequencial
    {
        // Construtor de definições
        public Sequencial()
        {
            Console.Title = "Contador Sequencial";
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Load()
        {
            while (true)
            {
                Console.Clear();
                GlobalConfig.Centralizar("Bem-vindo ao Contador Sequencial");
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
                    ExemploInicio();
                }
                else if (res == 2)
                {
                    TesteSeq();
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

        // Método que testa
        private static void TesteSeq()
        {
            Console.Clear();
            GetDados(out int numeroInicial, out int numeroFinal);

            // Condição para caso o usuário digitar um numero menor que outro 
            if (numeroInicial >= numeroFinal)
            {
                GlobalConfig.Centralizar("Esse é o modo secreto de decremento!");
                GlobalConfig.Centralizar("Iremos contar em ordem decrescente!");
                GlobalConfig.Centralizar("Aperte qualquer tecla para prosseguir");
                Console.ReadKey();

                // Alterações para acertar o número apresentado
                numeroInicial = numeroInicial + 1;
                numeroFinal = numeroFinal + 1;
                while (numeroInicial >= numeroFinal)
                {
                    // Loop de iteração com o valor digitado inicialmente
                    --numeroInicial;
                    Console.WriteLine(numeroInicial);
                }
                GlobalConfig.Centralizar("Aperte qualquer tecla para continuar");
                Console.ReadKey();
                // O loop mostra o resultado e saí para o menu
            }

            else
            {
                numeroInicial = numeroInicial - 1;
                numeroFinal = numeroFinal - 1;
                while (numeroInicial <= numeroFinal)
                {
                    numeroInicial = ++numeroInicial;
                    Console.WriteLine(numeroInicial);
                }
                GlobalConfig.Centralizar("Aperte qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Método que coleta as informações
        private static void GetDados(out int numeroInicial, out int numeroFinal)
        {
            GlobalConfig.Centralizar("Digite um número inicial para que eu possa contar: ");
            numeroInicial = int.Parse(Console.ReadLine());
            GlobalConfig.Centralizar("Até quanto você quer que eu conte?");
            numeroFinal = int.Parse(Console.ReadLine());
        }

        // Método de Exemplo
        private static void ExemploInicio()
        {
            GlobalConfig.Centralizar("Agora eu irei contar de 10 a 25 como exemplo");
            Console.ReadKey();
            int n = 10;
            while (n <= 24)
            {
                n++;
                Console.WriteLine(n);
            }
            GlobalConfig.Centralizar("Aperte qualquer tecla para continuar.");
            Console.ReadKey();
        }
    }
}
