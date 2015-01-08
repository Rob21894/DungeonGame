using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class Trapcrossroad2 : Design
    {
        public void Trapcrossroadtwo()
        {
            String Answer, Choice;

            Console.WriteLine();
            white();
            Console.WriteLine("       N");
            Console.WriteLine("      | |");
            Console.WriteLine("      | |");
            Console.WriteLine("  ____| |____");
            Red();
            Console.Write("W ");

            grey();
            Console.Write("____   ____");
            Blue();
            Console.WriteLine(" E");
            white();
            Console.WriteLine("      | |");
            Console.WriteLine("      | |");
            Console.WriteLine("      | |");
            yellow();
            Console.WriteLine("       S \n");


            Console.WriteLine("You step on a trap and you hear the plate move");
            Console.WriteLine(" there is a leaver you must push it up for Even, or push it down for odd");
            Console.WriteLine("What is your choice? (O/E)");
            Choice = Console.ReadLine().ToUpper();

            Trap Test = new Trap();


            if (Test.Trapped(Choice))
            {
                Console.WriteLine("You Guessed correctly and live!");
                Console.WriteLine("You can go either go North, East, South or west");
                Answer = Console.ReadLine();

                if (Answer == "North")
                {
                    Crossroad2 move = new Crossroad2();
                    move.Crossroadtwo();

                }

                if (Answer == "East")
                {
                    GameComplete move = new GameComplete();
                    move.Completed();
                }

                if (Answer == "South")
                {
                    Console.WriteLine("Cross road 3");
                }

                if (Answer == "West")
                {
                   BlockedLeftJunction move = new BlockedLeftJunction();
                    move.BlockedLJunction(); 
                }


            }


        }
    }
}
