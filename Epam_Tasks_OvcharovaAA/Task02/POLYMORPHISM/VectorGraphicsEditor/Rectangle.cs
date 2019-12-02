using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
   public class Rectangle : Figure
    {
        private double width;
        private double heigth;

        public double Width
        {
            get => width;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width must be > 0");
                }
                else
                    width = value;
            }
        }

        public double Heigth
        {
            get => heigth;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Heigth must be > 0");
                }
                else
                    heigth = value;
            }
        }

        public Rectangle(double width, double heigth)
        {
            Width = width;
            Heigth = heigth;
        }

        public double Perimetr => (Width + Heigth) * 2;

        public double Square => Width * Heigth;

        public override void Show() => Console.WriteLine($"Rectangle: \nWidth = {Width}\nHeigth = {Heigth}\nPerimetr = {Perimetr}\nSquare = {Square}");

        public static Rectangle ReadRectangle()
        {
            Rectangle rect;
            while (true)
            {
                Console.WriteLine("Enter digit of the a side.");
                if (double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("Enter digit of the b side.");
                    if (double.TryParse(Console.ReadLine(), out double b))
                    {
                            rect = new Rectangle(a, b);
                            break;
                    }
                }
            }
            return rect;
        }
    }
}
