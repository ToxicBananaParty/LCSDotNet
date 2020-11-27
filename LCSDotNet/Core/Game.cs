using System;
using System.Diagnostics;
using System.Timers;
using LCSDotNet.Data;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using SunshineConsole;

namespace LCSDotNet.Core
{
    public class Game
    {
        public static NameGenerator nameGenerator;
        public static Random rand;
        
        private ConsoleWindow console;
        public Game(ConsoleWindow console)
        {
            rand = new Random(DateTime.Now.Millisecond);
            nameGenerator = new NameGenerator(rand);
            Globals gTemp = new Globals();
            this.console = console;
            splashScreen();
        }

        private void splashScreen()
        {
            console.Write(3, "Liberal Crime Squad (.NET)");
            console.Write(5, "Inspired by the 1983 version of Oubliette");

            //TODO: Show save stats

            console.Write(20, "v3.9 Copyright (C) 2002-4, Tarn Adams");
            console.Write(22, "A Bay 12 Games Production");
            console.Write(24, "www.bay12games.com");

            console.Write(30, ".NET v1.0 Maintained by Ryan Dwyer");
            console.Write(32, "www.rydwy.com");
            
            console.Write(38, "Press Q now to Quit. Quitting later causes your progress to be saved.");
            console.Write(41, "Press any other key to pursue your Liberal agenda!");

            switch (console.GetInput()) {
                case "q":
                    console.Exit();
                    break;
                default:
                    Player.newGame(console);
                    return;
            }
        }
    }
}