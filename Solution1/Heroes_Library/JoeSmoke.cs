using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;

namespace Heroes_Library
{
    public class JoeSmoke : Heroes
    {
        //Fields
        //private bool isPaper;
        //private static Heroes heroName;

        //Properties
        public bool IsPaper { get; set; }

        //Constructors
        //public JoeSmoke(string name, int life, int maxLife, string description, bool isPaper)
        //    : base(heroName, life, maxLife, description)
        //{
        //    IsPaper = isPaper;
        //}

        public JoeSmoke()
        {
            Name = "Joe Smoke";
            Life = 3;
            Score = 0;
            Type = Dungeon_Library.Type.Paper;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("Joe Smoke");
        }

        public static int FightP(Monsters battleMonster, Heroes joeSmoke)
        {
            int win = 1;
            
            if (battleMonster.Name == "Sorceror Kahn Troll")
            {
                //Paper vs. Paper type
                Console.WriteLine("Draw!");
                //Character flees; No damage taken, no score increased.
                win = 2;
            }
            else if (battleMonster.Name == "Kafka Bug")
            {
                //Paper vs Scissors type
                Console.WriteLine("You take damage, and the enemy has escaped!");
                //Hero takes 1 damage to Life out of 3 MaxLife; If life = zero game over
                win = 1;
            }
            else if (battleMonster.Name == "Small Baby")
            {
                //Paper vs Rock
                Console.WriteLine("You win!");
                win = 3;
            }
            return win;
        }

    }
}
