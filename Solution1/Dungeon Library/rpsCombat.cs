using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class RPSCombat
    {  }



}
    //public static void FightR(Heroes heroes, Monsters monsters)
    //{
    //    int score = 0;


    //    if (heroes.Name == "Blaise Pascal" && monsters.Name == "Small Baby")
    //    {
    //        //Rock vs. Rock type
    //        Console.WriteLine("Draw!");
    //        //Character flees; No damage taken, no score increased.

    //    }
    //    else if (heroes.Name == "Blaise Pascal" && monsters.Name == "Sorceror Kahn Troll")
    //    {
    //        //Rock vs Paper type
    //        Console.WriteLine("You take damage, but the enemy has been defeated!");
    //        //Hero takes 1 damage to Life out of 3 MaxLife; If life = zero game over
    //    }
    //    else if (heroes.Name == "Blaise Pascal" && monsters.Name == "Kafka Bug")
    //    {
    //        //Rock vs Scissors type
    //        Console.WriteLine("You win!");
    //        score++;
    //    }
    //}
    //public static void FightP(Heroes heroes, Monsters monsters)
    //{
    //    int score = 0;

    //    if (heroes.Name == "Joe Smoke" && monsters.Name == "Sorceror Kahn Troll")
    //    {
    //        //Paper vs. Paper type
    //        Console.WriteLine("Draw!");
    //        //Character flees; No damage taken, no score increased.
    //    }
    //    else if (heroes.Name == "Joe Smoke" && monsters.Name == "Kafka Bug")
    //    {
    //        //Paper vs Scissors type
    //        Console.WriteLine("You take damage, but the enemy has been defeated!");
    //        //Hero takes 1 damage to Life out of 3 MaxLife; If life = zero game over
    //    }
    //    else if (heroes.Name == "Joe Smoke" && monsters.Name == "Small Baby")
    //    {
    //        //Paper vs Rock
    //        Console.WriteLine("You win!");
    //        score++;
    //    }
    //}

    //public static void FightS(Heroes heroes, Monsters monsters)
    //{
    //    int score = 0;

    //    if (heroes.Name == "Leszynski the Hungarian" && monsters.Name == "Kafka Bug")
    //    {
    //        //Scissors vs Scissors type
    //        Console.WriteLine("Draw!");
    //        //Character flees; No damage taken, no score increased.
    //    }
    //    else if (heroes.Name == "Leszynski the Hungarian" && monsters.Name == "Small Baby")
    //    {
    //        //Scissors vs Rock type
    //        Console.WriteLine("You take damage, but the enemy has been defeated!");
    //        //Hero takes 1 damage to Life out of 3 MaxLife; If life = zero game over
    //    }
    //    else if (heroes.Name == "Leszynski the Hungarian" && monsters.Name == "Sorcer Kahn Troll")
    //    {
    //        //Scissors vs Paper type
    //        Console.WriteLine("You win!");
    //        score++;
    //    }
    //}






//    public class SmallBaby : Monsters
//    {
//        public class SorcerorKahn : Monsters
//        {
//            public class KafkaBug : Monsters
//            {
//                public class Pascal : Heroes
//                {
//                    public class JoeSmoke : Heroes
//                    {
//                        public class Leszynski : Heroes
//                        {

//                            public static void GetMonster()
//                            {
//                                Heroes player1 = new Pascal();
//                                Heroes player2 = new JoeSmoke();
//                                Heroes player3 = new Leszynski();

//                                Monsters mon1 = new SmallBaby();
//                                Monsters mon2 = new SorcerorKahn();
//                                Monsters mon3 = new KafkaBug();



//                                Heroes[] heroesArray = { player1, player2, player3 };
//                                Monsters[] monstersArray = { mon1, mon2, mon3 };

//                                Random randomMonster = new Random();

//                                int battleMonster = randomMonster.Next(monstersArray.Length);
//                                System.Threading.Thread.Sleep(30);
//                            }

//                            public static void RPSAttack(CharacterBase attacker, CharacterBase defender)
//                            {



//                            }
//                            public static void RPSFight()
//                            {

//                            }

//                        }
//                    }
//                }
//            }
//        }
//    }
//}


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
