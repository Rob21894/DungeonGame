using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class BlockedLeftJunction
    {
        public void BlockedLjunction()
        {

            String Answer;
            // draw map
            LeftJunction drawmap = new LeftJunction();
            drawmap.Leftjunction();
            Console.ReadLine();

            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You have entered a room");
            Console.WriteLine("There are a pile of rocks in the middle of a floor with a narrow passige inbetween them");
            Console.WriteLine("You can attempt to walk through the narrow passge inbetween the rocks.");
            Console.WriteLine("Do you wish to attempt to walk down the narrow path?(Y/N)? ");
            Answer = Console.ReadLine().ToUpper();

            while (Answer == "Y")
            {

                Console.WriteLine("You walk Down the narrow passage");
                Console.WriteLine("While walking you accidently knock a little rock out the way");
                Console.WriteLine("It triggers the rockslide again and you get crushed by the rocks");
                Console.WriteLine("Do you wish to try again?(Y/N)");
                Answer = Console.ReadLine().ToUpper();

            }


            if (Answer == "N")
            {
                Console.WriteLine("You turn around and proceed back to where you came from");
                Console.ReadLine();

            }

        }

    }
}
