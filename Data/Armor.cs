using LCSDotNet.Backend;

namespace LCSDotNet.Data
{
    public class Armor
    {
        private string name { get; }
        private ArmorType type { get; }

        public Armor(ArmorType type)
        {
            this.type = type;
            //TODO: Generate name
        }

        public Armor(ArmorType type, string name)
        {
            this.type = type;
            this.name = name;
        }
    }
}