using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Circle : Figure
    {
        private double rad;
        public Point Center { get; set; }

        public double Radius
        {
            get => rad;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Enter positive radius, please");
                }
                else
                {
                    rad = value;
                }

            }
        }

        public Circle(double radius, Point center)
        {
            Radius = radius;
            Center = center;
        }

        public virtual double Length => 2 * Math.PI * Radius;

        public override void Show() => Console.WriteLine($"Circle: \nCenter  = ({Center.X},{Center.Y})\nRadius = {Radius}\nLength = {Length}");

        public static Circle ReadCircle()
        {
            Circle circle;
            Point center;
            while (true)
            {
                Console.WriteLine("Enter digit of the x point.");
                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine("Enter digit of the y point.");
                    if (double.TryParse(Console.ReadLine(), out double y))
                    {
                        center = new Point(x,y);
                        Console.WriteLine("Enter radius.");
                        if (double.TryParse(Console.ReadLine(), out double r))
                        {
                            circle = new Circle(r, center);
                            break;
                        }
                    }
                }
            }
            return circle;
        }
    }
}
