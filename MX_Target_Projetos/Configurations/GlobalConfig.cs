using System;

namespace MX_Target_Projetos.Configurations
{
    public static class GlobalConfig
    {
        public static int Center(string centre)
        {
            int spaces = 50 + (centre.Length / 2);
            Console.WriteLine(centre.PadLeft(spaces));
            return spaces;
        }
        public static void DrawLine()
        {
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
        }

        public static string AlignText(int SpacesToAdd, string Msg, string Alignment = "Right")
        {
            if (Alignment == "Left")
                Msg = Msg.PadLeft(SpacesToAdd + Msg.Length);
            else
            {
                Msg = Msg.PadLeft(SpacesToAdd + Msg.Length);
                Msg = Msg.PadRight(98 - Msg.Length + Msg.Length);
            }
            return Msg;
        }
    }
}
