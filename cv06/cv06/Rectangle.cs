using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Rectangle : Object2D
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        public override double ComputeArea()
        {
            return Length * Width;
        }

        public override void Draw()
        {
            Console.WriteLine("{0} (lenght = {1}, width = {2})", this.GetType().Name, Length, Width);
        }
    }
}
