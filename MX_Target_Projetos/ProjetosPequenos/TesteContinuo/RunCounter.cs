using MX_Target_Projetos.Entities;
using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteContinuo
{
    public class RunCounter
    {
        public static void Load()
        {
            
            Console.Clear();
            Console.WriteLine("Digite qual número você quer começar a contar:");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite até que número você quer que eu conte:");
            var lastNumber = int.Parse(Console.ReadLine());
            //var fNumber = new ProcessNumber(firstNumber);
        }
    }
}