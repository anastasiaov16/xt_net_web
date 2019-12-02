using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class PRound : Circle
    {
        public PRound(double radius, Point center) : base(radius, center) { }

        public double Square => Math.PI * Radius * Radius;

        public override void Show() => Console.WriteLine($"Round:\nCenter  = ({Center.X},{Center.Y})\nRadius = {Radius}\nSquare = {Square}");

        public static PRound ReadRound()
        {
            PRound round;
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
                            round = new PRound(r, center);
                            break;
                        }
                    }
                }
            }
            return round;
        }

    }
}
