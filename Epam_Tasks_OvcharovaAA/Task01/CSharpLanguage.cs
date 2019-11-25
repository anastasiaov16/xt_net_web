using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class CSharpLanguage
    {
        //Task1.7
        const int Len = 5;
        public int [] CreateMas()
        {
            int[] mas = new int[Len];
            Random r = new Random();
            for (var i = 0; i < Len; i++)
            {
                mas[i] = r.Next(-50, 50);
            }
            return mas;
        }

        public void Show(int[] mas)
        {
            Console.Write("{");
            foreach (var item in mas)
            {
                Console.Write("{0}, ", item);
            }
            Console.Write("}");
            Console.WriteLine();
        }

        public int GetMin(int[] mas)
        {
            int min = mas[0];
            foreach (var item in mas)
            {
               min = (item < min)? item : min;
            }
            return min;
        }

        public int GetMax(int[] mas)
        {
            int max = mas[0];
            foreach (var item in mas)
            {
               max = (item > max) ? item : max;
            }
            return max;
        }

        public int [] SortedMas(int [] mas)
        {
            var tmp = 0;
            for (var i = 0; i < Len; i++)
            {
                for (var j = 0; j < Len; j++)
                {
                    if (mas[i] < mas[j])
                    {
                        tmp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = tmp;
                    }
                }
            }
            return mas;
        }

        //Task1.8
        public int [, ,] Create3DMas()
        {
            int[,,] mas = new int[Len,Len,Len];
            Random r = new Random();
            for (var i = 0; i < Len; i++)
            {
                for (var j = 0; j < Len; j++)
                {
                    for (var h = 0; h < Len; h++)
                    {
                        mas[i,j,h] = r.Next(-50, 50);
                    }
                }
            }
            return mas;
        }

        public void NoPositive(int[,,] mas)
        {
            for (var i = 0; i < Len; i++)
            {
                for (var j = 0; j < Len; j++)
                {
                    for (var h = 0; h < Len; h++)
                    {
                       mas[i, j, h] = (mas[i,j,h] >= 0)? 0 : mas[i, j, h];
                    }
                }
            }
        }

        public void Show(int[,,] mas)
        {
            Console.Write("{");
            foreach (var item in mas)
            {
                Console.Write("{0}, ", item);
            }
            Console.Write("}");
            Console.WriteLine();
        }

        //Task1.9
        public void NonNegSum(int [] mas)
        {
            int sum = 0;
            foreach (var item in mas)
            {
               sum += (item > 0) ? item : 0;
            }
            Console.WriteLine("Sum of non-negative array elements: {0}", sum);
        }

        //Task1.10
        public int[,] Create2dMas()
        {
            int[,] mas = new int[Len, Len];
            Random r = new Random();
            for (var i = 0; i < Len; i++)
            {
                for (var j = 0; j < Len; j++)
                {
                    mas[i, j] = r.Next(0, 100);
                }
            }
            return mas;
        }

        public void GetSum(int[,] mas)
        {
            double sum = 0;
            for (var i = 0; i < Len; i++)
            {
                for (var j = 0; j < Len; j++)
                {
                   sum += ((i + j) % 2 == 0)? mas[i, j] : 0;
                }
            }
            Console.WriteLine("Sum of elements standing in even positions: {0}", sum);
        }

        public void Show(int[,] mas)
        {
            Console.Write("{");
            foreach (var item in mas)
            {
                Console.Write("{0}, ", item);
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
}
