using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task04
{
    class SortingUnit
    {
        private static int _threadID = 0;
        public static event Action<string> Finish = delegate { };
        public static void SortThread<T>(T[] array, Func<T, T, bool> comparator)
        {
            int threadId = ++_threadID;        
            Thread newThread = new Thread(() => CustomSort.Sort(ref array, comparator));
            newThread.Start();
            newThread.Join();
            Finish?.Invoke($"Sorting is finished in Thread with ID {threadId}.");
        }

        public static void Show()
        {
            int threads = 0;
            Finish += (element) =>
            {
                Console.WriteLine(element);
                threads++;
            };

            int[] tmp = new int[10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                tmp[i] = r.Next(-50, 50);
            }

            Console.WriteLine("Unsorted array:");
            foreach (var item in tmp)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            SortThread(tmp, (m, n) => m > n);

            Console.WriteLine("Sorted array:");
            foreach (var item in tmp)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        
    }
}

