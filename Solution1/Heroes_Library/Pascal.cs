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
        private static Heroes heroName;

        //Properties
        public bool IsRock { get; set; }

        //Constructors
        public Pascal(string name, int life, int maxLife, string description, bool IsRock)
            : base (heroName, life, maxLife, description)
        {
            IsRock = true;
        }

        public Pascal()
        {
            Name = "Blaise Pascal";
            Life = 3;
            MaxLife = 3;
            Description = "Makes Wagers; Rock type.";
        }

        //Methods
        //public override int CalcRPS()
        //{
        //    RPSCombat();
        //    return CalcRPS();
        //} 
    }
}
