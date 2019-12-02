using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
   public class Field
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Field(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}
