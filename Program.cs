using System;
using LCSDotNet.Backend;
using SadConsole;
using Microsoft.Xna.Framework;
using Console = SadConsole.Console;

namespace LCSDotNet
{
    public static class Program
    {
        public static Console console;
        public static readonly int width = 128, height = 32;
        private static Random rand;

        public static int RandomInt(int max)
        {
            return rand.Next(max);
        }

        public static int RandomInt(int min, int max)
        {
            return rand.Next(min, max);
        }
        
        static void Main()
        {
            rand = new Random(DateTime.Now.Millisecond);
            NameGenerator instance = new NameGenerator(rand);
            // Setup the engine and create the main window.
            SadConsole.Game.Create(width, height);

            // Hook the start event so we can add consoles to the system.
            SadConsole.Game.OnInitialize = Init;

            // Start the game.
            SadConsole.Game.Instance.Run();
            SadConsole.Game.Instance.Dispose();
        }

        static void Init()
        {
            console = new Console(width, height);
            console.FillWithRandomGarbage();
            console.Fill(new Rectangle(3, 3, 23, 3), Color.Violet, Color.Black, 0, 0);
            console.Print(4, 4, NameGenerator.Generate(Gender.Male));

            Global.CurrentScreen = console;
        }
    }
}