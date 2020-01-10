using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task07
{
    public static class EmailFinder
    {
        public static void emailSearch()
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            var regex = new Regex(@"\b[\w]+@[\w]+(\.[\w]+){1,}\b");
            var matches = regex.Matches(text);

            if(matches.Count > 0)
            {
                Console.WriteLine("Result:");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else Console.WriteLine("There's no emails in the text.");
        }
    }
}
