using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;

namespace Heroes_Library
{
    public class Leszynski : Heroes
    {
        //Fields
        private bool isScissors;
        private static Heroes heroName;

        //Properties
        public bool IsScissors { get; set; }

        //Constructors
        //public Leszynski(string name, int life, int maxLife, string description, bool IsScissors)
        //    : base(heroName, life, maxLife, description)
        //{
        //    IsScissors = isScissors;
        //}

        public Leszynski()
        {
            Name = "Leszynski the Hungarian";

        }


        //Methods
        public override string ToString()
        {
            return string.Format("Leszynski the Hungarian");
        }

        public static void FightS(Monsters battleMonster)
        {
            int score = 0;

            if (battleMonster.Name == "Kafka Bug")
            {
                //Scissors vs Scissors type
                Console.WriteLine("Draw!");
                //Character flees; No damage taken, no score increased.
            }
            else if (battleMonster.Name == "Small Baby")
            {
                //Scissors vs Rock type
                Console.WriteLine("You take damage, but the enemy has been defeated!");
                //Hero takes 1 damage to Life out of 3 MaxLife; If life = zero game over
            }
            else if (battleMonster.Name == "Sorcer Kahn Troll")
            {
                //Scissors vs Paper type
                Console.WriteLine("You win!");
                score++;
            }
        }
    }
}
