using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class RightJunction2
    {
        
        public void Rightjunction2 ()
        {

            String Answer; 

             //drawmap

            RightJunction1 drawmap = new RightJunction1();
            drawmap.Rightjunction();

            Console.WriteLine("You start off in a small dark room. You see two paths, one");
            Console.WriteLine("leading East, one leading South");
            Console.ReadLine();
            Console.WriteLine("Which path do you choose? East  South  North");
            Answer = Console.ReadLine();

            if (Answer == "East")
            {
                Console.WriteLine("You muster enough courage to go East...");
                Crossroad1 move = new Crossroad1();
                move.Crossroadone();
            }

            

            if (Answer == "South")

            {
                Console.WriteLine("You decide to head back to where you started....");
                BLJunction move = new BLJunction();
                move.Ljunction();
            }

            if (Answer == "North")

            {
                Console.WriteLine("You choose to carry on going South");
                BlockedLeftJunction move = new BlockedLeftJunction();
                move.BlockedLjunction();
            }
            





        }
    }
}
