using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_
{
    class Game
    {
        Dice Dice = new Dice();
        StatusTracking ST = new StatusTracking();
        #region Locations


        #endregion

        #region Encounters

        public void BanditFight()
        {
            ST.BanditCurrentHealth = 10;
            while (ST.BanditCurrentHealth > 0)
            {
                PlayerHUD();
                if (ST.BanditCurrentHealth < 3 && ST.BanditPotion == 1)
                {
                    Console.WriteLine("The bandit Pulls out a potion and takes a swig, smiling evilly as he does.");
                    Console.ReadLine();
                    ST.BanditCurrentHealth += D4();
                    int damage = Dice.Rollem(ST.PlayerWeapon);
                    Console.WriteLine($"You swing your sword at the bandit dealing {damage} to the bandit.");
                    ST.BanditCurrentHealth -= damage;
                    Console.ReadLine();
                }
                else
                {
                    int banditDamage = Dice.Rollem(ST.BanditSword);
                    int damage =Dice.Rollem(ST.PlayerWeapon);
                    Console.WriteLine($"The bandit hits you for {banditDamage} you return the favor for {damage} right back at him");
                    Console.ReadLine();
                    ST.PlayerCurrentHealth -= banditDamage;
                    ST.BanditCurrentHealth -= damage;
                }
             }
            Console.WriteLine("The bandit is dead!");
            Console.ReadLine();
        }
        
        #endregion

        #region Utilities

        public string InputReader()
        {
            string input = Console.ReadLine();
            return input;
        }
        public void PlayerHUD()
        {
            Console.WriteLine($"HP: {ST.PlayerCurrentHealth}/{ST.PlayerMaxHealth} MP: {ST.PlayerCurrentMagic}/{ST.PlayerMaxMagic} AC: {ST.PlayerArmor} Keys: {ST.PlayerKeys}");
        }
        public void DangerTravel()
        {
            Console.Clear();
            PlayerHUD();
            int travelEvent = Dice.Rollem("D10");
            if (travelEvent >= 1 && travelEvent <= 5)
            {
                Console.WriteLine("It's a little quiet out here, a little too quiet...");
                Console.ReadLine();
            }
            if (travelEvent > 5 && travelEvent < 10)
            {
                Console.WriteLine("A bandit lays in wait for you, prepare to defend yourself!");
                Console.ReadLine();
                BanditFight();
            }
            if (travelEvent == 10)
            {
                Console.WriteLine("You found a bit of gold behind a bush laying amoung some bones\n" +
                    "You gained 10 GP");
                Console.ReadLine();
                ST.PlayerMoney += 10;
            }
        }
        #endregion

      
    }
}
