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
            Score = 0;
            Type = Dungeon_Library.Type.Rock;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("Blaise Pascal");
        }

        public static int FightR(Monsters battleMonster, Heroes pascal)
        {
            int win = 1;
            

            if (battleMonster.Name == "Small Baby")
            {
                //Rock vs. Rock type
                Console.WriteLine("Draw!");
                //Character flees; No damage taken, no score increased.
                //win = 2;
            }
            else if (battleMonster.Name == "Sorceror Kahn Troll")
            {
                //Rock vs Paper type
                Console.WriteLine("You take damage, and the enemy has escaped!");
                //Hero takes 1 damage to Life out of 3 MaxLife; If life = zero game over
                //Life -= 1;
                win = 1;
            }
            else if (battleMonster.Name == "Kafka Bug")
            {
                //Rock vs Scissors type
                Console.WriteLine("You win!");
                pascal.Score += 1;
                
                //win = 3;
            }
            return win;

        }
    }
}
