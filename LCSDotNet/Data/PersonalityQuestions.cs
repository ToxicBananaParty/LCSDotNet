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
                console.Write(18, 1, "My parents named me " + player.name + ".");

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
                    default:
                        break;
                }
            }
        }

        private static void QuestionTwo(ConsoleWindow console, Player player)
        {
            
        }
        
        private static void QuestionThree(ConsoleWindow console, Player player)
        {
            
        }
        
        private static void QuestionFour(ConsoleWindow console, Player player)
        {
            
        }
        
        private static void QuestionFive(ConsoleWindow console, Player player)
        {
            
        }
    }
}