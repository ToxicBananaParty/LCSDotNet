using System;
using System.Drawing;
using System.Security.Principal;
using LCSDotNet.Data;
using SunshineConsole;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

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
        

        public string name, city;
        public Gender gender;

        public Player(string name, Gender gender, string location)
        {
            this.name = name;
            this.city = city;
            this.gender = gender;
        }

        public Player()
        {
            name = city = null;
            gender = Gender.Neutral;
        }
    }
}