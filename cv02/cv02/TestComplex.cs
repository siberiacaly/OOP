using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv02
{
    public class TestComplex
    {
        public const double Epsilon = 0.000001;
        public static void Test(Complex actual, Complex expected, string name)
        {
            double differenceReal = Math.Abs(actual.Real) - Math.Abs(expected.Real);
            double diffrenceImaginary = Math.Abs(actual.Imaginary) - Math.Abs(expected.Imaginary);
            if (differenceReal <= Epsilon && differenceReal >= -Epsilon && diffrenceImaginary <= Epsilon && diffrenceImaginary >= -Epsilon)
            {
                Console.WriteLine("Test {0}: fine", name);
            }
            else
            {
                Console.WriteLine("Test {0}: not ok", name);
                Console.WriteLine("Expected number: {0}", expected);
                Console.WriteLine("Real number: {0}", actual);
            }
        }
    }
}