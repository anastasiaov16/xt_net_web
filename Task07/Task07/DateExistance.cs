using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task07
{
    public static class DateExistance
    {
        public static void dateSearch()
        {
            DateTime defDate = DateTime.Now;
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            var dateRegex = new Regex(@"\b(0?[1-9]|[12][0-9]|3[01])-(0?[1-9]|[1][0-2])-\d{4}\b");
            var dates = dateRegex.Matches(text);

            Console.WriteLine("These dates were found:");

            foreach (var date in dates)
            {
                if (DateTime.TryParse(date.ToString(), out defDate))
                {
                    Console.WriteLine(date.ToString());
                }
            }
        }
            
    }
}
