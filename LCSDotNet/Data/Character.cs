using System.Collections.Generic;
using LCSDotNet.Core;

namespace LCSDotNet.Data
{
    public class Character
    {
        public string name, codename;
        public CharacterType type;
        public Gender gender;
        public Dictionary<Attribute, float> attributes;
        public Dictionary<Skill, float> skills;

        public Character(string name, string codename, Gender gender)
        {
            this.name = name;
            this.codename = codename;
            this.gender = gender;
            type = (CharacterType) Game.rand.Next(1, (int) CharacterType.NUM_CHARTYPES);
            attributes = new Dictionary<Attribute, float>((int)Attribute.NUM_ATTRIBUTES);
            skills = new Dictionary<Skill, float>((int)Skill.NUM_SKILLS);
            initAttributes();
            initSkills();
        }

        public Character(string name, string codename, Gender gender, CharacterType type)
        {
            this.name = name;
            this.codename = codename;
            this.gender = gender;
            this.type = type;
            attributes = new Dictionary<Attribute, float>((int)Attribute.NUM_ATTRIBUTES);
            skills = new Dictionary<Skill, float>((int)Skill.NUM_SKILLS);
            initAttributes();
            initSkills();
        }

        public float getAttribute(Attribute toGet)
        {
            return attributes[toGet];
        }

        public float getSkill(Skill toGet)
        {
            return skills[toGet];
        }

        private void initAttributes()
        {
            attributes.Add(Attribute.Strength, 0.0f);
            attributes.Add(Attribute.Intelligence, 0.0f);
            attributes.Add(Attribute.Wisdom, 0.0f);
            attributes.Add(Attribute.Agility, 0.0f);
            attributes.Add(Attribute.Charisma, 0.0f);
            attributes.Add(Attribute.Heart, 0.0f);
        }

        private void initSkills()
        {
            skills.Add(Skill.Art, 0.0f);
            skills.Add(Skill.Axe, 0.0f);
            skills.Add(Skill.Business, 0.0f);
            skills.Add(Skill.Club, 0.0f);
            skills.Add(Skill.Computers, 0.0f);
            skills.Add(Skill.Disguise, 0.0f);
            skills.Add(Skill.Dodge, 0.0f);
            skills.Add(Skill.Driving, 0.0f);
            skills.Add(Skill.FirstAid, 0.0f);
            skills.Add(Skill.HeavyWeapons, 0.0f);
            skills.Add(Skill.Knife, 0.0f);
            skills.Add(Skill.Law, 0.0f);
            skills.Add(Skill.HandToHand, 0.0f);
            skills.Add(Skill.Music, 0.0f);
            skills.Add(Skill.Persuasion, 0.0f);
            skills.Add(Skill.Pistol, 0.0f);
            skills.Add(Skill.Psychology, 0.0f);
            skills.Add(Skill.Religion, 0.0f);
            skills.Add(Skill.Rifle, 0.0f);
            skills.Add(Skill.Science, 0.0f);
            skills.Add(Skill.Security, 0.0f);
            skills.Add(Skill.Seduction, 0.0f);
            skills.Add(Skill.Shotgun, 0.0f);
            skills.Add(Skill.SMG, 0.0f);
            skills.Add(Skill.Stealth, 0.0f);
            skills.Add(Skill.StreetSense, 0.0f);
            skills.Add(Skill.Sword, 0.0f);
            skills.Add(Skill.Tailoring, 0.0f);
            skills.Add(Skill.Teaching, 0.0f);
            skills.Add(Skill.Throwing, 0.0f);
            skills.Add(Skill.Writing, 0.0f);
        }
    }
}