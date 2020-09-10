using System;
using System.Collections.Generic;
using System.Linq;

namespace GameList
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameList = new List<string> { "Super Mario Brothers", "Destiny 2", "Fall Out Guys", "Contra", "Tomb Raider: Rise of the Tomb Raider" };
            var nameLength = gameList.OrderBy(game => game.Length);

            Console.ReadLine();
        }
    }
}
