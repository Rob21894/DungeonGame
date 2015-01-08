using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class Trapcrossroad3 : Design
    {
        public void Trapcrossroadthree()
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
                        Game_Complete move = new Game_Complete();
                        move.Completed();

                    }

                    if (Answer == "East")
                    {
                        Crossroad4 move = new Crossroad4();
                        move.Crossroadfour();
                    }

                    if (Answer == "South")
                    {
                        Console.WriteLine("Blocked up");
                    }

                    if (Answer == "West")
                    {
                        Crossroad4 move = new Crossroad4();
                        move.Crossroadfour();
                        
                    }
                
            }

        }
    }
}
