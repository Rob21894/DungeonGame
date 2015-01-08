using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class UpJunction : Design
    {

        public void TJunction()
        {
            Console.WriteLine();
            yellow();
            Console.WriteLine("           N");
            grey();
            Console.WriteLine("          | |");
            Console.WriteLine("          | |");
            Console.WriteLine("          | |");
            Console.WriteLine("     _____| |_____");
            yellow();
            Console.WriteLine("W");
            grey();
            Console.WriteLine("____________");
            yellow();
            Console.WriteLine(" E");
            grey();

        }

    }
}
