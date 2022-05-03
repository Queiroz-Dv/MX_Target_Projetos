using MX_Target_Projetos.Configurations;
using System;

namespace MX_Target_Projetos.Entities
{
    public class ProcessNumber
    {
        public ProcessNumber() { }

        public ProcessNumber(int firstNumber, int lastNumber)
        {
            FirstNumber = firstNumber;
            LastNumber = lastNumber;

            if (FirstNumber >= LastNumber)
                Decrement(FirstNumber, LastNumber);
            else
                Increment(FirstNumber, LastNumber);
        }

        public ProcessNumber(int firstNumber, int jumper, int lastNumber)
        {
            FirstNumber = firstNumber;
            Jumper = jumper;
            LastNumber = lastNumber;

            if (FirstNumber >= LastNumber)
                Decrement(FirstNumber, Jumper, LastNumber);
            else
                Increment(FirstNumber, Jumper, LastNumber);
        }

        public int FirstNumber { get; private set; }
        public int Jumper { get; private set; }
        public int LastNumber { get; private set; }

        private void Decrement(int firstNumber, int lastNumber)
        {
            var fNumber = firstNumber + 1;
            var lNumber = lastNumber + 1;
            while (fNumber >= lNumber)
            {
                --fNumber;
                Console.WriteLine(fNumber);
            }

            GlobalConfig.Center("Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        private void Increment(int firstNumber, int lastNumber)
        {
            var fNumber = firstNumber - 1;
            var lNumber = lastNumber - 1;
            while (fNumber <= lNumber)
            {
                fNumber = ++fNumber;
                Console.WriteLine(fNumber);
            }

            GlobalConfig.Center("Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        private void Decrement(int firstNumber, int jumper, int lastNumber)
        {
            for (int x = 0; firstNumber < lastNumber; x++)
            {
                firstNumber = firstNumber - jumper;
                Console.WriteLine(firstNumber);
            }
            Console.WriteLine("Contagem finalizada!");
            GlobalConfig.Center("Aperte qualquer tecla para continuar");
            Console.ReadKey();
        }

        private void Increment(int firstNumber, int jumper, int lastNumber)
        {
            for (int x = 0; firstNumber < lastNumber; x++)
            {
                firstNumber = firstNumber + jumper;
                Console.WriteLine(firstNumber);
            }
            Console.WriteLine("Contagem finalizada!");
            GlobalConfig.Center("Aperte qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
