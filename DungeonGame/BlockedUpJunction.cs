using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class BlockedUpJunction
    {
        public void BlockedUpJunctionone()
        {
            String Answer;

            UpJunction drawmap = new UpJunction();
            drawmap.UpJunctionone();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You have entered a room");
            Console.WriteLine("There is a massive whole in the Middle of the room");
            Console.WriteLine("You feel as if you can clear the jump to proceed to the next side");
            Console.WriteLine("Do you wish to attempt the jump? (Y/N)? ");
            Answer = Console.ReadLine().ToUpper();

            while (Answer == "Y")
            {

                Console.WriteLine("You have Attempted to clear the jump");
                Console.WriteLine("You Fall too your death and lose 1 life");
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
