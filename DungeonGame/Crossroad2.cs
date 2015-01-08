using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class Crossroad2
    {
        public void Crossroadtwo()
        {
            Console.Clear();

            String Answer;

            Crossroad1 drawmap = new Crossroad1();
            drawmap.Crossroadone();
            
            Console.WriteLine("You approach another crossroad");
            Console.WriteLine("Which way do you choose to go?");
            Console.WriteLine(" N / E / W / S ");
            Console.WriteLine("What is your choice? type the corresponding letter now!");
            Answer = Console.ReadLine().ToUpper();


            if (Answer == "N")
            {
                Console.WriteLine("You choose to go North!");
                Downjunction3 move = new Downjunction3();
                move.Downjunctionthree();
            }

            if (Answer == "E")
            {
                Console.WriteLine("You decide to head East!!");
                LeftJunction move = new LeftJunction();
                move.Leftjunction();
            }

            if (Answer == "W")
            {
                Console.WriteLine("You hurry towards the Western path");
                Trapcrossroad1 move = new Trapcrossroad1();
                move.Trapcrossroadone();
            }

            if (Answer == "S")
            {
                Console.WriteLine("You tip-toe");
                Trapcrossroad2 move = new Trapcrossroad2();
                move.Trapcrossroadtwo();
            }


        }

    }
}
