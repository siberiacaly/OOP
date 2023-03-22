using System.Linq;
using System;



namespace cv07



{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 1, 5, 7, 9 };
            string[] strings = new string[] { "a", "b", "c" };
            Circle[] circles = new Circle[] { new Circle(2), new Circle(3), new Circle(4) };
            Rectangle[] rectangles = new Rectangle[] { new Rectangle(2, 3), new Rectangle(3, 4), new Rectangle(4, 5) };
            Ellipse[] ellipses = new Ellipse[] { new Ellipse(2, 3), new Ellipse(3, 4) };
            Object2D[] objectfield = new Object2D[] { new Circle(2), new Square(3), new Rectangle(2, 4) };


            Console.WriteLine("Largest int: " + Extremes.Largest(numbers));
            Console.WriteLine("Smallest int: " + Extremes.Smallest(numbers));
            Console.WriteLine("Largest circle: " + Extremes.Largest(circles));
            Console.WriteLine("Smallest circle: " + Extremes.Smallest(circles));
            Console.WriteLine("Largest string: " + Extremes.Largest(strings));
            Console.WriteLine("Smallest string: " + Extremes.Smallest(strings));
            Console.WriteLine("Largest rectangle: " + Extremes.Largest(rectangles));
            Console.WriteLine("Smallest rectangle: " + Extremes.Smallest(rectangles));
            Console.WriteLine("Largest ellipse: " + Extremes.Largest(ellipses));
            Console.WriteLine("Smallest ellipse: " + Extremes.Smallest(ellipses));
            Console.WriteLine("Smallest object: " + Extremes.Largest(objectfield));
            Console.WriteLine("Largest object: " + Extremes.Smallest(objectfield));


            var fourtoeight = numbers.Where(v => v > 4 && v < 8);
            Console.WriteLine("Filtered: ");
            foreach (int number in fourtoeight)
            {
                Console.Write(number + "");
            }
            Console.WriteLine("");
        }
    }
}