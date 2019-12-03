using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Cherry : Bonus
    {
        public override void GiveBonus(Player player)
        {
            Console.WriteLine("Cherry +10 health");
        }
    }
}
