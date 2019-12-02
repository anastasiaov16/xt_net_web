using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Game
    {
        private Field field;
        private List<Monsters> monsters;
        private List<Bonus> bonus;
        private List<Barrier> barrier;
        private Player player;

        public Game()
        {
            field = new Field(100, 100);
            monsters = new List<Monsters>();
            bonus = new List<Bonus>();
            barrier = new List<Barrier>();
            player = new Player("Bob", 100);
            Console.WriteLine("The game is creating...");
        }
    }

}
