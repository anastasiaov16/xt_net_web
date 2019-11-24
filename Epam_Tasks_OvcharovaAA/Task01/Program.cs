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
            double selection;
            CSharpBasics CS = new CSharpBasics();
            CSharpLanguage SL = new CSharpLanguage();
            CSharpStrings SS = new CSharpStrings();
            do
            {
                Console.WriteLine("1.1 Rectangle.");
                Console.WriteLine("1.2 Triangle.");
                Console.WriteLine("1.3 Another triangle.");
                Console.WriteLine("1.4 X-mas tree.");
                Console.WriteLine("1.5 Sum of nimbers.");
                Console.WriteLine("1.6 Font adjustment.");
                Console.WriteLine("1.7 Array processing.");
                Console.WriteLine("1.8 No positive.");
                Console.WriteLine("1.9 Non-negative sum.");
                Console.WriteLine("1.10 2D array.");
                Console.WriteLine("1.11 Avertage string length.");
                Console.WriteLine("1.12 Char doubler.");
                if (double.TryParse(Console.ReadLine(), out selection))
                {
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine("Task 1");
                            Console.WriteLine("This app counts rectangle area.");
                            CS.Rectangle();
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine("Task 2");
                            Console.WriteLine("This app drawing the triangle.");
                            Console.Write("Enter the demension: ");
                            int n = CS.Check();
                            CS.Triangle(n);
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine("Task 3");
                            Console.WriteLine("This app drawing another triangle.");
                            Console.Write("Enter the demension: ");
                            n = CS.Check();
                            CS.AnTriangle(n);
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine("Task 4");
                            Console.WriteLine("This app drawing Xmas triangle.");
                            Console.Write("Enter the demension: ");
                            n = CS.Check();
                            CS.XmasTree(n);
                            Console.WriteLine();
                            break;
                        case 5:
                            Console.WriteLine("Task 5");
                            Console.WriteLine("This app counts summary of elements, which is divided by 3 or 5");
                            CS.SumOfNumbers();
                            Console.WriteLine();
                            break;
                        case 6:
                            Console.WriteLine("Task 6");
                            CS.FontAdjustment();
                            break;
                        case 7:
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
                            break;
                        case 8:
                            Console.WriteLine("Task 8");
                            Console.WriteLine("This app replaces all positive elements with 0.");
                            var mas3D = SL.Create3DMas();
                            Console.WriteLine("Created array:");
                            SL.Show(mas3D);
                            SL.NoPositive(mas3D);
                            Console.WriteLine("No positive:");
                            SL.Show(mas3D);
                            Console.WriteLine();
                            break;
                        case 9:
                            Console.WriteLine("Task 9");
                            Console.WriteLine("This determines the sum of non-negative elements.");
                            mas = SL.CreateMas();
                            Console.WriteLine("Created array:");
                            SL.Show(mas);
                            SL.NonNegSum(mas);
                            Console.WriteLine();
                            break;
                        case 10:
                            Console.WriteLine("Task 10");
                            Console.WriteLine("This determines the sum of elements standing in even positions.");
                            var mas2D = SL.Create2dMas();
                            Console.WriteLine("Created array:");
                            SL.Show(mas2D);
                            SL.GetSum(mas2D);
                            Console.WriteLine();
                            break;
                        case 11:
                            SS.AvStrLen();
                            Console.WriteLine();
                            break;
                        case 12:
                            SS.CharDoubler();
                            Console.WriteLine();
                            break;
                        case 0:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid value entered!");
                }
            } while (selection != 0);
        }

    }
}

