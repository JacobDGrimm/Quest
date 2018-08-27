using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_
{
    class Dice
    {
        public int Rollem(string Dice)
        {
            Random roll = new Random();
            if (Dice == "D4")
            {
                int d4 = roll.Next(1, 5);
                return d4;
            }
            if (Dice == "D6")
            {
                int d6 = roll.Next(1, 7);
                return d6;
            }
            if (Dice == "D8")
            {
                int d8 = roll.Next(1, 9);
                return d8;
            }
            if (Dice == "D10")
            {
                int d10 = roll.Next(1, 11);
                return d10;
            }
            if (Dice == "D12")
            {
                int d12 = roll.Next(1, 13);
                return d12;
            }
            if (Dice == "D20")
            {
                int d20 = roll.Next(1, 21);
                return d20;
            }
            else
                return -1;
        }
    }
}
