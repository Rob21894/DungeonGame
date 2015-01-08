using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class LeftJunction : Design
    {
        public void Leftjunction()
        {
            String Answer;
            Console.Clear();
            Red();
            Console.WriteLine("      N");
            white();
            Console.WriteLine("       | |");
            Console.WriteLine("       | |");
            Console.WriteLine("       | |");
            Console.WriteLine("_______| |");
            Red();
            Console.WriteLine("W ");
            Console.WriteLine("_______  |");
            Console.WriteLine("       | |");
            Console.WriteLine("       | |"); 
            Console.WriteLine("       | |");
            Console.WriteLine("       | |");
            Green();
            Console.WriteLine("      S");
            Console.ReadLine();
            Console.WriteLine("You can either go North, West or South");
            Console.WriteLine("which way do you wish to go?");
            Answer = Console.ReadLine();


            if (Answer == "South")
            {
                Console.WriteLine(" You move south");
                BlockedLeftJunction move = new BlockedLeftJunction();
                move.BlockedLjunction();
            }

            if (Answer == "West")
            {
                Console.WriteLine(" You move West");
                Crossroad1 move = new Crossroad1();
                move.Crossroadone();

            }

            if (Answer == "North")
            {
                Console.WriteLine("You move north");
                RightJunction1 move = new RightJunction1();
                move.Rightjunction();
            }

        }
    }
}
