using System.Collections.Generic;
using LCSDotNet.Data;
using SunshineConsole;
using OpenTK.Graphics;

namespace LCSDotNet.Core
{
    public class Player
    {
        public static void newGame(ConsoleWindow console)
        {
            AdvancedGameplayOptions(console);
            bool saveMade = false, founderInfo = false;
            Player newPlayer = new Player();
            while (console.WindowUpdate()) {
                while (!saveMade) {
                    console.Write(1, 1, "In what world will you pursue your Liberal Agenda?", Color4.White);
                    console.Write(3, 1, "Enter a name for the save file", Color4.White);
                    string saveName = console.GetInput(5, 1);
                    console.Clear();
                    saveMade = true;
                }
                
                Gender gender = Gender.Neutral;
                string startName = Game.nameGenerator.Generate(gender);
                string city = Game.nameGenerator.GenerateCity();
                string firstName = startName.Split(' ')[0], lastName = startName.Split(' ')[1];
                bool randomHistory = false;
                while (!founderInfo) {
                    console.Write(5, 10, "The Founder of the Liberal Crime Squad", Color4.White);
                    console.Write(10, 5, "FIRST NAME: " + firstName, Color4.White);
                    console.Write(13, 5, "LAST NAME: " + lastName, Color4.White);

                    console.Write(16, 5, "GENDER: ", Color4.White);
                    string genderString = "";
                    Color4 genderColor = Color4.White;
                    if (gender == Gender.Neutral) {
                        genderString = "Non-Binary";
                        genderColor = Color4.Cyan;
                    }
                    else if (gender == Gender.Female) {
                        genderString = gender.ToString();
                        genderColor = Color4.Magenta;
                    }
                    else {
                        genderString = gender.ToString();
                        genderColor = Color4.YellowGreen;
                    }
                    console.Write(16, 13, genderString, genderColor);

                    console.Write(19, 5, "HISTORY: ", Color4.White);
                    if (randomHistory)
                        console.Write(19, 14, "Let Fate Decide", Color4.Red);
                    else
                        console.Write(19, 14, "Let Me Choose", Color4.Green);

                    console.Write(22, 5, "CITY: " + city, Color4.White);
                    console.Write(30, 5, "Press any other key when ready to begin...", Color4.White);

                    console.Write(10, 35, "(Press A to have your parents reconsider)", Color4.DarkGray);
                    console.Write(13, 35, "(Press B to be born to a different family)", Color4.DarkGray);
                    console.Write(16, 35, "(Press C to change your gender identity)", Color4.DarkGray);
                    console.Write(19, 35, "(Press D to toggle childhood control)", Color4.DarkGray);
                    console.Write(22, 35, "(Press E to relocate)", Color4.DarkGray);

                    switch (console.GetInput()) {
                        case "a":
                            firstName = Game.nameGenerator.Generate(gender).Split(' ')[0];
                            console.Clear();
                            break;
                        case "b":
                            lastName = Game.nameGenerator.Generate(gender).Split(' ')[1];
                            console.Clear();
                            break;
                        case "c":
                            Gender old = gender;
                            do {
                                gender = (Gender) Game.rand.Next(0, 3);
                            } while (old.Equals(gender));
                            console.Clear();
                            break;
                        case "d":
                            randomHistory = !randomHistory;
                            console.Clear();
                            break;
                        case "e":
                            city = Game.nameGenerator.GenerateCity();
                            console.Clear();
                            break;
                        default:
                            founderInfo = true;
                            newPlayer.name = firstName + " " + lastName;
                            newPlayer.city = city;
                            newPlayer.gender = gender;
                            console.Clear();
                            break;
                    }
                }
                PersonalityQuestions.QuestionOne(console, newPlayer);
                return;
            }
        }

        private static void AdvancedGameplayOptions(ConsoleWindow console)
        {
            string unselected = "[ ]", selected = "[X]";
            
            //Progress Trackers
            bool advancedOptions = false, agendaOptions = false, skillOptions = false;
            //Advanced Options selectors
            bool classicSelected, fireSelected, nightmareSelected, nationalSelected, marathonSelected;
            classicSelected = fireSelected = nightmareSelected = nationalSelected = marathonSelected = false;
            //Agenda Options selector
            bool democratMode = false;
            //Skill Options selectors
            bool fast = true, classic = false, hard = false;
            
            console.Clear();
            while (console.WindowUpdate()) {
                while (!advancedOptions) {
                    console.Write(3, 5, "New Game of Liberal Crime Squad: Advanced Gameplay Options");
                    console.Write(6, 1,
                        classicSelected ? selected : unselected + " A - Classic Mode: No Conservative Crime Squad",
                        fireSelected ? Color4.Gray : Color4.White);
                    console.Write(8, 1, fireSelected
                            ? selected
                            : unselected + " B - We Didn't Start The Fire: "
                                         + "The CCS starts active and extremely strong.",
                        classicSelected ? Color4.Gray : Color4.White);
                    console.Write(10, 1, nightmareSelected
                        ? selected
                        : unselected + " C - Nightmare Mode: Liberalism is forgotten. "
                                     + "Is it too late to fight back?");
                    console.Write(12, 1,
                        nationalSelected
                            ? selected
                            : unselected + " D - National LCS: Advanced play across multiple cities.");
                    console.Write(14, 1, marathonSelected
                        ? selected
                        : unselected
                          + " E - Marathon Mode: Prevent Liberals from amending the Constitution.");

                    console.Write(17, 5, "Press any other key to continue...");

                    switch (console.GetInput()) {
                        case "a":
                            if (!fireSelected)
                                classicSelected = !classicSelected;
                            break;
                        case "b":
                            if (!classicSelected)
                                fireSelected = !fireSelected;
                            break;
                        case "c":
                            nightmareSelected = !nightmareSelected;
                            break;
                        case "d":
                            nationalSelected = !nationalSelected;
                            break;
                        case "e":
                            marathonSelected = !marathonSelected;
                            break;
                        default:
                            advancedOptions = true;
                            console.Clear();
                            break;
                    }
                }

                while (!agendaOptions) {
                    console.Write(3, 5, "New Game of Liberal Crime Squad: Your Agenda");
                    console.Write(6, 1, democratMode 
                        ? unselected 
                        : selected + " A - No Compromise Classic: I will make all our laws Elite Liberal!");
                    console.Write(8, 1,
                        democratMode
                            ? selected
                            : unselected + " B - Democrat Mode: Most laws must be Elite Liberal, some can be Liberal.");
                    console.Write(11, 5, "Press any other key to continue...");

                    switch (console.GetInput()) {
                        case "a":
                            democratMode = false;
                            break;
                        case "b":
                            democratMode = true;
                            break;
                        default:
                            agendaOptions = true;
                            console.Clear();
                            break;
                    }
                }

                while (!skillOptions) {
                    console.Write(3, 5, "New Game of Liberal Crime Squad: Field Learning");
                    console.Write(4, 5, "(affect Security, Stealth, Disguise, and Driving)", Color4.LightGray);
                    console.Write(7, 1, fast 
                        ? selected + " A - Fast Skills: Grinding is Conservative!"
                        : unselected + " A - Fast Skills: Grinding is Conservative!");
                    console.Write(9, 1, classic 
                        ? selected + " B - Classic: Excellence requires practice."
                        : unselected + " B - Classic: Excellence requires practice.");
                    console.Write(11, 1, hard 
                        ? selected + " C - Hard Mode: Learn from the best, or face arrest!"
                        : unselected + " C - Hard Mode: Learn from the best, or face arrest!");
                    console.Write(14, 5, "Press any other key to continue...");

                    switch (console.GetInput()) {
                        case "a":
                            fast = true;
                            classic = hard = false;
                            break;
                        case "b":
                            classic = true;
                            hard = fast = false;
                            break;
                        case "c":
                            hard = true;
                            classic = fast = false;
                            break;
                        default:
                            console.Clear();
                            skillOptions = true;
                            break;
                    }
                }

                //Set CCS Options
                if (classicSelected)
                    Globals.instance.ccsOption = CCSOptions.ClassicMode;
                else if (fireSelected)
                    Globals.instance.ccsOption = CCSOptions.WeDidntStart;
                else
                    Globals.instance.ccsOption = CCSOptions.None;
                
                //Set LCS Options
                if (nightmareSelected && nationalSelected && marathonSelected)
                    Globals.instance.lcsOptions = LCSOptions.All;
                else if (nightmareSelected && nationalSelected)
                    Globals.instance.lcsOptions = LCSOptions.NationalNightmare;
                else if (nightmareSelected && marathonSelected)
                    Globals.instance.lcsOptions = LCSOptions.NightmareMarathon;
                else if (nationalSelected && marathonSelected)
                    Globals.instance.lcsOptions = LCSOptions.NationalMarathon;
                else if (nationalSelected)
                    Globals.instance.lcsOptions = LCSOptions.NationalLCS;
                else if (nightmareSelected)
                    Globals.instance.lcsOptions = LCSOptions.NightmareMode;
                else if (marathonSelected)
                    Globals.instance.lcsOptions = LCSOptions.MarathonMode;
                else {
                    Globals.instance.lcsOptions = LCSOptions.None;
                }
                
                //Set Agenda Options
                if (!democratMode)
                    Globals.instance.agendaOption = AgendaOptions.Classic;
                else {
                    Globals.instance.agendaOption = AgendaOptions.Democrat;
                }
                
                //Set Skill Options
                if (fast)
                    Globals.instance.skillOption = SkillOptions.Fast;
                else if (classic)
                    Globals.instance.skillOption = SkillOptions.Classic;
                else {
                    Globals.instance.skillOption = SkillOptions.Hard;
                }

                return;
            }
        }
        

        public string name, city, codename;
        public Gender gender;
        public Dictionary<Attribute, float> attributes;
        public Dictionary<Skill, float> skills;
        public List<LocationType> safeHouses;
        public List<Character> recruits, loveSlaves;
        public List<Vehicle> vehicles;
        public List<Item> inventory;
        public float money, juice;

        public Player(string name, Gender gender, string location)
        {
            this.name = name;
            this.city = location;
            this.gender = gender;
            attributes = new Dictionary<Attribute, float>((int)Attribute.NUM_ATTRIBUTES);
            skills = new Dictionary<Skill, float>((int)Skill.NUM_SKILLS);
            safeHouses = new List<LocationType>();
            recruits = new List<Character>();
            loveSlaves = new List<Character>();
            vehicles = new List<Vehicle>();
            money = 0.0f;
            initAttributes();
            initSkills();
        }

        public Player()
        {
            name = city = null;
            gender = Gender.Neutral;
            attributes = new Dictionary<Attribute, float>((int)Attribute.NUM_ATTRIBUTES);
            skills = new Dictionary<Skill, float>((int)Skill.NUM_SKILLS);
            safeHouses = new List<LocationType>();
            recruits = new List<Character>();
            loveSlaves = new List<Character>();
            vehicles = new List<Vehicle>();
            money = 0.0f;
            initAttributes();
            initSkills();
        }

        public void addToAttribute(float toAdd, Attribute toGet)
        {
            attributes[toGet] += toAdd;
        }

        public void addToSkill(float toAdd, Skill toGet)
        {
            skills[toGet] += toAdd;
        }
        
        private void initAttributes()
        {
            attributes.Add(Attribute.Strength, 4.0f);
            attributes.Add(Attribute.Intelligence, 3.0f);
            attributes.Add(Attribute.Wisdom, 1.0f);
            attributes.Add(Attribute.Agility, 5.0f);
            attributes.Add(Attribute.Charisma, 4.0f);
            attributes.Add(Attribute.Heart, 8.0f);
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