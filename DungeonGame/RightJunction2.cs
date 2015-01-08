using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class RightJunction2 : Design
    {
        
        public void RightJunctiontwo ()
        {

            String Answer;

            Console.Clear();
            Red();
            Console.WriteLine("      N");
            white();
            Console.WriteLine("     | |");
            Console.WriteLine("     | |");
            Console.WriteLine("     | |");
            Console.WriteLine("     | |_______");
            Blue();
            Console.Write(" E");
            white();
            Console.WriteLine("     |  ");
            Console.WriteLine("     |  _______");
            Console.WriteLine("     | |");
            Console.WriteLine("     | |");
            Console.WriteLine("     | |");
            Console.WriteLine("     | |");
            Green();
            Console.WriteLine("      S");
      
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
                move.BlockedLJunction();
            }
            





        }
    }
}
