using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main()
        {
            Round round = new Round();

            try
            {
                round = Round.ReadRound();
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            round.Show();
        }
    }
}
