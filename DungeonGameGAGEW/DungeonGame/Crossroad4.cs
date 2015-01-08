using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class Crossroad4 : Design
    {
        public void Crossroadfour()
        {

            

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
                Trapcrossroad2 move = new Trapcrossroad2();
                move.Trapcrossroadtwo();

            }

            if (Answer == "East")
            {
                Console.WriteLine("Left junction 2"); 

            }

            if (Answer == "South")
            {
                Console.WriteLine("upjunction2");

            }

            if (Answer == "West")
            {
                Trapcrossroad3 move = new Trapcrossroad3();
                move.Trapcrossroadthree();

            }




        }
    }
}