using System;
using Newtonsoft.Json;

namespace LCSDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Game game = new Game();
        }

        static void SaveGame()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Include;
        }

        static void LoadGame()
        {
            
        }
    }
}