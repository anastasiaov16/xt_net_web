using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select theme: \n 1 CSharpBasics \n 2 CSharpLanguage ");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    //CSharpBasics
                    CSharpBasics CS = new CSharpBasics();
                    Console.WriteLine("Task 1");
                    Console.WriteLine("This app counts rectangle area.");
                    CS.Rectangle();
                    Console.WriteLine();

                    Console.WriteLine("Task 2");
                    Console.WriteLine("This app drawing the triangle.");
                    Console.Write("Enter the demension: ");
                    int n = CS.Check();
                    CS.Triangle(n);
                    Console.WriteLine();

                    Console.WriteLine("Task 3");
                    Console.WriteLine("This app drawing another triangle.");
                    Console.Write("Enter the demension: ");
                    n = CS.Check();
                    CS.AnTriangle(n);
                    Console.WriteLine();

                    Console.WriteLine("Task 4");
                    Console.WriteLine("This app drawing Xmas triangle.");
                    Console.Write("Enter the demension: ");
                    n = CS.Check();
                    CS.XmasTree(n);
                    Console.WriteLine();

                    Console.WriteLine("Task 5");
                    Console.WriteLine("This app counts summary of elements, which is divided by 3 or 5");
                    CS.SumOfNumbers();
                    Console.WriteLine();

                    //Console.WriteLine("Task 6");
                    break;
                case "2":
                    //CSharpLanguage
                    CSharpLanguage SL = new CSharpLanguage();
                    Console.WriteLine("Task 7");
                    Console.WriteLine("This app generate/sort array and search min/max .");
                    var mas = SL.CreateMas();
                    Console.WriteLine("Created array:");
                    SL.Show(mas);
                    Console.WriteLine("Sorted array:");
                    SL.Show(SL.SortedMas(mas));
                    Console.WriteLine("Max element = {0}", SL.GetMax(mas));
                    Console.WriteLine("Min element = {0}", SL.GetMin(mas));
                    Console.WriteLine();


                    Console.WriteLine("Task 8");
                    Console.WriteLine("This app replaces all positive elements with 0.");
                    var mas3D = SL.Create3DMas();
                    Console.WriteLine("Created array:");
                    SL.Show(mas3D);
                    SL.NoPositive(mas3D);
                    Console.WriteLine("No positive:");
                    SL.Show(mas3D);
                    Console.WriteLine();


                    Console.WriteLine("Task 9");
                    Console.WriteLine("This determines the sum of non-negative elements.");
                    mas = SL.CreateMas();
                    Console.WriteLine("Created array:");
                    SL.Show(mas);
                    SL.NonNegSum(mas);
                    Console.WriteLine();

                    Console.WriteLine("Task 10");
                    Console.WriteLine("This determines the sum of elements standing in even positions.");
                    var mas2D = SL.Create2dMas();
                    Console.WriteLine("Created array:");
                    SL.Show(mas2D);
                    SL.GetSum(mas2D);
                    Console.WriteLine();
                    break;
            }

        }

    }
}

