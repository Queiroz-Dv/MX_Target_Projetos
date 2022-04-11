using System;

namespace MX_Target_Projetos.Configuratios
{
    public static class GlobalConfig
    {
        public static int Centralizar(string centre)
        {
            int espacos = 50 + (centre.Length / 2);
            Console.WriteLine(centre.PadLeft(espacos));
            return espacos;
        }

        public static void Linha()
        {
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
        }

        public static string AlinhaTexto(int EspacosParaAdicionar, string Msg, string Alinhamento = "Direita")
        {
            if (Alinhamento == "Esquerda")
                Msg = Msg.PadLeft(EspacosParaAdicionar + Msg.Length);
            else
            {
                Msg = Msg.PadLeft(EspacosParaAdicionar + Msg.Length);
                Msg = Msg.PadRight((98 - Msg.Length) + Msg.Length);
            }
            return Msg;
        }
    }
}
