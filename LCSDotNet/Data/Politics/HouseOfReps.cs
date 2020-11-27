using System.Collections.Generic;

namespace LCSDotNet.Data.Politics
{
    public class HouseOfReps
    {
        public List<Politician> members;
        
        public HouseOfReps()
        {
            members = new List<Politician>(435);
        }
    }
}