using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;
using Heroes_Library;

namespace Dungeon
{
    class DungeonSouls
    {
        static void Main(string[] args)
        {
            Console.Title = "DUNGEON SOULS";

            Console.WriteLine("DUNGEON SOULS");

            Heroes player1 = new Heroes(new Pascal().HeroName, 3, 3, "Rock type; Makes wagers");
            Heroes player2 = new Heroes(new JoeSmoke().HeroName, 3, 3, "Paper type; a cool camel");
            Heroes player3 = new Heroes(new Leszynski().HeroName, 3, 3, "Scissors type; Hungarian Barbarian");

            

          
            

            
            //bool to end do while loops here
            bool exitGame = false;




            //if "exitGame" boolean returns false, then run this code. Otherwise: Game Over. 
            do
            {
                bool doorOneOpened = false;
                bool intro = false;


                //if "intro && exitGame" booleans returns false, then run this code. Otherwise: Game Restart
                do
                {

                    //Story is introduced; A decision must be made.
                    Console.WriteLine("\n\nPiercing through the darkness, a faint light peeks through the ceiling... \n" +
                       "\"That's strange... I don't remember getting here...\" you think to yourself.... ");
                    Console.WriteLine("\n\nPress any key to continue..."); Console.ReadLine(); Console.Clear();

                    Console.WriteLine("\n\n" +
                       "You can barely see, but as your eyes adjust you can tell your are in a cold damp room made of stone. \n" +
                       "You hear a small *clink* on the floor nearby, \naccompanied by the sound of rats chattering and scurrying away; they look unusually large and particularly ferocious... ");
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
                                    //Needs to restart game from the beginning.
                                    intro = false;
                                    exitGame = false;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("New Game Reloaded\n\n");
                                    Console.ResetColor();
                                    break;
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


                    ////////////////////////////Actual Game begins//////////////////////////////////////////////////////////////////////////
                    while (doorOneOpened)
                    {
                        Console.WriteLine("You found a door! you slowly open it.\n\nYou now find yourself in a room with a large hole in the wall with wreckage and debris strewn about. \n" +
                            "before you can get your wits about you a purple parrot haphazardly flies by squawking loudly and obnoxiously" +
                            "\n\nParrot: WHO ARE YOU?!\n\n");

                        Console.Write("\nPlease choose an action:\n" +
                        "B) Blaise Pascal \n" +
                        "J) Joe Smoke\n" +
                        "L) Leszynski the Hungarian\n");

                        ConsoleKey charChoice = Console.ReadKey(true).Key;
                        //Executes on input without having to hit "Enter"

                        //Clear Console
                        Console.Clear();
                        //string character = "";
                        Heroes character = new Heroes();
                        switch (charChoice)
                        {
                            case ConsoleKey.B:
                                Console.WriteLine("Blaise Pascal, eh?");
                                character = player1;
                             break;
                            case ConsoleKey.J:
                                Console.WriteLine("Joe Smoke, a talking camel eh?");
                                character = player2;
                                break;
                            case ConsoleKey.L:
                                Console.WriteLine("Leszynski the Hungarian, eh?");
                                character = player3;
                                break;

                            default:
                                Console.WriteLine("Huh?");
                                break;
                        }

                        Console.WriteLine("Well, "+character.Name+" you wanna get outta here?");//solve this name issue
                        Console.WriteLine("Before you can answer, the parrot flies out of the room, through the hole in the wall. You see a swarm of bloodthirsty rats behind you and quickly decide to follow the bird. \n\nBefore you there are three doors with colors you've never layed eyes on, their beauty unparalleled. \n\nParrot: ARE YOU GONNA LOOK AT THEM ALL DAY OR WHAT? Pick a door and let's get outta here!!");

                        Console.Write("\nPlease choose a door number:\n" +
                       "1) The oaky, light salmon colored door\n" +//color code it?
                       "2) The bright, lemon chiffon colored door\n" +
                       "3) The dilapidated, magenta and cyan colored door\n");

                        ConsoleKey charDoor = Console.ReadKey(true).Key;
                        //Executes on input without having to hit "Enter"

                        //Clear Console
                        Console.Clear();
                        
                        //Score declared and initialized.
                        int score = 0;

                        switch (charDoor)
                        {
                            //TODO fix this switch for door selection / monster randomization
                            case ConsoleKey.D1:
                                Console.WriteLine("Inside the first door you see a formidable foe...");
                                //Combat initiated here
                                



                                //Score tallied
                                score++;
                                //Game win/lose determined
                                break;
                            case ConsoleKey.D2:
                                Console.WriteLine("Inside the second door you see a ferocious beast...");
                                //Combat initiated here
                                //Score tallied
                                //Game win/lose determined
                                break;
                            case ConsoleKey.D3:
                                Console.WriteLine("Inside the third door you see a fiend unimaginable...");
                                //Combat initiated here
                                //Score tallied
                                //Game win/lose determined
                                break;

                            default:
                                Console.WriteLine("That's not a door? What are you doing over there?");
                                break;
                        }

                        //TODO Play again y/n added here

                        break;
                        



                        //TODO - *** Jump Here ***
                        //Rock paper Scissors mechanics will eventually apply bonuses depending on the hero/enemy chosen.
                        //Normal mechanics can be applied after mvp is reached to go along with RPS mechanics.
                        //Have the enemies randomly picked once door is chosen so the player can never memorize the doors.
                        //Initiate combat, keep track of score, have menu option for character info, declare winner/loser
                        //Player should be able to exit any time.



                    }
                        break;

                } while (!intro && !exitGame);

            } while (!exitGame);

        }//End main
    }
}
