using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        private int _minDamage;
        public int MaxDamage { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }
        }
        public string Description { get; set; }
        public Monster(string name, int hitChance, int block, int maxLife,
            int maxDamage, int minDamage, string description)
            : base(name, hitChance, block, maxLife)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        public Monster()
        {
        }
        public override string ToString()
        {
            return "\n********* MONSTER *********\n" +
                base.ToString() +
                $"Damage: {MinDamage} to {MaxDamage}\n" +
                $"Description: \n{Description}";
        }
        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }
        public static Monster GetMonster()
        {
            Monster m1 = new Monster("Undead Goblin", 40, 25, 25, 8, 2, "A hideous mixture of rotting goblin and technology, the foot soldiers of the council.");
            Monster m2 = new Monster("Minotorg Guard", 50, 30, 5, 25, 4, "The sad remains of minotaurs that were captured and tortured in the Deathless War, rumor has it they're still in there, somewhere.");
            Monster m3 = new Monster("Council High Guard", 70, 5, 30, 30, 1, "A lich clad in a powerful exosuit that can survive a direct attack from a dragon's breath. Thankfully that power makes them slow and inaccurate.");
            Monster m4 = new Monster("The Council", 42, 42, 42, 42, 0, "The eldritch abomination of flesh and technology which was birthed from the council's dark ritual that ended the Deathless War and created the technomancer empire, pray they have mercy on this day.");
            List<Monster> monsters = new()
            {
                m1,m1,m1,m1,m1,m1,m1,m1,
                m2,m2,m2,m2,m2,m2,
                m3,m3,m3,m3,
                m4

            };
            int index = new Random().Next(monsters.Count);
            return monsters[index];
        }
    }
}
