using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class ULJunction : Inventory
    {

        public void UJunction()
        {

            String Answer;


            Console.Clear();
            Red();
            Console.WriteLine("      N");
            Blue();
            Console.WriteLine("                         E");
            white();
            Console.WriteLine("       ________________");
            Console.WriteLine("      |  ______________");
            Console.WriteLine("      | |");
            Console.WriteLine("      | |");
            Console.WriteLine("      | |");
            Console.WriteLine("      | |");
            Green();
            Console.WriteLine("      S");

            yellow();
            Console.WriteLine("You start off in a small dark room. You see two paths, one");
            Console.WriteLine("leading East, one leading South");
            Console.ReadLine();
            Console.WriteLine("Which path do you choose?");
            Red();
            Console.WriteLine("East          OR         South");
            Answer = Console.ReadLine();

            if (Answer == "East")
            {

               Console.WriteLine("You choose to go East...");
               DownJunction1 move = new DownJunction1();
               move.Downjunction(); 
                

            }

            if (Answer == "South")
            {
                RightJunction1 move = new RightJunction1();
                move.Rightjunction();
            }



        } // do not delete
    }
}