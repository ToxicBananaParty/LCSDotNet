using System;
using System.Collections.Generic;
using LCSDotNet.Backend;
using Attribute = LCSDotNet.Backend.Attribute;

namespace LCSDotNet.Data
{
    public class Character
    {
        private string name { get; }
        private string codeName { get; set; }
        private CharacterType type { get; }
        private Gender gender { get; }
        private Dictionary<Attribute, float> attributes { get; }
        private Dictionary<Skill, float> skills { get; }

        //TODO Calculate Skills, Attributes for new chars
        public Character(string name, Gender gender)
        {
            this.name = name;
            this.gender = gender;
            type = (CharacterType) new Random(DateTime.Now.Millisecond).Next((int) CharacterType.NUM_CHARTYPES);
            attributes = new Dictionary<Attribute, float>((int)Attribute.NUM_ATTRIBUTES);
            skills = new Dictionary<Skill, float>((int)Skill.NUM_SKILLS);
            initStats();
        }

        public Character(string name, Gender gender, CharacterType type)
        {
            this.name = name;
            this.gender = gender;
            this.type = type;
            attributes = new Dictionary<Attribute, float>((int)Attribute.NUM_ATTRIBUTES);
            skills = new Dictionary<Skill, float>((int)Skill.NUM_SKILLS);
            initStats();
        }

        public Character(CharacterType type)
        {
            this.type = type;
            gender = (Gender) Program.RandomInt((int) Gender.NUM_GENDERS);
            name = NameGenerator.Generate(gender);
            attributes = new Dictionary<Attribute, float>((int)Attribute.NUM_ATTRIBUTES);
            skills = new Dictionary<Skill, float>((int)Skill.NUM_SKILLS);
            initStats();
        }

        private void initStats()
        {
            //Add all attribute keys and set their values to 0
            for (int i = 0; i < (int) Attribute.NUM_ATTRIBUTES; i++) {
                attributes.Add((Attribute)i, 0.0f);
            }
            
            //Add all skills keys and set their values to 0
            for (int i = 0; i < (int) Skill.NUM_SKILLS; i++) {
                skills.Add((Skill)i, 0.0f);
            }
        }
    }
}