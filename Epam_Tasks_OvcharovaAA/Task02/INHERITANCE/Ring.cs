using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Ring:Round
    {
        private double outRad;

        public Ring():base()
        {
            OutRad = Radius * 2;
        }

        public Ring(double x, double y, double rad, double outRad) : base(x,y,rad)
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


        public new double Square => (Math.PI * (Math.Pow(OutRad, 2)) - (Math.Pow(InRadius, 2)));

        public double Summ => (OuterDiam + InnerDiam);

        public double OuterDiam => (2 * OutRad * Math.PI);
        public double InnerDiam => (2 * Radius * Math.PI);

        public new void Show() => Console.WriteLine($"Square = {Square}, Summ = {Summ}");

        public static Ring ReadRing()
        {
            Ring ring;
            while (true)
            {
                Console.WriteLine("Enter digit of the x point.");
                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine("Enter digit of the y point.");
                    if (double.TryParse(Console.ReadLine(), out double y))
                    {
                        Console.WriteLine("Enter InnerRadius.");
                        if (int.TryParse(Console.ReadLine(), out int ir))
                        {
                            Console.WriteLine("Enter OuterRadius.");
                            if (int.TryParse(Console.ReadLine(), out int or))
                            {
                                ring = new Ring(x, y, ir, or);
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
