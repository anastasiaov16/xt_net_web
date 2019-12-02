using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
   public class Line : Figure
    {
        public Point A { get; set; } 
        public Point B { get; set; } 

        public Line(Point a, Point b)
        {
            if (a.X == b.X && a.Y == b.Y)
            {
                throw new ArgumentException("A must not equal B!");
            }
            else
            {
                A = a;
                B = b;
            }
        }

        public double Length => Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));

        public override void Show() => Console.WriteLine($"Line: \nA = ({A.X}, {A.Y})\nB = ({B.X}, {B.Y})\nLength = {Length}");

        public static Line ReadLines()
        {
            Line line;
            Point a;
            Point b;
            while (true)
            {
                Console.WriteLine("Enter x of the A point.");
                if (double.TryParse(Console.ReadLine(), out double x1))
                {
                    Console.WriteLine("Enter y of the A point.");
                    if (double.TryParse(Console.ReadLine(), out double y1))
                    {
                        a = new Point(x1,y1);
                        Console.WriteLine("Enter x of the B point.");
                        if (double.TryParse(Console.ReadLine(), out double x2))
                        {
                            Console.WriteLine("Enter y of the B point.");
                            if (double.TryParse(Console.ReadLine(), out double y2))
                            {
                                b = new Point(x2, y2);
                                line = new Line(a, b);
                                break;
                            }
                        }
                    }
                }
            }
            return line;
        }
    }
}
