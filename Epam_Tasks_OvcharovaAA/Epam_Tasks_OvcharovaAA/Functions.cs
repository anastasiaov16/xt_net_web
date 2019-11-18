using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Tasks_OvcharovaAA
{
   public class Functions
    {
        //Task0.1
        public string Sequence(int N)
        {
            if(N <= 0)
            {
                return "0";
            }

            string seq = "";
            for(var i =1; i <= N; i++)
            {
                seq += $"{i}, ";
            }
            return seq;
        }

        //Task0.2
        public bool Simple(int N)
        {
            for(var i = 2; i < Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }

        //Task0.3
        public void Square(int N)
        {
            if (N < 0 || N % 2 == 0)
            {
                Console.WriteLine("Invalid value entered!");
            }
            else
            {
                for (var i = 0; i < N; i++)
                {
                    for (var j = 0; j < N; j++)
                    {
                        if ((i == N / 2) && (j == N / 2))
                        {
                            Console.Write(" ");
                        }
                        else Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
        }

        //Task 0.4
        public int [][] CreateArray(int N)
        {
            int[][] array = new int[N][];

            var rand = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write("Enter the demension of the {0}th nested array: ", i);
                int M = int.Parse(Console.ReadLine());
                array[i] = new int[M];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rand.Next(0, 100);
                }
            }
            return array;
        }

        public void Print(int [][] array)
        {
            Console.Write("{");
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write("{");
                for (var j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]},");
                }
                Console.Write("}");                   
            }
            Console.WriteLine("}");
        }

        public int[][] SortArray(int[][] array)
        {
            var len = 0;
            var idx = 0;
            for (var i = 0; i < array.Length; i++)
            {
                len += array[i].Length;
            }

            int[] newArr = new int[len];

            while (idx < len)
            {
                foreach (var arr in array)
                {
                    foreach (var item in arr)
                    {
                        newArr[idx] = item;
                        idx++;
                    }
                }
            }
            Array.Sort(newArr);
            idx = 0;
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = newArr[idx];
                    idx++;
                }
            }

            return array;
        }
    }
}
