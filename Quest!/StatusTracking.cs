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

        private string PlayerName;
        private int PlayerCurrentHealth;
        private int PlayerMaxHealth { get; set; }
        private int PlayerCurrentMagic { get; set; }
        private int PlayerMaxMagic { get; set; }
        private int PlayerArmor { get; set; }
        private int PlayerMoney { get; set; }
        private int PlayerXP { get; set; }
        private double PlayerWeight { get; set; }
        private int PlayerRations { get; set; }
        private int PlayerKeys { get; set; }
        private string PlayerWeapon { get; set; }
        private string PlayerDefense { get; set; }
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
            PlayerWeapon = "D6";
            PlayerDefense = "D4";
            #endregion

          

        }

        
        public string WeaponDamage()
        {
            return PlayerWeapon;
        }
        public void PlayerDamage(int damage)
        {
            PlayerCurrentHealth -= damage;
        }
        public void PlayerHUD()
        {
            Console.WriteLine($"HP: {PlayerCurrentHealth}/{PlayerMaxHealth} MP: {PlayerCurrentMagic}/{PlayerMaxMagic} AC: {PlayerArmor} Keys: {PlayerKeys}");
        }
    }
}
