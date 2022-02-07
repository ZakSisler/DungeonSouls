using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{

    public sealed class Heroes : CharacterBase
    {
        //NAME IDEAS:
        //Blaise Pascal - Strongest atk, medium speed, lowest health

        //Joe Smoke - Camel race, Super fast, weakest atk, medium health

        //Brutus Enduser - High health, medium atk, lowest speed

        //Fields
        private int _minDamage;

        //Properties
        //None


        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        //Constructors
        public Heroes(string name, int life, int maxLife, int hitChance, int minDamage, int maxDamage, string description)
        //: base(name, maxLife, life, hitChance, block)
        {
            //Monster inherits from the abstract class (Character) it has no constructor to inherit from. We never inherit the constructor but we are able to use the : base(params) shortcut for automatic assignment of any inherited properties. Since the character has no constructor it also does nothing for assignment of its porperties. When inheriting from an abstract but we will still need to manually perform assignment for all properties and methods, but we still need to manually perform the assignment for all properties in the CTOR.

            MaxLife = maxLife;
            MaxDamage = maxDamage;
            Description = description;
            Name = name;
            Life = life;
            HitChance = hitChance;
            MinDamage = minDamage;
            Description = description;
        }

        public Heroes() { }

        //Methods
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("\n@#$%@#$% HEROES @#$%@#$%@$%\n" +
                "{0}\nLife: {1} of {2}\nDamage: {3} to {4}\nDescription: {6}\n",
                Name,
                Life,
                MaxLife,
                MinDamage,
                MaxDamage,
                Description);
        }

    }

}

