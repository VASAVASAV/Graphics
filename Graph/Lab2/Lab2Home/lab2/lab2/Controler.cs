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

        public void DrawAll()
        {
            Pen GreenPen = new Pen(Color.Green,5);
            Graphics Cur = View.panel1.CreateGraphics();
            Cur.Clear(Color.White);
            //Cur.DrawLine(GreenPen, 10, 10, 100, 100);
           // return;
            int i, j, k;
            double fi;
            double[,] temp;  
            double[,] E = new double[4,4];
            E[0, 0] = 1;
            E[1, 1] = 1;
            E[2, 2] = 1;
            E[3, 3] = 1;
            double[,] op = new double[4, 4];
            double[,] vec = new double[1, 4];
            for (i = 0; i < MModel.Lines.Count; i++)
            {
                temp = new double[MModel.Lines[i].cells.Count, 4];
                for (j = 0; j < MModel.Lines[i].cells.Count; j++)
                {
                    temp[j, 0] = MModel.Lines[i].cells[j].coor[0] - MModel.Center.coor[0];
                    temp[j, 1] = MModel.Lines[i].cells[j].coor[1] - MModel.Center.coor[1];
                    temp[j, 2] = MModel.Lines[i].cells[j].coor[2] - MModel.Center.coor[2];
                    temp[j, 3] = MModel.Lines[i].cells[j].coor[3];
                }
                vec[0, 0] = MModel.CenterVec.coor[0];
                vec[0, 1] = MModel.CenterVec.coor[1];
                vec[0, 2] = MModel.CenterVec.coor[2];
                vec[0, 3] = MModel.CenterVec.coor[3];
                fi = Math.Atan(-1 * (vec[0, 1] / vec[0, 0]));
                fi*=(MModel.CenterVec.coor[2]>0)?(1):(-1);
                op = new double[4, 4];
                op[3, 3] = 1;
                op[2, 2] = 1;
                op[0, 0] = Math.Cos(fi);
                op[1, 1] = Math.Cos(fi);
                op[0, 1] = -1*Math.Sin(fi);
                op[1, 0] = Math.Sin(fi);
                temp = Matrixes.Multiply(temp, op);
                vec = Matrixes.Multiply(vec, op);
                fi = Math.Atan(-1*(vec[0, 0] / vec[0, 2]));
                fi *= (vec[0,0] > 0) ? (-1) : (1);
                op = new double[4, 4];
                op[3, 3] = 1;
                op[1, 1] = 1;
                op[0, 0] = Math.Cos(fi);
                op[2, 2] = Math.Cos(fi);
                op[0, 2] = -1*Math.Sin(fi);
                op[2, 0] = Math.Sin(fi);
                temp = Matrixes.Multiply(temp, op);
                vec = Matrixes.Multiply(vec, op);
                op = new double[4, 4];
                op[0, 0] = 1;
                op[1, 1] = 1;
                op[2, 2] = -1;
                op[3, 3] = 1;
                temp = Matrixes.Multiply(temp, op);
                vec = Matrixes.Multiply(vec, op);
                for (j = 0; j < MModel.Lines[i].cells.Count; j++)
                {
                    temp[j, 0] += View.panel1.Width/2;
                    temp[j, 1] += View.panel1.Height/2;
                }
                for (j = 1; j < MModel.Lines[i].cells.Count; j++)
                {
                    Cur.DrawLine(GreenPen, (int)temp[j - 1, 0], (int)temp[j - 1, 1], (int)temp[j, 0], (int)temp[j, 1]);
                }
               // View.panel1.Refresh();


            }
        }
    }

}
