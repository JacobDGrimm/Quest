using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_
{
    class Program
    {
        static void Main(string[] args)
        {
            var U = new Utilities();
            var Game = new Game();
            var ST = new StatusTracking();
            var Bandit = new Bandit();
            Bandit.BanditFight(ST);
            Game.Castle();
        }
    }
}
