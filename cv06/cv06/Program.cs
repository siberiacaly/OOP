using System;

namespace cv06
{
    namespace cv06
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                GroupOfObjects[] objects = new GroupOfObjects[]
                {
                new Sphere(2),
                new Cuboid(2,3,4),
                new Cylinder(2,5),
                new Circle(2),
                new Ellipse(2,3),
                new Pyramid(2,3,5),
                new Rectangle(2,4),
                new Triangle(3,2,2),
                };

                double totalArea = 0;
                double totalSurface = 0;
                double totalVolume = 0;

                foreach (var item in objects)
                {
                    double area = 0;
                    double surface = 0;
                    double volume = 0;
                    item.Draw();

                    if (item is Object2D)
                    {
                        area = ((Object2D)item).ComputeArea();
                        Console.WriteLine("Area = {0}", area);
                        Console.WriteLine("");
                        totalArea += area;
                    }
                    else if (item is Object3D)
                    {
                        surface = ((Object3D)item).ComputeSurface();
                        volume = ((Object3D)item).ComputeVolume();
                        Console.WriteLine("Surface = {0}, Volume = {1}", surface, volume);
                        Console.WriteLine("");
                        totalSurface += surface;
                        totalVolume += volume;
                    }
                }
                Console.WriteLine("Total area of 2D objects is {0:F4}.\nTotal volume of 3D objects is {1:F2}.\n" +
                "Total volume of 3D objects is {2:F2}.", totalArea, totalSurface, totalVolume);
                Console.ReadLine();
            }
        }
    }
}