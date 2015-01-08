using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonGame
{
    class Dead
    {
        public void Died()
        {

            String Answer;

            Console.Clear();
            Console.WriteLine("You are dead");
            Console.WriteLine("Do you wish to play again? (Yes/No)");
            Answer = Console.ReadLine();


            if (Answer == "Yes")
            {

                Console.WriteLine("You have chosen to play again");
                MainMenu move = new MainMenu();


            }


        }
      
    }
}
