using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_
{
    class Utilities
    {
        Dice Dice = new Dice();
        StatusTracking ST = new StatusTracking();
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
    }
}
