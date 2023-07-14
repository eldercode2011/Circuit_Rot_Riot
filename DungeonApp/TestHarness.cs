using DungeonLibrary;

namespace DungeonApp
    {
        internal class TestHarness
        {
            static void Main(string[] args)
            {
                //name, min, max, bonus hit, isTwoHanded
                Weapon w1 = new Weapon("Stick", 0, 5, 0, false, WeaponType.Dagger);
                Console.WriteLine(w1);

                Player p1 = Player.MakePlayer();

                Console.WriteLine(p1);
                Console.WriteLine("Hit Chance: " + p1.CalcHitChance());
                Console.WriteLine("Random Damage: " + p1.CalcDamage);

                Monster m1 = Monster.GetMonster();
                Console.WriteLine(m1);
                Console.WriteLine("Monster Damage: " + m1.CalcDamage);

                //boxing -> storing a "child type" as a "parent type"
                //object o1 = p1;
                //object o2 = w1;
                //Console.WriteLine(o1);
                //Console.WriteLine(o2);

                //unboxing -> returning a boxed "child type" to its original type.
                //Console.WriteLine(((Player)o1).Name);
                //Console.WriteLine(((Weapon)o2).Name);
            }
        }
    }
