using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class BLJunction : Design
    {
        public void Ljunction()
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
            Console.WriteLine("     |_________");
            Green();
            Console.WriteLine("      S");
            
            Console.WriteLine("You start in a cold dark cave. Before you there are 2 different paths.");
            Console.WriteLine("You can go either North or East - choose now!");
            Answer = Console.ReadLine();


            if (Answer == "East")
            {

                Console.WriteLine("You choose to go East...");
                UpJunction move = new UpJunction();
                move.UpJunctionone();

            }

            if (Answer == "North")
            {
                Console.WriteLine("You decide to venture North...");
                RightJunction2 move = new RightJunction2();
                move.RightJunctiontwo();
            }



        }
    }
}
