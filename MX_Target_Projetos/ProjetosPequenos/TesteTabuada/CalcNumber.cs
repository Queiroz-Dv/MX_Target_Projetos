using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteTabuada
{
    public class CalcNumber
    {
        public void CalcMulti(int initial, int times)
        {
            for (int i = 0; i < times; i++)
            {
                int result = initial * i;
                Console.WriteLine(initial + " x " + i + " = " + result);
            }
        }

        public void CalcSoma(int initial, int times)
        {
            for (int i = 0; i < times; i++)
            {
                int result = initial + i;
                Console.WriteLine(initial + " + " + i + " = " + result);
            }
        }

        public void CalcSub(int initial, int times)
        {
            for (int i = 0; i < times; i++)
            {
                int result = initial - i;
                Console.WriteLine(initial + " - " + i + " = " + result);
            }
        }

        public void CalcDiv(int initial, int times)
        {
            for (int i = 1; i < times; i++)
            {
                int result = initial / i;
                if (result == 0)
                    throw new DivideByZeroException(message: "Impossível dividir por zero");
                else
                    Console.WriteLine(initial + " / " + i + " = " + result);
            }
        }
    }
}
