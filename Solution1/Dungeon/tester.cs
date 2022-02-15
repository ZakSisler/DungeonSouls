using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class tester
    {
        static void Main(string[] args)
        {
            Console.Title = "DUNGEON SOULS";

            


            //bool to end do while loops here
            bool exitGame = false;
            bool intro = false;


            //if "exitGame" boolean returns false, then run this code. Otherwise: Game Over. 
            do
            {
                Console.WriteLine("Testing this do loop");
                string exit = Console.ReadLine();

              

            } while (!intro && !exitGame);
            
        }//End main
    }
}
