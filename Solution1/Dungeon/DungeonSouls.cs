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

            //Heroes made here (Perhaps they should be made in heroes.cs and called here?)
            Heroes hero = new Heroes("Blaise Pascal", 50, 50, 50, 20, 75, "Average build, Reliable, Makes wagers");



            //bools to end do while loops here
            bool intro = false;
            bool exitGame = false;
            bool doorOneOpened = false;


            //if "exitGame" boolean returns false, then run this code. Otherwise: Game Over. 
            do 
            {
                //if "intro && exitGame" booleans returns false, then run this code. Otherwise: Game Restart
                do
                {

                    //Story is introduced; A decision must be made.
                    Console.WriteLine("\n\nPiercing through the darkness, a faint light peeks through the ceiling... \n" +
                       "\"That's strange... I don't remember getting here...\" you think to yourself. \n\n" +
                       "You can barely see, but you can tell your are in a cold damp room made of stone. \n" +
                       "As your eyes adjust, you hear a small *clink* on the floor nearby, \naccompanied by the sound of rats\nchattering and scurrying away; Above, a shadowy figure lingers for a moment and then quickly disappears. \n" +
                       "Where am I? What was that noise?\n");


                    //User is prompted; Only one Path 
                    Console.WriteLine("What do you do next?: \n\n" +
                        "F) You quickly feel around for the item on the ground, avoiding any rats. \n(By the look of them they look unusually large and particularly ferocious...)\n" +
                        "R) You chase the rats... You are hungry after all...\n" +
                        "X) Exit Game");

                    Console.WriteLine("\nPlease press the key of your choice");
                    ConsoleKey userChoice = Console.ReadKey(true).Key;

                    Console.Clear();

                    //Switch for user selection
                    switch (userChoice)
                    {

                        //This choice continues the game
                        case ConsoleKey.F:
                            Console.WriteLine("You find a key!! Is there a door nearby? \n" +
                                "S) Search for a door.\n" +
                                "X) Exit Game.");
                            string newKey = Console.ReadLine().ToLower();
                            if (newKey == "s")
                            {
                                intro = true;
                            }
                            else
                            {
                                exitGame = true; //TODO (Not sure if needed here, further testing needed)
                                intro = true;
                                doorOneOpened = true;
                            }
                            break;


                            //This choice quickly ends the game and restarts the game; Helping the user understand the consequences of the game early on. Dungeon Souls will kick you out with no mercy.
                        case ConsoleKey.R:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You hastily chase the rats... annnnd to your horror are quickly swarmed and they devour you... \nYOU DIED");
                            Console.ResetColor();
                            exitGame = true;
                            intro = true;
                            break;

                            //Game Exit
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("\nYOU DIED (The only way to exit...)");
                            //intro = true;
                            break;
                        default:
                            Console.WriteLine("Git gud. Wrong input selected.");
                            break;
                    }



                    do
                    {
                        Console.WriteLine("You found a door! You slowly open it.\n\n" +
                            "You find yourself in a room with 7 doors");
                        //Console.WriteLine(GetRoom());///////Remove double slash (comment out when room code is fixed)
                        break;

                    } while (!intro && doorOneOpened);


            } while (!exitGame);
                   
                
                //get this code to execute at the end of every game
                    Console.WriteLine("play again?\n\ntype \"yes\" or \"no\"");
                    string playagain = Console.ReadLine().ToLower();
                    if (playagain == "yes")
                    {
                        Console.WriteLine("new game");
                        intro = false;
                    }
                    else
                    {
                        Console.WriteLine("thanks for playing!");
                        intro = true;
                        exitGame = true;
                        continue;
                    }
                } while (!intro && !exitGame);


        }//End main
        private static string GetRoom()
        {
            string[] rooms =
                {
                    "EMERALD ROOM",//Create rooms that randomly assigns different monsters into them when selected.
                    "PEARL ROOM",
                    "RUBY ROOM",
                    "TOPAZ ROOM",
                    "OBSIDIAN ROOM",
                    "CRYSTAL ROOM",
                };

            Random randomRoom = new Random();

            int indexNbr = randomRoom.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;

        }
    }
}
