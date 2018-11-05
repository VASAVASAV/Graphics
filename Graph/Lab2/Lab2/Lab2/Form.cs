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
        private GroupBox groupBox2;
    
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 637);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Робоче поле";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(747, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 637);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Контроль";
            // 
            // mainForm
            // 
            this.ClientSize = new System.Drawing.Size(1084, 662);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "mainForm";
            this.ResumeLayout(false);

        }

        public mainForm()
        {
            InitializeComponent();
        }
    }
}
