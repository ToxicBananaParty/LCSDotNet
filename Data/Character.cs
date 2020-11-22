using System.Collections.Generic;

namespace LCSDotNet.Data
{
    public class Character
    {
        public string name, codeName;
        public Health health;
        public Gender gender;
        public CharacterType type;
        public Dictionary<Attribute, float> attributes;
        public Dictionary<Skill, float> skills;
        public List<Item> inventory;
        public float heart, intelligence, agility;

        public Character()
        {
            
        }
    }
}