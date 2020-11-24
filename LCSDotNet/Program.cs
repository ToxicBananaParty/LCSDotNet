using System;
using System.Timers;
using LCSDotNet.Core;
using OpenTK.Graphics;
using OpenTK.Input;
using SunshineConsole;


namespace LCSDotNet
{
    class Program
    {
        public static readonly int width = 128, height = 48;
        private static ConsoleWindow console;
        

        public static void Main(string[] args)
        {
            console = new ConsoleWindow(48, 128, "Liberal Crime Squad");
            Game game = new Game(console);
        }
    }
}
