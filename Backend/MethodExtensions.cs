using Microsoft.Xna.Framework;
using Console = SadConsole.Console;

namespace LCSDotNet.Backend
{
    public static class MethodExtensions
    {
        public static void Print(this Console console, int row, string text)
        {
            int column = (Program.width - text.Length) / 2;
            if (column < 0)
                column = 0;
            
            console.Print(column, row, text);
        }
        
        public static void Print(this Console console, int row, string text, Color color)
        {
            int column = (Program.width - text.Length) / 2;
            if (column < 0)
                column = 0;
            
            console.Print(column, row, text, color);
        }
    }
}