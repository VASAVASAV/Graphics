using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        }

        public void DrawAll()
        {
            int i, j, k;
            double[,] temp;
            double[,] op = new double[4,4];
            for (i = 0; i < MModel.Lines.Count; i++)
            {
                temp = new double[MModel.Lines[i].cells.Count, 4];
                for (j = 0; j < MModel.Lines[i].cells.Count; j++)
                {
                    temp[i, 0] = MModel.Lines[i].cells[i].coor[0] - MModel.Center.coor[0];
                    temp[i, 1] = MModel.Lines[i].cells[i].coor[1] - MModel.Center.coor[1];
                    temp[i, 2] = MModel.Lines[i].cells[i].coor[2] - MModel.Center.coor[2];
                    temp[i, 3] = MModel.Lines[i].cells[i].coor[3];
                }
                


            }
        }
    }

}
