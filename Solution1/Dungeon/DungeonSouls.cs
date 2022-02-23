using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;
using Heroes_Library;
using Monster_Library;


namespace Dungeon
{
    class DungeonSouls
    {
        static void Main(string[] args)
        {
            Console.Title = "DUNGEON SOULS";

            Console.WriteLine("DUNGEON SOULS");

            int score = 0;
            //bool IsRock = true;
            //bool IsPaper = true;
            //bool IsScissors = true;
            Pascal player1 = new Pascal();
            JoeSmoke player2 = new JoeSmoke();
            Leszynski player3 = new Leszynski();





            //Heroes[] heroes = { player1, player2, player3 };


            //Monsters mon1 = new SmallBaby();
            //Monsters mon2 = new SorcerorKahn();
            //Monsters mon3 = new KafkaBug();

            //Monsters[] monsters = { mon1, mon2, mon3 };

            //Random randomMonster = new Random();

            //int battleMonster = randomMonster.Next(monsters.Length);

            //string BattleMonster = Convert.ToString(battleMonster);


            //monsters

            //Monsters battleMonster = monsters[indexNbr];


            //bool to end do while loops here
            bool exitGame = false;




            //if "exitGame" boolean returns false, then run this code. Otherwise: Game Over. 
            do
            {
                bool doorOneOpened = false;
                bool intro = false;
                Console.WriteLine("\n\nNEW GAME");
                Console.WriteLine(GetDungeon());



                //if "intro && exitGame" booleans returns false, then run this code. Otherwise: Game Restart
                do
                {



                    Monsters mon1 = new SmallBaby();
                    Monsters mon2 = new SorcerorKahn();
                    Monsters mon3 = new KafkaBug();

                    Monsters[] monsters = { mon1, mon2, mon3 };

                    Random randomMonster = new Random();

                    int indexNbr = randomMonster.Next(monsters.Length);


                    //monsters

                    Monsters battleMonster = monsters[indexNbr];


                    //return battleMonster;





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
                            continue;//possible break

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


                /////////Actual Game Begins//////////////////////////////////////////////////////////////////////////
                
                    Heroes character = new Heroes();
                    while (doorOneOpened)
                    {
                        Console.WriteLine("\n Before we continue..." +
                            "\nPICK YOUR FIGHTER!!\n\n");

                        Console.Write("\nPlease choose an character:\n" +
                        "B) Blaise Pascal (Rock Type)\n" +
                        "J) Joe Smoke (Paper Type)\n" +
                        "L) Leszynski the Hungarian (Scissors Type)\n" +
                        "" +
                        "See Info: \n" +
                        "P)Player Life/Score\n");

                        ConsoleKey charChoice = Console.ReadKey(true).Key;
                        //Executes on input without having to hit "Enter"

                        //Clear Console
                        Console.Clear();
                        //string character = "";
                        switch (charChoice)
                        {
                            case ConsoleKey.B:
                                character = player1;
                                Console.WriteLine("{0}, eh?", character);
                                //IsRock = true;
                                break;
                            case ConsoleKey.J:
                                character = player2;
                                Console.WriteLine("{0}, eh ? ", character);
                                //IsPaper = true;
                                break;
                            case ConsoleKey.L:
                                character = player3;
                                Console.WriteLine("{0}, eh ? ", character);
                                //IsScissors = true;
                                break;
                            case ConsoleKey.S:
                                Console.WriteLine(score);
                                break;
                            case ConsoleKey.P:
                                Console.WriteLine(character.Life);
                                Console.WriteLine(character.Score);
                                break;

                            default:
                                Console.WriteLine("Huh?");
                                break;
                        }

                        Console.WriteLine("Well, {0}, you wanna get outta here?", character.Name);//solve this name issue
                       

                        Console.Write("\nPICK THE DOOR TO INITIATE COMBAT: (1, 2, or 3?):\n" +
                       "1) The oaky, light salmon colored door\n" +//color code it?
                       "2) The bright, lemon chiffon colored door\n" +
                       "3) The dilapidated, magenta and cyan colored door\n");

                        ConsoleKey charDoor = Console.ReadKey(true).Key;
                        //Executes on input without having to hit "Enter"

                        //Clear Console
                        Console.Clear();

                        //Score declared and initialized.
                        //int score = 0;

                        int win = 1;
                        switch (charDoor)
                        {
                            //TODO fix this switch for door selection / monster randomization
                            case ConsoleKey.D1:
                                Console.WriteLine("Inside the first door you see a formidable foe...");
                                //Combat initiated here

                                Console.WriteLine("You face: " + battleMonster.Name);

                                if (character == player1)
                                {
                                    Pascal.FightR(battleMonster, character);
                                    if (battleMonster.Name == "Small Baby")
                                    {
                                        score++;
                                        Console.WriteLine("Current Score: {0}", score);
                                    }
                                    else if (win == 1)
                                    {

                                        character.Life -= 1;
                                        Console.WriteLine("You have {0} life points out of 3", character.Life);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Keep fighting!!");
                                        continue;
                                    }
                                }
                                else if (character == player2)
                                {
                                    JoeSmoke.FightP(battleMonster, character);
                                    if (win == 3)
                                    {
                                        score++;
                                        Console.WriteLine("Current Score: {0}", score);
                                    }
                                    else if (win == 1)
                                    {

                                        character.Life -= 1;
                                        Console.WriteLine("You have {0} life points out of 3", character.Life);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Keep fighting!!");
                                        continue;
                                    }
                                }
                                else
                                {
                                    Leszynski.FightS(battleMonster, character);
                                    if (win == 3)
                                    {
                                        score++;
                                        Console.WriteLine("Current Score: {0}", score);
                                    }
                                    else if (win == 1)
                                    {

                                        character.Life -= 1;
                                        Console.WriteLine("You have {0} life points out of 3", character, character.Life);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Keep fighting!!");
                                        continue;
                                    }
                                }
                                break;

                            //Pascal.FightR(character, battleMonster.Name);



                            //Score tallied

                            //Game win/lose determined

                            case ConsoleKey.D2:
                                Console.WriteLine("Inside the second door you see a ferocious beast...");
                                //Combat initiated here
                                Console.WriteLine("You face: " + battleMonster.Name);

                                if (character == player1)
                                {
                                    Pascal.FightR(battleMonster, character);
                                    if (win == 3)
                                    {
                                        score++;
                                        Console.WriteLine("Current Score: {0}", score);
                                    }
                                    else if (win == 1)
                                    {

                                        character.Life -= 1;
                                        Console.WriteLine("You have {0} life points out of 3", character.Life);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Keep fighting!!");
                                        continue;
                                    }
                                }
                                else if (character == player2)
                                {

                                    JoeSmoke.FightP(battleMonster, character);
                                    if (win == 3)
                                    {
                                        score++;
                                        Console.WriteLine("Current Score: {0}", score);
                                    }
                                    else if (win == 1)
                                    {

                                        character.Life -= 1;
                                        Console.WriteLine("You have {0} life points out of 3", character.Life);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Keep fighting!!");
                                        continue;
                                    }

                                }
                                else
                                {
                                    Leszynski.FightS(battleMonster, character);
                                    if (win == 3)
                                    {
                                        score++;
                                        Console.WriteLine("Current Score: {0}", score);
                                    }
                                    else if (win == 1)
                                    {

                                        character.Life -= 1;
                                        Console.WriteLine("You have life {0 }points out of 3", character.Life);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Keep fighting!!");
                                        continue;
                                    }
                                }
                                break;
                            //Score tallied
                            //Game win/lose determined

                            case ConsoleKey.D3:
                                Console.WriteLine("Inside the third door you see a fiend unimaginable...");
                                //Combat initiated here
                                Console.WriteLine("You face: " + battleMonster.Name);

                                if (character == player1)
                                {
                                    Pascal.FightR(battleMonster, character);
                                    if (win == 3)
                                    {
                                        score++;
                                        Console.WriteLine("Current Score: {0}", score);
                                    }
                                    else if (win == 1)
                                    {

                                        character.Life -= 1;
                                        Console.WriteLine("You have {0} life points out of 3", character.Life);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Keep fighting!!");
                                        continue;
                                    }
                                }
                                else if (character == player2)
                                {
                                    JoeSmoke.FightP(battleMonster, character);
                                    if (win == 3)
                                    {
                                        score++;
                                        Console.WriteLine("Current Score: {0}", score);
                                    }
                                    else if (win == 1)
                                    {

                                        character.Life -= 1;
                                        Console.WriteLine("{0} has {1} life points out of 3", character, character.Life);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Keep fighting!!");
                                        continue;
                                    }
                                }
                                else
                                {
                                    Leszynski.FightS(battleMonster, character);
                                    if (win == 3)
                                    {
                                        score++;
                                        Console.WriteLine("Current Score: {0}", score);
                                    }
                                    else if (win == 1)
                                    {

                                        character.Life -= 1;
                                        Console.WriteLine("{0} has {1} life points out of 3", character, character.Life);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Keep fighting!!");
                                        continue;
                                    }
                                }
                                break;
                            //Score tallied
                            //Game win/lose determined


                            default:
                                Console.WriteLine("That's not a door? What are you doing over there?");
                                break;
                        }




                        if (character.Life <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("GAME OVER. YOU DIED.");
                            //exitGame = true;
                            intro = true;
                            doorOneOpened = false;
                        }

                    }
                    //break;

                } while (!intro && !exitGame);

                //TODO Play again y/n added here
                //Console.WriteLine("Game Over");

                Console.WriteLine("play again?\n\ntype \"yes\" or \"no\"");
                string playagainFinal = Console.ReadLine().ToLower();
                if (playagainFinal == "yes")
                {
                    //Needs to restart game from the beginning.
                    intro = false;
                    exitGame = false;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("New Game Reloaded\n\n");
                    Console.ResetColor();
                    //break;
                }
                else
                {
                    Console.WriteLine("thanks for playing!");
                    intro = true;
                    exitGame = true;
                    return;
                }

            } while (!exitGame);

        }//End main

        private static string GetDungeon()
        {
            string[] dungeons =
                {
                    "You find yourself in a dark prison",
                    "You are locked within a torture chamber",
                    "You are at your buddy steve's",
                    "You are at an abandoned mall",
                    "You are in your basement",
                    "You are at a napalm death concert",
                    "You are in a simulated hellscape",
                    "You are cold and alone in a medieval prisoners cell"
                };

            Random randomDungeon = new Random();

            int indexNbr = randomDungeon.Next(dungeons.Length);

            string dungeon = dungeons[indexNbr];

            return dungeon;

        }

        //public static void GetMonster()
        //{
        //    Monsters mon1 = new SmallBaby();
        //    Monsters mon2 = new SorcerorKahn();
        //    Monsters mon3 = new KafkaBug();

        //    Monsters[] monsters = { mon1, mon2, mon3 };

        //    Random randomMonster = new Random();

        //    int indexNbr = randomMonster.Next(monsters.Length);


        //    //monsters

        //    Monsters battleMonster = monsters[indexNbr];


        //    //return battleMonster;

        //}
    }
}
