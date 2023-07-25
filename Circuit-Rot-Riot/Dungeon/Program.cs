using DungeonLibrary;
namespace DungeonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Circuit Rot City Adventures";
            Console.WriteLine("-= Circuit Rot City =-\nYour journey begins on the cold metalic streets of Circuit Rot, the night life and street fighting capital of the technomancer empire.\n\n");
            Player player = Player.MakePlayer();
            bool exit = false;
            do
            {
                Monster monster = Monster.GetMonster();
                Console.WriteLine(GetRoom() + $" As if knowing you'd arrive a {monster.Name} ambushes you!");
                bool reload = false;
                do
                {
                    Console.WriteLine("\nHurry Tech Chaser! Act:\n\t" +
                                       "H) Hack\n\t" +
                                       "F) Flee in Terror\n\t" +
                                       "C) Chaser Specs\n\t" +
                                       "M) Monster Specs\n\t" +
                                       "E) Exit\n");
                    ConsoleKey choice = Console.ReadKey(true).Key;
                    Console.Clear();
                    switch (choice)
                    {
                        case ConsoleKey.H:
                            Console.WriteLine("Hack!\n\n");
                            reload = Combat.DoBattle(player, monster);
                            break;
                        case ConsoleKey.F:
                            Console.WriteLine("Flee!");
                            Console.WriteLine($"{monster.Name} attacks you as you flee.");
                            Combat.DoAttack(monster, player);
                            reload = true;
                            break;
                        case ConsoleKey.C:
                            Console.WriteLine("Chaser Info: ");
                            Console.WriteLine(player);
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Monster Info: ");
                            Console.WriteLine(monster);
                            break;
                        case ConsoleKey.E:
                        case ConsoleKey.Escape:
                        case ConsoleKey.X:
                            Console.WriteLine("Chaser extracted.");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Are your circuts scrambled? That wasn't a valid input skuzzler!");
                            break;
                    }
                    if(player.Life <= 0)
                    {
                        Console.WriteLine("Another worthless goon for the council's army...");
                        exit = true;
                    }
                } while (!reload && !exit);
            } while (!exit);
            Console.WriteLine($"You systems have been fried, but you managed to hack {player.Score} all{(player.Score==1 ? "y." : "ies.")} for the cause. Good work chaser.");
        }
        private static string GetRoom()
        {
            string[] rooms =
            {
                "After many hours of running and/or gunning you find a dark and musky, rusty and damp mossy brick room with a single red flickering candle in the center.",
                "After losing all your credits at the underground gnome fights you get tossed into room with a blood stained metal floor with dark glass walls and a cieling decorated with the hides of past victims of debt.",
                "You fall through a trap door in the sidewalk, finding yourself in a rusted ancient pipe in the sewer's abandoned section, filled with a green, stinking, choking mist.",
                "While looking for the bathroom in Techno Tower you end up in the massive abomination of flesh, steel pipes, and electronic components that makes up both the council chambers and the council itself.",
                "You moron, your ramen was laced. You wake up in a padded room with Tike Myson's tattoo on your face and without any credits.",
                "You got a virus hacking into the under web and your mind is trapped in the digirealm.",
                "You wound up in an official fight in the virturena, the crowd is screaming for a blood bath."
            };
            return rooms[new Random().Next(rooms.Length)];
        }
    }
}