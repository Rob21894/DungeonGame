using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class BlockedDown
    {
         public void Blockeddownjunction()
        {

            String Answer;
            // draw map
            DownJunction1 drawmap = new DownJunction1();
            drawmap.Downjunction();
            Console.ReadLine();

            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You have entered a room");
            Console.WriteLine("There is an old rickety wooden bridge");
            Console.WriteLine("You can only go across the bridge, NO TURNING BACK");
            Console.WriteLine("Do you wish to attempt to walk over the Wooden bridge?(Y/N)? ");
            Answer = Console.ReadLine().ToUpper();

            while (Answer == "Y")
            {

                Console.WriteLine("You walk over the bridge");
                Console.WriteLine("While walking your foot goes through a plank");
                Console.WriteLine("you hold on for dear life, but then the rest of the bridge collapses ");
                Console.WriteLine("You plummet to the ground and die");
                Console.WriteLine("Do you wish to try again?(Y/N)");
                Answer = Console.ReadLine().ToUpper();

            }


            if (Answer == "N")
            {
                Console.WriteLine("You turn around, you try go through the cave you just came from");
                Console.WriteLine("while walking through it, loads of rocks fall on top of you");
                Console.WriteLine("You died.........");
                Console.ReadLine();

            }

        }

    
    }
}
