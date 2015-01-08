using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class URJunction : Design
    {
        public void rjunction()
        {
            String Answer;

            Console.Clear();
            Red();
            Console.WriteLine("      N");
            yellow();
Console.WriteLine("W                   ");
            white();
            Console.WriteLine("________");
            Console.WriteLine("_____  |");
            Console.WriteLine("     | |");
            Console.WriteLine("     | |");
            Console.WriteLine("     | |");
            Console.WriteLine("     | |");
            Green();
            Console.WriteLine("      S");


            Console.WriteLine(" You can either go West or South");
            Console.WriteLine(" Which way do you wish to go?");
            Answer = Console.ReadLine();

            if (Answer == "South")
            {
                Console.WriteLine(" you carry on going south");
                LeftJunction move = new LeftJunction();
                move.Leftjunction();
            }

            if (Answer == "West")
            {
                Console.WriteLine(" You carry on going West");
                Downjunction3 move = new Downjunction3();
                move.Downjunctionthree();

            }


        }
    }
}
