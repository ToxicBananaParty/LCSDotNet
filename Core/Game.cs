using System;
using LCSDotNet.Data;

namespace LCSDotNet
{
    public class Game
    {
        private NameGenerator nameGenerator;
        private Location currentLocation;
        
        public Game()
        {
            nameGenerator = new NameGenerator(new Random(DateTime.Now.Second));
        }

        public void endDay()
        {
            //Main loop
            //TODO
        }

        public Location getSquadLocation()
        {
            throw new NotImplementedException();
            //TODO
        }

        private void prompt()
        {
            
        }
    }
}