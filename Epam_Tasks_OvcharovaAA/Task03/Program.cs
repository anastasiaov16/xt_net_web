using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public class Program
    {
        static void Main()
        {
            double selection;
            do
            {
                Console.WriteLine("3,1 LOST.");
                Console.WriteLine("3,2 WORD FREQUENCY.");
                Console.WriteLine("3,3 DYNAMIC ARRAY.");
                Console.WriteLine("3,4 DYNAMIC ARRAY (HARDCORE MODE - CYCLED ARRAY).");
                Console.WriteLine();
                if (double.TryParse(Console.ReadLine(), out selection))
                {
                    switch (selection)
                    {
                        case 3.1:
                            Lost.Read();
                            break;
                        case 3.2:
                            var txt = WordFrequency.Read();
                            Dictionary<string, int> result = WordFrequency.WordFrequence(txt);
                            WordFrequency.Show(result);
                            break;
                        case 3.3:

                            DynamicArray<int>.Show();
                            Console.WriteLine();
                            DynamicArrayHardcoreMode<int>.ShowHM();
                            break;
                        case 3.4:
                            var vs = new CycledDynamicArray<int>(new List<int> { 1, 2, 3, 4, 5 }, 5);
                            foreach (var item in vs)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                }
            }
            
            } while (selection != 0);

            
        }
    }
}
