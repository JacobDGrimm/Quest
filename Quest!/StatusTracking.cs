using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_
{
    class StatusTracking
    {
        #region Player Properties

        public string PlayerName { get; set; }
        public int PlayerCurrentHealth { get; set; }
        public int PlayerMaxHealth { get; set; }
        public int PlayerCurrentMagic { get; set; }
        public int PlayerMaxMagic { get; set; }
        public int PlayerArmor { get; set; }
        public int PlayerMoney { get; set; }
        public int PlayerXP { get; set; }
        public double PlayerWeight { get; set; }
        public int PlayerRations { get; set; }
        public int PlayerKeys { get; set; }
        public int PlayerWeapon { get; set; }
        #endregion



        public StatusTracking()
        {
            #region Player Constructors

            PlayerName = "Adventurer";
            PlayerCurrentHealth = 100;
            PlayerMaxHealth = 100;
            PlayerMaxMagic = 100;
            PlayerCurrentMagic = 100;
            PlayerArmor = 10;
            PlayerMoney = 10;
            PlayerXP = 0;
            PlayerWeight = 0.0;
            PlayerRations = 5;
            PlayerKeys = 0;
            PlayerWeapon = D6(); 
            #endregion

            #region Monster Constructors

            BanditCurrentHealth = 10;
            BanditMaxHealth = 10;
            BanditPotion = 1;
            BanditSword = D6();
            #endregion

        }


        #region Monster Properties

        public int BanditCurrentHealth { get; set; }
        public int BanditMaxHealth { get; private set; }
        public int BanditPotion { get; set; }
        public int BanditSword { get; set; }

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
