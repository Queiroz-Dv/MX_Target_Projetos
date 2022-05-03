using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteTabuada
{
    public class Divisao
    {
        public Divisao()
        {
            Console.Title = "Divisão";
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Load()
        {
            ProcessarDivisao();
        }

        private static void ProcessarDivisao()
        {
            Console.WriteLine("Digite o número que deseja calcular:");
            var initialNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas vezes quer que calcule?");
            var timesToCalc = int.Parse(Console.ReadLine());

            ValidaDiv(initialNumber, timesToCalc);

            Console.Clear();
            Console.WriteLine($"Tabuada de Divisão de {initialNumber}");

            new CalcNumber().CalcDiv(initialNumber, timesToCalc);

            Console.WriteLine("Tabuada Finalizada!");
            Console.ReadKey();
        }

        private static void ValidaDiv(int initialNumber, int timesToCalc)
        {
            if (initialNumber == 0)
            {
                Console.WriteLine("Impossível dividir por 0");
                Console.ReadKey();
                Load();
                Console.Clear();
            }
        }
    }
}