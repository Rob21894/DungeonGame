using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class Crossroad2
    {
        public void Crossroadtwo ()
        {
            String Answer;

            Crossroad1 drawmap = new Crossroad1();
            drawmap.Crossroadone();
            

            Console.WriteLine("You Can either go North, East, South or West");
            Console.WriteLine("Where do you wish to go?");
            Answer = Console.ReadLine();

            if (Answer == "North")
            {
                Downjunction3 move = new Downjunction3();
                move.Downjunctionthree();

            }

            if (Answer == "East")
            {
                LeftJunction move = new LeftJunction();
                move.Leftjunction();

            }

            if (Answer == "South")
            {
                Trapcrossroad2 move = new Trapcrossroad2();
                move.Trapcrossroadtwo();

            }

            if (Answer == "West")
            {
                Trapcrossroad1 move = new Trapcrossroad1();
                move.Trapcrossroadone();

            }

        }

    }
}
