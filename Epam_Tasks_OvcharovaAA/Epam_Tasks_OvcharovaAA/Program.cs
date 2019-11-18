using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Tasks_OvcharovaAA
{
    public class Program
    {
        static void Main()
        {
            Functions f = new Functions();
            Console.WriteLine("Select task: \n 0.1 SEQUENCE \n 0.2 SIMPLE \n 0.3 SQUARE \n 0.4 ARRAY");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "0.1":
                    Console.Write("Enter a positive number: ");
                    int N = int.Parse(Console.ReadLine());
                    Console.WriteLine(f.Sequence(N));
                    break;
                case "0.2":
                    Console.Write("Enter a number to check for simplicity ");
                    int N1 = int.Parse(Console.ReadLine());
                    if (f.Simple(N1))
                    {
                        Console.WriteLine("This number is prime!");
                    }
                    else Console.WriteLine("This number isn't prime!");
                    break;
                case "0.3":
                    Console.Write("Enter positive odd number: ");
                    int N2 = int.Parse(Console.ReadLine());
                    f.Square(N2);
                    break;
                case "0.4":
                    Console.Write("Enter array demension, please: ");
                    int N3 = int.Parse(Console.ReadLine());
                    var array = f.CreateArray(N3);

                    Console.WriteLine("Default array:");
                    f.Print(array);
                    f.SortArray(array);
                    Console.WriteLine("Sorted array:");
                    f.Print(array);
                    break;
            }
        }

    }

}