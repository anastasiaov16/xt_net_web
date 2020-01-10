using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void Main()
        {
            int selection;
            do
            {
                Console.WriteLine("1. Date Existance");
                Console.WriteLine("2. HTML Replacer");
                Console.WriteLine("3. Email Finder");
                Console.WriteLine("4. Number Validator");
                Console.WriteLine("5. Time Counter");
                Console.WriteLine("0. Exit");
                if (int.TryParse(Console.ReadLine(), out selection))
                {
                    switch (selection)
                    {
                        case 1:
                            DateExistance.dateSearch();
                            break;
                        case 2:
                            HtmlReplacer.htmlReplace();
                            break;
                        case 3:
                            EmailFinder.emailSearch();
                            break;
                        case 4:
                            NumberValidator.Show();
                            break;
                        case 5:
                            TimeCounter.timeCounter();
                            break;
                    }
                }
            } while (selection != 0);          
        }
    }
}
