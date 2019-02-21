using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    static class Geometry
    {

        public static bool IsRightFromLine(MPoint start, MPoint end, MPoint P)
        {
            double x = P.coor[0];
            double y = P.coor[1];

            double x1 = start.coor[0];
            double y1 = start.coor[1];

            double x2 = end.coor[0];
            double y2 = end.coor[1];

            double f = (y1 - y2) * x + (x2 - x1) * y + (x1 * y2 - x2 * y1);
            return f < 0;
        }

        public static double GetDotProd(MPoint v1, MPoint v2)
        {
            return v1.coor[ 0] * v2.coor[0] + v1.coor[1] * v2.coor[1] + v1.coor[2] * v2.coor[2];
        }

        public static double GetCosAngle(MPoint v1, MPoint v2)
        {
            double dp = GetDotProd(v1, v2);
            return dp / (v1.GetLength() * v2.GetLength());
        }

        public static double[] CyclycWithoutMinuses(double[] a, double[] c, double[] b, double[] f)
        {
            int N = f.Length + 1;

            Func<double[], double[]> Offset = inputArray =>
            {

                var lst = inputArray.ToList();
                lst.Insert(0, 0);

                return lst.ToArray();

            };

            a = Offset(a);
            c = Offset(c);
            b = Offset(b);
            f = Offset(f);

            double[] alpha = new double[N];
            double[] beta = new double[N];
            double[] gama = new double[N];
            double[] p = new double[N];
            double[] q = new double[N];
            double[] y = new double[N];
            //double[] x = new double[N]; 


            N = N - 1;

            alpha[2] = -b[1] / c[1];
            beta[2] = f[1] / c[1];
            gama[2] = -a[1] / c[1];

            for (int i = 2; i < N; i++)
            {
                double z = -c[i] - a[i] * alpha[i];

                alpha[i + 1] = b[i] / z;
                beta[i + 1] = (-f[i] + a[i] * beta[i]) / z;
                gama[i + 1] = (a[i] * gama[i]) / z;
            }


            p[N - 1] = beta[N];
            q[N - 1] = alpha[N] + gama[N];

            for (int i = N - 2; i >= 1; i--)
            {
                p[i] = alpha[i + 1] * p[i + 1] + beta[i + 1];
                q[i] = alpha[i + 1] * q[i + 1] + gama[i + 1];
            }

            y[N] = (-f[N] + b[N] * p[1] + a[N] * p[N - 1]) / (-c[N] - b[N] * q[1] - a[N] * q[N - 1]);

            for (int i = 1; i < N; i++)
                y[i] = p[i] + y[N] * q[i];



            var lsty = y.ToList();
            lsty.RemoveAt(0);
            y = lsty.ToArray();

            return y;
        }

        public static double Bernstein(int n, int k, double t)
        {
            return ((double)Fact(n) / (Fact(k) * Fact(n - k))) * (Math.Pow(t, k)) * (Math.Pow((1 - t), n - k));
        }

        public static int Fact(int n)
        {
            if (n == 0 || n==1)
                return 1;
            else
            {
                return n * Fact(n - 1);
            }

        }
    }
}
