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
            #endregion

            #region Monster Constructors

            BanditCurrentHealth = 10;
            BanditMaxHealth = 10;
            #endregion
        }


        #region Monster Properties

        public int BanditCurrentHealth { get; set; }
        public int BanditMaxHealth { get; private set; }

        #endregion
        
    }
}
