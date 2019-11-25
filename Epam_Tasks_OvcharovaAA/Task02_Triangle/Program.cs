using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            try
            {
                triangle = Triangle.ReadTriangle();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            triangle.Show();
        }
    }
}
