using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main()
        {
            double selection;
            do
            {
                Console.WriteLine("4,1 CUSTOM SORT.");
                Console.WriteLine("4,2 CUSTOM SORT DEMO.");
                Console.WriteLine("4,3 SORTING UNIT.");
                Console.WriteLine("4,4 NUMBER ARRAY SUM.");
                Console.WriteLine("4,5 TO INT OR NOT TO INT?");
                Console.WriteLine("4,6 I SEEK YOU.");
                Console.WriteLine("0 Exit.");
                Console.WriteLine();
                if (double.TryParse(Console.ReadLine(), out selection))
                {
                    switch (selection)
                    {
                        case 4.1:
                            CustomSort.ShowFirstTask();
                            break;
                        case 4.2:
                            CustomSort.ShowSecondTask();
                            break;
                        case 4.3:
                            SortingUnit.Show();
                            break;
                        case 4.4:
                            NumberArraySum.ShowFourthTask();
                            break;
                        case 4.5:
                            NumberArraySum.ShowFifthTask();
                            break;
                        case 4.6:
                            //processing...
                            break;
                        case 0:
                            break;

                    }
                }
            } while (selection != 0);
        }
    }
}
