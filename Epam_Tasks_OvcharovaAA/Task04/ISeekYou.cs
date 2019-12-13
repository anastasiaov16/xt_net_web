using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    static class ISeekYou
    {
        public static List<int> SearchPositiveNumbers(this int [] array)
        {
            var list = new List<int>();
            foreach (var item in array)
            {
                if(item > 0)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public static List<int> SearchPositiveNumbers(this int[] array, Predicate<int> condition)
        {
            var list = new List<int>();
            foreach (var item in array)
            {
                if (condition(item))
                {
                    list.Add(item);
                }
            }

            return list;
        }

        public static void General(int [] array)
        {
            Console.WriteLine("General Sort:");
            var res = array.SearchPositiveNumbers();
            res.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
        }
        

        public static void DelegateSort(int[] array)
        {
            Console.WriteLine("Delegate Sort:");
            Predicate<int> deleg = new Predicate<int>(x => x > 0);
            var res = array.SearchPositiveNumbers(deleg);
            res.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
        }

        public static void LambdaSort(int [] array)
        {
            Console.WriteLine("Delegate Sort:");
            var res = array.SearchPositiveNumbers((x) => x > 0);
            res.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
        }

        public static void AnonSort(int [] array)
        {
            Predicate<int> operation = delegate (int x){ return (x > 0);};
            Console.WriteLine("Anonymus Sort:");
            var res = array.SearchPositiveNumbers((m) => m > 0);
            res.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
        }

        public static void LinqSort(int [] array)
        {
            var res = array.Where(x => x > 0);
            foreach (var x in res)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }

        public static void Show()
        {
            List<int> searchTimes = new List<int>();
            int[] tmp = new int[1000];
            Random r = new Random();
            for (int i = 0; i < 1000; i++)
            {
                tmp[i] = r.Next(-1000, 1000);
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            General(tmp);
            Console.WriteLine($"Sorting {(int)stopWatch.ElapsedTicks} times");
            stopWatch.Stop();
            Console.WriteLine();

            stopWatch.Start();
            DelegateSort(tmp);
            Console.WriteLine($"Sorting {(int)stopWatch.ElapsedTicks} times");
            stopWatch.Stop();
            Console.WriteLine();

            stopWatch.Start();
            LambdaSort(tmp);
            Console.WriteLine($"Sorting {(int)stopWatch.ElapsedTicks} times");
            stopWatch.Stop();
            Console.WriteLine();

            stopWatch.Start();
            AnonSort(tmp);
            Console.WriteLine($"Sorting {(int)stopWatch.ElapsedTicks} times");
            stopWatch.Stop();
            Console.WriteLine();

            stopWatch.Start();
            LinqSort(tmp);
            Console.WriteLine($"Sorting {(int)stopWatch.ElapsedTicks} times");
            stopWatch.Stop();
            Console.WriteLine();
        }
    }
}
