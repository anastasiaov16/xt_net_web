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
            GetLost(tmp);
            Console.WriteLine(tmp[0]);
        }

        public static List<int> CreateList(int N)
        {
            List<int> lst = new List<int>();
            for (int i = 0; i < N; i++)
            {
                lst.Add(i);
            }
            return lst;
        }

        public static List<int> GetLost(List<int> tmp)
        {
            int i = 1;
            foreach (var item in tmp)
            {
                i = i % tmp.Count;
                tmp.Remove(i);
                i++;
            }
            return tmp;
        }
    }
}
