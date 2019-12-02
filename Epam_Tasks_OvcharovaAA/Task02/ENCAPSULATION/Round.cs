using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
   public  class Round
    {
        private double radius;
        public double X { get; set; }
        public double Y { get; set; }

        public double Radius
        {
            get => radius;

            set
            {
                if(value < 0)
                {

                    throw new ArgumentException("Enter positive number, please"); 
                }

                else
                {
                    radius = value;
                }
            }
        }

        public Round()
        {
            X = 0;
            Y = 0;
            Radius = 1;
        }

        public Round(double rad, double x, double y)
        {
            Radius = rad;
            X = x;
            Y = y;
        }

        public double Square => Math.PI * Radius * Radius;

        public double Length => 2 * Math.PI * Radius;

        public void Show() => Console.WriteLine($"Radius = {Radius}, X = {X}, Y = {Y}, Square = {Square}, Lenght = {Length}");
        public static Round ReadRound()
        {
            Round round;
            while (true)
            {
                Console.WriteLine("Enter digit of the x point.");
                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine("Enter digit of the y point.");
                    if (double.TryParse(Console.ReadLine(), out double y))
                    {
                        Console.WriteLine("Enter radius.");
                        if (double.TryParse(Console.ReadLine(), out double r))
                        {
                            round = new Round(r, x, y);
                            break;
                        }
                    }
                }
            }
            return round;
        }
    }

}
