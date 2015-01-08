using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class UpJunction : Design
    {

        public void UpJunctionone()
        {

            String Answer;

            Console.WriteLine();
            yellow();
            Console.WriteLine("           N");
            grey();
            Console.WriteLine("          | |");
            Console.WriteLine("          | |");
            Console.WriteLine("          | |");
            Console.WriteLine("     _____| |_____");
            yellow();
            Console.WriteLine("W");
            grey();
            Console.WriteLine("     ____________");
            yellow();
            Console.WriteLine(" E");
            grey();
  
            Console.WriteLine("You have entered a room");
            Console.WriteLine("Cobwebs surround you but you manage to see two paths in front of you.");
            Console.WriteLine("Do you wish to go North or East or back West? ");
            Console.WriteLine(" Choose: N  /  E  /  W  ");
            Answer = Console.ReadLine().ToUpper();



            if (Answer == "N")
            {
                Console.WriteLine("You choose to head North");
                Crossroad3 move = new Crossroad3();
                move.Crossroadthree();

            }

            if (Answer == "E")
            {
                Console.WriteLine("You muster enough courage to go East...");
                Crossroad1 move = new Crossroad1();
                move.Crossroadone();
            }

            if (Answer == "W")
            {
                Console.WriteLine("Your fear overwhelms you, so you turn back and head north...");
                ULJunction move = new ULJunction();
                move.UJunction();
            }







        }

    }
}
