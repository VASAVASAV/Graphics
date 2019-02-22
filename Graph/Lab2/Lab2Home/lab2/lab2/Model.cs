using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Model
    {
        public Controler Cont3d;
        public MPoint Center = new MPoint(300, 300, 300);
        public MPoint CenterZVec = new MPoint(-300, -300, -300);
        public MPoint CenterYVec = new MPoint(-50, -50, 100);
        public MPoint CenterXVec = new MPoint(-300,300,0);

        public bool Axon = false;
        public bool Persp = false;
        public bool Kava = false;
        public double[] AxPar = new double[3];
        public double[] PerPar = new double[3];
        public double[] KavPar = new double[3];
        
        public List<Figure> Lines = new List<Figure>();
        public List<Figure> Figs = new List<Figure>();
        public List<Figure> Planes = new List<Figure>();

        public List<List<List<int>>> FigsSides = new List<List<List<int>>>();

        public List<String> LineTypes = new List<string>();
        public List<String> PlaneTypes = new List<string>();
        public List<int> PlanesAddINfo = new List<int>();

        public Model()
        {
            List<MPoint> ML = new List<MPoint>();
            /*
            ML.Add(new MPoint(50, 50, 0));
            ML.Add(new MPoint(25, -25, 0));
            ML.Add(new MPoint(-50, -50, 0));
            ML.Add(new MPoint(-25, 25, 0));
            ML.Add(new MPoint(50, 50, 200));
            ML.Add(new MPoint(25, -25, 200));
            ML.Add(new MPoint(-50, -50, 200));
            ML.Add(new MPoint(-25, 25, 200));
            Figs.Add(new Figure(ML));
            List<List<int>> Sides = new List<List<int>>();
            List<int> Side = new List<int>();
            Side.Add(0);
            Side.Add(1);
            Side.Add(2);
            Side.Add(3);
            Sides.Add(Side);

          Side = new List<int>();
          Side.Add(0);
          Side.Add(4);
          Side.Add(5);
          Side.Add(1);
          Sides.Add(Side);
          
          Side = new List<int>();
          Side.Add(0);
          Side.Add(3);
          Side.Add(7);
          Side.Add(4);
          Sides.Add(Side);
          
          Side = new List<int>();
          Side.Add(7);
          Side.Add(3);
          Side.Add(2);
          Side.Add(6);
          Sides.Add(Side);
          
          Side = new List<int>();
          Side.Add(6);
          Side.Add(2);
          Side.Add(1);
          Side.Add(5);
          Sides.Add(Side);
          
          Side = new List<int>();
          Side.Add(7);
          Side.Add(6);
          Side.Add(5);
          Side.Add(4);
          Sides.Add(Side);
          FigsSides.Add(Sides);
             //*/

            /*
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
              ML.Add(new MPoint(25, 75, 25));
            //*/

            //Lines.Add(new Figure(ML));
          //LineTypes.Add("broken");
        }

        public void ChangeCenter(bool Xneed, bool Yneed, bool Zneed, double x, double y, double z)
        {
            if (Xneed)
            {
                Center.coor[0] = x;
            }
            if (Yneed)
            {
                Center.coor[1] = y;
            }
            if (Zneed)
            {
                Center.coor[2] = z;
            }
        }

        public void TurnCamera(double zxAngle, double zyAngle, double xyAngle)
        {
            double[,] vecz = new double[1, 4];
            double[,] vecy = new double[1, 4];
            double[,] vecx = new double[1, 4];
            double[,] op = new double[4, 4];

            vecz[0, 0] = CenterZVec.coor[0];
            vecz[0, 1] = CenterZVec.coor[1];
            vecz[0, 2] = CenterZVec.coor[2];
            vecz[0, 3] = CenterZVec.coor[3];

            vecy[0, 0] = CenterYVec.coor[0];
            vecy[0, 1] = CenterYVec.coor[1];
            vecy[0, 2] = CenterYVec.coor[2];
            vecy[0, 3] = CenterYVec.coor[3];

            vecx[0, 0] = CenterXVec.coor[0];
            vecx[0, 1] = CenterXVec.coor[1];
            vecx[0, 2] = CenterXVec.coor[2];
            vecx[0, 3] = CenterXVec.coor[3];
           // Console.WriteLine(vecx[0, 0]* vecy[0, 0]+ vecx[0, 1]* vecy[0, 1] + vecx[0, 2]* vecy[0, 2]);
           // Console.WriteLine(vecz[0, 0] * vecy[0, 0] + vecz[0, 1] * vecy[0, 1] + vecz[0, 2] * vecy[0, 2]);
           // Console.WriteLine(vecx[0, 0] * vecz[0, 0] + vecx[0, 1] * vecz[0, 1] + vecx[0, 2] * vecz[0, 2]);
           // Console.WriteLine();
            if (zxAngle != 0)
            {
                op[3, 3] = 1;
                op[1, 1] = 1;
                op[0, 0] = Math.Cos(zxAngle);
                op[2, 2] = Math.Cos(zxAngle);
                op[0, 2] = -1 * Math.Sin(zxAngle);
                op[2, 0] = Math.Sin(zxAngle);
                vecx = Matrixes.Multiply(vecx, op);
                vecy = Matrixes.Multiply(vecy, op);
                vecz = Matrixes.Multiply(vecz, op);

            }
            if (zyAngle != 0)
            {
                op[3, 3] = 1;
                op[0, 0] = 1;
                op[1, 1] = Math.Cos(zyAngle);
                op[2, 2] = Math.Cos(zyAngle);
                op[1, 2] = -1 * Math.Sin(zyAngle);
                op[2, 1] = Math.Sin(zyAngle);
                vecx = Matrixes.Multiply(vecx, op);
                vecy = Matrixes.Multiply(vecy, op);
                vecz = Matrixes.Multiply(vecz, op);

            }
            if (xyAngle != 0)
            {
                op[3, 3] = 1;
                op[2, 2] = 1;
                op[1, 1] = Math.Cos(xyAngle);
                op[0, 0] = Math.Cos(xyAngle);
                op[1, 0] = -1 * Math.Sin(xyAngle);
                op[0, 1] = Math.Sin(xyAngle);
                vecy = Matrixes.Multiply(vecy, op);
                vecx = Matrixes.Multiply(vecx, op);
                vecz = Matrixes.Multiply(vecz, op);

            }
            //Console.WriteLine(vecx[0, 0] * vecy[0, 0] + vecx[0, 1] * vecy[0, 1] + vecx[0, 2] * vecy[0, 2]);
            //Console.WriteLine(vecz[0, 0] * vecy[0, 0] + vecz[0, 1] * vecy[0, 1] + vecz[0, 2] * vecy[0, 2]);
            //Console.WriteLine(vecx[0, 0] * vecz[0, 0] + vecx[0, 1] * vecz[0, 1] + vecx[0, 2] * vecz[0, 2]);
            //Console.WriteLine();
            CenterZVec.coor[0]=vecz[0, 0];
            CenterZVec.coor[1]=vecz[0, 1];
            CenterZVec.coor[2]=vecz[0, 2];
            CenterZVec.coor[3]=vecz[0, 3];
           
            CenterYVec.coor[0]=vecy[0, 0];
            CenterYVec.coor[1]=vecy[0, 1];
            CenterYVec.coor[2]=vecy[0, 2];
            CenterYVec.coor[3]=vecy[0, 3];
           
            CenterXVec.coor[0]=vecx[0, 0];
            CenterXVec.coor[1]=vecx[0, 1];
            CenterXVec.coor[2]=vecx[0, 2];
            CenterXVec.coor[3]=vecx[0, 3];
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
                    Figs[i].cells[j].coor[3] = temp[j, 3];
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

        public void Stretch(double x, double y, double z)
        {
            int i, j, k;
            for (i = 0; i < Lines.Count; i++)
            {
                for (j = 0; j < Lines[i].cells.Count; j++)
                {
                    Lines[i].cells[j].coor[0] *=x;
                    Lines[i].cells[j].coor[1] *=y;
                    Lines[i].cells[j].coor[2] *=z;
                }
            }
            for (i = 0; i < Figs.Count; i++)
            {
                for (j = 0; j < Figs[i].cells.Count; j++)
                {
                    Figs[i].cells[j].coor[0]*=x;
                    Figs[i].cells[j].coor[1]*=y;
                    Figs[i].cells[j].coor[2]*=z;
                }
            }
            for (i = 0; i < Planes.Count; i++)
            {
                for (j = 0; j < Planes[i].cells.Count; j++)
                {
                    Planes[i].cells[j].coor[0] *= x;
                    Planes[i].cells[j].coor[1] *= y;
                    Planes[i].cells[j].coor[2] *= z;
                }
            }
        }
    }
}
