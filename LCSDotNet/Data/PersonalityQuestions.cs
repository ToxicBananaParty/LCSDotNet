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
                        player.addToSkill(1f, Skill.Stealth);
                        break;
                    case "b":
                        player.addToSkill(1f, Skill.HandToHand);
                        break;
                    case "c":
                        player.addToSkill(1f, Skill.Law);
                        break;
                    case "d":
                        player.addToSkill(1f, Skill.Seduction);
                        break;
                    case "e":
                        player.addToSkill(1f, Skill.Writing);
                        break;
                    default:
                        continue;
                }

                console.Clear();
                QuestionFive(console, player);
                return;
            }
        }
        
        private static void QuestionFive(ConsoleWindow console, Player player)
        {
            while (console.WindowUpdate()) {
                console.Write(3, 1, "In junior high school...");
                console.Write(7, 1, "A - I was into chemistry. I wanted to know what made the world tick.");
                console.Write(9, 1, "B - I played guitar in a grunge band. We sucked, but so did life.");
                console.Write(11, 1, "C - I drew things, a lot. I was drawing a world better than this.");
                console.Write(13, 1, "D - I played violent video games at home. I was a total outcast.");
                console.Write(15, 1, "E - I was obsessed with swords, and started lifting weights.");
                switch (console.GetInput(false)) {
                    case "a":
                        player.addToAttribute(2f, Attribute.Intelligence);
                        player.addToSkill(2f, Skill.Science);
                        break;
                    case "b":
                        player.addToAttribute(2f, Attribute.Charisma);
                        player.addToSkill(2f, Skill.Music);
                        break;
                    case "c":
                        player.addToAttribute(2f, Attribute.Heart);
                        player.addToSkill(2f, Skill.Art);
                        break;
                    case "d":
                        player.addToAttribute(2f, Attribute.Agility);
                        player.addToSkill(2f, Skill.Computers);
                        break;
                    case "e":
                        player.addToAttribute(2f, Attribute.Strength);
                        player.addToSkill(2f, Skill.Sword);
                        break;
                    default:
                        continue;
                }
                
                console.Clear();
                QuestionSix(console, player);
                return;
            }
        }

        private static void QuestionSix(ConsoleWindow console, Player player)
        {
            while (console.WindowUpdate()) {
                console.Write(3, 1, "Things got really bad when...");
                console.Write(7, 1, "A - I stole my first car. I got a few blocks before I totalled it");
                console.Write(9, 1, "B - I went to live with my dad. He had been in 'Nam, and he still drank.");
                console.Write(11, 1, "C - I went completely goth. I had no friends and made costumes by myself.");
                console.Write(13, 1, "D - I was sent to religious counseling, which just stressed me out more.");
                console.Write(15, 1, "E - I tried being a teacher's assistant, but it just made me a target.");
                switch (console.GetInput(false)) {
                    case "a":
                        player.addToSkill(1f, Skill.Driving);
                        player.addToSkill(1f, Skill.Security);
                        break;
                    case "b":
                        player.addToSkill(1f, Skill.Shotgun);
                        player.addToSkill(1f, Skill.Rifle);
                        player.addToSkill(1f, Skill.Psychology);
                        break;
                    case "c":
                        player.addToSkill(2f, Skill.Tailoring);
                        break;
                    case "d":
                        player.addToSkill(1f, Skill.Religion);
                        player.addToSkill(1f, Skill.Psychology);
                        break;
                    case "e":
                        player.addToSkill(2f, Skill.Teaching);
                        break;
                    default:
                        continue;
                }
                
                console.Clear();
                QuestionSeven(console, player);
                return;
            }
        }

        private static void QuestionSeven(ConsoleWindow console, Player player)
        {
            while (console.WindowUpdate()) {
                console.Write(3, 1, "Well, I knew it had reached a crescendo when...");
                console.Write(7, 1, "A - I stole a cop car when I was only 14. I went to juvie for 6 months.");
                console.Write(9, 1, "B - My stepmom shot her ex-husband, my dad, with a shotgun. She got off.");
                console.Write(11, 1, "C - I tried wrestling for a querter, desperate to fit in.");
                console.Write(13, 1, "D - I got caught making out, and now I needed to be 'cured' of homosexuality");
                console.Write(15, 1, "E - I was resorting to controlling people. I had my own clique of outcasts.");

                switch (console.GetInput(false)) {
                    case "a":
                        player.addToAttribute(1f, Attribute.Intelligence);
                        player.addToSkill(1f, Skill.Driving);
                        player.addToSkill(1f, Skill.Security);
                        break;
                    case "b":
                        player.addToAttribute(1f, Attribute.Agility);
                        player.addToSkill(2f, Skill.Shotgun);
                        break;
                    case "c":
                        player.addToAttribute(1f, Attribute.Strength);
                        player.addToSkill(2f, Skill.HandToHand);
                        break;
                    case "d":
                        player. addToAttribute(1f, Attribute.Heart);
                        player.addToSkill(1f, Skill.Seduction);
                        player.addToSkill(1f, Skill.Religion);
                        break;
                    case "e":
                        player.addToAttribute(1f, Attribute.Charisma);
                        player.addToSkill(2f, Skill.Persuasion);
                        break;
                    default:
                        continue;
                }
                
                console.Clear();
                QuestionEight(console, player);
                return;
            }
        }

        private static void QuestionEight(ConsoleWindow console, Player player)
        {
            while (console.WindowUpdate()) {
                console.Write(3, 1, "I was only 15 when I ran away...");
                console.Write(7, 1, "A - I started robbing houses: rich people only. I was fed up with their crap.");
                console.Write(9, 1, "B - I hung out with thugs and beat the shit out of people.");
                console.Write(11, 1, "C - I got a horrible job working fast food, smiling as people fed the man.");
                console.Write(13, 1, "D - I let people pay me for sex. I needed the money to survive.");
                console.Write(15, 1, "E - I volunteered for a left-wing candidate. It wasn't *real*, though, you know?");
                
                switch (console.GetInput(false)) {
                    case "a":
                        player.addToAttribute(1f, Attribute.Agility);
                        player.addToSkill(1f, Skill.Security);
                        player.addToSkill(1f, Skill.Stealth);
                        break;
                    case "b":
                        player.addToAttribute(1f, Attribute.Strength);
                        player.addToSkill(2f, Skill.HandToHand);
                        break;
                    case "c":
                        player.addToAttribute(1f, Attribute.Charisma);
                        player.addToSkill(2f, Skill.Business);
                        break;
                    case "d":
                        player.addToAttribute(-1f, Attribute.Heart);
                        player.addToAttribute(2f, Attribute.Charisma);
                        player.addToSkill(2f, Skill.Seduction);
                        break;
                    case "e":
                        player.addToAttribute(1f, Attribute.Intelligence);
                        player.addToSkill(1f, Skill.Law);
                        player.addToSkill(1f, Skill.Persuasion);
                        break;
                    default:
                        continue;
                }
                
                console.Clear();
                QuestionNine(console, player);
                return;
            }
        }

        //TODO Fix location stuff
        private static void QuestionNine(ConsoleWindow console, Player player)
        {
            while (console.WindowUpdate()) {
                console.Write(3, 1, "Life went on. On my 18th birthday...");
                console.Write(7, 1, "A - I got my hands on a sports car. The owner must have been pissed.");
                console.Write(9, 1, "B - I bought myself an assault rifle.");
                console.Write(11, 1, "C - I celebrated. I'd saved a thousand bucks!");
                console.Write(13, 1, "D - I went to a party and met a cool law student. We've been dating ever since.");
                console.Write(15, 1, "E - I managed to acquire secret maps of several major buildings downtown.");
                
                switch (console.GetInput(false)) {
                    case "a":
                        player.vehicles.Add(new Vehicle(VehicleType.SportsCar));
                        break;
                    case "b":
                        player.inventory.Add(new Item(ItemType.AK47));
                        for(int i = 0; i < 9; i++)
                            player.inventory.Add(new Item(ItemType.Mag_AK47));
                        break;
                    case "c":
                        player.money += 1000f;
                        break;
                    case "d":
                        player.loveSlaves.Add(new Character(CharacterType.LAWYER));
                        break;
                    case "e":
                        player.inventory.Add(new Item(ItemType.Map_CosmeticLab));
                        player.inventory.Add(new Item(ItemType.Map_TextileFactory));
                        break;
                    default:
                        continue;
                }
                
                console.Clear();
                QuestionTen(console, player);
                return;
            }
        }
        
        private static void QuestionTen(ConsoleWindow console, Player player)
        {
            while (console.WindowUpdate()) {
                switch (console.GetInput(false)) {
                    case "a":
                        player.addToAttribute(2f, Attribute.Intelligence);
                        player.addToAttribute(2f, Attribute.Agility);
                        player.addToSkill(2f, Skill.Security);
                        player.money += 500f;
                        player.safeHouses.Add(LocationType.DowntownApartments);
                        break;
                    case "b":
                        player.addToAttribute(2f, Attribute.Agility);
                        player.addToAttribute(2f, Attribute.Heart);
                        player.addToAttribute(2f, Attribute.Strength);
                        player.addToSkill(2f, Skill.Rifle);
                        player.addToSkill(2f, Skill.Pistol);
                        player.addToSkill(2f, Skill.StreetSense);
                        player.safeHouses.Add(LocationType.CrackHouse);
                        //TODO: 10 rations
                        for(int i = 0; i < 4; i++)
                            player.recruits.Add(new Character(CharacterType.GANGMEMBER));
                        break;
                    case "c":
                        player.addToAttribute(4f, Attribute.Intelligence);
                        player.addToSkill(2f, Skill.Computers);
                        player.addToSkill(2f, Skill.Teaching);
                        player.addToSkill(2f, Skill.Science);
                        player.addToSkill(2f, Skill.Writing);
                        player.addToSkill(1f, Skill.Business);
                        player.addToSkill(1f, Skill.Law);
                        player.money += 200f;
                        player.safeHouses.Add(LocationType.UniversityApartments);
                        break;
                    case "d":
                        player.addToAttribute(4f, Attribute.Heart);
                        player.addToAttribute(2f, Attribute.Intelligence);
                        player.addToAttribute(2f, Attribute.Agility);
                        player.addToAttribute(1f, Attribute.Strength);
                        player.addToAttribute(1f, Attribute.Charisma);
                        player.addToSkill(2f, Skill.FirstAid);
                        player.addToSkill(2f, Skill.StreetSense);
                        player.safeHouses.Add(LocationType.HomelessShelter);
                        break;
                    case "e":
                        player.addToAttribute(2f, Attribute.Charisma);
                        player.addToAttribute(2f, Attribute.Intelligence);
                        player.addToSkill(1f, Skill.Writing);
                        player.addToSkill(1f, Skill.Law);
                        player.addToSkill(2f, Skill.Persuasion);
                        player.juice += 50f;
                        player.money += 50f;
                        player.safeHouses.Add(LocationType.IndustrialApartments);
                        break;
                    default:
                        continue;
                }
                
                console.Clear();
                return;
            }
        }
    }
}