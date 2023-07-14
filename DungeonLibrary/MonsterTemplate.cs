using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{//! Make it public, make it a child of Monster
    public class MonsterTemplate : Monster
    {/*
        //FIELDS - only if you have business rules


        //PROPS
        //! Add at least one custom property. 
        public bool IsUndead { get; set; }
        public int UndeadChance { get; set; }
        //CTORS
        //! CTOR (defaults Life = MaxLife)
        public Goblin(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description int undeadChance) : base(name, hitChance, block, maxLife, maxDamage, minDamage, description)
            {
            //! Add your custom prop(s) to the parameter list and assign them here.
            UndeadChance = undeadChance;
            UndeadChance = new Random().Next(20);
            }

            //! Default CTOR (creates a basic version of this monster)
            public MonsterTemplate()
            {
            //Assign each of the props some default value here
            //Name, HitChance, Block, MaxLife, MaxDamage, MinDamage, Description
            }
            public override string ToString()
            {
                //! Update the ToString() to include your new prop
                return base.ToString() + "";
            }

        //! Override at least one parent method to change the functionality based on your custom prop
        public override int CalcBlock()
        {
            //return base.CalcBlock();
            if (IsUndead)
            {
                Console.WriteLine("A hideous undead goblin!");
                return Block = 0;
            }
            else return Block;
        }
        public override int CalcHitChance()
        {
            return base.CalcHitChance() + (IsUndead ? - 25)
        }*/
    }

}
