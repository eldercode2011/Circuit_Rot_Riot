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
            : base(name, 70, 5, 40)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;

            #region Potential Expansion - Racial Bonuses
            switch (PlayerRace)
            {
                case Race.Human:
                    break;
                case Race.Goblin:
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
                    break;
                default:
                    break;
            }
            #endregion
        }

        public static Player MakePlayer()
        {
            Weapon w1 = new Weapon("OmniDrone", 1, 8, 10, false, WeaponType.Dagger);
            Player p = new Player("Tech Chaser Leaf Song", Race.Elf, w1);
            return p;
        }
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
            }
            return desc;
        }

        public override string ToString()
        {
            return base.ToString() + $"Weapon:\n{EquippedWeapon}\n" +
                                     $"Description:\n{GetRaceDesc(PlayerRace)}";
        }
        public override int CalcDamage()
        {
            {
                Random rand = new Random();
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