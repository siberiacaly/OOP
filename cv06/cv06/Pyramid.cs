using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Pyramid : Object3D
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Pyramid(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public override double ComputeSurface()
        {
            double widthTriangle = Width * Math.Sqrt(Math.Pow(Length/ 2, 2))+Height*Height;
            double lengthTriangle = Length * Math.Sqrt(Math.Pow(Width / 2, 2) + Height * Height);
            return Length * Width + lengthTriangle + widthTriangle;

        }

        public override double ComputeVolume()
        {
            return (Length * Width * Height) / 3;
        }

        public override void Draw()
        {
            Console.WriteLine("{0} (lenght = {1}, width = {2}, height = {3})", this.GetType().Name, Length, Width, Height);
        }
    }
}
