﻿using MX_Target_Projetos.Configurations;
using System;

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
                GlobalConfig.Center("Bem-vindo ao Teste de Pular Números");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                GlobalConfig.DrawLine();
                Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 1. Exemplo                      ||"));
                Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 2. Testar                       ||"));
                Console.WriteLine("|{0}|", GlobalConfig.AlignText(35, "|| 0. Voltar                       ||"));
                GlobalConfig.DrawLine();
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
                    AccessMenu.Load();
                    break;
                }
                else
                {
                    GlobalConfig.Center("Valor inválido, aperte qualquer tecla para retorna");
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
            GlobalConfig.Center("Agora irei de dois em dois para você como exemplo");
            Console.ReadKey();
            for (int x = 1; x < 100; x += 2)
            {
                Console.WriteLine(x);
            }
            GlobalConfig.Center("Digite alguma tecla para continuar!");
            Console.ReadKey();
        }
    }
}
