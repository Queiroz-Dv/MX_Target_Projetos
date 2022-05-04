using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteFatorial
{
    public class FatorialProcess
    {
        public static void Load()
        {
            Console.Clear();
            int val = ProcessData();
            ValidNumber(val);
        }

        private static int ProcessData()
        {
            Console.WriteLine("Digite o número que você deseja fatorar: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        private static void ValidNumber(int val)
        {
            if (val != 0)
                GetFat(val);
            else
            {
                Console.WriteLine("Impossível fatorar 0");
                Console.ReadKey();
                FatorialMenu.Load();
            }
        }

        private static void GetFat(int val)
        {
            int ftr = 1;
            for (int i = 2; i <= val; i++)
            {
                ftr *= i;
                if (ftr == 0)
                    break;
                Console.WriteLine("Fator: " + ftr);
            }
            Console.WriteLine("O fatorial de " + val + " é igual a " + ftr);
            Console.WriteLine("Fatoração finalizada!");
            Console.ReadKey();
        }
    }
}