using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cv03
{
    public class Matrix
    {
        private double[,] matrixArr;

        public Matrix(double[,] matrixArr)
        {
            this.matrixArr = matrixArr;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            try
            {
                if (a.matrixArr.GetLength(0) == b.matrixArr.GetLength(0) && a.matrixArr.GetLength(1) == b.matrixArr.GetLength(1))
                {
                    Matrix m = new Matrix(new double[a.matrixArr.GetLength(0), a.matrixArr.GetLength(1)]);

                    for (int x = 0; x < a.matrixArr.GetLength(0); x++)
                    {
                        for (int y = 0; y < a.matrixArr.GetLength(1); y++)
                        {
                            m.matrixArr[x, y] = a.matrixArr[x, y] + b.matrixArr[x, y];
                        }
                    }
                    return m;
                }
                else
                {
                    throw new ArgumentException("Matrix are not the same size");
                }
            }
            catch (Exception e) { }
            return null;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            try
            {
                if (a.matrixArr.GetLength(0) == b.matrixArr.GetLength(0) && a.matrixArr.GetLength(1) == b.matrixArr.GetLength(1))
                {
                    Matrix m = new Matrix(new double[a.matrixArr.GetLength(0), a.matrixArr.GetLength(1)]);

                    for (int x = 0; x < a.matrixArr.GetLength(0); x++)
                    {
                        for (int y = 0; y < a.matrixArr.GetLength(1); y++)
                        {
                            m.matrixArr[x, y] = a.matrixArr[x, y] - b.matrixArr[x, y];
                        }
                    }
                    return m;
                }
                else
                {
                    throw new ArgumentException("Matrix are not the same size");
                }
            }
            catch(Exception e)
            {

            }
            return null;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            try
            {
                if (a.matrixArr.GetLength(1) == b.matrixArr.GetLength(0))
                {
                    Matrix m = new Matrix(new double[a.matrixArr.GetLength(0), b.matrixArr.GetLength(1)]);
                    for (int x = 0; x < a.matrixArr.GetLength(0); x++)
                    {
                        for (int y = 0; y < b.matrixArr.GetLength(1); y++)
                        {
                            for (int z = 0; z < b.matrixArr.GetLength(1); z++)
                            {
                                m.matrixArr[x, y] += a.matrixArr[x, z] * b.matrixArr[z, y];
                            }
                        }
                    }
                    return m;
                }
                else
                {
                    throw new ArgumentException("Matrix doesnt have req for multiplication");
                }
            }
            catch (Exception e)
            {

            }
            return null;
        }


        public static Matrix operator -(Matrix a)
        {
            try
            {
                Matrix m = new Matrix(new double[a.matrixArr.GetLength(0), a.matrixArr.GetLength(1)]);

                for (int x = 0; x < a.matrixArr.GetLength(0); x++)
                {
                    for (int y = 0; y < a.matrixArr.GetLength(1); y++)
                    {
                        m.matrixArr[x, y] = (-1) * a.matrixArr[x, y];
                    }
                }
                return m;
            }
            catch (Exception e)
            {

            }
            return null;
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            try
            {
                if (a.matrixArr.GetLength(0) == b.matrixArr.GetLength(0) && a.matrixArr.GetLength(1) == b.matrixArr.GetLength(1))
                {
                    for (int x = 0; x < a.matrixArr.GetLength(0); x++)
                    {
                        for (int y = 0; y < a.matrixArr.GetLength(1); y++)
                        {
                            if (a.matrixArr[x, y] != a.matrixArr[x, y])
                            {
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    return false;

                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;

        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            try
            {
                if (a == b)
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return true;
            }
            return true;

        }

        public double Determinant()
        {
            try
            {
                if (matrixArr.GetLength(0) == matrixArr.GetLength(1))
                {
                    switch (matrixArr.GetLength(0))
                    {
                        case 1:
                            return matrixArr[0, 0];
                        case 2:
                            return matrixArr[0, 0] * matrixArr[1, 1] - matrixArr[0, 1] * matrixArr[1, 0];
                        case 3:
                            double a1 = matrixArr[0, 0] * matrixArr[1, 1] * matrixArr[2, 2] - matrixArr[0, 2] * matrixArr[1, 1] * matrixArr[2, 0];
                            double a2 = matrixArr[1, 0] * matrixArr[2, 1] * matrixArr[0, 2] - matrixArr[1, 2] * matrixArr[2, 1] * matrixArr[0, 0];
                            double a3 = matrixArr[2, 0] * matrixArr[0, 1] * matrixArr[1, 2] - matrixArr[1, 0] * matrixArr[0, 1] * matrixArr[2, 2];
                            return a1 + a2 + a3;
                        default:
                            throw new ArgumentException("Matrix is bigget than 3x3");
                    }
                }
            }
            catch (Exception e)
            {

            }
            return double.NaN;
            }

        public override string ToString()
        {
            String ret = "";
            for (int x = 0; x < matrixArr.GetLength(0); x++)
            {
                for (int y = 0; y < matrixArr.GetLength(1); y++)
                {
                    if (y == 0)
                    {
                        ret = ret + matrixArr[x, y];
                    }
                    else
                    {
                        ret = ret + " " + matrixArr[x, y];
                    }
                }
                ret = ret + "\n";
            }
            return ret;
        }

        public double[,] MatrixArr
        {
            get { return matrixArr; } 
            set { matrixArr = value; }
        }






    }
}