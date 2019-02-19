using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Model
    {
        public Controler Cont3d;
        public MPoint Center = new MPoint(500, 500, 500);
        public MPoint CenterVec = new MPoint(-500, -500, -500);

        public bool Axon = false;
        public bool Persp = false;
        public bool Kava = false;
        public double[] AxPar = new double[3];
        public double[] PerPar = new double[3];
        public double[] KavPar = new double[3];
        
        public List<Figure> Lines = new List<Figure>();
        public List<Figure> Figs = new List<Figure>();
        public List<Figure> Planes = new List<Figure>();

        void Move(int x, int y, int z)
        {

        }

        void Turn(int x, int y, int z)
        {

        }
    }
}
