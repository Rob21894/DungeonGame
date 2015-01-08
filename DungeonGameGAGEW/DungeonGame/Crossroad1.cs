using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class Crossroad1 : Design
    {
        public void Crossroadone()
        {

            Console.Clear();

            String Answer = "";

            Console.WriteLine();
            white();
            Console.WriteLine("       N");
            Console.WriteLine("      | |");
            Console.WriteLine("      | |");
            Console.WriteLine("  ____| |____");
            Red();
            Console.Write("W ");

            grey();
            Console.Write("____   ____");
            Blue();
            Console.WriteLine(" E");
            white();
            Console.WriteLine("      | |");
            Console.WriteLine("      | |");
            Console.WriteLine("      | |");
            yellow();
            Console.WriteLine("       S \n");

            Console.WriteLine("You Can either go North, East, South or West");
            Console.WriteLine("Where do you wish to go?");
            Answer = Console.ReadLine();


            if (Answer == "North")
            {
                DownJunction1 move = new DownJunction1();
                move.Downjunction();

            }

            if (Answer == "East")
            {
                Trapcrossroad1 move = new Trapcrossroad1();
                move.Trapcrossroadone();

            }

            if (Answer == "South")
            {
                Trapcrossroad4 move = new Trapcrossroad4();
                move.Trapcrossroadfour();

            }

            if (Answer == "West")
            {
                BlockedLeftJunction move = new BlockedLeftJunction();
                move.BlockedLjunction();

            }



        }
    }
}
