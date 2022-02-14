﻿using System;
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
                       "\"That's strange... I don't remember getting here...\" you think to yourself.... ");
                    Console.WriteLine("\n\nPress any key to continue..."); Console.ReadLine(); Console.Clear();

                    Console.WriteLine("\n\n" +
                       "You can barely see, but you can tell your are in a cold damp room made of stone. \n" +
                       "As your eyes adjust, you hear a small *clink* on the floor nearby, \naccompanied by the sound of rats\nchattering and scurrying away; they look unusually large and particularly ferocious... ");
                    Console.WriteLine("\n\nPress any key to continue..."); Console.ReadLine(); Console.Clear();

                    Console.WriteLine("\n Above, a shadowy figure lingers for a moment and then quickly disappears. \n" +
                       "\"Where am I? What was that noise?\" you think to yourself as you clutch your sides, feeling the pangs of hunger... \n");


                    //User is prompted; Only one Path 

                    Console.WriteLine("What do you do next?: \n\n" +
                        "F) You quickly feel around for the item on the ground, avoiding any rats. \n" +
                        "R) You chase the rats... You are hungry after all...\n" +
                        "X) Exit Game");

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\n^^^Please press the key of your choice.^^^");
                    Console.ResetColor();
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
                                doorOneOpened = true;
                                
                            }
                            else
                            {
                                Console.WriteLine("Game Over");

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
                                    return;
                                }
                            }
                            break;


                            //This choice quickly ends the game and restarts the game; Helping the user understand the consequences of the game early on. Dungeon Souls will kick you out with no mercy.
                        case ConsoleKey.R:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You hastily chase the rats... \nto your horror you are quickly swarmed by thousands of plague infested, mutated rats and they devour you... \nYOU DIED");
                            Console.ResetColor();
                            exitGame = true;
                            intro = true;
                            continue;

                            //Game Exit
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nYOU DIED (The only way to exit...)");
                            Console.ResetColor();
                            exitGame = true;
                            intro = true;
                            return;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Git gud. Wrong input selected.");
                            Console.ResetColor();
                            break;
                    }
                    break;

                    //Implement second portion of the game after opening the door with the key found.
                    //do
                    //{
                    //    Console.WriteLine("You found a door! You slowly open it.\n\n" +
                    //        "You find yourself in a room with 7 doors");
                    //    //Console.WriteLine(GetRoom());///////Remove double slash (comment out when room code is fixed)
                    //    break;

                    //} while (!doorOneOpened);


            } while (!exitGame);
                   
                
                } while (!intro && !exitGame);
                //get this code to execute at the end of every game

                    Console.WriteLine("\n\nWant play again?\n\ntype \"yes\" or \"no\"");
                    string playagainFinal = Console.ReadLine().ToLower();
                    if (playagainFinal == "yes")
                    {
                        Console.WriteLine("new game");
                        intro = false;
                    }
                    else
                    {
                        Console.WriteLine("thanks for playing!");
                        intro = true;
                        exitGame = true;
                        //continue;
                    }


        }//End main


        //Room randomizer made here
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
