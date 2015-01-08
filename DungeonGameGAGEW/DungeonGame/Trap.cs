using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class Trap
    {
        public bool Trapped(string Choice)
        {
            Boolean Live = true;
            Int16 number;
            // string Choice;

            Random Randnumb = new Random();
            number = Convert.ToInt16(Randnumb.Next(1, 50));

            //            Console.WriteLine("To avoid the trap you need to enter Odd or Even (O / E)");
            //          Choice = Console.ReadLine().ToUpper();

            if (Choice == "E")
            {
                if (number % 2 != 0)
                {
                    Live = false;
                }
            }
            else
            {
                if (number % 2 == 0)
                {
                    Live = false;
                }
            }

            return Live;
        }

    }
}
