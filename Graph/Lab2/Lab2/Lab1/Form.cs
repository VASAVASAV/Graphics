using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Lab2
{
    class mainForm : Form
    {
        private GroupBox groupBox1;
        private Panel PanelFor2d;
        private GroupBox groupBox2;
    
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PanelFor2d = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 648);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Робоче поле";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PanelFor2d);
            this.groupBox2.Location = new System.Drawing.Point(817, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 649);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Контроль";
            // 
            // PanelFor2d
            // 
            this.PanelFor2d.Location = new System.Drawing.Point(6, 19);
            this.PanelFor2d.Name = "PanelFor2d";
            this.PanelFor2d.Size = new System.Drawing.Size(340, 624);
            this.PanelFor2d.TabIndex = 0;
            // 
            // mainForm
            // 
            this.ClientSize = new System.Drawing.Size(1181, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "mainForm";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public mainForm()
        {
            InitializeComponent();
        }
    }
}
