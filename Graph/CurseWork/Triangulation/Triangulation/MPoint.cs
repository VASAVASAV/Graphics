using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Triangulation
{
    class MPoint
    {
        public double X;
        public double Y;
        public int Number;
        public List<MPoint> neighbours;
        public List<Edge> NeighEdges;
        public MPoint()
        {
            X = 0;
            Y = 0;
            Number = 0;
            neighbours = new List<MPoint>();
        }
        public MPoint(double x, double y)
        {
            X = x;
            Y = y;
            Number = 1;
            neighbours = new List<MPoint>();
        }

        public MPoint(double x, double y, int N)
        {
            X = x;
            Y = y;
            Number = N;
            neighbours = new List<MPoint>();
        }
        void AddNeigh(MPoint newNeighbour)
        {
            if(!neighbours.Contains(newNeighbour))
            {
                neighbours.Add(newNeighbour);
            }
        }

        void DeleteNeigh(MPoint NeighbourToDelete)
        {
            if (neighbours.Contains(NeighbourToDelete))
            {
                neighbours.Remove(NeighbourToDelete);
            }
        }

        bool IsNeigh(MPoint Neighbour)
        {
            if (neighbours.Contains(Neighbour))
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator ==(MPoint p1, MPoint p2)
        {
            if (Math.Abs(p1.X - p2.X) + Math.Abs(p1.Y - p2.Y) > 0.00001)
                return false;
            return true;
        }

        public static bool operator !=(MPoint p1, MPoint p2)
        {
            if (Math.Abs(p1.X - p2.X) + Math.Abs(p1.Y - p2.Y) > 0.00001)
                return true;
            return false;
        }
        public static implicit operator double[] (MPoint SomePoint)
        {
            double[] result = new double[2];
            result[0] = SomePoint.X;
            result[1] = SomePoint.Y;
            return result;
        }

        public bool IsInsideOfCircle(MPoint A, MPoint B, MPoint C)
        {
            if ((A.X * (B.Y - C.Y) + B.X * (C.Y - A.Y) + C.X * (A.Y - B.Y)) == 0)
            {
                return true; ;
            }
            double CenterX = (-0.5) * ((A.Y * (B.X * B.X + B.Y * B.Y - C.X * C.X - C.Y * C.Y) + B.Y * (C.X * C.X + C.Y * C.Y - A.X * A.X - A.Y * A.Y) + C.Y * (A.X * A.X + A.Y * A.Y - B.X * B.X - B.Y * B.Y)) / (A.X * (B.Y - C.Y) + B.X * (C.Y - A.Y) + C.X*(A.Y - B.Y)));
            double CenterY = 0.5 * ((A.X * (B.X * B.X + B.Y * B.Y - C.X * C.X - C.Y * C.Y) + B.X * (C.X * C.X + C.Y * C.Y - A.X * A.X - A.Y * A.Y) + C.X * (A.X * A.X + A.Y * A.Y - B.X * B.X - B.Y * B.Y)) / (A.X * (B.Y - C.Y) + B.X * (C.Y - A.Y) + C.X * (A.Y - B.Y)));
            double Radious = Math.Sqrt(Math.Pow(A.X - CenterX, 2) + Math.Pow(A.Y - CenterY, 2));
            double Distance = Math.Sqrt(Math.Pow(this.X - CenterX, 2) + Math.Pow(this.Y - CenterY, 2));
            return (Distance < Radious-0.0000001);//to ensure that point on the line doesnt count as soemthing inside
        }
    }
}
