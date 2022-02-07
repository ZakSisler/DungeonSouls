using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class DungeonSouls
    {
        static void Main(string[] args)
        {
            Console.Title = "DUNGEON SOULS";

            Console.WriteLine("DUNGEON SOULS");

            bool intro = false;
            bool exitGame = false;
            do
            {
                do
                {


                    Console.WriteLine("\n\nPiercing through the darkness, a faint light peeks through the ceiling... \n" +
                       "\"That's strange... I don't remember getting here...\" you think to yourself. \n\n" +
                       "You can barely see, but you can tell your are in a cold damp room made of stone. \n" +
                       "As your eyes adjust, you hear a small *clink* on the floor nearby, \naccompanied by the sound of rats\nchattering and scurrying away; Above, a shadowy figure lingers for a moment and then quickly disappears. \n" +
                       "Where am I? What was that noise?\n");

                    Console.WriteLine("What do you do next?: (Press the key related to your decision)\n\n" +
                        "F) You quickly feel around for the item on the ground.\n" +
                        "R) You chase the rats... You are hungry after all...\n" +
                        "X) Exit Game");

                    Console.WriteLine("\n");
                    ConsoleKey userChoice = Console.ReadKey(true).Key;

                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.F:
                            Console.WriteLine("You find a key!! Is there a door nearby? \n" +
                                "S) Search for a door.\n" +
                                "R) Look for the rats.\n" +
                                "X) Exit Game.");
                            string newKey = Console.ReadLine().ToLower();
                            if (newKey == "s")
                            {
                                intro = true;
                            }
                            else if (newKey == "r")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You hastily chase the rats... annnnd to your horror are quickly swarmed and they devour you... \nYOU DIED \n");
                                Console.ResetColor();
                                intro = true;
                            }
                            else
                            {
                                exitGame = true;
                            }
                            break;

                        case ConsoleKey.R:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You hastily chase the rats... annnnd to your horror are quickly swarmed and they devour you... \nYOU DIED");
                            Console.ResetColor();
                            intro = true;
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("\nYOU DIED (The only way to exit...)");
                            intro = true;
                            break;
                        default:
                            Console.WriteLine("Git gud. Wrong input selected.");
                            break;
                    }
                    
                } while (!intro && !exitGame);

                bool doorOneOpened = false;

                do
                {
                    Console.WriteLine("You found a door! You slowly open it.\n\n" +
                        "You find yourself in a room with 7 doors");


                } while (!doorOneOpened);


                    Console.WriteLine("Play Again?\n\nType \"Yes\" or \"No\"");
                    string playAgain = Console.ReadLine().ToLower();
                    if (playAgain == "yes")
                    {
                        Console.WriteLine("New Game");
                        intro = false;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                        intro = true;
                    }



            } while (!exitGame);

        }
    }
}
