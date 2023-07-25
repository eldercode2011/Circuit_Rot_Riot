using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        //Let's ceate a method to hadnle one-side of an attack
        public static void DoAttack(Character attacker, Character defender)
        {
            //Adjust the hit chance
                                     //50                       //20     = 30% chance to hit!
            int chance = attacker.CalcHitChance() - defender.CalcBlock();

            //Roll the dice!
            int roll = new Random().Next(1, 101);
            Thread.Sleep(600);
            if (roll <= chance)
            {
                //Then the attacker "hits" if the roll is less than or equal to the adjusted hit chance
                int damage = attacker.CalcDamage();

                //Subtract that damage from the defender's life
                defender.Life -= damage;

                //output the result - Red Text to help idicate damage
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damage} damage!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(attacker.Name + " missed!");
            }
        }//end DoAttack()

        public static bool DoBattle(Player player, Monster monster)
        {
            #region Potentail Expansions
            //COncider adding an "Initiative" property to Character
            //Then check the initiative to determine who attacks first.
            //if (player.Initiative >= monster.Initiative)
            #endregion
            DoAttack(player, monster);

            //If the monster is alive, let them attack the player
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
                return false;//monster is still alive
            }
            else
            {
                //the monster has died!
                #region Possible Expansions
                //heal?
                //if (player.Score % x == 0) player.Life += 50%

                //Loot drops!
                //You'd have to add an Inventory property to player (List<Item>)
                //Item rubyNecklace = new Item("Ruby Necklace", "Increases Max Life", MaxLife, 10);
                //inventory.add(rubyNecklace);
                //Console.WriteLine($"{player.Name} received {rubyNecklace.Name}!");
                //Console.WriteLine("{0}", rubyNecklace);
                #endregion

                player.Score++;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nYou killed the {monster.Name} that blocked your path! Well done adventurer!");
                Console.ResetColor();
                return true;//monster has died

            }
        }
    }
}
