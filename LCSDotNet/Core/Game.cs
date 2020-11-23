using System;
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
            Player.newGame(console);
        }
    }
}