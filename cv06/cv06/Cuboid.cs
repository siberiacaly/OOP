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
    public class Cuboid : Object3D
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public Cuboid(double length, double height, double width)
        {
            this.Length = length;
            this.Height = height;
            this.Width = width;
        }

        public override double ComputeSurface()
        {
            return 2 * ((Length*Width) + (Width*Height) + (Height*Length));
        }

        public override double ComputeVolume()
        {
            return Length * Width * Height;
        }

        public override void Draw()
        {
            Console.WriteLine("{0} (lenght = {1}, width = {2}, height = {3})", this.GetType().Name, Length, Width, Height);
        }
    }
}
