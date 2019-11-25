using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class CSharpBasics
    {
        public int Check()
        {
            int N;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out N))
                {
                    if (N < 1)
                    {
                        Console.WriteLine("Enter valid number.");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return N;
        }
        //Task1.1
        public void Rectangle()
        {
            Console.WriteLine("Enter rectangle's sides (positive number):");
            int a, b;
            a = Check();
            b = Check();
            Console.WriteLine("Square = {0}", a * b);
        }

        //Task1.2
        public void Triangle(int N)
        {
            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }

        //Task1.3
        public void AnTriangle(int N)
        {
            for (var i = N; i != 0; i--)
            {
                for (var j = i; j != 0; j--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (var m = (N - i) * 2; m != 0; m--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //Task1.4
        public void XmasTree(int N)
        {
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    for (int k = 0; k < N - j; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < j; k++)
                    {
                        Console.Write("*");
                        if (k > 0)
                            Console.Write("*");
                    }
                    if (i != j)
                        Console.WriteLine();

                }
            }
            Console.WriteLine();
        }

        //Task1.5
        public void SumOfNumbers()
        {
            int sum = 0;
            for(var i = 1; i < 1000; i++)
            {
               sum += (i % 3 == 0 || i % 5 == 0) ? i : 0;
            }
            Console.WriteLine("Summary = {0}", sum);
        }

        //Task1.6
        public void FontAdjustment()
        {
            Font font = new Font();
            byte input;

            do
            {
                Console.WriteLine("Параметры надписи: " + font);
                Console.WriteLine("Введите:");
                Console.WriteLine("\t1: Bold");
                Console.WriteLine("\t2: Italic");
                Console.WriteLine("\t3: Underline");
                Console.WriteLine("\t4: Stop");

                if (byte.TryParse(Console.ReadLine(), out input))
                {
                    if (input > 3 || input < 1)
                    {
                        Console.WriteLine("Введите число от 1 до 3");
                        continue;
                    }
                    font ^= (Font)Math.Pow(2, input-1);
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение!");
                }
            } while (input != 4);

        }

        [Flags]
        public enum Font : byte
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4
        }

    }
}
