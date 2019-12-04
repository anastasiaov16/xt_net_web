using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public class Lost
    {
        public static void Read()
        {
            List<int> tmp = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter N.");
                if (int.TryParse(Console.ReadLine(), out int N))
                {
                    tmp = CreateList(N);                    
                    break;
                }
            }
            foreach(var item in tmp)
            {
                Console.Write("{0}, ",item);
            }
            Console.WriteLine();
            GetLost(tmp);
            Console.WriteLine(tmp[0]);
        }

        public static List<int> CreateList(int N)
        {
            List<int> lst = new List<int>();
            for (int i = 0; i < N; i++)
            {
                lst.Add(i + 1);
            }
            return lst;
        }

        public static List<int> GetLost(List<int> tmp)
        {
            int i = 1;
            while(tmp.Count > 1)
            {
                i = i % tmp.Count;
                tmp.RemoveAt(i);
                i++;
            }
            return tmp;
        }
    }
}
