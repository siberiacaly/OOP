using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv02
{
    public class JEDEM
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(3, 7);
            Complex c2 = new Complex(-8, 5);
            TestComplex.Test(new Complex(3, 7) + new Complex(-8, 5), new Complex(-5, 12), "test +");
            TestComplex.Test(new Complex(3, 7) - new Complex(-8, 5), new Complex(11, +2), "test -");
            TestComplex.Test(new Complex(3, 7) * new Complex(-8, 5), new Complex(-59, -41), "test *");
            TestComplex.Test(new Complex(3, 7) / new Complex(-8, 5), new Complex(0.12359551, -0.7977528), "test /");
            TestComplex.Test(-new Complex(3, 7), new Complex(-3, -7), "test u-");
            TestComplex.Test(new Complex(3, 7).Conjugate(), new Complex(3, -7), "test conjugate");
         
            //test fail

            TestComplex.Test(new Complex(3, 7).Conjugate(), new Complex(-8, 55), "test conjugate");
            Console.WriteLine("only printing");
            Console.WriteLine("is {0} == {1} : {2}", c, c2, c == c2);
            Console.WriteLine("is {0} != {1} : {2}", c, c2, c != c2);
            Console.WriteLine("modul of {0} is {1}", c2, c2.Modul());
            Console.WriteLine("argument of {0} is {1}", c2, c2.Argument());
            Console.ReadLine();
        }

    }
}
