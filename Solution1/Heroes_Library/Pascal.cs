using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;

namespace Heroes_Library
{
    public class Pascal : Heroes
    {
        //Fields
        //private bool isRock;
        //private static Heroes heroName;



        //Properties
        public bool IsRock { get; set; }
        //public int Life { get; set; }



        //Constructors
        //public Pascal(string name, int life, int maxLife, string description, bool IsRock)
        //    : base(heroName, life, maxLife, description)
        //{
        //    IsRock = true;
        //}



        public Pascal()
        {
            Name = "Blaise Pascal";
            Life = 3;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("Blaise Pascal");
        }

        public static void FightR(Monsters battleMonster)
        {
            int score = 0;

            if (battleMonster.Name == "Small Baby")
            {
                //Rock vs. Rock type
                Console.WriteLine("Draw!");
                //Character flees; No damage taken, no score increased.

            }
            else if (battleMonster.Name == "Sorceror Kahn Troll")
            {
                //Rock vs Paper type
                Console.WriteLine("You take damage, but the enemy has been defeated!");
                //Hero takes 1 damage to Life out of 3 MaxLife; If life = zero game over
                Life -= 1;
            }
            else if (battleMonster.Name == "Kafka Bug")
            {
                //Rock vs Scissors type
                Console.WriteLine("You win!");
                score++;
            }
        }
    }
}
