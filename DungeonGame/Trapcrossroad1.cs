using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class Trapcrossroad1 : Design
    {
        public void Trapcrossroadone()
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
            Console.WriteLine("What is your choice? O/E");
            Choice = Console.ReadLine().ToUpper();

            Trap Test = new Trap();

            if (Test.Trapped(Choice))

            {
                Console.WriteLine("You can go North, East, South or west");

                Answer = Console.ReadLine();

                if (Answer == "North")
                {
                    

                }

                if (Answer == "East")
                {

                    Crossroad2 move = new Crossroad2();
                    move.Crossroadtwo();

                }

                if (Answer == "South")
                {
                    GameComplete move = new GameComplete();
                    move.Completed();
                }

                if (Answer == "West")
                {
                    Crossroad1 move = new Crossroad1();
                    move.Crossroadone();
                }

            }

        }

    }

}
