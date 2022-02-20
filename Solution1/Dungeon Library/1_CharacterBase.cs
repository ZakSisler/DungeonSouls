using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public abstract class CharacterBase
    {
        //Fields
        

        //Properties
        public string Name { get; set; }

        //public int HitChance { get; set; }

        //public int MaxLife { get; set; }

       

        //Constructors
        //We have already done all of the work for the FQCTOR of player, so we'll opt not to create any constructors
        //Dont construct a constructor because its abstract (see line 9 above)

        //Methods

        //No need to override the ToString() we will never create a character object it will always be a player or a monster.

        //Below are methods we want to be inherited by player and monster, so we are creating default methods. The child classes will use these methods if they do not override them.

        //MINILAB
        //Calchitchance

        //public virtual int CalcHitChance()
        //{
        //    return HitChance;
        //}

        //public virtual int CalcDamage()
        //{
        //    return 0;
        //    //Starting with return 0. We will override this method for monster and player so they have their own unique ways to calculate the damage they deal.
        //}


    }
}

