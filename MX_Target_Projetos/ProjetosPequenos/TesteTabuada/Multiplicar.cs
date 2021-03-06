using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteTabuada
{
    public class Multiplicar
    {
        public static void Load()
        {
            ProcessarMult();
        }

        private static void ProcessarMult()
        {
            Console.WriteLine("Digite o número que deseja calcular:");
            var initialNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas vezes quer que calcule?");
            var timesToCalc = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Tabuada de Multiplicação de {initialNumber}");

            new CalcNumber().CalcMulti(initialNumber, timesToCalc);

            Console.WriteLine("Tabuada Finalizada!");
            Console.ReadKey();
        }
    }
}