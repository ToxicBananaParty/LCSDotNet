using LCSDotNet.Core;

namespace LCSDotNet.Data.Politics
{
    public class Government
    {
        public HouseOfReps houseOfReps;
        public Senate senate;
        public SupremeCourt supremeCourt;

        public string presidentName, vpName;
        public Party presidentParty;

        public Government()
        {
            houseOfReps = new HouseOfReps();
            senate = new Senate();
            supremeCourt = new SupremeCourt();

            presidentName = Game.nameGenerator.Generate(Gender.Male);
            vpName = Game.nameGenerator.Generate(Gender.Male);
            presidentParty = Party.ArchConservative;
        }
    }
}