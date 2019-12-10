using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class CustomSort
    {
        #region methods
        public static void Sort<T>(ref T[] collection, Func<T, T,bool> sorted)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                for (int j = 0; j < collection.Length - 1; j++)
                {
                    if (sorted.Invoke(collection[j], collection[j+1]))
                    {
                        var temp = collection[j];
                        collection[j] = collection[j + 1];
                        collection[j + 1] = temp;
                    }
                }
            }
        }

        public static bool Comparer(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return true;
            }
            else if (a.Length < b.Length)
            {
                return false;
            }
            else
            {
                if (String.Compare(a, b) > 0)
                {
                    return true;
                }
                else return false;
            }
        }
        #endregion

        #region show
        public static void ShowFirstTask()
        {
            int[] tmp = new int[10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                tmp[i] = r.Next(-50,50);
            }

            Console.WriteLine("Unsorted array:");
            foreach (var item in tmp)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            var func = new Func<int, int, bool>((m,n) => m > n);
            Sort(ref tmp, func);

            Console.WriteLine("Sorted array:");
            foreach (var item in tmp)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public static void ShowSecondTask()
        {
            string[] str = "When you said your last goodbye\nI died a little bit inside\nI lay in tears in bed all night\nAlone without you by my side".ToLower().Split(' ', '\n', '.', ',');

            Console.WriteLine("Unsorted string:");
            foreach (var item in str)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            var func = new Func<string, string, bool>(Comparer);
            Sort(ref str, func);

            Console.WriteLine("Sorted string:");
            foreach (var item in str)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        #endregion
    }
}
