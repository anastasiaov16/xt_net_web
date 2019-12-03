using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Wolf : Monsters
    {
        public Wolf()
        {
            Name = "Wolf";
        }
        public override void Attack()
        {
            Console.WriteLine("Wolf attack");
        }

        public override void Move()
        {
            Console.WriteLine("Wolf moving");
        }
    }
}
