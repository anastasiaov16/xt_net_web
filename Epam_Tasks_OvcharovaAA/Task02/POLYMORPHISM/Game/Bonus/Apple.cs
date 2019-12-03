using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Apple : Bonus
    {
        public override void GiveBonus(Player player)
        {
            Console.WriteLine("Apple +15 health");
        }
    }
}
