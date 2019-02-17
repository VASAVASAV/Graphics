using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Triangulation
{
    static class Geometry
    {
        public static bool IsRightFromLine(Edge Vector, MPoint P)
        {
            double x = P.X;
            double y = P.Y;

            double x1 = Vector.StartP.X;
            double y1 = Vector.StartP.Y;

            double x2 = Vector.EndP.X;
            double y2 = Vector.EndP.Y;

            double f = (y1 - y2) * x + (x2 - x1) * y + (x1 * y2 - x2 * y1);
            return f < 0;
        }

    }
}
