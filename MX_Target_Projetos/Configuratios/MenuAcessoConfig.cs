using System;

namespace MX_Target_Projetos.Configuratios
{
    public static class MenuAcessoConfig
    {
        public static void Windowconfig()
        {
            Console.SetWindowSize(100, 25);
            Console.Title = "Menu Principal";
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
