using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class PRing : Circle
    {
        private double outRad;

        public double OutRad
        {
            get => outRad;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius must me > 0!");
                }
                else
                {
                    outRad = value;
                }
            }
        }

        public double InRadius
        {
            get => base.Radius;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius must me > 0!");
                }
                else base.Radius = value;
            }
        }
        public PRing(double rad, double outRad, Point center) : base(rad, center)
        {
            if (outRad < rad)
            {
                throw new ArgumentException("OutRadius must be > InnerRadius!");
            }
            else
            {
                OutRad = outRad;
            }
        }

        public double Square => (Math.PI * (Math.Pow(OutRad, 2)) - (Math.Pow(InRadius, 2)));

        public override void Show() => Console.WriteLine($"Ring:\nCenter  = ({Center.X},{Center.Y})\nInnerRadius = {Radius}\nOuterRadius = {OutRad}\nSquare = {Square}");

        public static PRing ReadRing()
        {
            PRing ring;
            Point center;
            while (true)
            {
                Console.WriteLine("Enter digit of the x point.");
                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine("Enter digit of the y point.");
                    if (double.TryParse(Console.ReadLine(), out double y))
                    {
                        center = new Point(x, y);
                        Console.WriteLine("Enter InnerRadius.");
                        if (int.TryParse(Console.ReadLine(), out int ir))
                        {
                            Console.WriteLine("Enter OuterRadius.");
                            if (int.TryParse(Console.ReadLine(), out int or))
                            {
                                ring = new PRing (ir, or, center);
                                break;
                            }
                        }
                    }
                }
            }
            return ring;
        }
    }
}
