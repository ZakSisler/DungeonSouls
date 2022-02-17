using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;

namespace Monster_Library
{
    public class SorcerorKahn : Monsters
    {
        //Fields

        //Properties
        public bool IsPaper { get; set; }

        //Constructors
        public SorcerorKahn(string name, int life, int maxLife, string description)
            : base(name, life, maxLife, description) { }

        //Methods
        public SorcerorKahn() { }
    }
}
