using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Triangulation
{
    class Edge
    {
        public Edge EdgeBefore;
        public Edge EdgeAfter;
        public MPoint StartP;
        public MPoint EndP;

        public Edge(MPoint One, MPoint Two)
        {
            StartP = One;
            EndP = Two;
        }
        public Edge GetOtherNeigh(Edge Other)
        {
            if(EdgeBefore==Other)
            {
                return EdgeAfter;
            }
            else
            {
                return EdgeBefore;
            }
        }
       /* public static bool operator ==(Edge e1, Edge e2)
        {
            if (((e1.StartP == e2.StartP) && (e1.EndP == e2.EndP)) || ((e1.StartP == e2.EndP) && (e1.EndP == e2.StartP)))
                return true;
            return false;
        }*/

       /* public static bool operator !=(Edge e1, Edge e2)
        {
            if (((e1.StartP == e2.StartP) && (e1.EndP == e2.EndP)) || ((e1.StartP == e2.EndP) && (e1.EndP == e2.StartP)))
                return false;
            return true;
        }*/

        public bool Contains(MPoint p)
        {
            if (StartP == p || EndP == p)
            {
                return true;
            }
            return false;
        }
    }
}
