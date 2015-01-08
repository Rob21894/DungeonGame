using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class Game_Complete : Design
    {
        public void Completed()

        {
            white();
            Console.WriteLine("Congratulations, you have completed");
            Console.WriteLine(" ");
            Megenta();
            Console.WriteLine("TTTTTTTTTT  HHH  HHH  EEEEE   GGGGGGGG    AAA          MMM    MMM     EEEEE ");
            Blue();
            Console.WriteLine("   TTTT     HHH  HHH  E       GG         AA AA        MM MM  MM MM    E     ");
            Red();
            Console.WriteLine("   TTTT     HHHHHHHH  EEEEE   GG GGGGG  AA   AA      MM   MMMM   MM   EEEEE ");
            Green();
            Console.WriteLine("   TTTT     HHH  HHH  E       GG   GG  AAAAAAAAA    MM     MM     MM  E     ");
            yellow();
            Console.WriteLine("   TTTT     HHH  HHH  EEEEE   GGGGGGG AA       AA  MM              MM EEEEE ");
            Console.ReadLine();


        }


    }
}
