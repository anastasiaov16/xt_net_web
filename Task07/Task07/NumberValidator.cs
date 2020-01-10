using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task07
{
    public static class NumberValidator
    {
        public static bool IsUsual(string input)
        {
            var regex = new Regex(@"-?\d+(\.\d+)?$");
            return regex.IsMatch(input);
        }
        public static bool IsScientist(string input)
        {
            var regex = new Regex(@"-?\d+\.(\d+)?e-?(\d+)?$");
            return regex.IsMatch(input);
        }

        public static void Show()
        {
            Console.WriteLine("Enter number: ");
            string text = Console.ReadLine();

            if (IsScientist(text))
            {
                Console.WriteLine("This is number in scientist notation");
            }
            else if (IsUsual(text))
            {
                Console.WriteLine("This is number in usual notation");
            }
            else Console.WriteLine("This is not a number");
        }
    }
}
