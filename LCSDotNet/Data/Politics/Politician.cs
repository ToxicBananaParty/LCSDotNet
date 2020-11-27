using LCSDotNet.Core;

namespace LCSDotNet.Data.Politics
{
    public class Politician
    {
        public Party party;

        public Politician()
        {
            party = (Party) Game.rand.Next((int) Party.NUM_PARTIES);
        }

        public Politician(Party party)
        {
            this.party = party;
        }
    }
}