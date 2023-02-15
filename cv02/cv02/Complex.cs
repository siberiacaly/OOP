using System;
namespace cv02
{
    public class Complex
    {

        public Complex(double real = 0, double imaginary = 0)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary, a.Real * b.Imaginary + a.Imaginary * b.Real);
        }

        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex((a.Real * b.Real + b.Imaginary * a.Imaginary) / (b.Real * b.Real + b.Imaginary * b.Imaginary), (b.Real * a.Imaginary - a.Real * b.Imaginary) / (b.Imaginary * b.Imaginary + b.Real * b.Real));
        }

        public static bool operator ==(Complex a, Complex b)
        {
            return (a.Real == b.Real) && (a.Imaginary == b.Imaginary);
        }

        public static bool operator !=(Complex a, Complex b)
        {
            return !(a.Real == b.Real) && !(a.Imaginary == b.Imaginary);
        }

        public static Complex operator -(Complex a)
        {
            return new Complex(-a.Real, -a.Imaginary);
        }

        public Complex Conjugate ()
        {
            return new Complex (Real, -Imaginary);
        }
        public double Modul ()
        {
            return Math.Sqrt (Real * Real + Imaginary * Imaginary);
        }

        public double Argument ()
        {
            return Math.Atan2 (Real, Imaginary);

        }

        public override string ToString()
        {
            if (Imaginary >= 0)
            {
                return string.Format("{0}+{1}j", Real, Imaginary);
            }
            else
            {
                return string.Format("{0}-{1}j", Real, -Imaginary);
            }

        }

        public double Real
        {
            get;
            set;
        }

        public double Imaginary
        {
            get;
            set;
        }
    }
}