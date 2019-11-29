using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class MyString
    {
        private char[] MyStr{ get; set; }

        public MyString(){}

        public MyString(string str)
        {
            this.MyStr = str.ToCharArray();
        }

        public MyString(char[] str)
        {
            this.MyStr = str;
        }


        public int Length => MyStr.Length;

        public char [] ToChar()
        {
            char[] resultString = new char[Length];
            for(var i = 0; i < Length; i++)
            {
                resultString[i] += MyStr[i];
            }
            return resultString;
        }
            
        public static MyString Concat(MyString s1, MyString s2)
        {
            char[] resultString = new char[s1.Length + s2.Length];
            var ss1 = s1.ToChar();
            var ss2 = s2.ToChar();
            var len = ss1.Length;
            for(var i = 0; i < s1.Length; i++)
            {
                resultString[i] = ss1[i];
            }

            for(var i = 0; i < s2.Length; i++)
            {
                resultString[len + i] = ss2[i];
            }

            return new MyString(resultString);
        }

        public static bool operator == (MyString s1, MyString s2)
        {
            if(s1.Length != s2.Length)
            {
                return false;
            }
            else 
            {
                var str1 = s1.ToChar();
                var str2 = s2.ToChar();
                for(var i = 0; i < s1.Length; i++)
                {
                    if(str1[i] != str2[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator !=(MyString s1, MyString s2)
        {
            if (s1.Length != s2.Length)
            {
                return true;
            }
            else
            {
                var str1 = s1.ToChar();
                var str2 = s2.ToChar();
                for (var i = 0; i < s1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int? IndexOf(char word)
        {
            for(var i = 0; i < MyStr.Length; i++)
            {
                if(MyStr[i] == word)
                {
                    return i;
                }
            }
            return null;
        }

        public static explicit operator MyString(string str) => new MyString(str);

        public static explicit operator string(MyString str) => str.ToString();

        public override string ToString()
        {
            return string.Concat(this.MyStr);
        }

        public MyString Upper()
        {
            char[] resultString = new char[Length];
            for (var i = 0; i < Length; i++)
            {
                resultString[i] = Char.ToUpper(MyStr[i]);
            }
            return new MyString (resultString);
        }

        public MyString Lower()
        {
            char[] resultString = new char[Length];
            for (var i = 0; i < Length; i++)
            {
                resultString[i] = Char.ToLower(MyStr[i]);
            }
            return new MyString(resultString);
        }

        public override bool Equals(object obj)
        {
            var @string = obj as MyString;
            return @string != null &&
                   EqualityComparer<char[]>.Default.Equals(MyStr, @string.MyStr) &&
                   Length == @string.Length &&
                   Length == @string.Length;
        }

        public override int GetHashCode()
        {
            var hashCode = 1759314955;
            hashCode = hashCode * -1521134295 + EqualityComparer<char[]>.Default.GetHashCode(MyStr);
            hashCode = hashCode * -1521134295 + Length.GetHashCode();
            hashCode = hashCode * -1521134295 + Length.GetHashCode();
            return hashCode;
        }
    }

}
