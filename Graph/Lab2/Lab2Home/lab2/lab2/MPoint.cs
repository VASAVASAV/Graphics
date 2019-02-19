using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    class MPoint
    {
        double[] coor;
        List<MPoint> neighbours;
        public MPoint()
        {
            coor = new double[4];
            coor[3] = 1;
            neighbours = new List<MPoint>();
        }
        public MPoint(double x, double y, double z)
        {
            coor = new double[4];
            coor[0] = x;
            coor[1] = y;
            coor[2] = z;
            coor[3] = 1;
            neighbours = new List<MPoint>();
        }

        public MPoint(double x, double y)
        {
            coor = new double[4];
            coor[0] = x;
            coor[1] = y;
            coor[3] = 1;
            neighbours = new List<MPoint>();
        }

        public MPoint(double[] newCoors)
        {
            coor = new double[4];
            coor[0] = newCoors[0];
            coor[1] = newCoors[1];
            if (newCoors.Length >2)
            {
                coor[2] = newCoors[2];
            }
            if (newCoors.Length == 4)
            {
                coor[3] = newCoors[3];
            }
            else
            {
                coor[3] = 1;
            }
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
            for (int i = 0; i < 4; i++)
            {
                if (p1.coor[i] != p2.coor[i])
                    return false;
            }
            return true;
        }

        public static bool operator !=(MPoint p1, MPoint p2)
        {
            for (int i = 0; i < 4; i++)
            {
                if (p1.coor[i] != p2.coor[i])
                    return true;
            }
            return false;
        }
        public static implicit operator double[] (MPoint SomePoint)
        {
            double[] result = new double[4];
            for (int i = 0; i < 4; i++)
            {
                result[i] = SomePoint.coor[i];
            }
            return result;
        }
    }
}
