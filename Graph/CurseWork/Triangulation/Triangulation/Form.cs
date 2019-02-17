using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Triangulation
{
    class MyProg : Form
    {
        private Panel panel1;
        private Button button1;
        private Button button2;
        List<MPoint> Points;
        List<Triangle> Triangles;
        List<Edge> Edges;
        private TextBox textBox2;
        Pen RedPen;
        Pen BluePen;
        private Label label1;
        private TextBox textBox1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox textBox3;
        private Label label2;
        private Button button3;

        public MyProg()
        {
            RedPen = new Pen(Color.FromName("Red"), 3f);
            BluePen = new Pen(Color.FromName("Blue"), 3f);
            InitializeComponent();
            Points = new List<MPoint>();
            Triangles = new List<Triangle>();
            Edges = new List<Edge>();
            panel1.Paint += PaintingLines;
        }
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 588);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(807, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Очистити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(807, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(367, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Оновити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(807, 243);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(367, 282);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(889, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Додати певну кількість випадкових точок";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(954, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(807, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(367, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Додати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(807, 531);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(367, 34);
            this.button4.TabIndex = 10;
            this.button4.Text = "Зберегти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(807, 571);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(365, 34);
            this.button5.TabIndex = 9;
            this.button5.Text = "Відкрити";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(807, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 34);
            this.button6.TabIndex = 11;
            this.button6.Text = "Тест (триангуляція)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(997, 52);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(177, 34);
            this.button7.TabIndex = 12;
            this.button7.Text = "Тест(малювання)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(997, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(906, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "кількість тестів";
            // 
            // MyProg
            // 
            this.ClientSize = new System.Drawing.Size(1184, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "MyProg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void PaintingLines(object sender, PaintEventArgs e)
        {
            DateTime point = DateTime.Now;
            Graphics MyGraphics = e.Graphics;
            MyGraphics.Clear((sender as Panel).BackColor);
            for (int i = 0; i < Points.Count; i++)
            {
                MyGraphics.DrawRectangle(RedPen, (int)Points[i].X-1, (int)Points[i].Y-1, 3, 3);
            }
            for (int i = 0; i < Edges.Count; i++)
            {
                MyGraphics.DrawLine(BluePen, (int)Edges[i].StartP.X, (int)Edges[i].StartP.Y, (int)Edges[i].EndP.X, (int)Edges[i].EndP.Y);
            }
          //  textBox2.Text += (DateTime.Now - point).TotalMilliseconds + Environment.NewLine;
        }

        void Triangulate()
        {
            int i,j,k;
            if (Points.Count < 2)
            {
                panel1.Invalidate();
                return;
            }
            MPoint First = Points[0];
            for (i = 1; i < Points.Count; i++)
            {
                if (Points[i].X < First.X)
                {
                    First = Points[i];
                }
            }
            lol:
            for (i = 0; i < Points.Count-1; i++)
            {
                for (j = i+1; j < Points.Count; j++)
                {
                    if (Points[i] == Points[j]) 
                    {
                        Points.RemoveAt(j);
                        goto lol;
                    }
                }
            }
            double CurAngle = double.MaxValue;
            Edge FirstEdge;
            if (Points[0] == First)
            {
                FirstEdge = new Edge(First, Points[1]);
            }
            else
            {
                FirstEdge = new Edge(First, Points[0]);
            }
            for (i = 0; i < Points.Count; i++)
            {
                if (Points[i] == FirstEdge.EndP)
                {
                    continue;
                }
                if (Geometry.IsRightFromLine(FirstEdge,Points[i]))
                {
                    FirstEdge.EndP = Points[i];
                }
            }
            List<Edge> ActiveEdges = new List<Edge>();
            ActiveEdges.Add(FirstEdge);
            List<MPoint> FreePoints = new List<MPoint>();
            for (i = 0; i < Points.Count; i++)
            {
                if (Points[i] != FirstEdge.StartP && Points[i] != FirstEdge.EndP)
                {
                    FreePoints.Add(Points[i]);
                }
            }
            MPoint Target;
            bool GoodPoint = true; 
            Edge NewEdge;
            Edges.Clear();
            Edges.Add(FirstEdge);
            DateTime point = DateTime.Now;
            while (ActiveEdges.Count>0||FreePoints.Count>0)
            {
                Target = null;
                for (i = 0; i < FreePoints.Count; i++)
                {
                    GoodPoint = true;//checking activeedges[0] and freepoints[i] for being able to create good triangle            
                    for(j=0; j <Points.Count;j++ )
                    {
                        if (Points[j].IsInsideOfCircle(ActiveEdges[0].StartP, ActiveEdges[0].EndP, FreePoints[i]))
                        {
                            GoodPoint = false;
                            break;
                        }
                    }
                    if (GoodPoint)
                    {
                        Edges.Add(new Edge(ActiveEdges[0].StartP, FreePoints[i]));
                        Edges.Add(new Edge(ActiveEdges[0].EndP, FreePoints[i]));
                        ActiveEdges.Add(Edges[Edges.Count - 2]);
                        ActiveEdges.Add(Edges[Edges.Count - 1]);
                        //ActiveEdges.RemoveAt(0);
                        for (j = 1; j < ActiveEdges.Count; j++)
                        {
                            GoodPoint = true;
                            if (ActiveEdges[j].EndP == FreePoints[i] || ActiveEdges[j].StartP == FreePoints[i])
                            {
                                continue;
                            }
                            for (k = 0; k < Points.Count; k++)
                            {
                                if (Points[k].IsInsideOfCircle(ActiveEdges[j].StartP, ActiveEdges[j].EndP, FreePoints[i]))
                                {
                                    GoodPoint = false;
                                    break;
                                }
                            }
                            if (GoodPoint)
                            {
                                Edges.Add(new Edge(ActiveEdges[j].StartP, FreePoints[i]));
                                Edges.Add(new Edge(ActiveEdges[j].EndP, FreePoints[i]));
                                ActiveEdges.Add(Edges[Edges.Count - 2]);
                                ActiveEdges.Add(Edges[Edges.Count - 1]);
                                ActiveEdges.RemoveAt(j);
                                j--;
                            }
                        }
                        FreePoints.RemoveAt(i);
                        break;
                    }
                }
                if (!GoodPoint && FreePoints.Count!=0) // if activedeges[0] cant create triagnels, but theres still points to add, ve move it to the end of list
                {
                    ActiveEdges.Add(ActiveEdges[0]);
                }
                ActiveEdges.RemoveAt(0);
                start:
                for (i = 0; i < ActiveEdges.Count; i++)
                {
                    for (j = i+1; j < ActiveEdges.Count; j++)
                    {
                        if (((ActiveEdges[i].StartP == ActiveEdges[j].EndP) && (ActiveEdges[i].EndP == ActiveEdges[j].StartP)) || ((ActiveEdges[i].StartP == ActiveEdges[j].StartP) && (ActiveEdges[i].EndP == ActiveEdges[j].EndP)))
                        {
                            ActiveEdges.RemoveAt(j);
                            goto start;
                        }
                    }
                }
              /*  for (i = 0; i < Edges.Count; i++)
                {
                    for (j = i + 1; j < Edges.Count; j++)
                    {
                        if (((Edges[i].StartP == Edges[j].EndP) && (Edges[i].EndP == Edges[j].StartP)) || ((Edges[i].StartP == Edges[j].StartP) && (Edges[i].EndP == Edges[j].EndP)))
                        {
                            Edges.RemoveAt(j);
                            j--;
                        }
                    }
                }*/
                NiceWork :
                for (i = 0; i < ActiveEdges.Count; i++)
                {
                    for (j = i + 1; j < ActiveEdges.Count; j++)
                    {
                        if ((ActiveEdges[i].StartP == ActiveEdges[j].EndP) || (ActiveEdges[i].EndP == ActiveEdges[j].StartP) || (ActiveEdges[i].StartP == ActiveEdges[j].StartP) || (ActiveEdges[i].EndP == ActiveEdges[j].EndP))
                        {
                            MPoint Same = new MPoint(), xi1 = new MPoint(), xi2 = new MPoint();
                            if (ActiveEdges[i].StartP == ActiveEdges[j].EndP)
                            {
                                Same = ActiveEdges[i].StartP;
                                xi1 = ActiveEdges[i].EndP;
                                xi2 = ActiveEdges[j].StartP;
                            }
                            if (ActiveEdges[i].StartP == ActiveEdges[j].StartP)
                            {
                                Same = ActiveEdges[i].StartP;
                                xi1 = ActiveEdges[i].EndP;
                                xi2 = ActiveEdges[j].EndP;
                            }
                            if (ActiveEdges[i].EndP == ActiveEdges[j].EndP)
                            {
                                Same = ActiveEdges[i].EndP;
                                xi1 = ActiveEdges[i].StartP;
                                xi2 = ActiveEdges[j].StartP;
                            }
                            if (ActiveEdges[i].EndP == ActiveEdges[j].StartP)
                            {
                                Same = ActiveEdges[i].EndP;
                                xi1 = ActiveEdges[i].StartP;
                                xi2 = ActiveEdges[j].EndP;
                            }
                            GoodPoint = true;
                            for(k=0; k <Points.Count;k++ )
                            {
                                if (Points[k].IsInsideOfCircle(Same, xi1, xi2))
                                {
                                    GoodPoint = false;
                                    break;
                                }
                            }
                            for(k=0; k <Edges.Count;k++ )
                            {
                                if((Edges[k].StartP == xi1 && Edges[k].EndP == xi2) || (Edges[k].EndP == xi1 && Edges[k].StartP == xi2))
                                {
                                     GoodPoint = false;
                                    break;
                                }
                            }
                            if (GoodPoint)
                            {
                                Edges.Add(new Edge(xi1,xi2));
                                ActiveEdges.Add(Edges[Edges.Count-1]);
                                ActiveEdges.RemoveAt(i);
                                ActiveEdges.RemoveAt(j-1);
                                goto NiceWork;
                            }

                        }
                    }
                }
            }
            //textBox2.Text += "Time of work = " + (DateTime.Now - point).TotalMilliseconds + "ms" +Environment.NewLine;
            //textBox2.Text += (DateTime.Now - point).TotalMilliseconds + Environment.NewLine;
           /* lil:
            for (i = 0; i < Edges.Count; i++)
            {
                for (j = i + 1; j < Edges.Count; j++)
                {
                    if (((Edges[i].StartP == Edges[j].EndP) && (Edges[i].EndP == Edges[j].StartP)) || ((Edges[i].StartP == Edges[j].StartP) && (Edges[i].EndP == Edges[j].EndP)))
                    {
                        Edges.RemoveAt(j);
                        goto lil;
                    }
                }
            }*/
            //textBox2.Text += "Time of work with additional delete= " + (DateTime.Now - point).TotalMilliseconds + "ms" + Environment.NewLine;
            textBox2.Text += (DateTime.Now - point).TotalMilliseconds + Environment.NewLine;
            int [] Counter = new int[Points.Count];
            for (i = 0; i < Edges.Count; i++)
            {
                Counter[Edges[i].EndP.Number - 1]++;
                Counter[Edges[i].StartP.Number - 1]++;
            }
            for (i = 0; i < Points.Count;i++ )
            {
                if (Counter[i] < 2)
                {
                   // textBox2.Text += "Aaaaaaaaaaaa";
                }
            }
             panel1.Invalidate();
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            Points = new List<MPoint>();
            Triangles = new List<Triangle>();
            Edges = new List<Edge>();
            panel1.Invalidate();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x, y;
            x = e.X;
            y = e.Y;
            Points.Add(new MPoint(e.X,e.Y,Points.Count+1));
            Triangulate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Triangulate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Number;
            try
            {
                Number = Convert.ToInt32(textBox1.Text);
                if(Number<0 || Number > 1000)
                {
                    throw new Exception();
                }
            }
            catch
            {
                textBox2.Text += "wrong";
                return;
            }
            
            Random A = new Random();
            for (int i = 0; i < Number; i++)
            {
                Points.Add(new MPoint(A.Next(panel1.Width - 5), A.Next(panel1.Height - 5),Points.Count+1));
            }
            Triangulate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Points.Count <= 0)
            {
                return;
            }
            // Stream myStream;
            SaveFileDialog savingFileDialog = new SaveFileDialog();
            savingFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            savingFileDialog.FilterIndex = 2;
            savingFileDialog.RestoreDirectory = true;
            savingFileDialog.RestoreDirectory = true;
            if (savingFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter FileToWrite = new System.IO.StreamWriter(savingFileDialog.FileName, true))
                {
                    for (int i = 0; i < Points.Count; i++)
                    {
                        FileToWrite.Write("" + Points[i].X);
                        FileToWrite.Write(" ");
                        FileToWrite.WriteLine("" + Points[i].Y);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpeningDialog = new OpenFileDialog();
            bool Mistaken = false;
            OpeningDialog.InitialDirectory = Application.StartupPath.ToString();
            OpeningDialog.Filter = "txt files (*.txt)|*.txt| dat files (*.dat)|*.dat";
            OpeningDialog.FilterIndex = 1;
            OpeningDialog.RestoreDirectory = true;

            if (OpeningDialog.ShowDialog() == DialogResult.OK)
            {
                Points.Clear();
                try
                {
                    string[] FileLikeStrings = File.ReadAllLines(OpeningDialog.FileName);
                    char[] separators = new char[] { ' ', '\t', '\n' };
                    string[] valuesInLine;
                    int j;
                    double x, y;
                    for (int i = 0; i < FileLikeStrings.Length; i++)
                    {
                        valuesInLine = FileLikeStrings[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        Mistaken = false;
                        try
                        {
                            x = Convert.ToDouble(valuesInLine[0]);
                            y = Convert.ToDouble(valuesInLine[1]);
                            Points.Add(new MPoint(x, y));
                        }
                        catch
                        {
 
                        }
                    }
                }
                catch (Exception ExThatOccured)
                {
                    textBox2.Text += ("Error happened while reading the file. Original error: " + ExThatOccured.Message + Environment.NewLine);
                    textBox2.Text += "Maybe, youve tried to open not two dementional file" + Environment.NewLine;
                }
            }
            Triangulate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int Num;
            try
            {
                Num = Convert.ToInt32(textBox3.Text);
            }
            catch
            {
                return;
            }
            for (int i = 0; i < Num; i++)
            {
                Triangulate();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int Num;
            try
            {
                Num = Convert.ToInt32(textBox3.Text);
            }
            catch
            {
                return;
            }
            for (int i = 0; i < Num; i++)
            {
                panel1.Refresh();
            }
        }
    }
}
