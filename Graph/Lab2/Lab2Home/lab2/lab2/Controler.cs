using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

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

        public void DrawAll()
        {
            Pen BlackPen = new Pen(Color.Black, 5);
            Pen RedXPen = new Pen(Color.Red, 4);
            Pen BlueYPen = new Pen(Color.Blue, 4);
            Pen GreenZPen = new Pen(Color.Green, 4);
            Pen RedDarkXPen = new Pen(Color.DarkRed, 4);
            Pen BlueDarkYPen = new Pen(Color.DarkBlue, 4);
            Pen GreenDarkZPen = new Pen(Color.DarkSeaGreen, 4);
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

                for (j = 0; j < MModel.Lines[i].cells.Count; j++)
                {
                    temp[j, 0] += View.panel1.Width / 2;
                    temp[j, 1] += View.panel1.Height / 2;
                }

                for (j = 1; j < MModel.Lines[i].cells.Count; j++)
                {
                    //if(temp[j - 1,2]>0 &&temp[j,2]>0)
                    Cur.DrawLine(BlackPen, (int)temp[j - 1, 0], (int)temp[j - 1, 1], (int)temp[j, 0], (int)temp[j, 1]);
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
                    Console.WriteLine();
                }

                for (j = 0; j < MModel.Figs[i].cells.Count; j++)
                {
                    temp[j, 0] += View.panel1.Width / 2;
                    temp[j, 1] += View.panel1.Height / 2;
                }

                for (j = 0; j < MModel.FigsSides[i].Count; j++)
                {
                    if ((((temp[MModel.FigsSides[i][j][1], 0] - temp[MModel.FigsSides[i][j][0], 0]) * (temp[MModel.FigsSides[i][j][2], 1] - temp[MModel.FigsSides[i][j][0], 1])) - ((temp[MModel.FigsSides[i][j][1], 1] - temp[MModel.FigsSides[i][j][0], 1]) * (temp[MModel.FigsSides[i][j][2], 0] - temp[MModel.FigsSides[i][j][1], 0]))) >= 0 && Roberts)
                        continue;
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
        }
    }

}
