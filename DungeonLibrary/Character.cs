using System.Xml.Linq;

namespace DungeonLibrary
{
    //an abstract class is "incomplete"
    //This is often used to mean "Inheritance Only"
    //We will be unable to make any instances of Character directly. It MUST be inherited in order to be used.
    public abstract class Character //: Object
    {
        //FIELDS
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;
        private int _life;

        //PROPERTIES
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    //If trying to set a life value less than or equal
                    //to max life, that's fine.
                    _life = value;
                }
                else
                {
                    //Otherwise, if trying to set life higher than 
                    //max life, set it to their max life value instead.
                    _life = MaxLife;
                }

                //refactor with a conditional expression
                //_life = (value <= MaxLife ? value : MaxLife);
            }
        }


        //CONSTRUCTORS
        public Character(string name, int hitChance, int block, int maxLife, int life)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = life;
        }

        //Remove int-life from list below, default life to maxlife
        public Character(string name, int hitChance, int block, int maxLife/*, int life*/)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            //Any properties with business rules that reference other properties MUST be assigned AFTER those other properties.
            //Life references/depends on MaxLife, so MaxLife comes FIRST
            MaxLife = maxLife;
            Life = maxLife;//set life equal to MaxLife, all characters start out at 100% health
        }

        public Character()
        {
            //default CTOR for future use 
        }
        //METHODS
        public override string ToString()
        {
            return $"----- {Name} -----\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Hit Chance: {HitChance}%\n" +
                $"Block: {Block}%\n";
        }

        //Because we intend to use Character as a base class for other, more specific types (Player/Monster), we
        //want those classes to have their own versions of the methods below.

        //This way, when we're using Polymorphism, we still have access to the specific implementations of these methods.

        public virtual int CalcBlock()
        {
            return Block;//Return Block for player, overridden for specific monster child classes.
        }

        public virtual int CalcHitChance()
        {
            return HitChance;//Will be overridden for Player, could be overridden for monster child classes.
        }
        //The abstract keyword indicates an "incomplete" implementation. Any child class MUST complete this method in order to be considered a type of "Character"
        public abstract int CalcDamage {
            get;//NO BODY!
}
    }
}