using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    public static class NumberArraySum
    {
        #region methods
        /// <summary>
        /// Task4
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Sum(this int [] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        public static double Sum(this double[] arr)
        {
            double sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        public static float Sum(this float[] arr)
        {
            float sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        public static long Sum(this long[] arr)
        {
            long sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        public static short Sum(this short[] arr)
        {
            short sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        public static byte Sum(this byte[] arr)
        {
            byte sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        public static decimal Sum(this decimal[] arr)
        {
            decimal sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        public static ushort Sum(this ushort[] arr)
        {
            ushort sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        public static sbyte Sum(this sbyte[] arr)
        {
            sbyte sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        public static uint Sum(this uint[] arr)
        {
            uint sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        public static ulong Sum(this ulong[] arr)
        {
            ulong sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        /// <summary>
        /// Task5
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        
        public static bool IsInt(this string txt)
        {
            var result = txt.Trim();
            if(result.Length == 0)
                throw new ArgumentNullException();

            if (!Char.IsDigit(result[0]))
                return false;
            for (int i = 0; i < result.Length; i++)
            {
                if (!Char.IsDigit(result[i]))
                    return false;
            }
            return true;
        }
        #endregion

        #region show
        public static void ShowFourthTask()
        {
            int[] arr = new int[] {1,2,3,4,5};
            Console.WriteLine(arr.Sum()); 

            double[] arr1 = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };           
            Console.WriteLine(arr1.Sum());
            Console.WriteLine();
        }

        public static void ShowFifthTask()
        {
            Console.WriteLine("Enter a string to check for a number:");
            string str = Console.ReadLine();

            if(str.IsInt())
                Console.WriteLine("This is a positive integer number");
            else
                Console.WriteLine("This is not a positive integer number");
        }
        #endregion
    }
}
