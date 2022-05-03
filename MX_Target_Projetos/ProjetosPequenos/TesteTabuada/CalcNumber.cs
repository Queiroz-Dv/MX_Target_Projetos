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
            for (int i = 0; i < times; i++)
            {
                try
                {
                    int result = initial / i;
                    if (result == 1 || result == 2 || result == 0)
                    {
                        Console.WriteLine("Resultados entre 0, 1 e 2 são ignorados");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(initial + " / " + i + " = " + result);
                    }
                }
                catch (Exception)
                {
                    throw new Exception(message: "Error");
                }
            }
        }
    }
}
