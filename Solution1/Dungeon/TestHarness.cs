using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class TestHarness
    {
        static void Main(string[] args)
        {
            Console.Title = "DUNGEON SOULS";

            Console.WriteLine("DUNGEON SOULS");

            //Heroes made here 
            Heroes heroBlaise = new Heroes("Blaise Pascal", 50, 50, 50, 20, 75, "Average build, Reliable, Makes wagers");



            //Monsters made here


        }//End main
        private static string GetRoom()
        {
            string[] rooms =
                {
                    "EMERALD ROOM",//Create rooms that randomly assigns different monsters into them when selected.
                    "PEARL ROOM",
                    "RUBY ROOM",
                    "TOPAZ ROOM",
                    "OBSIDIAN ROOM",
                    "CRYSTAL ROOM",
                };

            Random randomRoom = new Random();

            int indexNbr = randomRoom.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;

        }
    }
}
