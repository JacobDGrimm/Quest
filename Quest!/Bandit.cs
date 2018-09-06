using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_
{
    class Bandit
    {
        int banditHealth = 10;
        int banditPotion = 1;
        string banditWeapon = "D6";
        
        public void BanditFight(StatusTracking ST)
        {
            var D = new Dice();
            var U = new Utilities();
            while (banditHealth > 0)
            {
                if (banditHealth < 3 && banditPotion > 0)
                {
                    Console.Clear();
                    ST.PlayerHUD();
                    banditHealth += D.Rollem("D4");
                    Console.WriteLine($"The bandit Pulls out a potion and takes a swig, smiling evilly as he does.\n" +
                        $"Would you like to <attack> or <wait> or <defend>\n\n" +
                        $"would you like to <attack> or <wait>");
                    switch (Console.ReadLine())
                    {
                        case "attack":
                            banditHealth -= U.BattleAttack(ST.WeaponDamage());
                            break;
                        case "wait":
                            Console.WriteLine("you just wait");
                            break;
                        default:
                            Console.WriteLine("not choosing is choosing to wait");
                            break;
                    }
                    Console.WriteLine($"The bandit has {banditHealth} life left.");
                    Console.ReadLine();
                }
                if (banditHealth > 3 || banditPotion == 0)
                {
                    int banditDamage = D.Rollem(banditWeapon);
                    Console.Clear();
                    ST.PlayerHUD();
                    Console.WriteLine($"" +
                        $"The Bandit attacks! dealing {banditDamage} points of damage\n\n" +
                        $"would you like to <attack> or <wait>");
                    ST.PlayerDamage(banditDamage);
                    switch (Console.ReadLine())
                    {
                        case "attack":
                            banditHealth -= U.BattleAttack(ST.WeaponDamage());
                            break;
                        case "wait":
                            Console.WriteLine("you just wait");
                            break;
                        default:
                            Console.WriteLine("not choosing is choosing to wait");
                            break;
                    }
                    Console.WriteLine($"The bandit has {banditHealth} life left");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"You have killed the bandit, good job");
            Console.ReadLine();
        }
    }
}
