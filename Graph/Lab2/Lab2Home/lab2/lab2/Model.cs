using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Model
    {
        public Controler Cont3d;
        public MPoint Center = new MPoint(300, -200, 500);
        public MPoint CenterVec = new MPoint(-300, 200, -500);

        public bool Axon = false;
        public bool Persp = false;
        public bool Kava = false;
        public double[] AxPar = new double[3];
        public double[] PerPar = new double[3];
        public double[] KavPar = new double[3];
        
        public List<Figure> Lines = new List<Figure>();
        public List<Figure> Figs = new List<Figure>();
        public List<Figure> Planes = new List<Figure>();

        public Model()
        {
            List<MPoint> ML = new List<MPoint>();
            ML.Add(new MPoint(0, 0, 0));
            ML.Add(new MPoint(100, 0, 0));
            ML.Add(new MPoint(100, 100, 0));
            ML.Add(new MPoint(0, 100, 0));
            ML.Add(new MPoint(0, 0, 0));
            ML.Add(new MPoint(0, 0, 100));
            ML.Add(new MPoint(0, 0, 100));
            ML.Add(new MPoint(100, 0, 100));
            ML.Add(new MPoint(100, 100, 100));
            ML.Add(new MPoint(0, 100, 100));
            ML.Add(new MPoint(0, 0, 100));
            ML.Add(new MPoint(0, 100, 100));
            ML.Add(new MPoint(0, 100, 0 ));
            ML.Add(new MPoint(0, 100, 100));
            ML.Add(new MPoint(100, 100, 100));
            ML.Add(new MPoint(100, 100, 0));
            ML.Add(new MPoint(100, 100, 100));
            ML.Add(new MPoint(100, 0, 100));
            ML.Add(new MPoint(100, 0, 0));
            ML.Add(new MPoint(100, 0, 100));
            //ML.Add(new MPoint(25, 75, 25));
            Lines.Add(new Figure(ML));
        }

        public void Move(double x, double y, double z)
        {
            int i, j, k;
            for (i = 0; i < Lines.Count; i++)
            {
                for (j = 0; j < Lines[i].cells.Count; j++)
                {
                    Lines[i].cells[j].coor[0] = Lines[i].cells[j].coor[0] + x;
                    Lines[i].cells[j].coor[1] = Lines[i].cells[j].coor[1] + y;
                    Lines[i].cells[j].coor[2] = Lines[i].cells[j].coor[2] + z;
                }
            }
            for (i = 0; i < Figs.Count; i++)
            {
                for (j = 0; j < Figs[i].cells.Count; j++)
                {
                    Figs[i].cells[j].coor[0] = Figs[i].cells[j].coor[0] + x;
                    Figs[i].cells[j].coor[1] = Figs[i].cells[j].coor[1] + y;
                    Figs[i].cells[j].coor[2] = Figs[i].cells[j].coor[2] + z;
                }
            }
            for (i = 0; i < Planes.Count; i++)
            {
                for (j = 0; j < Planes[i].cells.Count; j++)
                {
                    Planes[i].cells[j].coor[0] = Planes[i].cells[j].coor[0] + x;
                    Planes[i].cells[j].coor[1] = Planes[i].cells[j].coor[1] + y;
                    Planes[i].cells[j].coor[2] = Planes[i].cells[j].coor[2] + z;
                }
            }
        }

        public void Turn(double fxy, double fyz, double fxz)
        {
            int i, j, k;
            double[,] temp;
            double[,] E = new double[4, 4];
            E[0, 0] = 1;
            E[1, 1] = 1;
            E[2, 2] = 1;
            E[3, 3] = 1;
            double[,] op = new double[4, 4];
            for (i = 0; i < Lines.Count; i++)
            {
                temp = new double[Lines[i].cells.Count, 4];
                for (j = 0; j < Lines[i].cells.Count; j++)
                {
                    temp[j, 0] = Lines[i].cells[j].coor[0];
                    temp[j, 1] = Lines[i].cells[j].coor[1];
                    temp[j, 2] = Lines[i].cells[j].coor[2];
                    temp[j, 3] = Lines[i].cells[j].coor[3];
                }
                op = new double[4, 4];
                op[0, 0] = 1;
                op[3, 3] = 1;
                op[1, 1] = Math.Cos(fyz);
                op[1, 2] = Math.Sin(fyz);
                op[2, 1] = -Math.Sin(fyz);
                op[2, 2] = Math.Cos(fyz);
                temp = Matrixes.Multiply(temp, op);
                op = new double[4, 4];
                op[1, 1] = 1;
                op[3, 3] = 1;
                op[0, 0] = Math.Cos(fxz);
                op[0, 2] = -Math.Sin(fxz);
                op[2, 0] = Math.Sin(fxz);
                op[2, 2] = Math.Cos(fxz);
                temp = Matrixes.Multiply(temp, op);
                op = new double[4, 4];
                op[2, 2] = 1;
                op[3, 3] = 1;
                op[0, 0] = Math.Cos(fxy);
                op[0, 1] = Math.Sin(fxy);
                op[1, 0] = -Math.Sin(fxy);
                op[1, 1] = Math.Cos(fxy);
                temp = Matrixes.Multiply(temp, op);
                for (j = 0; j < Lines[i].cells.Count; j++)
                {
                    Lines[i].cells[j].coor[0] = temp[j, 0];
                    Lines[i].cells[j].coor[1] = temp[j, 1];
                    Lines[i].cells[j].coor[2] = temp[j, 2];
                    Lines[i].cells[j].coor[3] = temp[j, 3];
                }
            }
            for (i = 0; i < Figs.Count; i++)
            {
                temp = new double[Figs[i].cells.Count, 4];
                for (j = 0; j < Figs[i].cells.Count; j++)
                {
                    temp[j, 0] = Figs[i].cells[j].coor[0];
                    temp[j, 1] = Figs[i].cells[j].coor[1];
                    temp[j, 2] = Figs[i].cells[j].coor[2];
                    temp[j, 3] = Figs[i].cells[j].coor[2];
                }
                op = new double[4, 4];
                op[0, 0] = 1;
                op[3, 3] = 1;
                op[1, 1] = Math.Cos(fyz);
                op[1, 2] = Math.Sin(fyz);
                op[2, 1] = -Math.Sin(fyz);
                op[2, 2] = Math.Cos(fyz);
                temp = Matrixes.Multiply(temp, op);
                op = new double[4, 4];
                op[1, 1] = 1;
                op[3, 3] = 1;
                op[0, 0] = Math.Cos(fxz);
                op[0, 2] = -Math.Sin(fxz);
                op[2, 0] = Math.Sin(fxz);
                op[2, 2] = Math.Cos(fxz);
                temp = Matrixes.Multiply(temp, op);
                op = new double[4, 4];
                op[2, 2] = 1;
                op[3, 3] = 1;
                op[0, 0] = Math.Cos(fxy);
                op[0, 1] = Math.Sin(fxy);
                op[1, 0] = -Math.Sin(fxy);
                op[1, 1] = Math.Cos(fxy);
                temp = Matrixes.Multiply(temp, op);
                for (j = 0; j < Figs[i].cells.Count; j++)
                {
                    Figs[i].cells[j].coor[0] = temp[j, 0];
                    Figs[i].cells[j].coor[1] = temp[j, 1];
                    Figs[i].cells[j].coor[2] = temp[j, 2];
                    Figs[i].cells[j].coor[2] = temp[j, 3];
                }
            }
            for (i = 0; i < Planes.Count; i++)
            {
                temp = new double[Planes[i].cells.Count, 4];
                for (j = 0; j < Planes[i].cells.Count; j++)
                {
                    temp[j, 0] = Planes[i].cells[j].coor[0];
                    temp[j, 1] = Planes[i].cells[j].coor[1];
                    temp[j, 2] = Planes[i].cells[j].coor[2];
                    temp[j, 3] = Planes[i].cells[j].coor[2];
                }
                op = new double[4, 4];
                op[0, 0] = 1;
                op[3, 3] = 1;
                op[1, 1] = Math.Cos(fyz);
                op[1, 2] = Math.Sin(fyz);
                op[2, 1] = -Math.Sin(fyz);
                op[2, 2] = Math.Cos(fyz);
                temp = Matrixes.Multiply(temp, op);
                op = new double[4, 4];
                op[1, 1] = 1;
                op[3, 3] = 1;
                op[0, 0] = Math.Cos(fxz);
                op[0, 2] = -Math.Sin(fxz);
                op[2, 0] = Math.Sin(fxz);
                op[2, 2] = Math.Cos(fxz);
                temp = Matrixes.Multiply(temp, op);
                op = new double[4, 4];
                op[2, 2] = 1;
                op[3, 3] = 1;
                op[0, 0] = Math.Cos(fxy);
                op[0, 1] = Math.Sin(fxy);
                op[1, 0] = -Math.Sin(fxy);
                op[1, 1] = Math.Cos(fxy);
                temp = Matrixes.Multiply(temp, op);
                for (j = 0; j < Planes[i].cells.Count; j++)
                {
                    Planes[i].cells[j].coor[0] = temp[j, 0];
                    Planes[i].cells[j].coor[1] = temp[j, 1];
                    Planes[i].cells[j].coor[2] = temp[j, 2];
                    Planes[i].cells[j].coor[2] = temp[j, 3];
                }
            }
        }
    }
}
