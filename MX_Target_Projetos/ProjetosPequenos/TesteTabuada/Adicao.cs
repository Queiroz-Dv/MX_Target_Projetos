using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteTabuada
{
    public class Adicao
    {
        public Adicao()
        {
            Console.Title = "Adição";
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Load()
        {
            ProcessarSoma();
        }

        private static void ProcessarSoma()
        {
            Console.WriteLine("Digite o número que deseja calcular:");
            var initialNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas vezes quer que calcule?");
            var timesToCalc = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Tabuada de Adição de {initialNumber}");
            var calc = new CalcNumber();
            calc.CalcSoma(initialNumber, timesToCalc);
            Console.WriteLine("Tabuada Finalizada!");
            Console.ReadKey();
        }
    }
}