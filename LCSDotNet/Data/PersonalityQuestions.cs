using LCSDotNet.Core;
using SunshineConsole;

namespace LCSDotNet.Data
{
    public class PersonalityQuestions
    {
        public static void QuestionOne(ConsoleWindow console, Player player)
        {
            while (console.WindowUpdate()) {
                console.Write(3, 1, "The day I was born in 1984...");
                console.Write(7, 1, "A - the Polish priest Popieluszko was kidnapped by government agents.");
                console.Write(9, 1, "B - was the 3rd anniversary of the assassination attempt on Ronald Reagan.");
                console.Write(11, 1, "C - the Macintosh was introduced.");
                console.Write(13, 1, "D - the Nobel Peace Prize went to Desmond Tutu for opposition to apartheid.");
                console.Write(15, 1, "E - the Sandanista Front won the elections in Nicaragua.");
                console.Write(18, 1, "My parents named me " + player.name.Split(' ')[0] + ".");

                switch (console.GetInput(false)) {
                    case "a":
                        player.addToAttribute(2f, Attribute.Agility);
                        break;
                    case "b":
                        player.addToAttribute(2f, Attribute.Strength);
                        break;
                    case "c":
                        player.addToAttribute(2f, Attribute.Intelligence);
                        break;
                    case "d":
                        player.addToAttribute(2f, Attribute.Heart);
                        break;
                    case "e":
                        player.addToAttribute(2f, Attribute.Charisma);
                        break;
                    default:
                        continue;
                }
                console.Clear();
                QuestionTwo(console, player);
                return;
            }
        }

        private static void QuestionTwo(ConsoleWindow console, Player player)
        {
            while (console.WindowUpdate()) {
                console.Write(3, 1, "When I was bad...");
                console.Write(7, 1, "A - My parents grounded my and hid my toys, but I knew where they put them.");
                console.Write(9, 1, "B - My father beat me. I learned to take a punch earlier than most.");
                console.Write(11, 1, "C - I was sent to my room, where I studied quietly by myself.");
                console.Write(13, 1, "D - My parents argued with each other about me, but I was never punished.");
                console.Write(15, 1, "E - My father lectured me endlessly, trying to make me think like him.");

                switch (console.GetInput(false)) {
                    case "a":
                        player.addToAttribute(1f, Attribute.Agility);
                        player.addToSkill(1f, Skill.Security);
                        break;
                    case "b":
                        player.addToAttribute(1f, Attribute.Strength);
                        player.addToSkill(1f, Skill.HandToHand);
                        break;
                    case "c":
                        player.addToAttribute(1f, Attribute.Intelligence);
                        player.addToSkill(1f, Skill.Writing);
                        break;
                    case "d":
                        player.addToAttribute(1f, Attribute.Heart);
                        player.addToSkill(1f, Skill.Persuasion);
                        break;
                    case "e":
                        player.addToAttribute(1f, Attribute.Charisma);
                        player.addToSkill(1f, Skill.Psychology);
                        break;
                    default:
                        continue;
                }
                console.Clear();
                QuestionThree(console, player);
                return;
            }
        }
        
        private static void QuestionThree(ConsoleWindow console, Player player)
        {
            while (console.WindowUpdate()) {
                console.Write(3, 1, "In elementary school...");
                console.Write(7, 1, "A - I was mischevious, and always up to something.");
                console.Write(9, 1, "B - I had a lot of repressed anger. I hurt animals.");
                console.Write(11, 1, "C - I was at the head of the class, and I worked very hard.");
                console.Write(13, 1, "D - I was unruly and often fouth with the other children");
                console.Write(15, 1, "E - I was the class clown. I even had some friends.");

                switch (console.GetInput(false)) {
                    case "a":
                        player.addToAttribute(1f, Attribute.Agility);
                        player.addToSkill(1f, Skill.Disguise);
                        break;
                    case "b":
                        player.addToAttribute(1f, Attribute.Strength);
                        player.addToAttribute(1f, Attribute.Agility);
                        player.addToAttribute(-1f, Attribute.Heart);
                        player.addToSkill(1f, Skill.Psychology);
                        break;
                    case "c":
                        player.addToAttribute(1f, Attribute.Intelligence);
                        player.addToSkill(1f, Skill.Writing);
                        break;
                    case "d":
                        player.addToAttribute(1f, Attribute.Strength);
                        player.addToSkill(1f, Skill.HandToHand);
                        break;
                    case "e":
                        player.addToAttribute(1f, Attribute.Charisma);
                        player.addToSkill(1f, Skill.Persuasion);
                        break;
                    default:
                        continue;
                }
                console.Clear();
                QuestionFour(console, player);
                return;
            }
        }
        
        private static void QuestionFour(ConsoleWindow console, Player player)
        {
            while (console.WindowUpdate()) {
                console.Write(3, 1, "When I was 10...");
                console.Write(7, 1, "A - My parents divorced. Whenever I talked, they argued, so I stayed quiet.");
                console.Write(9, 1, "B - My parents divorced. Violently.");
                console.Write(11, 1, "C - My parents divorced. Acrimoniously. I once tripped over the paperwork!");
                console.Write(13, 1, "D - My parents divorced. Mom slept with the divorce lawyer.");
                console.Write(15, 1, "E - My parents divorced. It still hurts to read my old diary.");
                switch (console.GetInput(false)) {
                    case "a":
                        break;
                    case "b":
                        break;
                    case "c":
                        break;
                    case "d":
                        break;
                    case "e":
                        break;
                }
            }
        }
        
        private static void QuestionFive(ConsoleWindow console, Player player)
        {
            
        }
    }
}