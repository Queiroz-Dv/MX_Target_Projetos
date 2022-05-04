using System;

namespace MX_Target_Projetos.ProjetosPequenos.TesteValidade
{
    public class ValidadeProcess
    {
        public static void Load()
        {
            Console.WriteLine("Digite o dia: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mês: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano: ");
            int year = int.Parse(Console.ReadLine());
            ProcessData(day, month, year);
        }

        private static void ProcessData(int day, int month, int year)
        {
            if (year < 1900 || year > 2999)
            {
                Console.WriteLine("Ano digitado é inválido.");
                Console.ReadKey();
            }

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Mês inválido");
                Console.ReadKey();
            }

            if ((day <= 31) && (month <= 12))
            {
                if (((day > 28) && (month == 2))
                    || ((day == 31) && ((month == 4)
                    || (month == 6) || (month == 9)
                    || (month == 11))))
                {
                    Console.WriteLine("Data inválida");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Data válida");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Data fora das regras de validação");
                Console.ReadKey();
            }
        }
    }
}