
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{

        class RightJunction1 : Design

        {
            public void Rightjunction()
            {
                string Answer = " ";

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
                Console.ReadLine();

                Console.WriteLine("You come across a path leading East. You can also choose to carry on South");
                Console.WriteLine("You can go either South, East or North - choose now!");
                Answer = Console.ReadLine();


                if (Answer == "South")
                {
                    Console.WriteLine("You choose to carry on going South");
                    BlockedLeftJunction move = new BlockedLeftJunction();
                    move.BlockedLjunction(); 
                
                }

                if (Answer == "East")
                {
                    Console.WriteLine("You muster enough courage to go East...");
                    Crossroad1 move = new Crossroad1();
                    move.Crossroadone();
                }

                if (Answer == "North")
                {
                    Console.WriteLine("Your fear overwhelms you, so you turn back and head north...");
                    ULJunction move = new ULJunction();
                    move.UJunction();
                }

            }
        }
}
