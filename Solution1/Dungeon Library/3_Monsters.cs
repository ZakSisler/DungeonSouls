using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Monsters : CharacterBase
    {

        //Monster Ideas:

        //A small baby (baby)   - rock
        //Sorceror Kahn (troll) - paper
        //Kafka Bug (bug)       - scissors

        //RPS will add a (positive/neutral/negative)




        //Fields
        //private int _minDamage;

        //Properties
        //public string Name { get; set; }

        //public int HitChance { get; set; }

        //public int Block { get; set; }

        //public int MaxLife { get; set; }


        //public int MaxDamage { get; set; }
        public string Description { get; set; }
        
        //public int MinDamage
        //{
        //    get { return _minDamage; }
        //    set
        //    {
        //        if (value > 0 && value <= MaxDamage)
        //        {
        //            _minDamage = value;
        //        }
        //        else
        //        {
        //            _minDamage = 1;
        //        }
        //    }
        //}

        //Constructors
        public Monsters(string name, int life, int maxLife, string description)
        //: base(name, maxLife, life, hitChance, block)
        {
            //Monster inherits from the abstract class (Character) it has no constructor to inherit from. We never inherit the constructor but we are able to use the : base(params) shortcut for automatic assignment of any inherited properties. Since the character has no constructor it also does nothing for assignment of its porperties. When inheriting from an abstract but we will still need to manually perform assignment for all properties and methods, but we still need to manually perform the assignment for all properties in the CTOR.
            Name = name;
            Life = 1;
            MaxLife = 1;
            //MaxDamage = maxDamage;
            //HitChance = hitChance;
            //MinDamage = minDamage;
            Description = description;
        }

        public Monsters() { }

        //Methods
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("\n------- MONSTER -------\n" +
                "{0}\nLife: {1} of {2} \nDescription:{3}\n",
                Name,
                Life,
                MaxLife,
                //MinDamage,
                //MaxDamage,
                Description);
        }

        
    }
}
