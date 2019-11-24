using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
   public class CSharpStrings
    {
        //Task1.11
        public void AvStrLen()
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();

            bool isFirstLetter = false;
            int start = 0;
            double sum = 0, amount = 0;

            for (var i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
                    if (!isFirstLetter)
                    {
                        start = i;
                        isFirstLetter = true;
                    }
                }
                else
                {
                    sum += (i - start);
                    amount++;
                    isFirstLetter = false;
                }
            }
            double res = sum / amount;
            Console.WriteLine("The avertage word length in the entered line = {0:F3}", res);
        }

        public void CharDoubler()
        {
            Console.WriteLine("Enter first string:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string:");
            string str2 = Console.ReadLine();
            string res = String.Empty;

            for (var i = 0; i < str1.Length; i++)
            {
                if (str2.Contains(str1[i]))
                {
                    res += str1[i];
                    res += str1[i];
                }
                else
                {
                    res += str1[i];
                }
            }

            Console.WriteLine("Result string : {0}", res);
        }
    }
}
