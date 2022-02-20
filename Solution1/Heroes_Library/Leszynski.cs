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
        public Leszynski(string name, int life, int maxLife, string description, bool IsScissors)
            : base(heroName, life, maxLife, description)
        {
            IsScissors = isScissors;
        }

        public Leszynski()
        {
            Name = "Leszynski the Hungarian";
        }

        //Methods
    }
}
