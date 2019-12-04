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
            //Lost.Read();
            var txt = WordFrequency.Read();
            Dictionary<string, int> result = WordFrequency.WordFrequence(txt);
            WordFrequency.Show(result);

        }
    }
}
