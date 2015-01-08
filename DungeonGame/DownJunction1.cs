using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{

        class DownJunction1 : Design
        {
            public void Downjunction()
            {
                String Answer = "" ;

                Console.Clear();
                Blue();
                Console.WriteLine("                                      E");
                white();
                Console.WriteLine("        ________________________");
                yellow();
                Console.WriteLine(" W");
                white();
                Console.WriteLine("        ___________   __________");
                Console.WriteLine("                   | |          ");
                Console.WriteLine("                   | |          ");
                Console.WriteLine("                   | |     ");
                Console.WriteLine("                   | |          ");
                grey();
                Console.WriteLine("                    S");



                Console.WriteLine("Two paths lie in front of you.");
                Console.WriteLine("You can hear the sound of an animal from the South");
                Console.WriteLine("You feel a cold breeze from the East");
                Console.ReadLine();
                Console.WriteLine("Do you choose: South or East or West");
                Answer = Console.ReadLine();



                if (Answer == "South") 

                {
                    Console.WriteLine("You head south....");
                    Console.ReadLine();
                    Crossroad1 move = new Crossroad1();
                    move.Crossroadone();

                }

                if (Answer == "East")

                {
                    Console.WriteLine("You take the path east....");
                    Console.ReadLine();
                    DownJunction2 move = new DownJunction2();
                    move.Downjunction2();

                }

                if (Answer == "West")

                {
                    Console.WriteLine("You decide to head back west...");
                    Console.ReadLine();
                    RightJunction1 move = new RightJunction1();
                    move.Rightjunction();
                }



            }

        }
}
