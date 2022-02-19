using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class SmallBaby : Monsters
    {
        public class SorcerorKahn : Monsters
        {
            public class KafkaBug : Monsters
            {
                public class Pascal : Heroes
                {
                    public class JoeSmoke : Heroes
                    {
                        public class Leszynski : Heroes
                        {

                            public static void GetMonster()
                            {
                                Heroes player1 = new Pascal();
                                Heroes player2 = new JoeSmoke();
                                Heroes player3 = new Leszynski();

                                Monsters mon1 = new SmallBaby();
                                Monsters mon2 = new SorcerorKahn();
                                Monsters mon3 = new KafkaBug();



                                Heroes[] heroesArray = { player1, player2, player3 };
                                Monsters[] monstersArray = { mon1, mon2, mon3 };

                                Random randomMonster = new Random();

                                int indexNbr = randomMonster.Next(monstersArray.Length);
                                System.Threading.Thread.Sleep(30);
                            }

                            public static void RPSAttack(CharacterBase attacker, CharacterBase defender)
                            {



                            }
                            public static void RPSFight()
                            {

                            }

                        }
                    }
                }
            }
        }
    }
}


//string rock = "rock";
//string paper = "paper";
//string scissors = "scissors";



//RPS style combat mechanics here

//ROCK > SCISSORS
//ROCK = ROCK
//ROCK < PAPER

//PAPER > ROCK
//PAPER = PAPER
//PAPER < SCISSORS

//SCISSORS > PAPER
//SCISSORS = SCISSORS
//SCISSORS < ROCK
#region old code

//public class FightRPS
//{
//    public enum Type { rock, paper, scissors };
//    public enum Outcome { Win, Lose, Draw };

//    public Type MonsterPick { get; set; }
//    public Type PlayerPick { get; set; }
//    public char UserSelection { get; set; }

//    public Type getUserType()
//    {
//        while (!validateSelection)
//        {
//            Console.Clear();
//            Console.WriteLine("Invalid Input");
//            Screen();
//            UserSelection = Convert.ToChar(Console.ReadLine());
//        }
//        switch (Char.ToUpper(UserSelection))
//        {
//            case "ROCK":
//                PlayerPick = Type.rock;
//                break;
//            case "PAPER":
//                PlayerPick = Type.paper;
//                break;
//            case "SCISSORS":
//                PlayerPick = Type.scissors;
//                break;

//            default:
//                break;
//        }
//        return PlayerPick;

//    }


//    private bool validateSelection()
//    {
//        char value = Char.ToUpper(UserSelection);
//        if (value != "ROCK" && value != "PAPER" && != "SCISSORS")
//            return false;
//        else
//        {
//            return true;

//        }
//        private void Screen()
//        {
//            Console.WriteLine("Blaise Pascal (Rock)");
//            Console.WriteLine("Joe Camel (Paper)");
//            Console.WriteLine("Leszynski the Hungarian (Scissors)");
//            Console.WriteLine("Choose your hero: (Rock/Paper/Scissors)?? )");
//        }

//    }

//}
#endregion
