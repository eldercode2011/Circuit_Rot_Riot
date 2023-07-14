using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public int Score { get; set; }

        public Player(string name, Race playerRace, Weapon equippedWeapon)
            : base(name, 70, 5, 40) //HitChance = 70, Block = 5, Life/MaxLife = 40
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;

            #region Potential Expansion - Racial Bonuses
            switch (PlayerRace)
            {
                case Race.Human:
                    break;
                case Race.Goblin:
                    HitChance += 5;
                    break;
                case Race.Elf:
                    break;
                case Race.Dwarf:
                    break;
                case Race.Gnome:
                    break;
                case Race.Steel_Forged:
                    break;
                case Race.Half_Demon:
                    break;
                case Race.Evolved_Slime:
                    break;
                case Race.Dryad:
                    MaxLife -= 5;
                    Life -= 5;
                    break;

                default:
                    break;
            }
            #endregion
        }//end CTOR

        public static Player MakePlayer()
        {
            //Console.WriteLine("Enter a name");
            //Have them pick a weapon
            Weapon w1 = new Weapon("Stick", 1, 8, 10, false, WeaponType.Dagger);
            //Have them pick a race

            Player p = new Player("Leeroy Jenkins", Race.Elf, w1);
            //cw the player. Ask them if it's good
            //If not, just call MakePlayer()
            //otherwise,
            return p;
        }//end MakePlayer()
        public static string GetRaceDesc(Race race)
        {
            string desc = "";
            switch (race)
            {
                case Race.Human:
                    break;
                case Race.Goblin:
                    break;
                case Race.Elf:
                    desc = "Elf - gets +5 to Hit Chance";
                    break;
                case Race.Dwarf:
                    break;
                case Race.Gnome:
                    break;
                case Race.Steel_Forged:
                    break;
                case Race.Half_Demon:
                    break;
                case Race.Evolved_Slime:
                    break;
                case Race.Dryad:
                    break;

                default:
                    break;
            }//end switch
            return desc;
        }//end GetRaceDesc()

        public override string ToString()
        {
            return base.ToString() + $"Weapon:\n{EquippedWeapon}\n" +
                                     $"Description:\n{GetRaceDesc(PlayerRace)}";
        }//end ToString()

        public override int CalcDamage
        {
            get
            {
                //throw new NotImplementedException();
                Random rand = new Random();
                // >= min, < max
                int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
                return damage;
            }
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }

    }
}