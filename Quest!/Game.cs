using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_
{
    class Game
    {
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
                // Battle system needs to go here!
            }
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
            int travelEvent = D10();
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

        #region Dice

        public int D4()
        {
            Random roll = new Random();
            int d4 = roll.Next(1, 5);
            return d4;
        }
        public int D6()
        {
            Random rnd = new Random();
            int d6 = rnd.Next(1, 7);
            return d6;
        }
        public int D8()
        {
            Random roll = new Random();
            int d8 = roll.Next(1, 9);
            return d8;
        }
        public int D10()
        {
            Random roll = new Random();
            int d10 = roll.Next(1, 11);
            return d10;
        }
        public int D12()
        {
            Random roll = new Random();
            int d12 = roll.Next(1, 13);
            return d12;
        }
        public int D20()
        {
            Random roll = new Random();
            int d20 = roll.Next(1, 21);
            return d20;
        }
        #endregion
    }
}
