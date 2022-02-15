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
        private bool isPaper;
        private static Heroes heroName;

        //Properties
        public bool IsPaper { get; set; }

        //Constructors
        public JoeSmoke(string name, int life, int maxLife, string description, bool IsPaper)
            : base(heroName, life, maxLife, description)
        {
            IsPaper = isPaper;
        }

        public JoeSmoke() { }

        //Methods
    }
}
