using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Player : IMove, IAttack
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Player(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void Attack()
        {
            Console.WriteLine("Player attack");
        }

        public void Move()
        {
            Console.WriteLine("Player moving");
        }
    }
}
