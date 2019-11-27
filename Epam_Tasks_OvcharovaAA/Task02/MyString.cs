using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class MyString
    {
        public char[] MyStr { get; set; }

        public MyString()
        {

        }

        public MyString(string str)
        {
            MyStr = str.ToCharArray();
        }

        public MyString(char [] str)
        {
            MyStr = str;
        }

        public static bool Compare(MyString s1, MyString s2)
        {
            return true;
        }

    }

}
