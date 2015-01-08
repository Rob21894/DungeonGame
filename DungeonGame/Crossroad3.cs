using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class Crossroad3 : Design
    {
        public void Crossroadthree()
        {
            String Answer;

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


            Console.WriteLine("You approach another crossroad");
            Console.WriteLine("Which way do you choose to go?");
            Console.WriteLine(" N / E / W / S ");
            Console.WriteLine("What is your choice? type the corresponding letter now!");
            Answer = Console.ReadLine().ToUpper();


            if (Answer == "N")
            {
                Console.WriteLine("You have chosen to to go through the narrown path north...");
                Trapcrossroad4 move = new Trapcrossroad4();
                move.Trapcrossroadfour();

            }

            if (Answer == "E")
            {
                Console.WriteLine("You muster enough courage and head east....");
                Trapcrossroad3 move = new Trapcrossroad3();
                move.Trapcrossroadthree();

            }

            if (Answer == "W")
            {
                Console.WriteLine("You decide to go west.......");
                RightJunction2 move = new RightJunction2();
                move.RightJunctiontwo();
            }

            if (Answer == "S")
            {
                Console.WriteLine("You hurry down the stone path South....");
                UpJunction move = new UpJunction();
                move.UpJunctionone();
            }

        }
    }
}
