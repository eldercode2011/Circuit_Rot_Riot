using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DungeonLibrary
{
    public class Weapon
    {
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private int _minDamage;
        private int _maxDamage;
        private WeaponType _type;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
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
        public WeaponType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwohanded)
        {
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwohanded;
            MaxDamage = maxDamage;
            MinDamage = minDamage;       
        }

        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwohanded, WeaponType dagger) : this(name, minDamage, maxDamage, bonusHitChance, isTwohanded)
        {
        }

        public override string ToString()
        {
            return $"{Name}\n" +
                $"Damage: {MinDamage} to {MaxDamage}\n" +
                $"Bonus Hit: {BonusHitChance}%\n" +
                $"{(IsTwoHanded ? "Two" : "One")}-Handed\n";
        }
    }
}

