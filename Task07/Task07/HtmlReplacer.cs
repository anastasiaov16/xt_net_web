using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task07
{
    public static class HtmlReplacer
    {
        public static void htmlReplace()
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            var res =  Regex.Replace(text, @"<[^>]*>", "_");
            Console.WriteLine("Result: {0}", res);

        }
    }
}
