using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using MathParserNet;

namespace Lab2
{
     class Controler
    {
        private MainForm View;
        private Model MModel;
        public bool Persp = false;
        public double[] PerspPar;
        public bool Cosc = false;
        public double[] CoscPar;
        public bool Roberts = false;
        //private bool

        public Controler(Model ModelForUse, MainForm OurView)
        {
            MModel = ModelForUse;
            View = OurView;
            MModel.Cont3d = this;
            View.MyCont = this;
            DrawAll();
        }

        public void Move(double x, double y, double z)
        {
            MModel.Move(x,y,z);
            DrawAll();
        }

        public void Turn(double fxy, double fyz, double fxz)
        {
            MModel.Turn((fxy * Math.PI) / 180, (fyz * Math.PI) / 180, (fxz *Math.PI) / 180);
            DrawAll();
        }

        public void Stretch(double x, double y, double z)
        {
            MModel.Stretch(x, y, z);
            DrawAll();
        }

        public void ChangeCenter(bool Xneed, bool Yneed, bool Zneed, double x, double y, double z)
        {
            MModel.ChangeCenter(Xneed, Yneed, Zneed, x, y, z);
            DrawAll();
        }

        public void TurnCamera(double zxAngle, double zyAngle,double xyAngle)
        {
            MModel.TurnCamera((zxAngle * Math.PI) / 180, (zyAngle * Math.PI) / 180, (xyAngle * Math.PI) / 180);
            DrawAll();
        }

         public void AddLine(List<MPoint> NewLine, string type)
         {
             MModel.Lines.Add(new Figure(NewLine));
             MModel.LineTypes.Add(type);
             DrawAll();
         }

         public void AddFormulaLine(string xt, string yt, string zt, int step, double lt, double rt)
         {
             List<MPoint> ML = new List<MPoint>();
             MPoint temp;
             Parser MyPars = new Parser();
             MyPars.AddVariable("e",Math.E);
             MyPars.AddVariable("pi", Math.PI);
             for (double i = lt; i <= rt; i += (rt - lt) / (step))
             {
                 MyPars.AddVariable("t", i);
                 ML.Add(new MPoint(MyPars.SimplifyDouble(xt), MyPars.SimplifyDouble(yt), MyPars.SimplifyDouble(zt)));
                 MyPars.RemoveVariable("t");
             }
             MModel.Lines.Add(new Figure(ML));
             MModel.LineTypes.Add("form");
             DrawAll();
         }

         public void AddSplain(string xt, string yt, string zt, int step, double lt, double rt)
         {
             List<MPoint> ML = new List<MPoint>();
             MPoint temp;
             Parser MyPars = new Parser();
             MyPars.AddVariable("e", Math.E);
             MyPars.AddVariable("pi", Math.PI);
             for (double i = lt; i <= rt; i += (rt - lt) / (step))
             {
                 MyPars.AddVariable("t", i);
                 ML.Add(new MPoint(MyPars.SimplifyDouble(xt), MyPars.SimplifyDouble(yt), MyPars.SimplifyDouble(zt)));
                 MyPars.RemoveVariable("t");
             }
             MModel.Lines.Add(new Figure(ML));
             MModel.LineTypes.Add("splain");
             DrawAll();
         }

         public void AddRoundPlane(string xt, string yt, string zt, double lt, double rt, int stept, int stepfi, int stepfis, MPoint p1, MPoint p2)
         {
             List<MPoint> ML = new List<MPoint>();
             ML.Add(p1);
             ML.Add(p2);
             MModel.Lines.Add(new Figure(ML));
             MModel.LineTypes.Add("broken");

             double[,] E = new double[4, 4];
             E[0, 0] = 1;
             E[1, 1] = 1;
             E[2, 2] = 1;
             E[3, 3] = 1;

             double[,] op = new double[4, 4];
             double[,] temp;
             double fi;

             double[,] vec = new double[1, 4];
             vec[0, 0] = p2.coor[0] - p1.coor[0];
             vec[0, 1] = p2.coor[1] - p1.coor[1];
             vec[0, 2] = p2.coor[2] - p1.coor[2];
             vec[0, 3] = 1;

             fi = Math.Atan((vec[0, 0] / vec[0, 2]));
             fi *= (vec[0, 0] > 0) ? (-1) : (-1);
             op = new double[4, 4];
             op[3, 3] = 1;
             op[1, 1] = 1;
             op[0, 0] = Math.Cos(fi);
             op[2, 2] = Math.Cos(fi);
             op[0, 2] = Math.Sin(fi);
             op[2, 0] = -1*Math.Sin(fi);
             vec = Matrixes.Multiply(vec, op);
             E = Matrixes.Multiply(E, Matrixes.GetReverse(op, 4));

             fi = Math.Atan((vec[0, 1] / vec[0, 2]));
             fi *= (vec[0, 1] > 0) ? (-1) : (1);
             op = new double[4, 4];
             op[3, 3] = 1;
             op[0, 0] = 1;
             op[1, 1] = Math.Cos(fi);
             op[2, 2] = Math.Cos(fi);
             op[1, 2] = Math.Sin(fi);
             op[2, 1] = -1*Math.Sin(fi);
             vec = Matrixes.Multiply(vec, op);
             E = Matrixes.Multiply(E, Matrixes.GetReverse(op, 4));


             fi = (2*Math.PI)/ stepfis;
             op = new double[4, 4];
             op[3, 3] = 1;
             op[2, 2] = 1;
             op[0, 0] = Math.Cos(fi);
             op[1, 1] = Math.Cos(fi);
             op[1, 0] = Math.Sin(fi);
             op[0, 1] = -1 * Math.Sin(fi);
             temp = new double[stept+1, 4];
             Parser MyPars = new Parser();
             MyPars.AddVariable("e", Math.E);
             MyPars.AddVariable("pi", Math.PI);

             for (int i=0; i < stept; i++)
             {
                 MyPars.AddVariable("t", lt + i * ((rt - lt) / stept));
                 temp[i,0] = MyPars.SimplifyDouble(xt);
                 temp[i,1] =MyPars.SimplifyDouble(yt);
                 temp[i,2] =MyPars.SimplifyDouble(zt);
                 temp[i, 3] = 1;
                 MyPars.RemoveVariable("t");
             }

             for (int i = 0; i < stepfis; i++)
             {
                 ML = new List<MPoint>();
                 for (int j = 0; j < stept; j++)
                 {
                     ML.Add(new MPoint(temp[j, 0], temp[j, 1], temp[j, 2]));
                 }
                 MModel.Planes.Add(new Figure(ML));
                 MModel.PlaneTypes.Add("ober");
                 MModel.PlanesAddINfo.Add(0);
                 temp = Matrixes.Multiply(temp, op);
             }
             double st = lt;

             op = new double[4, 4];
             op[3, 3] = 1;
             op[2, 2] = 1;
             op[0, 0] = Math.Cos(Math.PI/180);
             op[1, 1] = Math.Cos(Math.PI / 180);
             op[1, 0] = Math.Sin(Math.PI / 180);
             op[0, 1] = -1 * Math.Sin(Math.PI / 180);

             for (int i = 0; i < stepfi; i++)
             {
                 st = lt + i * ((rt - lt)/stepfi);
                 ML = new List<MPoint>();
                 MyPars.AddVariable("t", st);
                 temp = new double[1, 4];
                 temp[0, 0] = MyPars.SimplifyDouble(xt);
                 temp[0, 1] = MyPars.SimplifyDouble(yt);
                 temp[0, 2] = MyPars.SimplifyDouble(zt);
                 temp[0, 3] = 1;
                 MyPars.RemoveVariable("t");
                 for (int j = 0; j < 360; j++)
                 {
                     ML.Add(new MPoint(temp[0, 0], temp[0, 1], temp[0, 2]));
                     temp = Matrixes.Multiply(temp, op);
                 }
                 MModel.Planes.Add(new Figure(ML));
                 MModel.PlaneTypes.Add("ober");
                 MModel.PlanesAddINfo.Add(0);
             }
             DrawAll();

         }

         public void BuildKuns(double [,] Xmat, double [,] Ymat, double [,] Zmat, int steps)
         {
             List<MPoint> ML = new List<MPoint>();
             int i, j, k;
             for (i = 0; i < 2; i++)
             {
                 for (j = 0; j < 2; j++)
                 {
                     ML.Add(new MPoint(Xmat[i,j],Ymat[i,j], Zmat[i,j]));
                 }
             }
             for (i = 2; i < 4; i++)
             {
                 for (j = 0; j < 2; j++)
                 {
                     ML.Add(new MPoint(Xmat[i, j], Ymat[i, j], Zmat[i, j]));
                 }
             }
             for (i = 0; i < 2; i++)
             {
                 for (j = 2; j < 4; j++)
                 {
                     ML.Add(new MPoint(Xmat[i, j], Ymat[i, j], Zmat[i, j]));
                 }
             }
             for (i = 2; i < 4; i++)
             {
                 for (j = 2; j < 4; j++)
                 {
                     ML.Add(new MPoint(Xmat[i, j], Ymat[i, j], Zmat[i, j]));
                 }
             }
             MModel.Planes.Add(new Figure(ML));
             MModel.PlaneTypes.Add("kuns");
             MModel.PlanesAddINfo.Add(0);
             DrawAll();
         }

         public void BuildPlaneBez(List<MPoint> ML, int length)
         {
             MModel.Planes.Add(new Figure(ML));
             MModel.PlaneTypes.Add("bez");
             MModel.PlanesAddINfo.Add(length);
             DrawAll();
         }


         public double[] Q(double u, double v, double[,] Xmat, double[,] Ymat, double[,] Zmat)
         {
            double[,] Fu = new double [1,4], Fv = new double [4,1];
            Fu[0, 0] = 2 * u * u * u - 3 * u * u + 1;
            Fu[0, 1] = -2 * u * u * u + 3 * u * u;
            Fu[0, 2] = u * u * u - 2 * u * u + u;
            Fu[0, 3] = u * u * u - u * u;

            Fv[0, 0] = 2 * v * v * v - 3 * v * v + 1;
            Fv[1, 0] = -2 * v * v * v + 3 * v * v;
            Fv[2, 0] = v * v * v - 2 * v * v + v;
            Fv[3, 0] = v * v * v - v * v;

            return new double[] { Matrixes.Multiply(Matrixes.Multiply(Fu, Xmat), Fv)[0, 0], Matrixes.Multiply(Matrixes.Multiply(Fu, Ymat), Fv)[0, 0], Matrixes.Multiply(Matrixes.Multiply(Fu, Zmat), Fv)[0, 0] };
         }

         public void DrawAll()
        {
            Pen BlackPen = new Pen(Color.Black, 3);
            Pen RedXPen = new Pen(Color.Red, 4);
            Pen BlueYPen = new Pen(Color.Blue, 4);
            Pen GreenZPen = new Pen(Color.Green, 4);
            Pen RedDarkXPen = new Pen(Color.DarkRed, 4);
            Pen BlueDarkYPen = new Pen(Color.DarkBlue, 4);
            Pen GreenDarkZPen = new Pen(Color.DarkSeaGreen, 4);
            Pen CyanSplainPen = new Pen(Color.Cyan,3);
            Graphics Cur = View.panel1.CreateGraphics();
            Cur.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Cur.Clear(Color.White);
            //Cur.DrawLine(GreenPen, 10, 10, 100, 100);
            // return;
            int i, j, k;
            double fi;
            double[,] temp;
            double[,] E = new double[4, 4];
            E[0, 0] = 1;
            E[1, 1] = 1;
            E[2, 2] = 1;
            E[3, 3] = 1;
            double[,] op = new double[4, 4];
            double[,] vecz = new double[1, 4];
            double[,] vecy = new double[1, 4];
            double[,] vecx = new double[1, 4];
            //// Coord vectors ahead
            double[,] CoorVec = new double[7, 4];//first one os zero point
            CoorVec[0, 3] = 1;
            CoorVec[1, 3] = 1;
            CoorVec[2, 3] = 1;
            CoorVec[3, 3] = 1;
            CoorVec[4, 3] = 1;
            CoorVec[5, 3] = 1;
            CoorVec[6, 3] = 1;

            CoorVec[1, 0] = 3000;
            CoorVec[2, 1] = 3000;
            CoorVec[3, 2] = 3000;
            CoorVec[4, 0] = -3000;
            CoorVec[5, 1] = -3000;
            CoorVec[6, 2] = -3000;

            if (Persp)
            {
                op = new double[4, 4];
                op[0, 0] = 1;
                op[1, 1] = 1;
                op[2, 2] = 1;
                op[3, 3] = 1;
                op[0, 3] = 1 / PerspPar[0];
                op[1, 3] = 1 / PerspPar[1];
                op[2, 3] = 1 / PerspPar[2];
                CoorVec = Matrixes.Multiply(CoorVec, op);
                for (j = 0; j < 7; j++)
                {
                    CoorVec[j, 0] /= CoorVec[j, 3];
                    CoorVec[j, 1] /= CoorVec[j, 3];
                    CoorVec[j, 2] /= CoorVec[j, 3];
                    CoorVec[j, 3] /= CoorVec[j, 3];
                }
                // for()
            }

            CoorVec[0, 0] -= MModel.Center.coor[0];//Moving the, cause of camera
            CoorVec[1, 0] -= MModel.Center.coor[0];
            CoorVec[2, 0] -= MModel.Center.coor[0];
            CoorVec[3, 0] -= MModel.Center.coor[0];
            CoorVec[4, 0] -= MModel.Center.coor[0];
            CoorVec[5, 0] -= MModel.Center.coor[0];
            CoorVec[6, 0] -= MModel.Center.coor[0];

            CoorVec[0, 1] -= MModel.Center.coor[1];
            CoorVec[1, 1] -= MModel.Center.coor[1];
            CoorVec[2, 1] -= MModel.Center.coor[1];
            CoorVec[3, 1] -= MModel.Center.coor[1];
            CoorVec[4, 1] -= MModel.Center.coor[1];
            CoorVec[5, 1] -= MModel.Center.coor[1];
            CoorVec[6, 1] -= MModel.Center.coor[1];

            CoorVec[0, 2] -= MModel.Center.coor[2];
            CoorVec[1, 2] -= MModel.Center.coor[2];
            CoorVec[2, 2] -= MModel.Center.coor[2];
            CoorVec[3, 2] -= MModel.Center.coor[2];
            CoorVec[4, 2] -= MModel.Center.coor[2];
            CoorVec[5, 2] -= MModel.Center.coor[2];
            CoorVec[6, 2] -= MModel.Center.coor[2];
            ////////
            vecz[0, 0] = MModel.CenterZVec.coor[0];
            vecz[0, 1] = MModel.CenterZVec.coor[1];
            vecz[0, 2] = MModel.CenterZVec.coor[2];
            vecz[0, 3] = MModel.CenterZVec.coor[3];

            vecy[0, 0] = MModel.CenterYVec.coor[0];
            vecy[0, 1] = MModel.CenterYVec.coor[1];
            vecy[0, 2] = MModel.CenterYVec.coor[2];
            vecy[0, 3] = MModel.CenterYVec.coor[3];

            vecx[0, 0] = MModel.CenterXVec.coor[0];
            vecx[0, 1] = MModel.CenterXVec.coor[1];
            vecx[0, 2] = MModel.CenterXVec.coor[2];
            vecx[0, 3] = MModel.CenterXVec.coor[3];
            fi = Math.Atan(-1 * (vecz[0, 1] / vecz[0, 0]));
            fi *= (MModel.CenterZVec.coor[2] > 0) ? (1) : (-1);
            op = new double[4, 4];
            op[3, 3] = 1;
            op[2, 2] = 1;
            op[0, 0] = Math.Cos(fi);
            op[1, 1] = Math.Cos(fi);
            op[0, 1] = -1 * Math.Sin(fi);
            op[1, 0] = Math.Sin(fi);
            CoorVec = Matrixes.Multiply(CoorVec, op);
            vecz = Matrixes.Multiply(vecz, op);
            vecy = Matrixes.Multiply(vecy, op);
            vecx = Matrixes.Multiply(vecx, op);

            fi = Math.Atan(-1 * (vecz[0, 0] / vecz[0, 2]));
            fi *= (vecz[0, 0] > 0) ? (-1) : (1);
            op = new double[4, 4];
            op[3, 3] = 1;
            op[1, 1] = 1;
            op[0, 0] = Math.Cos(fi);
            op[2, 2] = Math.Cos(fi);
            op[0, 2] = -1 * Math.Sin(fi);
            op[2, 0] = Math.Sin(fi);
            CoorVec = Matrixes.Multiply(CoorVec, op);
            vecz = Matrixes.Multiply(vecz, op);
            vecy = Matrixes.Multiply(vecy, op);
            vecx = Matrixes.Multiply(vecx, op);

            op = new double[4, 4];
            op[0, 0] = -1;
            op[1, 1] = -1;
            op[2, 2] = -1;
            op[3, 3] = 1;
            CoorVec = Matrixes.Multiply(CoorVec, op);
            vecz = Matrixes.Multiply(vecz, op);
            vecy = Matrixes.Multiply(vecy, op);
            vecx = Matrixes.Multiply(vecx, op);

            ///*
            fi = Math.Atan(-1 * (vecy[0, 0] / vecy[0, 1]));
            fi *= (vecy[0, 0] > 0) ? (-1) : (1);
            op = new double[4, 4];
            op[3, 3] = 1;
            op[2, 2] = 1;
            op[0, 0] = Math.Cos(fi);
            op[1, 1] = Math.Cos(fi);
            op[0, 1] = -1 * Math.Sin(fi);
            op[1, 0] = Math.Sin(fi);
            CoorVec = Matrixes.Multiply(CoorVec, op);
            vecz = Matrixes.Multiply(vecz, op);
            vecy = Matrixes.Multiply(vecy, op);
            vecx = Matrixes.Multiply(vecx, op);

            /*   op = new double[4, 4];
               op[0, 0] = -1;
               op[1, 1] = 1;
               op[2, 2] = 1;
               op[3, 3] = 1;
               CoorVec = Matrixes.Multiply(CoorVec, op);
               vecz = Matrixes.Multiply(vecz, op);
               vecy = Matrixes.Multiply(vecy, op);
               vecx = Matrixes.Multiply(vecx, op);
               //*/
            CoorVec[0, 0] += View.panel1.Width / 2;
            CoorVec[0, 1] += View.panel1.Height / 2;
            CoorVec[1, 0] += View.panel1.Width / 2;
            CoorVec[1, 1] += View.panel1.Height / 2;
            CoorVec[2, 0] += View.panel1.Width / 2;
            CoorVec[2, 1] += View.panel1.Height / 2;
            CoorVec[3, 0] += View.panel1.Width / 2;
            CoorVec[3, 1] += View.panel1.Height / 2;
            CoorVec[4, 0] += View.panel1.Width / 2;
            CoorVec[4, 1] += View.panel1.Height / 2;
            CoorVec[5, 0] += View.panel1.Width / 2;
            CoorVec[5, 1] += View.panel1.Height / 2;
            CoorVec[6, 0] += View.panel1.Width / 2;
            CoorVec[6, 1] += View.panel1.Height / 2;
            // if (CoorVec[0, 2] >= 0)
            {
                //  if (CoorVec[1, 2]>=0)
                Cur.DrawLine(RedXPen, (int)CoorVec[0, 0], (int)CoorVec[0, 1], (int)CoorVec[1, 0], (int)CoorVec[1, 1]);
                // if (CoorVec[2, 2] >= 0)
                Cur.DrawLine(BlueYPen, (int)CoorVec[0, 0], (int)CoorVec[0, 1], (int)CoorVec[2, 0], (int)CoorVec[2, 1]);
                // if (CoorVec[3, 2] >= 0)
                Cur.DrawLine(GreenZPen, (int)CoorVec[0, 0], (int)CoorVec[0, 1], (int)CoorVec[3, 0], (int)CoorVec[3, 1]);

                //                if (CoorVec[4, 2] >= 0)
                Cur.DrawLine(RedDarkXPen, (int)CoorVec[0, 0], (int)CoorVec[0, 1], (int)CoorVec[4, 0], (int)CoorVec[4, 1]);
                // if (CoorVec[5, 2] >= 0)
                Cur.DrawLine(BlueDarkYPen, (int)CoorVec[0, 0], (int)CoorVec[0, 1], (int)CoorVec[5, 0], (int)CoorVec[5, 1]);
                //  if (CoorVec[6, 2] >= 0)
                Cur.DrawLine(GreenDarkZPen, (int)CoorVec[0, 0], (int)CoorVec[0, 1], (int)CoorVec[6, 0], (int)CoorVec[6, 1]);
            }
            ////Figures ahead
            for (i = 0; i < MModel.Lines.Count; i++)
            {
                temp = new double[MModel.Lines[i].cells.Count, 4];
                for (j = 0; j < MModel.Lines[i].cells.Count; j++)
                {
                    temp[j, 0] = MModel.Lines[i].cells[j].coor[0];
                    temp[j, 1] = MModel.Lines[i].cells[j].coor[1];
                    temp[j, 2] = MModel.Lines[i].cells[j].coor[2];
                    temp[j, 3] = MModel.Lines[i].cells[j].coor[3];
                }

                //////////

                if (MModel.LineTypes[i] == "splain")
                {
                     temp = new double[(MModel.Lines[i].cells.Count)*25, 4];
                    ////////////////
                    Double[] ArrayX, ArrayY, ArrayZ, ArrayT;
                    ArrayX = new double[MModel.Lines[i].cells.Count];
                    ArrayY = new double[MModel.Lines[i].cells.Count];
                    ArrayZ = new double[MModel.Lines[i].cells.Count];
                    ArrayT = new double[MModel.Lines[i].cells.Count];
                    for (j = 0; j < MModel.Lines[i].cells.Count; j++)
                    {
                        ArrayT[j] = j;
                        ArrayX[j] = MModel.Lines[i].cells[j].coor[0];
                        ArrayY[j] = MModel.Lines[i].cells[j].coor[1];
                        ArrayZ[j] = MModel.Lines[i].cells[j].coor[2];
                    }
                    //Console.Write("lol");
                    double[] Steps = new double[MModel.Lines[i].cells.Count - 1];
                    double[] Inpa, Inpb, Inpc, Inpf;
                    Inpa = new double[MModel.Lines[i].cells.Count - 1];
                    Inpb = new double[MModel.Lines[i].cells.Count - 1];
                    Inpc = new double[MModel.Lines[i].cells.Count - 1];
                    Inpf = new double[MModel.Lines[i].cells.Count - 1];
                    for (j = 0; j < MModel.Lines[i].cells.Count - 1; j++)
                    {
                        Steps[j] = ArrayT[j + 1] - ArrayT[j];
                    }
                    //double[][] matrix = new double[MModel.Lines[i].cells.Count - 2][];
                    for (j = 0; j < MModel.Lines[i].cells.Count - 2; j++)
                    {
                        Inpc[j] = 2 * (Steps[j] + Steps[j + 1]);
                    }
                    Inpc[MModel.Lines[i].cells.Count - 2] = 2 * (Steps[MModel.Lines[i].cells.Count - 2] + Steps[0]);
                    for (j = 0; j < MModel.Lines[i].cells.Count - 2; j++)
                    {
                        Inpa[j] = Steps[j];
                        Inpb[j] = Steps[j + 1];
                    }
                    Inpa[0] = Steps[MModel.Lines[i].cells.Count - 2];
                    Inpb[0] = Steps[1];
                    Inpa[MModel.Lines[i].cells.Count - 2] = Steps[MModel.Lines[i].cells.Count - 2];
                    Inpb[MModel.Lines[i].cells.Count - 2] = Steps[0];
                    for (j = 0; j < Inpf.Length - 1; j++)
                    {
                        Inpf[j] = 6 * (((ArrayX[j + 2] - ArrayX[j + 1]) / Steps[j + 1]) - ((ArrayX[j + 1] - ArrayX[j]) / Steps[j]));
                    }
                    Inpf[Inpf.Length - 1] = 0;//6 * (((ArrayX[0] - ArrayX[MModel.Lines[i].cells.Count - 1]) / Steps[0]) - ((ArrayX[MModel.Lines[i].cells.Count - 1] - ArrayX[MModel.Lines[i].cells.Count - 2]) / Steps[MModel.Lines[i].cells.Count - 2]));
                    ////paaaaiiiiin
                    //double[][] InputMatrix = new double[MModel.Lines[i].cells.Count - 2][];
                    ////
                    double[] newc = Geometry.CyclycWithoutMinuses(Inpa, Inpc, Inpb, Inpf);
                    if (newc == null)
                    {
                       // textBox1.Text += "Cry loudly" + Environment.NewLine;
                        return;
                    }
                    double[] cx = new double[MModel.Lines[i].cells.Count];
                    double[] dx = new double[MModel.Lines[i].cells.Count];
                    double[] bx = new double[MModel.Lines[i].cells.Count];
                    double[] ax = new double[MModel.Lines[i].cells.Count];
                    for (j = 1; j < MModel.Lines[i].cells.Count; j++)
                    {
                        cx[j] = newc[j - 1];
                    }
                    cx[0] = cx[MModel.Lines[i].cells.Count - 1];
                    ax[0] = ArrayX[0];
                    for (j = 1; j < MModel.Lines[i].cells.Count; j++)
                    {
                        dx[j] = (cx[j] - cx[j - 1]) / Steps[j - 1];
                        ax[j] = ArrayX[j];
                        bx[j] = 0.5 * Steps[j - 1] * cx[j] - (1.0 / 6) * Steps[j - 1] * Steps[j - 1] * dx[j] + ((ArrayX[j] - ArrayX[j - 1]) / Steps[j - 1]);
                    }


                    /////
                    Steps = new double[MModel.Lines[i].cells.Count - 1];
                    Inpa = new double[MModel.Lines[i].cells.Count - 1];
                    Inpb = new double[MModel.Lines[i].cells.Count - 1];
                    Inpc = new double[MModel.Lines[i].cells.Count - 1];
                    Inpf = new double[MModel.Lines[i].cells.Count - 1];
                    for (j = 0; j < MModel.Lines[i].cells.Count - 1; j++)
                    {
                        Steps[j] = ArrayT[j + 1] - ArrayT[j];
                    }
                    for (j = 0; j < MModel.Lines[i].cells.Count - 2; j++)
                    {
                        Inpc[j] = 2 * (Steps[j] + Steps[j + 1]);
                    }
                    Inpc[MModel.Lines[i].cells.Count - 2] = 2 * (Steps[MModel.Lines[i].cells.Count - 2] + Steps[0]);
                    for (j = 1; j < MModel.Lines[i].cells.Count - 2; j++)
                    {
                        Inpa[j] = Steps[j];
                        Inpb[j] = Steps[j + 1];
                    }
                    Inpa[0] = Steps[MModel.Lines[i].cells.Count - 2];
                    Inpb[0] = Steps[1];
                    Inpa[MModel.Lines[i].cells.Count - 2] = Steps[MModel.Lines[i].cells.Count - 2];
                    Inpb[MModel.Lines[i].cells.Count - 2] = Steps[0];
                    for (j = 0; j < Inpf.Length - 1; j++)
                    {
                        Inpf[j] = 6 * (((ArrayY[j + 2] - ArrayY[j + 1]) / Steps[j + 1]) - ((ArrayY[j + 1] - ArrayY[j]) / Steps[j]));
                    }
                    Inpf[Inpf.Length - 1] = 0;// 6 * (((ArrayY[1] - ArrayY[MModel.Lines[i].cells.Count - 1]) / Steps[0]) - ((ArrayY[MModel.Lines[i].cells.Count - 1] - ArrayY[MModel.Lines[i].cells.Count - 2]) / Steps[MModel.Lines[i].cells.Count - 2]));
                    ////paaaaiiiiin
                    ////
                    newc = Geometry.CyclycWithoutMinuses(Inpa, Inpc, Inpb, Inpf);
                    if (newc == null)
                    {
                        //textBox1.Text += "Cry loudly" + Environment.NewLine;
                        return;
                    }
                    double[] cy = new double[MModel.Lines[i].cells.Count];
                    double[] dy = new double[MModel.Lines[i].cells.Count];
                    double[] by = new double[MModel.Lines[i].cells.Count];
                    double[] ay = new double[MModel.Lines[i].cells.Count];
                    for (j = 1; j < MModel.Lines[i].cells.Count; j++)
                    {
                        cy[j] = newc[j - 1];
                    }
                    cy[0] = cy[MModel.Lines[i].cells.Count - 1];
                    ay[0] = ArrayY[0];
                    for (j = 1; j < MModel.Lines[i].cells.Count; j++)
                    {
                        dy[j] = (cy[j] - cy[j - 1]) / Steps[j - 1];
                        ay[j] = ArrayY[j];
                        by[j] = 0.5 * Steps[j - 1] * cy[j] - (1.0 / 6) * Steps[j - 1] * Steps[j - 1] * dy[j] + ((ArrayY[j] - ArrayY[j - 1]) / Steps[j - 1]);
                    }

                    /////z
                    Steps = new double[MModel.Lines[i].cells.Count - 1];
                    Inpa = new double[MModel.Lines[i].cells.Count - 1];
                    Inpb = new double[MModel.Lines[i].cells.Count - 1];
                    Inpc = new double[MModel.Lines[i].cells.Count - 1];
                    Inpf = new double[MModel.Lines[i].cells.Count - 1];
                    for (j = 0; j < MModel.Lines[i].cells.Count - 1; j++)
                    {
                        Steps[j] = ArrayT[j + 1] - ArrayT[j];
                    }
                    for (j = 0; j < MModel.Lines[i].cells.Count - 2; j++)
                    {
                        Inpc[j] = 2 * (Steps[j] + Steps[j + 1]);
                    }
                    Inpc[MModel.Lines[i].cells.Count - 2] = 2 * (Steps[MModel.Lines[i].cells.Count - 2] + Steps[0]);
                    for (j = 1; j < MModel.Lines[i].cells.Count - 2; j++)
                    {
                        Inpa[j] = Steps[j];
                        Inpb[j] = Steps[j + 1];
                    }
                    Inpa[0] = Steps[MModel.Lines[i].cells.Count - 2];
                    Inpb[0] = Steps[1];
                    Inpa[MModel.Lines[i].cells.Count - 2] = Steps[MModel.Lines[i].cells.Count - 2];
                    Inpb[MModel.Lines[i].cells.Count - 2] = Steps[0];
                    for (j = 0; j < Inpf.Length - 1; j++)
                    {
                        Inpf[j] = 6 * (((ArrayZ[j + 2] - ArrayZ[j + 1]) / Steps[j + 1]) - ((ArrayZ[j + 1] - ArrayZ[j]) / Steps[j]));
                    }
                    Inpf[Inpf.Length - 1] = 0;// 6 * (((ArrayZ[1] - ArrayZ[MModel.Lines[i].cells.Count - 1]) / Steps[0]) - ((ArrayZ[MModel.Lines[i].cells.Count - 1] - ArrayZ[MModel.Lines[i].cells.Count - 2]) / Steps[MModel.Lines[i].cells.Count - 2]));
                    ////paaaaiiiiin
                    ////
                    newc = Geometry.CyclycWithoutMinuses(Inpa, Inpc, Inpb, Inpf);
                    if (newc == null)
                    {
                        //textBox1.Text += "Cry loudly" + Environment.NewLine;
                        return;
                    }
                    double[] cz = new double[MModel.Lines[i].cells.Count];
                    double[] dz = new double[MModel.Lines[i].cells.Count];
                    double[] bz = new double[MModel.Lines[i].cells.Count];
                    double[] az = new double[MModel.Lines[i].cells.Count];
                    for (j = 1; j < MModel.Lines[i].cells.Count; j++)
                    {
                        cz[j] = newc[j - 1];
                    }
                    cz[0] = cz[MModel.Lines[i].cells.Count - 1];
                    az[0] = ArrayZ[0];
                    for (j = 1; j < MModel.Lines[i].cells.Count; j++)
                    {
                        dz[j] = (cz[j] - cz[j - 1]) / Steps[j - 1];
                        az[j] = ArrayZ[j];
                        bz[j] = 0.5 * Steps[j - 1] * cz[j] - (1.0 / 6) * Steps[j - 1] * Steps[j - 1] * dz[j] + ((ArrayZ[j] - ArrayZ[j - 1]) / Steps[j - 1]);
                    }

                    /////z
                    //chart1.Series[0].Points.Clear();
                    double f;
                     k=0;
                    for (j = 1; j < MModel.Lines[i].cells.Count; j++)
                    {
                        for (f = ArrayT[j - 1]; f < ArrayT[j];k++, f = k*0.04)
                        {
                            temp[k,0] = ax[j]  + bx[j] * (f - ArrayT[j]) + (cx[j] / 2) * Math.Pow((f - ArrayT[j]), 2) + (dx[j] / 6) * Math.Pow((f - ArrayT[j]), 3);
                            temp[k,1] = ay[j]  + by[j] * (f - ArrayT[j]) + (cy[j] / 2) * Math.Pow((f - ArrayT[j]), 2) + (dy[j] / 6) * Math.Pow((f - ArrayT[j]), 3);
                            temp[k,2] = az[j]  + bz[j] * (f - ArrayT[j]) + (cz[j] / 2) * Math.Pow((f - ArrayT[j]), 2) + (dz[j] / 6) * Math.Pow((f - ArrayT[j]), 3);
                            temp[k, 3] = 1;
                        }
                    }
                    ////////////////
                }

                if (MModel.LineTypes[i] == "bez")
                {
                    k=0;
                    double sum=0;
                    temp = new double[(MModel.Lines[i].cells.Count-1) * 25 +1, 4];
                    for (double t = 0; k < (MModel.Lines[i].cells.Count-1) * 25 +1;k++, t += 1d / ((MModel.Lines[i].cells.Count - 1) * 25))
                    { 
                        t = (t>1)?(1):(t);
                        sum = 0;
                        for(j=0; j <MModel.Lines[i].cells.Count; j++ )
                        {
                            sum+=MModel.Lines[i].cells[j].coor[0]*Geometry.Bernstein(MModel.Lines[i].cells.Count-1,j,t);
                        }
                        temp[k,0] = sum;

                        sum = 0;
                        for(j=0; j <MModel.Lines[i].cells.Count; j++ )
                        {
                            sum+=MModel.Lines[i].cells[j].coor[1]*Geometry.Bernstein(MModel.Lines[i].cells.Count-1,j,t);
                        }
                        temp[k,1] = sum;

                        sum = 0;
                        for(j=0; j <MModel.Lines[i].cells.Count; j++ )
                        {
                            sum+=MModel.Lines[i].cells[j].coor[2]*Geometry.Bernstein(MModel.Lines[i].cells.Count-1,j,t);
                        }
                        temp[k,2] = sum;
                        temp[k, 3] = 1;
                    }
                }
                /////////


                if (Persp)
                {
                    op = new double[4, 4];
                    op[0, 0] = 1;
                    op[1, 1] = 1;
                    op[2, 2] = 1;
                    op[3, 3] = 1;
                    op[0, 3] = 1 / PerspPar[0];
                    op[1, 3] = 1 / PerspPar[1];
                    op[2, 3] = 1 / PerspPar[2];
                    temp = Matrixes.Multiply(temp, op);
                    for (j = 0; j < MModel.Lines[i].cells.Count; j++)
                    {
                        temp[j, 0] /= temp[j, 3];
                        temp[j, 1] /= temp[j, 3];
                        temp[j, 2] /= temp[j, 3];
                        temp[j, 3] /= temp[j, 3];
                    }
                    // for()
                }

                if (Cosc)
                {
                    op = new double[4, 4];
                    op[0, 0] = 1;
                    op[1, 1] = 1;
                    op[2, 2] = 1;
                    op[3, 3] = 1;
                    op[2, 0] = CoscPar[1] * Math.Cos(CoscPar[0]);
                    op[2, 1] = -1 * CoscPar[1] * Math.Sin(CoscPar[0]);
                    temp = Matrixes.Multiply(temp, op);
                    // for()
                }

                for (j = 0; j < MModel.Lines[i].cells.Count; j++)
                {
                    temp[j, 0] -= MModel.Center.coor[0];
                    temp[j, 1] -= MModel.Center.coor[1];
                    temp[j, 2] -= MModel.Center.coor[2];
                }

                vecz[0, 0] = MModel.CenterZVec.coor[0];
                vecz[0, 1] = MModel.CenterZVec.coor[1];
                vecz[0, 2] = MModel.CenterZVec.coor[2];
                vecz[0, 3] = MModel.CenterZVec.coor[3];

                vecy[0, 0] = MModel.CenterYVec.coor[0];
                vecy[0, 1] = MModel.CenterYVec.coor[1];
                vecy[0, 2] = MModel.CenterYVec.coor[2];
                vecy[0, 3] = MModel.CenterYVec.coor[3];

                vecx[0, 0] = MModel.CenterXVec.coor[0];
                vecx[0, 1] = MModel.CenterXVec.coor[1];
                vecx[0, 2] = MModel.CenterXVec.coor[2];
                vecx[0, 3] = MModel.CenterXVec.coor[3];

                fi = Math.Atan(-1 * (vecz[0, 1] / vecz[0, 0]));
                fi *= (MModel.CenterZVec.coor[2] > 0) ? (1) : (-1);
                op = new double[4, 4];
                op[3, 3] = 1;
                op[2, 2] = 1;
                op[0, 0] = Math.Cos(fi);
                op[1, 1] = Math.Cos(fi);
                op[0, 1] = -1 * Math.Sin(fi);
                op[1, 0] = Math.Sin(fi);
                temp = Matrixes.Multiply(temp, op);
                vecz = Matrixes.Multiply(vecz, op);
                vecy = Matrixes.Multiply(vecy, op);
                vecx = Matrixes.Multiply(vecx, op);

                fi = Math.Atan(-1 * (vecz[0, 0] / vecz[0, 2]));
                fi *= (vecz[0, 0] > 0) ? (-1) : (1);
                op = new double[4, 4];
                op[3, 3] = 1;
                op[1, 1] = 1;
                op[0, 0] = Math.Cos(fi);
                op[2, 2] = Math.Cos(fi);
                op[0, 2] = -1 * Math.Sin(fi);
                op[2, 0] = Math.Sin(fi);
                temp = Matrixes.Multiply(temp, op);
                vecz = Matrixes.Multiply(vecz, op);
                vecy = Matrixes.Multiply(vecy, op);
                vecx = Matrixes.Multiply(vecx, op);

                op = new double[4, 4];
                op[0, 0] = -1;
                op[1, 1] = -1;
                op[2, 2] = -1;
                op[3, 3] = 1;
                temp = Matrixes.Multiply(temp, op);
                vecz = Matrixes.Multiply(vecz, op);
                vecy = Matrixes.Multiply(vecy, op);
                vecx = Matrixes.Multiply(vecx, op);

                ///*
                fi = Math.Atan(-1 * (vecy[0, 0] / vecy[0, 1]));
                fi *= (vecy[0, 0] > 0) ? (-1) : (1);
                op = new double[4, 4];
                op[3, 3] = 1;
                op[2, 2] = 1;
                op[0, 0] = Math.Cos(fi);
                op[1, 1] = Math.Cos(fi);
                op[0, 1] = -1 * Math.Sin(fi);
                op[1, 0] = Math.Sin(fi);
                temp = Matrixes.Multiply(temp, op);
                vecz = Matrixes.Multiply(vecz, op);
                vecy = Matrixes.Multiply(vecy, op);
                vecx = Matrixes.Multiply(vecx, op);

                /* op = new double[4, 4];
                  op[0, 0] = -1;
                  op[1, 1] = 1;
                  op[2, 2] = 1;
                  op[3, 3] = 1;
                  temp = Matrixes.Multiply(temp, op);
                  vecz = Matrixes.Multiply(vecz, op);
                  vecy = Matrixes.Multiply(vecy, op);
                  vecx = Matrixes.Multiply(vecx, op);//*/

                if (vecz[0, 3] < 0)
                {

                }

                for (j = 0; j < temp.Length / 4; j++)
                {
                    temp[j, 0] += View.panel1.Width / 2;
                    temp[j, 1] += View.panel1.Height / 2;
                }

                if (MModel.LineTypes[i] == "broken" || MModel.LineTypes[i] == "splain" || MModel.LineTypes[i] == "bez")
                {
                    for (j = 1; j < temp.Length/4; j++)
                    {
                        if (temp[j, 3] == 0 || temp[j - 1, 3] == 0)
                            continue; 
                        //if(temp[j - 1,2]>0 &&temp[j,2]>0)
                        Cur.DrawLine(BlackPen, (int)temp[j - 1, 0], (int)temp[j - 1, 1], (int)temp[j, 0], (int)temp[j, 1]);
                    }
                }

                if (MModel.LineTypes[i] == "form")
                {
                    for (j = 1; j < temp.Length / 4; j++)
                    {
                        if (temp[j, 3] == 0 || temp[j - 1, 3] == 0)
                            continue;
                        //if(temp[j - 1,2]>0 &&temp[j,2]>0)
                        Cur.DrawLine(CyanSplainPen, (int)temp[j - 1, 0], (int)temp[j - 1, 1], (int)temp[j, 0], (int)temp[j, 1]);
                    }
                }
               
                // View.panel1.Refresh();


            }

            ////////
            ////////
            ///
            for (i = 0; i < MModel.Figs.Count; i++)
            {
                temp = new double[MModel.Figs[i].cells.Count, 4];
                for (j = 0; j < MModel.Figs[i].cells.Count; j++)
                {
                    temp[j, 0] = MModel.Figs[i].cells[j].coor[0];
                    temp[j, 1] = MModel.Figs[i].cells[j].coor[1];
                    temp[j, 2] = MModel.Figs[i].cells[j].coor[2];
                    temp[j, 3] = MModel.Figs[i].cells[j].coor[3];
                }

                if (Persp)
                {
                    op = new double[4, 4];
                    op[0, 0] = 1;
                    op[1, 1] = 1;
                    op[2, 2] = 1;
                    op[3, 3] = 1;
                    op[0, 3] = 1 / PerspPar[0];
                    op[1, 3] = 1 / PerspPar[1];
                    op[2, 3] = 1 / PerspPar[2];
                    temp = Matrixes.Multiply(temp, op);
                    for (j = 0; j < MModel.Figs[i].cells.Count; j++)
                    {
                        temp[j, 0] /= temp[j, 3];
                        temp[j, 1] /= temp[j, 3];
                        temp[j, 2] /= temp[j, 3];
                        temp[j, 3] /= temp[j, 3];
                    }
                    // for()
                }

                if (Cosc)
                {
                    op = new double[4, 4];
                    op[0, 0] = 1;
                    op[1, 1] = 1;
                    op[2, 2] = 1;
                    op[3, 3] = 1;
                    op[2, 0] = CoscPar[1] * Math.Cos(CoscPar[0]);
                    op[2, 1] = -1 * CoscPar[1] * Math.Sin(CoscPar[0]);
                    temp = Matrixes.Multiply(temp, op);
                    // for()
                }

                for (j = 0; j < MModel.Figs[i].cells.Count; j++)
                {
                    temp[j, 0] -= MModel.Center.coor[0];
                    temp[j, 1] -= MModel.Center.coor[1];
                    temp[j, 2] -= MModel.Center.coor[2];
                }

                vecz[0, 0] = MModel.CenterZVec.coor[0];
                vecz[0, 1] = MModel.CenterZVec.coor[1];
                vecz[0, 2] = MModel.CenterZVec.coor[2];
                vecz[0, 3] = MModel.CenterZVec.coor[3];

                vecy[0, 0] = MModel.CenterYVec.coor[0];
                vecy[0, 1] = MModel.CenterYVec.coor[1];
                vecy[0, 2] = MModel.CenterYVec.coor[2];
                vecy[0, 3] = MModel.CenterYVec.coor[3];

                vecx[0, 0] = MModel.CenterXVec.coor[0];
                vecx[0, 1] = MModel.CenterXVec.coor[1];
                vecx[0, 2] = MModel.CenterXVec.coor[2];
                vecx[0, 3] = MModel.CenterXVec.coor[3];

                fi = Math.Atan(-1 * (vecz[0, 1] / vecz[0, 0]));
                fi *= (MModel.CenterZVec.coor[2] > 0) ? (1) : (-1);
                op = new double[4, 4];
                op[3, 3] = 1;
                op[2, 2] = 1;
                op[0, 0] = Math.Cos(fi);
                op[1, 1] = Math.Cos(fi);
                op[0, 1] = -1 * Math.Sin(fi);
                op[1, 0] = Math.Sin(fi);
                temp = Matrixes.Multiply(temp, op);
                vecz = Matrixes.Multiply(vecz, op);
                vecy = Matrixes.Multiply(vecy, op);
                vecx = Matrixes.Multiply(vecx, op);

                fi = Math.Atan(-1 * (vecz[0, 0] / vecz[0, 2]));
                fi *= (vecz[0, 0] > 0) ? (-1) : (1);
                op = new double[4, 4];
                op[3, 3] = 1;
                op[1, 1] = 1;
                op[0, 0] = Math.Cos(fi);
                op[2, 2] = Math.Cos(fi);
                op[0, 2] = -1 * Math.Sin(fi);
                op[2, 0] = Math.Sin(fi);
                temp = Matrixes.Multiply(temp, op);
                vecz = Matrixes.Multiply(vecz, op);
                vecy = Matrixes.Multiply(vecy, op);
                vecx = Matrixes.Multiply(vecx, op);

                op = new double[4, 4];
                op[0, 0] = -1;
                op[1, 1] = -1;
                op[2, 2] = -1;
                op[3, 3] = 1;
                temp = Matrixes.Multiply(temp, op);
                vecz = Matrixes.Multiply(vecz, op);
                vecy = Matrixes.Multiply(vecy, op);
                vecx = Matrixes.Multiply(vecx, op);

                ///*
                fi = Math.Atan(-1 * (vecy[0, 0] / vecy[0, 1]));
                fi *= (vecy[0, 0] > 0) ? (-1) : (1);
                op = new double[4, 4];
                op[3, 3] = 1;
                op[2, 2] = 1;
                op[0, 0] = Math.Cos(fi);
                op[1, 1] = Math.Cos(fi);
                op[0, 1] = -1 * Math.Sin(fi);
                op[1, 0] = Math.Sin(fi);
                temp = Matrixes.Multiply(temp, op);
                vecz = Matrixes.Multiply(vecz, op);
                vecy = Matrixes.Multiply(vecy, op);
                vecx = Matrixes.Multiply(vecx, op);

                /*op = new double[4, 4];
                op[0, 0] = -1;
                op[1, 1] = 1;
                op[2, 2] = -1;
                op[3, 3] = 1;
                temp = Matrixes.Multiply(temp, op);
                vecz = Matrixes.Multiply(vecz, op);
                vecy = Matrixes.Multiply(vecy, op);
                vecx = Matrixes.Multiply(vecx, op);//*/

                if (vecz[0, 2] < 0 || Math.Abs(vecz[0,1])>0.001 || Math.Abs(vecz[0, 0]) > 0.001 || vecy[0, 1] < 0 || Math.Abs(vecy[0, 2]) > 0.001 || Math.Abs(vecy[0, 0]) > 0.001 || vecx[0,0] < 0 || Math.Abs(vecx[0, 1]) > 0.001 || Math.Abs(vecx[0, 2]) > 0.001)
                {
                   // Console.WriteLine();
                }

                for (j = 0; j < MModel.Figs[i].cells.Count; j++)
                {
                    temp[j, 0] += View.panel1.Width / 2;
                    temp[j, 1] += View.panel1.Height / 2;
                }

                for (j = 0; j < MModel.FigsSides[i].Count; j++)
                {
                    //if ((((temp[MModel.FigsSides[i][j][1], 0] - temp[MModel.FigsSides[i][j][0], 0]) * (temp[MModel.FigsSides[i][j][2], 1] - temp[MModel.FigsSides[i][j][0], 1])) - ((temp[MModel.FigsSides[i][j][1], 1] - temp[MModel.FigsSides[i][j][0], 1]) * (temp[MModel.FigsSides[i][j][2], 0] - temp[MModel.FigsSides[i][j][1], 0]))) >= 0 && Roberts)
                        //continue;
                    if (Roberts&&Geometry.IsRightFromLine(new MPoint(temp[MModel.FigsSides[i][j][0], 0], temp[MModel.FigsSides[i][j][0], 1]), new MPoint(temp[MModel.FigsSides[i][j][1], 0], temp[MModel.FigsSides[i][j][1], 1]), new MPoint(temp[MModel.FigsSides[i][j][2], 0], temp[MModel.FigsSides[i][j][2], 1])))
                    {
                        continue;
                    }
                    //if()
                    for (k = 0; k < MModel.FigsSides[i][j].Count-1; k++)
                    {
                        if(!(Roberts&&((temp[MModel.FigsSides[i][j][k], 2]<0)&&(temp[MModel.FigsSides[i][j][k+1], 2]<0))))
                            Cur.DrawLine(BlackPen, (int)temp[MModel.FigsSides[i][j][k], 0], (int)temp[MModel.FigsSides[i][j][k], 1], (int)temp[MModel.FigsSides[i][j][k+1], 0], (int)temp[MModel.FigsSides[i][j][k+1], 1]);
                    }
                    if (!(Roberts && ((temp[MModel.FigsSides[i][j][k], 2] < 0) && (temp[MModel.FigsSides[i][j][0], 2] < 0))))
                        Cur.DrawLine(BlackPen, (int)temp[MModel.FigsSides[i][j][k], 0], (int)temp[MModel.FigsSides[i][j][k], 1], (int)temp[MModel.FigsSides[i][j][0], 0], (int)temp[MModel.FigsSides[i][j][0], 1]);
                }
                // View.panel1.Refresh();


            }

             //////////

            for (i = 0; i < MModel.Planes.Count; i++)
            {
                temp = new double[MModel.Planes[i].cells.Count, 4];
                for (j = 0; j < MModel.Planes[i].cells.Count; j++)
                {
                    temp[j, 0] = MModel.Planes[i].cells[j].coor[0];
                    temp[j, 1] = MModel.Planes[i].cells[j].coor[1];
                    temp[j, 2] = MModel.Planes[i].cells[j].coor[2];
                    temp[j, 3] = MModel.Planes[i].cells[j].coor[3];
                }

                if (MModel.PlaneTypes[i] == "bez")
                {
                    temp = new double[8, 4];
                    int s =0;
                    int r,v;
                    double sum;
                    for (j = 0; j < 2; j++)
                    {
                        for (k = 0; k < 2; k++)
                        {
                            sum = 0;
                            for(v=0; v < MModel.Planes[i].cells.Count/MModel.PlanesAddINfo[i]; v++)
                            {
                                for(r=0; r < MModel.PlanesAddINfo[i]; r++)
                                {
                                    sum += Geometry.Bernstein(MModel.PlanesAddINfo[i], r, k * 1) * Geometry.Bernstein(MModel.Planes[i].cells.Count / MModel.PlanesAddINfo[i], v, j * 1) * MModel.Planes[i].cells[v * MModel.PlanesAddINfo[i] + r].coor[0];
                                }
                            }
                            temp[s,0] = sum;

                            sum = 0;
                            for (v = 0; v < MModel.Planes[i].cells.Count / MModel.PlanesAddINfo[i]; v++)
                            {
                                for (r = 0; r < MModel.PlanesAddINfo[i]; r++)
                                {
                                    sum += Geometry.Bernstein(MModel.PlanesAddINfo[i], r, k * 1) * Geometry.Bernstein(MModel.Planes[i].cells.Count / MModel.PlanesAddINfo[i], v, j * 1) * MModel.Planes[i].cells[v * MModel.PlanesAddINfo[i] + r].coor[1];
                                }
                            }
                            temp[s,1] = sum;

                            sum = 0;
                            for (v = 0; v < MModel.Planes[i].cells.Count / MModel.PlanesAddINfo[i]; v++)
                            {
                                for (r = 0; r < MModel.PlanesAddINfo[i]; r++)
                                {
                                    sum += Geometry.Bernstein(MModel.PlanesAddINfo[i], r, k * 1) * Geometry.Bernstein(MModel.Planes[i].cells.Count / MModel.PlanesAddINfo[i], v, j * 1) * MModel.Planes[i].cells[v * MModel.PlanesAddINfo[i] + r].coor[2];
                                }
                            }
                            temp[s,2] = sum;

                            temp[s,3] = 1;
                            s++;
                        }
                    }
                    for (j = 0; j < 2; j++)
                    {
                        for (k = 0; k < 2; k++)
                        {
                            sum = 0;
                            for (v = 0; v < MModel.Planes[i].cells.Count / MModel.PlanesAddINfo[i]; v++)
                            {
                                for (r = 0; r < MModel.PlanesAddINfo[i]; r++)
                                {
                                    sum += Geometry.Bernstein(MModel.PlanesAddINfo[i], r, k * 1) * Geometry.Bernstein(MModel.Planes[i].cells.Count / MModel.PlanesAddINfo[i], v, j * 1) * MModel.Planes[i].cells[v * MModel.PlanesAddINfo[i] + r].coor[0];
                                }
                            }
                            temp[s, 0] = sum;

                            sum = 0;
                            for (v = 0; v < MModel.Planes[i].cells.Count / MModel.PlanesAddINfo[i]; v++)
                            {
                                for (r = 0; r < MModel.PlanesAddINfo[i]; r++)
                                {
                                    sum += Geometry.Bernstein(MModel.PlanesAddINfo[i], r, k * 1) * Geometry.Bernstein(MModel.Planes[i].cells.Count / MModel.PlanesAddINfo[i], v, j * 1) * MModel.Planes[i].cells[v * MModel.PlanesAddINfo[i] + r].coor[1];
                                }
                            }
                            temp[s, 1] = sum;

                            sum = 0;
                            for (v = 0; v < MModel.Planes[i].cells.Count / MModel.PlanesAddINfo[i]; v++)
                            {
                                for (r = 0; r < MModel.PlanesAddINfo[i]; r++)
                                {
                                    sum += Geometry.Bernstein(MModel.PlanesAddINfo[i], r, k * 1) * Geometry.Bernstein(MModel.Planes[i].cells.Count / MModel.PlanesAddINfo[i], v, j * 1) * MModel.Planes[i].cells[v * MModel.PlanesAddINfo[i] + r].coor[2];
                                }
                            }
                            temp[s, 2] = sum;

                            temp[s, 3] = 1;
                            s++;
                        }
                    }
                }

                if (MModel.PlaneTypes[i] == "kuns")
                {
                    ////////////////////

                    double[,] Xmat = new double[4, 4], Ymat = new double[4, 4], Zmat = new double[4, 4];


                     Xmat[0, 0] = MModel.Planes[i].cells[0].coor[0];
                     Xmat[0, 1] = MModel.Planes[i].cells[1].coor[0];
                     Xmat[1, 0] = MModel.Planes[i].cells[2].coor[0];
                     Xmat[1, 1] = MModel.Planes[i].cells[3].coor[0];
                                 
                     Xmat[2, 0] = MModel.Planes[i].cells[4].coor[0];
                     Xmat[2, 1] = MModel.Planes[i].cells[5].coor[0];
                     Xmat[3, 0] = MModel.Planes[i].cells[6].coor[0];
                     Xmat[3, 1] = MModel.Planes[i].cells[7].coor[0];
                                 
                     Xmat[0, 2] = MModel.Planes[i].cells[8].coor[0];
                     Xmat[0, 3] = MModel.Planes[i].cells[9].coor[0];
                     Xmat[1, 2] = MModel.Planes[i].cells[10].coor[0];
                     Xmat[1, 3] = MModel.Planes[i].cells[11].coor[0];
                             
                     Xmat[2, 2] = MModel.Planes[i].cells[12].coor[0];
                     Xmat[2, 3] = MModel.Planes[i].cells[13].coor[0];
                     Xmat[3, 2] = MModel.Planes[i].cells[14].coor[0];
                     Xmat[3, 3] = MModel.Planes[i].cells[15].coor[0];
                     
                     //////

                     Ymat[0, 0] = MModel.Planes[i].cells[0].coor[1];
                     Ymat[0, 1] = MModel.Planes[i].cells[1].coor[1];
                     Ymat[1, 0] = MModel.Planes[i].cells[2].coor[1];
                     Ymat[1, 1] = MModel.Planes[i].cells[3].coor[1];

                     Ymat[2, 0] = MModel.Planes[i].cells[4].coor[1];
                     Ymat[2, 1] = MModel.Planes[i].cells[5].coor[1];
                     Ymat[3, 0] = MModel.Planes[i].cells[6].coor[1];
                     Ymat[3, 1] = MModel.Planes[i].cells[7].coor[1];

                     Ymat[0, 2] = MModel.Planes[i].cells[8].coor[1];
                     Ymat[0, 3] = MModel.Planes[i].cells[9].coor[1];
                     Ymat[1, 2] = MModel.Planes[i].cells[10].coor[1];
                     Ymat[1, 3] = MModel.Planes[i].cells[11].coor[1];

                     Ymat[2, 2] = MModel.Planes[i].cells[12].coor[1];
                     Ymat[2, 3] = MModel.Planes[i].cells[13].coor[1];
                     Ymat[3, 2] = MModel.Planes[i].cells[14].coor[1];
                     Ymat[3, 3] = MModel.Planes[i].cells[15].coor[1];
                     
                     ///////

                     Zmat[0, 0] = MModel.Planes[i].cells[0].coor[2];
                     Zmat[0, 1] = MModel.Planes[i].cells[1].coor[2];
                     Zmat[1, 0] = MModel.Planes[i].cells[2].coor[2];
                     Zmat[1, 1] = MModel.Planes[i].cells[3].coor[2];

                     Zmat[2, 0] = MModel.Planes[i].cells[4].coor[2];
                     Zmat[2, 1] = MModel.Planes[i].cells[5].coor[2];
                     Zmat[3, 0] = MModel.Planes[i].cells[6].coor[2];
                     Zmat[3, 1] = MModel.Planes[i].cells[7].coor[2];

                     Zmat[0, 2] = MModel.Planes[i].cells[8].coor[2];
                     Zmat[0, 3] = MModel.Planes[i].cells[9].coor[2];
                     Zmat[1, 2] = MModel.Planes[i].cells[10].coor[2];
                     Zmat[1, 3] = MModel.Planes[i].cells[11].coor[2];

                     Zmat[2, 2] = MModel.Planes[i].cells[12].coor[2];
                     Zmat[2, 3] = MModel.Planes[i].cells[13].coor[2];
                     Zmat[3, 2] = MModel.Planes[i].cells[14].coor[2];
                     Zmat[3, 3] = MModel.Planes[i].cells[15].coor[2];

                    ///////////
                    temp = new double[2000, 4];
                    double[] vault;
                    int s=0;
                    double u=0,v=0;
                    for(j=0; j <10; j++)
                    {
                        for (k = 0; k < 100; k++)
                        {
                            vault = Q(j*(0.125),k*(0.01),Xmat,Ymat,Zmat);
                            temp[s, 0] = vault[0];
                            temp[s, 1] = vault[1];
                            temp[s, 2] = vault[2];
                            s++;
                        }
                    }
                    for (j = 0; j < 10; j++)
                    {
                        for (k = 0; k < 100; k++)
                        {
                            vault = Q( k * (0.01),j * (0.125), Xmat, Ymat, Zmat);
                            temp[s, 0] = vault[0];
                            temp[s, 1] = vault[1];
                            temp[s, 2] = vault[2];
                            s++;
                        }
                    }
                }

                if (Persp)
                {
                    op = new double[4, 4];
                    op[0, 0] = 1;
                    op[1, 1] = 1;
                    op[2, 2] = 1;
                    op[3, 3] = 1;
                    op[0, 3] = 1 / PerspPar[0];
                    op[1, 3] = 1 / PerspPar[1];
                    op[2, 3] = 1 / PerspPar[2];
                    temp = Matrixes.Multiply(temp, op);
                    for (j = 0; j < MModel.Planes[i].cells.Count; j++)
                    {
                        temp[j, 0] /= temp[j, 3];
                        temp[j, 1] /= temp[j, 3];
                        temp[j, 2] /= temp[j, 3];
                        temp[j, 3] /= temp[j, 3];
                    }
                    // for()
                }

                if (Cosc)
                {
                    op = new double[4, 4];
                    op[0, 0] = 1;
                    op[1, 1] = 1;
                    op[2, 2] = 1;
                    op[3, 3] = 1;
                    op[2, 0] = CoscPar[1] * Math.Cos(CoscPar[0]);
                    op[2, 1] = -1 * CoscPar[1] * Math.Sin(CoscPar[0]);
                    temp = Matrixes.Multiply(temp, op);
                    // for()
                }

                for (j = 0; j < MModel.Planes[i].cells.Count; j++)
                {
                    temp[j, 0] -= MModel.Center.coor[0];
                    temp[j, 1] -= MModel.Center.coor[1];
                    temp[j, 2] -= MModel.Center.coor[2];
                }

                vecz[0, 0] = MModel.CenterZVec.coor[0];
                vecz[0, 1] = MModel.CenterZVec.coor[1];
                vecz[0, 2] = MModel.CenterZVec.coor[2];
                vecz[0, 3] = MModel.CenterZVec.coor[3];

                vecy[0, 0] = MModel.CenterYVec.coor[0];
                vecy[0, 1] = MModel.CenterYVec.coor[1];
                vecy[0, 2] = MModel.CenterYVec.coor[2];
                vecy[0, 3] = MModel.CenterYVec.coor[3];

                vecx[0, 0] = MModel.CenterXVec.coor[0];
                vecx[0, 1] = MModel.CenterXVec.coor[1];
                vecx[0, 2] = MModel.CenterXVec.coor[2];
                vecx[0, 3] = MModel.CenterXVec.coor[3];

                fi = Math.Atan(-1 * (vecz[0, 1] / vecz[0, 0]));
                fi *= (MModel.CenterZVec.coor[2] > 0) ? (1) : (-1);
                op = new double[4, 4];
                op[3, 3] = 1;
                op[2, 2] = 1;
                op[0, 0] = Math.Cos(fi);
                op[1, 1] = Math.Cos(fi);
                op[0, 1] = -1 * Math.Sin(fi);
                op[1, 0] = Math.Sin(fi);
                temp = Matrixes.Multiply(temp, op);
                vecz = Matrixes.Multiply(vecz, op);
                vecy = Matrixes.Multiply(vecy, op);
                vecx = Matrixes.Multiply(vecx, op);

                fi = Math.Atan(-1 * (vecz[0, 0] / vecz[0, 2]));
                fi *= (vecz[0, 0] > 0) ? (-1) : (1);
                op = new double[4, 4];
                op[3, 3] = 1;
                op[1, 1] = 1;
                op[0, 0] = Math.Cos(fi);
                op[2, 2] = Math.Cos(fi);
                op[0, 2] = -1 * Math.Sin(fi);
                op[2, 0] = Math.Sin(fi);
                temp = Matrixes.Multiply(temp, op);
                vecz = Matrixes.Multiply(vecz, op);
                vecy = Matrixes.Multiply(vecy, op);
                vecx = Matrixes.Multiply(vecx, op);

                op = new double[4, 4];
                op[0, 0] = -1;
                op[1, 1] = -1;
                op[2, 2] = -1;
                op[3, 3] = 1;
                temp = Matrixes.Multiply(temp, op);
                vecz = Matrixes.Multiply(vecz, op);
                vecy = Matrixes.Multiply(vecy, op);
                vecx = Matrixes.Multiply(vecx, op);

                ///*
                fi = Math.Atan(-1 * (vecy[0, 0] / vecy[0, 1]));
                fi *= (vecy[0, 0] > 0) ? (-1) : (1);
                op = new double[4, 4];
                op[3, 3] = 1;
                op[2, 2] = 1;
                op[0, 0] = Math.Cos(fi);
                op[1, 1] = Math.Cos(fi);
                op[0, 1] = -1 * Math.Sin(fi);
                op[1, 0] = Math.Sin(fi);
                temp = Matrixes.Multiply(temp, op);
                vecz = Matrixes.Multiply(vecz, op);
                vecy = Matrixes.Multiply(vecy, op);
                vecx = Matrixes.Multiply(vecx, op);

                /*op = new double[4, 4];
                op[0, 0] = -1;
                op[1, 1] = 1;
                op[2, 2] = -1;
                op[3, 3] = 1;
                temp = Matrixes.Multiply(temp, op);
                vecz = Matrixes.Multiply(vecz, op);
                vecy = Matrixes.Multiply(vecy, op);
                vecx = Matrixes.Multiply(vecx, op);//*/

                if (vecz[0, 2] < 0 || Math.Abs(vecz[0, 1]) > 0.001 || Math.Abs(vecz[0, 0]) > 0.001 || vecy[0, 1] < 0 || Math.Abs(vecy[0, 2]) > 0.001 || Math.Abs(vecy[0, 0]) > 0.001 || vecx[0, 0] < 0 || Math.Abs(vecx[0, 1]) > 0.001 || Math.Abs(vecx[0, 2]) > 0.001)
                {
                    // Console.WriteLine();
                }

                for (j = 0; j < temp.Length/4; j++)
                {
                    temp[j, 0] += View.panel1.Width / 2;
                    temp[j, 1] += View.panel1.Height / 2;
                }

                for (j = 0; j < temp.Length / 4; j++)
                {
                    Cur.DrawEllipse(BlackPen, (int)temp[j, 0] - 1, (int)temp[j, 1] - 1, 2, 2);
                    //if ((((temp[MModel.FigsSides[i][j][1], 0] - temp[MModel.FigsSides[i][j][0], 0]) * (temp[MModel.FigsSides[i][j][2], 1] - temp[MModel.FigsSides[i][j][0], 1])) - ((temp[MModel.FigsSides[i][j][1], 1] - temp[MModel.FigsSides[i][j][0], 1]) * (temp[MModel.FigsSides[i][j][2], 0] - temp[MModel.FigsSides[i][j][1], 0]))) >= 0 && Roberts)
                    //continue;
                    //if()
                }
                // View.panel1.Refresh();


            }
        }
    }

}
