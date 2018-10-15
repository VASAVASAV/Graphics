using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Numerics;

namespace Lab1
{
    
    class MyProg : Form
    {
        List<TabPage> TempList = new List<TabPage>();
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
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Button button3;
        private Label label4;
        private Label label1;
        private TabPage tabPage2;
        private Button button5;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox8;
        private Label label2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button button8;
        private Button button7;
        private Button button6;
        private TextBox textBox11;
        private TextBox textBox9;
        private TextBox textBox7;
        private Label label15;
        private Label label14;
        private Label label12;
        private Label label3;
        private DataGridView dataGridView1;
        private CheckBox checkBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox textBox10;
        private RadioButton radioButton3;
        private TabPage tabPage3;
        Graphics Pictgraph;
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(763, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 565);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Контроль";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(143, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "Розтяг";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(253, 340);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(245, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Рух";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Рух";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Пересунути";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Рух по у";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рух по х";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(245, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поворот";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 41);
            this.button5.TabIndex = 23;
            this.button5.Text = "Повернути";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 197);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 22;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 158);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 21;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(13, 40);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "у точки повороту";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "х точки повороту";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Поворот";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Повертати відосно точки:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Кут повороту";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.textBox11);
            this.tabPage4.Controls.Add(this.textBox9);
            this.tabPage4.Controls.Add(this.textBox7);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(245, 314);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Відзеркалення";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(15, 246);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(217, 53);
            this.button8.TabIndex = 10;
            this.button8.Text = "Стерти пряму задану 2 точками";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 187);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(217, 53);
            this.button7.TabIndex = 9;
            this.button7.Text = "Відзеркалити відносно прямої заданої двома точками";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 128);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(217, 53);
            this.button6.TabIndex = 8;
            this.button6.Text = "Відзеркалити відносно заданої прямої заданої рівнянням";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(32, 89);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 7;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(32, 63);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(32, 37);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "С";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "В";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "А";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Відносно прямої заданої рівнянням";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Controls.Add(this.checkBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(245, 314);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Фігура";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(4, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(238, 274);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Х";
            this.Column1.Name = "Column1";
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "У";
            this.Column2.Name = "Column2";
            this.Column2.Width = 90;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(4, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Замкнена";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(245, 314);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Розтяг";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 89);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(60, 17);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.Text = "Фігура";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 66);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(100, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.Text = "Відзеркалення";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Поворот";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Рух";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Малюй";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Очистити поле";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 620);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Робоче поле";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(732, 594);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(763, 577);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(266, 49);
            this.textBox10.TabIndex = 2;
            // 
            // MyProg
            // 
            this.ClientSize = new System.Drawing.Size(1041, 644);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyProg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
            while (tabControl1.Controls.Count != 0)
            {
                TempList.Add(tabControl1.Controls[0] as TabPage);
                tabControl1.Controls.RemoveAt(0);
            }
            dataGridView1.AllowUserToAddRows = true;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                tabControl1.Controls.Clear();
                tabControl1.Controls.Add(TempList[0]);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                tabControl1.Controls.Clear();
                tabControl1.Controls.Add(TempList[1]);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                tabControl1.Controls.Clear();
                tabControl1.Controls.Add(TempList[2]);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                tabControl1.Controls.Clear();
                tabControl1.Controls.Add(TempList[3]);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                tabControl1.Controls.Clear();
                tabControl1.Controls.Add(TempList[4]);
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            figs.Clear();
            double[,] ArrToSave = new double[dataGridView1.Rows.Count - 1, 2];
            try
            {
                for(int i=0; i < dataGridView1.Rows.Count-1; i++)
                {
                    ArrToSave[i, 0] = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                    ArrToSave[i, 1] = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                }
            }
            catch
            {
                textBox10.Text = "Фігура введена невірно";
                return;
            }
            figs.Add(new ObjTWW(ArrToSave,checkBox1.Checked));
            DisplayAll();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            figs.Clear();
            double[,] ArrToSave = new double[dataGridView1.Rows.Count - 1, 2];
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    ArrToSave[i, 0] = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                    ArrToSave[i, 1] = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                }
            }
            catch
            {
                textBox10.Text = "Фігура введена невірно";
                return;
            }
            figs.Add(new ObjTWW(ArrToSave, checkBox1.Checked));
            DisplayAll();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            figs.Clear();
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            double[,] ArrToSave = new double[dataGridView1.Rows.Count-1, 2];
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    ArrToSave[i, 0] = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                    ArrToSave[i, 1] = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                }
            }
            catch
            {
                textBox10.Text = "Фігура введена невірно";
                return;
            }
            figs.Add(new ObjTWW(ArrToSave, checkBox1.Checked));
            DisplayAll();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            figs.Clear();
            double[,] ArrToSave = new double[dataGridView1.Rows.Count - 1, 2];
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    ArrToSave[i, 0] = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                    ArrToSave[i, 1] = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                }
            }
            catch
            {
                textBox10.Text = "Фігура введена невірно";
                return;
            }
            figs.Add(new ObjTWW(ArrToSave, checkBox1.Checked));
            DisplayAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double mx, my;
            try
            {
                mx = Convert.ToDouble(textBox1.Text);
                my = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                textBox10.Text = "Параметри руху введена невірно";
                return;
            }
            for (int i = 0; i < figs.Count; i++)
            {
                figs[i].Move(mx,my);
            }
            DisplayAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double px, py, angle;
            try
            {
                angle = Convert.ToDouble(textBox8.Text);
            }
            catch
            {
                textBox10.Text = "Кут поворота заданий невірно";
                return;
            }
            try
            {
                px = Convert.ToDouble(textBox6.Text);
                py = Convert.ToDouble(textBox5.Text);
            }
            catch
            {
                textBox10.Text = "Поворот буде здійснено відносно точки 0,0";
                px =0;
                py =0;
            }
            PentoUse.Color = Color.Green;
            Pictgraph.DrawLine(PentoUse, (int)px - 5, (int)py + 5, (int)px + 5, (int)py - 5);
            Pictgraph.DrawLine(PentoUse, (int)px - 5, (int)py - 5, (int)px + 5, (int)py + 5);

            PentoUse.Color = Color.Red;
            for (int i = 0; i < figs.Count; i++)
            {
                figs[i].Rotate(px, py,angle*(Math.PI/180));
            }
            DisplayAll();
            PentoUse.Color = Color.Green;
            Pictgraph.DrawLine(PentoUse, (int)px - 5, (int)py + 5, (int)px + 5, (int)py - 5);
            Pictgraph.DrawLine(PentoUse, (int)px - 5, (int)py - 5, (int)px + 5, (int)py + 5);
            PentoUse.Color = Color.Red;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double px, py;
            try
            {
                px = Convert.ToDouble(textBox6.Text);
                py = Convert.ToDouble(textBox5.Text);
                DisplayAll();
                PentoUse.Color = Color.Green;
                Pictgraph.DrawLine(PentoUse, (int)px - 5, (int)py + 5, (int)px + 5, (int)py - 5);
                Pictgraph.DrawLine(PentoUse, (int)px - 5, (int)py - 5, (int)px + 5, (int)py + 5);

                PentoUse.Color = Color.Red;
            }
            catch
            {
                return;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double px, py;
            try
            {
                px = Convert.ToDouble(textBox6.Text);
                py = Convert.ToDouble(textBox5.Text);
                DisplayAll();
                PentoUse.Color = Color.Green;
                Pictgraph.DrawLine(PentoUse, (int)px - 5, (int)py + 5, (int)px + 5, (int)py - 5);
                Pictgraph.DrawLine(PentoUse, (int)px - 5, (int)py - 5, (int)px + 5, (int)py + 5);

                PentoUse.Color = Color.Red;
            }
            catch
            {
                return;
            }
        }



    }
    class ObjTWW
    {
        public Point[] ps;
        public double[,] RealPs;
        public bool cycled = false;
        public ObjTWW()
        {
            ps = new Point[0];
            RealPs = new double[0, 2];
        }
        public ObjTWW(int x, int y)
        {
            ps = new Point[] { new Point(x, y) };
            RealPs = new double[1, 2];
            RealPs[0, 0] = x;
            RealPs[0, 1] = y;
        }
        public ObjTWW(Point[] targ)
        {
            ps = targ;
            RealPs = new double[targ.Length, 2];
            for (int i = 0; i < targ.Length; i++)
            {
                RealPs[i, 0] = targ[i].X;
                RealPs[i, 1] = targ[i].Y;
            }
            
        }
        public ObjTWW(double[,] targ, bool needsCycle)
        {
            cycled = needsCycle;
            ps = new Point[(int)targ.Length/2];
            RealPs = targ;
            for (int i = 0; i < (int)(targ.Length/2); i++)
            {
                ps[i].X = (int)targ[i,0];
                ps[i].Y = (int)targ[i,1];
            }

        }
        public ObjTWW(Point[] targ, bool needsCycle)
        {
            cycled = needsCycle;
            ps = targ;
            RealPs = new double[targ.Length, 2];
            for (int i = 0; i < targ.Length; i++)
            {
                RealPs[i, 0] = targ[i].X;
                RealPs[i, 1] = targ[i].Y;
            }
        }
        public void Move(double xm, double ym)
        {
            Complex[,] MoveMat = new Complex [3,3];
            Complex[,] TargMat = new Complex[3,1];
            MoveMat[0,0] = 1;
            MoveMat[1, 1] = 1;
            MoveMat[2, 2] = 1;
            MoveMat[0, 2] = xm;
            MoveMat[1, 2] = ym;
            for (int i = 0; i < ps.Length; i++)
            {
                TargMat[0,0] = RealPs[i, 0];
                TargMat[1,0] = RealPs[i, 1];
                TargMat[2,0] = 1;
                TargMat = Matrixes.Multiply(MoveMat,TargMat);
                RealPs[i,0] = (TargMat[0,0]/TargMat[2,0]).Real;
                RealPs[i, 1] = (TargMat[1, 0] / TargMat[2, 0]).Real;
                ps[i].X = (int)RealPs[i, 0];
                ps[i].Y = (int)RealPs[i, 1];
            }
        }
        public void Rotate(double px, double py, double angle)
        {
            this.Move(-px,-py);
            Complex[,] MoveMat = new Complex[3, 3];
            Complex[,] TargMat = new Complex[3, 1];
            MoveMat[0, 0] = Math.Cos(angle);
            MoveMat[0, 1] = Math.Sin(angle);
            MoveMat[1, 0] = -1*Math.Sin(angle);
            MoveMat[1, 1] = Math.Cos(angle);
            MoveMat[2, 2] = 1;
            for (int i = 0; i < ps.Length; i++)
            {
                TargMat[0, 0] = RealPs[i, 0];
                TargMat[1, 0] = RealPs[i, 1];
                TargMat[2, 0] = 1;
                TargMat = Matrixes.Multiply(MoveMat, TargMat);
                RealPs[i, 0] = (TargMat[0, 0] / TargMat[2, 0]).Real;
                RealPs[i, 1] = (TargMat[1, 0] / TargMat[2, 0]).Real;
                ps[i].X = (int)RealPs[i, 0];
                ps[i].Y = (int)RealPs[i, 1];
            }
            this.Move(px, py);
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
