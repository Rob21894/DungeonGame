using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class CrossRoad : Design
    {
        public void Crossroad1()
        {
            Console.Clear();

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

            Console.ReadLine();
        }





    }
}
