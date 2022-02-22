using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{

    public class Heroes : CharacterBase
    {
        //NAME IDEAS:

        //Blaise Pascal (human)              - rock a
        //Joe Smoke (camel)                  - paper b
        //Lezinski the Hungarian (barbarian) - scissors c

        //RPS will add a (positive/neutral/negative) multiplier respectively

        //Fields
        //private int _minDamage;
        private int _life;


        //Properties
        public int Score { get; set; }
        public Type Type { get; set; }

        //public int MaxDamage { get; set; }
        //public Heroes HeroName { get; set; }
        public string Description { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                if (value > 0)
                {
                    _life = value;
                }
                else
                {
                    _life = 0;
                    //Console.WriteLine("Game Over.");
                }
            }
        }
        


        //Constructor
        public Heroes() { }



        //Methods
        public override string ToString()
        {
            //return base.ToString();
            return string.Format(
                "{0}\nLife: \n",
                Life);
        }

    }

}

#region ignore
//Constructors
//public int MinDamage
// {
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
//public Heroes(Heroes heroName, int life, int maxLife, string description)
//: base(name, maxLife, life, hitChance, block)
//{
//    //Monster inherits from the abstract class (Character) it has no constructor to inherit from. We never inherit the constructor but we are able to use the : base(params) shortcut for automatic assignment of any inherited properties. Since the character has no constructor it also does nothing for assignment of its porperties. When inheriting from an abstract but we will still need to manually perform assignment for all properties and methods, but we still need to manually perform the assignment for all properties in the CTOR.

//    MaxLife = maxLife;
//    //MaxDamage = maxDamage;
//    HeroName = heroName;
//    Life = life;
//    //HitChance = hitChance;
//    //MinDamage = minDamage;
//    Description = description;
//} 
#endregion
