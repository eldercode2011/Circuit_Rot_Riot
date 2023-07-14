namespace DungeonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            # region Title / Introduction
            Console.Title = "DUNGEON OF DOOM";
            Console.WriteLine("-= Dungeon of Doom =-\nYour journey begins...\n\n");
            #endregion

            #region Character/Player Creation
            //TODO Create a Weapon
            //TODO Create a Player
            #endregion

            #region Main Game Loop
            bool exit = false;
            do
            {
                //TODO Create a Monster
                //TODO Generate a Room
                Console.WriteLine(GetRoom() + ". In this room, you see a [monster]!");
                #region Encounter Loop
                bool reload = false;
                do
                {
                    #region Menu
                    Console.WriteLine("\nPlease choose an action:\n\t" +
                                       "A) Attack\n\t" +
                                       "R) Run Away\n\t" +
                                       "P) Player Info\n\t" +
                                       "M) Monster Info\n\t" +
                                       "E) Exit\n");
  
                    // capture user selection
                    ConsoleKey choice = Console.ReadKey(true).Key;
                    //Clear the console
                    Console.Clear();

                    switch (choice)
                    {
                        case ConsoleKey.A:
                            //TODO Combat Functionality
                            Console.WriteLine("ATTACK!!!\n\n");
                            break;

                        case ConsoleKey.R:
                            //TODO Run Away - Attack of Opportunity
                            Console.WriteLine("Run away!");
                            reload = true;//"reload the monster and room
                            break;

                        case ConsoleKey.P:
                            Console.WriteLine("Player Info: ");
                            //TODO Player Info
                            break;

                        case ConsoleKey.M:
                            Console.WriteLine("Monster Info: ");
                            //TODO Monster Info
                            break;

                        case ConsoleKey.E:
                        case ConsoleKey.Escape:
                        case ConsoleKey.X:
                            Console.WriteLine("No one likes a quitter...");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Thou hast chosen an improper action. Triest thou again.");
                            break;
                    }//end switch

                    //TODO Check Player Life. If the died, exit. Otherwise, do nothing.
                    #endregion
                } while (!reload && !exit);
                #endregion
            } while (!exit);
            #endregion

            //TODO - Display final score and exit message.
        }//end Main()

        #region Room Generation
        private static string GetRoom()
        {
            string[] rooms =
            {
                "Room 1",
                "Room 2",
                "Room 3",
                "Room 4",
                "Room 5",
                "Room 6",
                "Room 7",
                "Room 8",
                "Room 9",
                "Room 10",//TODO Update the Room Descriptions
            };
            //Random rand = new Random();
            //int index = rand.Next(rooms.Length);
            //return rooms[index];

            // refactored
            return rooms[new Random().Next(rooms.Length)];
        }
        #endregion
    }//end class
}//end namespace