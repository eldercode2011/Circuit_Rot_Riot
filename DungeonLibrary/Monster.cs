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
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 2; }
        }
        public string Description { get; set; }

        public override int CalcDamage => throw new NotImplementedException();

        public Monster(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description)
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
            return "\n****** MONSTER ******\n" +
                base.ToString() +
                $"Damage: {MinDamage} to {MaxDamage}\n" +
                $"Description \n{Description}";
        }

        public static Monster GetMonster()
        {
            Monster m1 = new("Monster 1", 40, 25, 25, 8, 2, "The first monster");
            Monster m2 = new("Monster 2", 40, 25, 25, 8, 2, "The second monster");
            Monster m3 = new("Monster 3", 40, 25, 25, 8, 2, "The third monster");
            Monster m4 = new("Monster 4", 40, 25, 25, 8, 2, "The fourth monster");
            Monster m5 = new("Monster 5", 40, 25, 25, 8, 2, "The fifth monster");

            List<Monster> monsters = new()
            {
                m1,m1,m1,m1,m1,m1,m1,
                m2,m2,m2,m2,
                m3,m3,m3,
                m4,m4,
                m5
            };
            int index = new Random().Next(monsters.Count);
            return monsters[index];
        }

        //public override int CalcDamage();
    }
}
