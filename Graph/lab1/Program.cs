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
        Pen PentoUse = new Pen(Color.Red);
        Pen CenterPen = new Pen(Color.Black);
        Pen OldPen = new Pen(Color.Blue);

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
                for (j = 0; j < figs[i].ps.Length; j++)
                {
                    Pictgraph.DrawLine(PentoUse, figs[i].ps[j].X - 1, figs[i].ps[j].Y - 1, figs[i].ps[j].X + 1, figs[i].ps[j].Y + 1);
                    Pictgraph.DrawLine(PentoUse, figs[i].ps[j].X - 1, figs[i].ps[j].Y + 1, figs[i].ps[j].X + 1, figs[i].ps[j].Y - 1);
                }
            }
        }
        public MyProg()
        {
            InitializeComponent();
            Pictgraph = pictureBox1.CreateGraphics();
            figs.Add(new ObjTWW(new Point[] { new Point(5, 5), new Point(205, 205) }));
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
