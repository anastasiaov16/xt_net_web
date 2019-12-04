using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task03
{
    public class WordFrequency
    {
        public static string Read()
        {
            string txt = "";
            using (StreamReader filestream = new StreamReader("input.txt"))
            {
               txt = filestream.ReadToEnd();
            }
            return txt;
        }

        public static Dictionary<string, int> WordFrequence(string txt)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            var txtForSearching = txt.ToLower().Split(' ', '.');
            foreach (var item in txtForSearching)
            {
                if (!result.ContainsKey(item.ToString()))
                {
                    result.Add(item.ToString(), 1);
                }
                else
                {
                    result[item.ToString()]++;
                }
            }
            result.OrderBy(pair => pair.Value);
            return result;
        }

        public static void Show(Dictionary<string, int> result)
        {
            foreach(var item in result)
            {
                Console.WriteLine("{0} ---> {1}", item.Key, item.Value);
            }
        }
    }
}
