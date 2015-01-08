using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class BlockedRightJunction
    {
        public void BlockedLjunction()
        {

            String Answer;
            // draw map
            RightJunction1 drawmap = new RightJunction1();
            drawmap.Rightjunction();
            Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You have entered a room");
            Console.WriteLine("There is a Pressure plate 5 steps ahead of you, you are not sure what its for");
            Console.WriteLine("You can attempt to run to one of the chosen destinations (West, North, South.");
            Console.WriteLine("Do you wish to attempt to run to another location?(Y/N)? ");
            Answer = Console.ReadLine().ToUpper();

            while (Answer == "Y")
            {

                Console.WriteLine("You run as fast as you can to the south path");
                Console.WriteLine("You triggered the pressure plate.........");
                Console.WriteLine("The floor beneath you crumbles, and you fall to your death....");
                Console.WriteLine("Do you wish to try again?(Y/N)");
                Answer = Console.ReadLine().ToUpper();

            }


            if (Answer == "N")
            {
                Console.WriteLine("There is no Escape, You are dead......");
                Console.ReadLine();


            }

        }

    }
}
