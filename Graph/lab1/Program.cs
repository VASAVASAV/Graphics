using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Lab1
{
    
    class MyProg : Form
    {
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private PictureBox pictureBox1;
        Point center = new Point(0, 0);
        Pen PentoUse = new Pen(Color.Red,2);
        Pen CenterPen = new Pen(Color.Black,4);
        Pen OldPen = new Pen(Color.Blue,2);
        Pen ToolPen = new Pen(Color.Green, 3);
        bool isMoving = false;
        Point StartMove;
        DateTime temp = DateTime.Now;

        List<ObjTWW> figs = new List<ObjTWW>();
        private Button button2;
        Graphics Pictgraph;
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(690, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Контроль";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Малюй";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Очистити поле";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 482);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Робоче поле";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 456);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // MyProg
            // 
            this.ClientSize = new System.Drawing.Size(921, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyProg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        public void DisplayAll()
        {
            Pictgraph.Clear(pictureBox1.BackColor);
            int i, j;
            for (i = 0; i < figs.Count; i++)
            {
                if (figs[i].ps.Length == 1)
                {
                    Pictgraph.DrawLine(PentoUse, figs[i].ps[0].X - 1, figs[i].ps[0].Y + 1, figs[i].ps[0].X + 1, figs[i].ps[0].Y - 1);
                    Pictgraph.DrawLine(PentoUse, figs[i].ps[0].X - 1, figs[i].ps[0].Y - 1, figs[i].ps[0].X + 1, figs[i].ps[0].Y + 1);
                }
                else
                {
                    for (j = 0; j < figs[i].ps.Length - 1; j++)
                    {
                        Pictgraph.DrawLines(PentoUse, figs[i].ps);
                    }
                    if (figs[i].cycled == true)
                    {
                        Pictgraph.DrawLine(PentoUse, figs[i].ps[0], figs[i].ps[figs[i].ps.Length-1]);
                    }
                }
            }
            Pictgraph.DrawLine(CenterPen, center.X - 15, center.Y, center.X + 15, center.Y);
            Pictgraph.DrawLine(CenterPen, center.X, center.Y - 15, center.X, center.Y + 15);
        }
        public MyProg()
        {
            InitializeComponent();
            Pictgraph = pictureBox1.CreateGraphics();
            figs.Add(new ObjTWW(new Point[] { new Point(5, 5), new Point(205, 205), new Point(15, 205) },true));
        }
        private void Move(int xarg, int yarg)
        {
            center.X -= xarg;
            center.Y -= yarg;
            int i;
            for (i = 0; i < figs.Count; i++)
            {
                figs[i].Move(xarg,yarg);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            figs.Clear();
            center.X = 0;
            center.Y = 0;
            DisplayAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayAll();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            StartMove = e.Location;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            isMoving = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                if ((DateTime.Now - temp).TotalMilliseconds>75)
                {
                    DisplayAll();
                    Pictgraph.DrawLine(ToolPen,e.Location,StartMove );
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
            Move(StartMove.X - e.X, StartMove.Y - e.Y);
            DisplayAll();
        }
    }
    class ObjTWW
    {
        public Point[] ps;
        public bool cycled = false;
        public ObjTWW()
        {
            ps = new Point[0];
        }
        public ObjTWW(int x, int y)
        {
            ps = new Point[] { new Point(x, y) };
        }
        public ObjTWW(Point[] targ)
        {
            ps = targ;
        }
        public ObjTWW(Point[] targ, bool needsCycle)
        {
            cycled = needsCycle;
            ps = targ;
        }
        public void Move(int xm, int ym)
        {
            for (int i = 0; i < ps.Length; i++)
            {
                ps[i].X -= xm;
                ps[i].Y -= ym;
            }
        }
    }
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyProg Prog = new MyProg();
            Application.Run(Prog);
        }
    }
}
