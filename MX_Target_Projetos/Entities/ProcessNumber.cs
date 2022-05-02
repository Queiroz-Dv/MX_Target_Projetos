using MX_Target_Projetos.Configurations;
using System;

namespace MX_Target_Projetos.Entities
{
    public class ProcessNumber
    {
        public ProcessNumber()
        {

        }

        public ProcessNumber(int firstNumber, int lastNumber)
        {
            FirstNumber = firstNumber;
            LastNumber = lastNumber;
        }

        public ProcessNumber(int firstNumber, int jumper, int lastNumber)
        {
            FirstNumber = firstNumber;
            Jumper = jumper;
            LastNumber = lastNumber;
        }

        public int FirstNumber { get; private set; }
        public int Jumper { get; private set; }
        public int LastNumber { get; private set; }


        public static void Decrement(int firstNumber, int lastNumber)
        {
            var fNumber = firstNumber + 1;
            var lNumber = lastNumber + 1;
            while (fNumber >= lNumber)
            {
                --fNumber;
                Console.WriteLine(fNumber);
            }
        }

        public static void Increment(int firstNumber, int lastNumber)
        {
            var fNumber = firstNumber - 1;
            var lNumber = lastNumber - 1;
            while (fNumber <= lNumber)
            {
                fNumber = ++fNumber;
                Console.WriteLine(fNumber);
            }
        }
    }
}
