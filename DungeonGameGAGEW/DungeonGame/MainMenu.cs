using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
      class MainMenu 
    {
        static void Main(string[] args)
        {

            String Answer, RaceName = "",Invalid = "Y";


            Console.WriteLine("Hello and Welcome to Eau Minerelle Natturelle!");
            Console.WriteLine("game do you wish to continue? (Y/N)");

            Answer = Console.ReadLine().ToUpper();

            while (Answer == "Y")
            {

                Console.WriteLine("Welcome to the game!");
                Console.ReadLine();
                Console.WriteLine("Press enter to continue");

                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The aim of ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Eau Minerale Naturelle "); 
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("is to traverse a");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" mysterious underground cave system");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" on the planet Evian.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You play one of 4 unique races trying to find an unknown");
                Console.WriteLine("item that is shrouded in mystery");
                Console.WriteLine("The legendary item will aid your race in their long term");
                Console.WriteLine("survival in space. Finding it will make you");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("famous");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" and");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" rich.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Rumours of its location has culminated in each race sending");
                Console.WriteLine("a single experienced explorer into the deep dark caverns to find it.");
                Console.ReadLine();
                Console.WriteLine("You are that explorer.");
                while (Invalid == "Y")
                {
                    Console.WriteLine("There are 4 races to choose from");
                    Console.WriteLine("They are: Advent, Nid, Orc and Coalition. Type the name of your choice now!");
                    RaceName = Console.ReadLine();

                    if (RaceName == "Advent" || RaceName == "Nid" || RaceName == "Orc" || RaceName == "Coalition")
                    {
                        Invalid = "N";
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }  // end invalid loop

                    if (RaceName == "Advent")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("You are an Advent! Your species excels in all scientific");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("fields. Your race is ancient has its civilization has lasted millenia");
                        Console.WriteLine("You are a short people, with long beards and have an unnatural craving for");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("milk. You eat glass and hate water. Your stature allows you to fit through");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("the smallest gaps. This makes cave exploring easy.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You enter the cave...........");
                        Console.ReadLine();
                        Game_Complete move = new Game_Complete();
                        move.Completed();
                        Console.ReadLine();



                    }

                    if (RaceName == "Nid")
                    {
                        Console.Clear();
                        Console.WriteLine("You are a Nid. You belong to an unknown alien race that dwells");
                        Console.WriteLine("in the darkest reaches of space");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Your race destroys everything in its path, leaving only wildlife alive");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Your species is mysteriously drawn to the item and you have been chosen");
                        Console.WriteLine("over all of your kin to retrieve it");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You enter the cave...........");
                        Console.ReadLine();
                        URJunction move = new URJunction();
                        move.rjunction();
                        Console.ReadLine();
                    }

                    if (RaceName == "Orc")
                    {
                        Console.Clear();
                        Console.Write("You are an");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" Ork. ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("You are");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" Big.");
                        Console.Write(" Strong.");
                        Console.Write(" Green.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Despite your physical presence,");
                        Console.WriteLine(" you lack great intellingence, making you gullible and reckless.");
                        Console.WriteLine("For some reason you race is attracted to shiny objects and simple");
                        Console.WriteLine(" things like water confuse them but complex things they understand");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You enter the cave...........");
                        Console.ReadLine();
                        BLJunction move = new BLJunction();
                        move.Ljunction();
                        Console.ReadLine();
                    }
                        
                    if (RaceName == "Coalition")
                    {
                        Console.Clear();
                        Console.WriteLine("You are a member of the.... ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write(" Coalition  ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("As a result of your training you are good at such things as:");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Good at guerrilla warfare, sneaking and stealth");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("You are part of a unified Human race. And for some reason...");
                        Console.WriteLine("You can jump really high");
                        Console.ReadLine();
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You enter the cave...........");
                        Console.ReadLine();
                        BRJunction move = new BRJunction();
                        move.jjunction();
                        Console.ReadLine();



                    }
                    Console.ReadLine();

               
                    Console.ReadLine();








                Console.WriteLine("Do you wish to Play again? (Y/N)");
                Answer = Console.ReadLine().ToUpper();






            } // end of loop
 






        }
    }
}
