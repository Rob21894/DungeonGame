using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class Help : Design
    {
        public void HelpObject()
        {
            Console.Clear();
            white();
            Console.WriteLine("Frequently asked questions");
            Console.WriteLine(" ");
            Green();
            Console.WriteLine("What is the game objective?");
            Console.WriteLine(" ");
            white();
            Console.WriteLine("The aim of “Eau Minerale Naturelle” is to traverse a mysterious");
            Console.WriteLine("underground cave system on the planet Evian.");
            Console.WriteLine("The player needs to find a way to get to the centre of the map without dying.");
            Console.WriteLine("Along the way the player will come across traps, enemies and more which they will need to overcome.");
            Console.WriteLine("The player needs to use various tools scattered around the map to survive.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Green();
            Console.WriteLine("How do i complete the game?");
            Console.WriteLine(" ");
            white();
            Console.WriteLine("By playing the game and getting to the end.");
            Console.WriteLine(" "); 
            Console.WriteLine(" ");
            Green();
            Console.WriteLine("What is the best race to pick?");
            Console.WriteLine(" ");
            white();
            Console.WriteLine("Other players have said the Orc race was the most exciting");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Green();
            Console.WriteLine("How many story lines are there?");
            Console.WriteLine(" ");
            white();
            Console.WriteLine("There are four different story lines these are:");
            Console.WriteLine(" Orc, Nid, coalission & Advent ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.ReadLine();



        }
    }
}