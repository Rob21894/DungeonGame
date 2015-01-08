using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class DownJunction2
    {
        public void Downjunction2()
        {
            //drawmap
            String Answer;


            DownJunction1 drawmap = new DownJunction1();
            drawmap.Downjunction();

            Console.WriteLine("You see two paths.");
            Console.WriteLine("You can head East or south");
            Console.WriteLine("You can also go back the way you came.");
            Console.WriteLine("Which way do you choose?");
            Console.ReadLine();
            Console.WriteLine("E / S / W");
            Answer = Console.ReadLine();


            if ( Answer == "E")
            {
                Console.WriteLine("You continue heading East");
                Downjunction3 move = new Downjunction3();
                move.Downjunctionthree();
            }

            if (Answer == "S")
            {
                Console.WriteLine("You decide to head South");
                Trapcrossroad1 move = new Trapcrossroad1();
                move.Trapcrossroadone();
            }

            if (Answer == "W")
            {
                Console.WriteLine("You turn around and go to the previous room");
                DownJunction1 move = new DownJunction1();
                move.Downjunction();
            }
        }
    }
}
