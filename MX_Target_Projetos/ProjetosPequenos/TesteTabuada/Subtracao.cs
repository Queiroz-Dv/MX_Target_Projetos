using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteTabuada
{
    public class Subtracao
    {
        public Subtracao()
        {
            Console.Title = "Subtração";
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Load()
        {
            ProcessarSubtracao();
        }

        private static void ProcessarSubtracao()
        {
            Console.WriteLine("Digite o número que deseja calcular:");
            var initialNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas vezes quer que calcule?");
            var timesToCalc = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Tabuada de Subtração de {initialNumber}");

            new CalcNumber().CalcSub(initialNumber, timesToCalc);

            Console.WriteLine("Tabuada Finalizada!");
            Console.ReadKey();
        }
    }
}