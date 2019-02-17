using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Triangulation
{
    class Edge
    {
        public Edge LeftT;
        public Edge RightT;
        public MPoint StartP;
        public MPoint EndP;

        public Edge(MPoint One, MPoint Two)
        {
            StartP = One;
            EndP = Two;
        }
    }
}
