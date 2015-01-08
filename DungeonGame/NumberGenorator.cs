using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class Numbergenorator : Design
    {
        public void NumbGenorator()
        {

            Int16 number;
            string goagain = "Y";

            Random Randnumb = new Random();

            while (goagain == "Y")
            {
                number = Convert.ToInt16(Randnumb.Next(1, 50));

                Console.WriteLine("Number is : " + number);

                if (number % 2 != 0)
                {
                    Console.WriteLine(number + " is odd");
                }

                if (number % 2 != 1)
                {
                    Console.WriteLine(number + " is even");

                }





                Console.WriteLine("Another number? (Y/N)");
                goagain = Console.ReadLine().ToUpper();
                Console.WriteLine();





            }

            Console.ReadLine();

        }


    }
}
