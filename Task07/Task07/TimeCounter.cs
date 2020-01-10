using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task07
{
    public static class TimeCounter
    {
        public static void timeCounter()
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            var regex = new Regex(@"\b(([0-1]?\d)|(2[0-3])):([0-5]\d))\b");
            var matches = regex.Matches(text);
            Console.WriteLine("This text contains {0} times", matches.Count); 
        }
    }
}
