﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;

namespace Monster_Library
{
    public class KafkaBug : Monsters
    {
        //Fields

        //Properties
        public bool IsScissors { get; set; }

        //Constructors
        public KafkaBug(string name, int life, string description)
           : base(name, life, description) { }

        //Methods
        public KafkaBug() { }
    }
}
