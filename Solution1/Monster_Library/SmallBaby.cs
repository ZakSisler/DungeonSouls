using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;

namespace Monster_Library
{
    public class SmallBaby : Monsters
    {
        //Fields

        //Properties
        public bool IsRock { get; set; }

        //Constructors
        public SmallBaby(string name, int life, int maxLife, string description)
           : base(name, life, maxLife, description) { }

        public SmallBaby()
        {
            Name = "A Small Baby";
            Life = 1;
            MaxLife = 1;
            Description = "Rock type; Don't underestimate!";
        }

        //Methods
    }
}
