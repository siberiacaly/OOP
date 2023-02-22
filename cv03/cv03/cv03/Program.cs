using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv03
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[,] { { 5, 4 }, { 2, 3 } };
            double[,] b = new double[,] { { 5, 4 }, { 2, 3 } };
            double[,] c = new double[,] { { 5, 4, 2 }, { 2, 3, 1 }, { 0, 5, 4 } };
            double[,] d = new double[,] { { 5 } };
            double[,] e = new double[,] { { 5, 4 }, { 2, 3 }, { 7, 1 } };
            double[,] f = new double[,] { { 5, 4, 2, 8 }, { 2, 3, 1, 2 }, { 8, 4, 2, 3 }, { 6, 4, 2, 0 } };


            Matrix m1 = new Matrix(a);
            Matrix m2 = new Matrix(b);
            Matrix m3 = new Matrix(c);
            Matrix m4 = new Matrix(d);

            Console.WriteLine(m1 + m2);
            Console.WriteLine(m1 - m2);
            Console.WriteLine(m1 * m2);
            Console.WriteLine(-m2);
            Console.WriteLine(m1 == m2);
            Console.WriteLine(m1 != m2);
            Console.WriteLine(m1.Determinant());
            Console.WriteLine(m4.Determinant());
            Console.WriteLine(m3.Determinant());
            Console.ReadLine();
            }
        }
    }