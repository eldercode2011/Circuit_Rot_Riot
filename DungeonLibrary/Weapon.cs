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
        //FIELDS
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private int _minDamage;
        private int _maxDamage;
        //added a new enum:
        private WeaponType _type;


        //PROPERTIES
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
                //MinDamage shouldn't exceed MaxDamage & shouldn't be less than 1
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
                //refactor: 
                //_minDamage = ((value > 0 && value <= _maxDamage) ? value : MaxDamage);
            }
        }
        //Added a new enum:
        public WeaponType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        //CONSTRUCTORS
        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwohanded)
        {
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwohanded;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            //ANY properties with business rules based off of OTHER properties
            //MUST come AFTER those other properties are set. In this case, our 
            //MinDamage has business rules that reference MaxDamage, so we 
            //MUST set MaxDamage BEFORE MinDamage.           
        }

        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwohanded, WeaponType dagger) : this(name, minDamage, maxDamage, bonusHitChance, isTwohanded)
        {
        }

        //METHODS
        public override string ToString()
        {
            return $"{Name}\n" +
                $"Damage: {MinDamage} to {MaxDamage}\n" +
                $"Bonus Hit: {BonusHitChance}%\n" +
                $"{(IsTwoHanded ? "Two" : "One")}-Handed\n";
        }
    }
}

