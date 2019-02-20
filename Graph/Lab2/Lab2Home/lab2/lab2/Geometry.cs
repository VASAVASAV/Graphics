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
    }
}
