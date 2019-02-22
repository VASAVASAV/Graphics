using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using MathParserNet;

namespace Lab2
{
    class MainForm : Form
    {
        private GroupBox groupBox1;
        private Panel PanelFor2d;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RadioButton radioButton1;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private GroupBox groupBox2;
        private RadioButton radioButton11;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private TabPage tabPage11;
        private TabControl tabControl2;
        private TabPage tabPage12;
        private TabControl tabControl3;
        private TabPage tabPage13;
        private TabControl tabControl4;
        private TabPage tabPage14;
        private Button button1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private Button button3;
        public Panel panel1;
        public Controler MyCont;
        private Button button4;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox9;
        private Label label9;
        private Button button5;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private RadioButton radioButton12;
        private TabPage tabPage15;
        private TextBox textBox10;
        private Label label10;
        private TextBox textBox11;
        private Label label11;
        private TextBox textBox12;
        private Label label12;
        private CheckBox checkBox6;
        private RadioButton radioButton15;
        private RadioButton radioButton14;
        private RadioButton radioButton13;
        private CheckBox checkBox5;
        private TextBox textBox13;
        private Label label13;
        private TextBox textBox14;
        private Label label14;
        private TextBox textBox15;
        private Label label15;
        private CheckBox checkBox4;
        private TextBox textBox16;
        private Label label16;
        private TextBox textBox17;
        private Label label17;
        private CheckBox checkBox7;
        private DataGridView dataGridView1;
        private Button button6;
        private TabPage tabPage16;
        private TabPage tabPage17;
        private TabPage tabPage18;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button button7;
        private TextBox textBox23;
        private Label label23;
        private TextBox textBox22;
        private Label label22;
        private TextBox textBox21;
        private Label label21;
        private TextBox textBox20;
        private Label label20;
        private TextBox textBox19;
        private Label label19;
        private TextBox textBox18;
        private Label label18;
        private Button button8;
        private TextBox textBox24;
        private Label label24;
        private TextBox textBox25;
        private Label label25;
        private TextBox textBox26;
        private Label label26;
        private TextBox textBox27;
        private Label label27;
        private TextBox textBox28;
        private Label label28;
        private TextBox textBox29;
        private Label label29;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button button9;
        private TabPage tabPage19;
        private TabPage tabPage20;
        private Button button10;
        private Button button11;
        private TextBox textBox43;
        private Label label39;
        private TextBox textBox42;
        private Label label38;
        private TextBox textBox36;
        private Label label32;
        private TextBox textBox37;
        private Label label33;
        private TextBox textBox38;
        private Label label34;
        private TextBox textBox39;
        private Label label35;
        private TextBox textBox40;
        private Label label36;
        private TextBox textBox41;
        private Label label37;
        private TextBox textBox33;
        private TextBox textBox34;
        private TextBox textBox35;
        private Label label31;
        private TextBox textBox32;
        private TextBox textBox31;
        private TextBox textBox30;
        private Label label30;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Button button12;
        private TextBox textBox44;
        private Label label40;
        private Label label41;
        private TextBox textBox45;
        private Button button13;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        public Graphics MyGraph;
    
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PanelFor2d = new System.Windows.Forms.Panel();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button9 = new System.Windows.Forms.Button();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tabPage19 = new System.Windows.Forms.TabPage();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage20 = new System.Windows.Forms.TabPage();
            this.label41 = new System.Windows.Forms.Label();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PanelFor2d.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage17.SuspendLayout();
            this.tabPage18.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.tabPage19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPage15.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 648);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Робоче поле";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(7, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 624);
            this.panel1.TabIndex = 0;
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
            this.PanelFor2d.Controls.Add(this.radioButton12);
            this.PanelFor2d.Controls.Add(this.button3);
            this.PanelFor2d.Controls.Add(this.radioButton11);
            this.PanelFor2d.Controls.Add(this.radioButton10);
            this.PanelFor2d.Controls.Add(this.radioButton9);
            this.PanelFor2d.Controls.Add(this.radioButton8);
            this.PanelFor2d.Controls.Add(this.radioButton7);
            this.PanelFor2d.Controls.Add(this.radioButton6);
            this.PanelFor2d.Controls.Add(this.radioButton5);
            this.PanelFor2d.Controls.Add(this.radioButton4);
            this.PanelFor2d.Controls.Add(this.radioButton3);
            this.PanelFor2d.Controls.Add(this.radioButton2);
            this.PanelFor2d.Controls.Add(this.radioButton1);
            this.PanelFor2d.Controls.Add(this.tabControl1);
            this.PanelFor2d.Location = new System.Drawing.Point(6, 19);
            this.PanelFor2d.Name = "PanelFor2d";
            this.PanelFor2d.Size = new System.Drawing.Size(340, 624);
            this.PanelFor2d.TabIndex = 0;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(127, 146);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(64, 17);
            this.radioButton12.TabIndex = 12;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Камера";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 26);
            this.button3.TabIndex = 7;
            this.button3.Text = "test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(84, 118);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(145, 17);
            this.radioButton11.TabIndex = 11;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Перспективна проекція";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(183, 95);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(125, 17);
            this.radioButton10.TabIndex = 10;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Косокутна проекція";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(8, 95);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(157, 17);
            this.radioButton9.TabIndex = 9;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Аксонометрична проекція";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(110, 58);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(94, 17);
            this.radioButton8.TabIndex = 8;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Набір команд";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(233, 26);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(100, 17);
            this.radioButton7.TabIndex = 7;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Відзеркалення";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(154, 26);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(60, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Розтяг";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(66, 26);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(68, 17);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Поворот";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(8, 26);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(42, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Рух";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(259, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Поверхня";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(142, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Лінія";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Фігура";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPage15);
            this.tabControl1.Location = new System.Drawing.Point(4, 169);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 452);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(325, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Фігура";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage12);
            this.tabControl2.Location = new System.Drawing.Point(7, 52);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(312, 338);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(304, 312);
            this.tabPage12.TabIndex = 0;
            this.tabPage12.Text = "tabPage12";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(325, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Лінія";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage13);
            this.tabControl3.Controls.Add(this.tabPage16);
            this.tabControl3.Controls.Add(this.tabPage17);
            this.tabControl3.Controls.Add(this.tabPage18);
            this.tabControl3.Location = new System.Drawing.Point(6, 29);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(312, 364);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.dataGridView1);
            this.tabPage13.Controls.Add(this.button6);
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(304, 338);
            this.tabPage13.TabIndex = 0;
            this.tabPage13.Text = "Ламана";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(291, 279);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Y";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Z";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 292);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(294, 40);
            this.button6.TabIndex = 0;
            this.button6.Text = "Додати";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabPage16
            // 
            this.tabPage16.Controls.Add(this.button10);
            this.tabPage16.Controls.Add(this.dataGridView2);
            this.tabPage16.Controls.Add(this.button9);
            this.tabPage16.Location = new System.Drawing.Point(4, 22);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Size = new System.Drawing.Size(304, 338);
            this.tabPage16.TabIndex = 1;
            this.tabPage16.Text = "Без\'є";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(7, 246);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(294, 40);
            this.button10.TabIndex = 4;
            this.button10.Text = "Зробити пінгвінчика";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(5, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(291, 233);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "X";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Y";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Z";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(5, 292);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(294, 40);
            this.button9.TabIndex = 2;
            this.button9.Text = "Додати";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.button8);
            this.tabPage17.Controls.Add(this.textBox24);
            this.tabPage17.Controls.Add(this.label24);
            this.tabPage17.Controls.Add(this.textBox25);
            this.tabPage17.Controls.Add(this.label25);
            this.tabPage17.Controls.Add(this.textBox26);
            this.tabPage17.Controls.Add(this.label26);
            this.tabPage17.Controls.Add(this.textBox27);
            this.tabPage17.Controls.Add(this.label27);
            this.tabPage17.Controls.Add(this.textBox28);
            this.tabPage17.Controls.Add(this.label28);
            this.tabPage17.Controls.Add(this.textBox29);
            this.tabPage17.Controls.Add(this.label29);
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Size = new System.Drawing.Size(304, 338);
            this.tabPage17.TabIndex = 2;
            this.tabPage17.Text = "Сплайн";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 295);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(294, 40);
            this.button8.TabIndex = 24;
            this.button8.Text = "Додати";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(90, 154);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(100, 20);
            this.textBox24.TabIndex = 23;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(35, 157);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 13);
            this.label24.TabIndex = 22;
            this.label24.Text = "крок t";
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(90, 128);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(100, 20);
            this.textBox25.TabIndex = 21;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(14, 131);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 13);
            this.label25.TabIndex = 20;
            this.label25.Text = "права межа t";
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(90, 102);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(100, 20);
            this.textBox26.TabIndex = 19;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(20, 105);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(64, 13);
            this.label26.TabIndex = 18;
            this.label26.Text = "ліва межа t";
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(47, 69);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(100, 20);
            this.textBox27.TabIndex = 17;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(20, 72);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(21, 13);
            this.label27.TabIndex = 16;
            this.label27.Text = "z(t)";
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(47, 43);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(100, 20);
            this.textBox28.TabIndex = 15;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(20, 46);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(21, 13);
            this.label28.TabIndex = 14;
            this.label28.Text = "y(t)";
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(47, 17);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(100, 20);
            this.textBox29.TabIndex = 13;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(20, 20);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(21, 13);
            this.label29.TabIndex = 12;
            this.label29.Text = "x(t)";
            // 
            // tabPage18
            // 
            this.tabPage18.Controls.Add(this.button7);
            this.tabPage18.Controls.Add(this.textBox23);
            this.tabPage18.Controls.Add(this.label23);
            this.tabPage18.Controls.Add(this.textBox22);
            this.tabPage18.Controls.Add(this.label22);
            this.tabPage18.Controls.Add(this.textBox21);
            this.tabPage18.Controls.Add(this.label21);
            this.tabPage18.Controls.Add(this.textBox20);
            this.tabPage18.Controls.Add(this.label20);
            this.tabPage18.Controls.Add(this.textBox19);
            this.tabPage18.Controls.Add(this.label19);
            this.tabPage18.Controls.Add(this.textBox18);
            this.tabPage18.Controls.Add(this.label18);
            this.tabPage18.Location = new System.Drawing.Point(4, 22);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Size = new System.Drawing.Size(304, 338);
            this.tabPage18.TabIndex = 3;
            this.tabPage18.Text = "Формула";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 295);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(294, 40);
            this.button7.TabIndex = 12;
            this.button7.Text = "Додати";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(79, 148);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(100, 20);
            this.textBox23.TabIndex = 11;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(24, 151);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "крок t";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(79, 122);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(100, 20);
            this.textBox22.TabIndex = 9;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 125);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "права межа t";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(79, 96);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 20);
            this.textBox21.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 99);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "ліва межа t";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(36, 63);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 20);
            this.textBox20.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "z(t)";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(36, 37);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 20);
            this.textBox19.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "y(t)";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(36, 11);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "x(t)";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(325, 426);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Поверхня";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage14);
            this.tabControl4.Controls.Add(this.tabPage19);
            this.tabControl4.Controls.Add(this.tabPage20);
            this.tabControl4.Location = new System.Drawing.Point(6, 3);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(312, 420);
            this.tabControl4.TabIndex = 1;
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.button11);
            this.tabPage14.Controls.Add(this.textBox43);
            this.tabPage14.Controls.Add(this.label39);
            this.tabPage14.Controls.Add(this.textBox42);
            this.tabPage14.Controls.Add(this.label38);
            this.tabPage14.Controls.Add(this.textBox36);
            this.tabPage14.Controls.Add(this.label32);
            this.tabPage14.Controls.Add(this.textBox37);
            this.tabPage14.Controls.Add(this.label33);
            this.tabPage14.Controls.Add(this.textBox38);
            this.tabPage14.Controls.Add(this.label34);
            this.tabPage14.Controls.Add(this.textBox39);
            this.tabPage14.Controls.Add(this.label35);
            this.tabPage14.Controls.Add(this.textBox40);
            this.tabPage14.Controls.Add(this.label36);
            this.tabPage14.Controls.Add(this.textBox41);
            this.tabPage14.Controls.Add(this.label37);
            this.tabPage14.Controls.Add(this.textBox33);
            this.tabPage14.Controls.Add(this.textBox34);
            this.tabPage14.Controls.Add(this.textBox35);
            this.tabPage14.Controls.Add(this.label31);
            this.tabPage14.Controls.Add(this.textBox32);
            this.tabPage14.Controls.Add(this.textBox31);
            this.tabPage14.Controls.Add(this.textBox30);
            this.tabPage14.Controls.Add(this.label30);
            this.tabPage14.Location = new System.Drawing.Point(4, 22);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(304, 394);
            this.tabPage14.TabIndex = 0;
            this.tabPage14.Text = "Поверхня обертання";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(4, 318);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(294, 40);
            this.button11.TabIndex = 28;
            this.button11.Text = "Створити";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textBox43
            // 
            this.textBox43.Location = new System.Drawing.Point(124, 292);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(100, 20);
            this.textBox43.TabIndex = 27;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(32, 295);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(87, 13);
            this.label39.TabIndex = 26;
            this.label39.Text = "крок обертання";
            // 
            // textBox42
            // 
            this.textBox42.Location = new System.Drawing.Point(124, 266);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(100, 20);
            this.textBox42.TabIndex = 25;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(44, 269);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(56, 13);
            this.label38.TabIndex = 24;
            this.label38.Text = "крок кута";
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(124, 240);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(100, 20);
            this.textBox36.TabIndex = 23;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(54, 243);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(37, 13);
            this.label32.TabIndex = 22;
            this.label32.Text = "крок t";
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(124, 214);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(100, 20);
            this.textBox37.TabIndex = 21;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(32, 217);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(74, 13);
            this.label33.TabIndex = 20;
            this.label33.Text = "права межа t";
            // 
            // textBox38
            // 
            this.textBox38.Location = new System.Drawing.Point(124, 188);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(100, 20);
            this.textBox38.TabIndex = 19;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(32, 191);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(64, 13);
            this.label34.TabIndex = 18;
            this.label34.Text = "ліва межа t";
            // 
            // textBox39
            // 
            this.textBox39.Location = new System.Drawing.Point(124, 162);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(100, 20);
            this.textBox39.TabIndex = 17;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(97, 165);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(21, 13);
            this.label35.TabIndex = 16;
            this.label35.Text = "z(t)";
            // 
            // textBox40
            // 
            this.textBox40.Location = new System.Drawing.Point(124, 136);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(100, 20);
            this.textBox40.TabIndex = 15;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(97, 139);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(21, 13);
            this.label36.TabIndex = 14;
            this.label36.Text = "y(t)";
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(124, 110);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(100, 20);
            this.textBox41.TabIndex = 13;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(97, 113);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(21, 13);
            this.label37.TabIndex = 12;
            this.label37.Text = "x(t)";
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(97, 77);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(84, 20);
            this.textBox33.TabIndex = 7;
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(187, 77);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(84, 20);
            this.textBox34.TabIndex = 6;
            // 
            // textBox35
            // 
            this.textBox35.Location = new System.Drawing.Point(7, 77);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(84, 20);
            this.textBox35.TabIndex = 5;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 60);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(20, 13);
            this.label31.TabIndex = 4;
            this.label31.Text = "P2";
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(187, 29);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(84, 20);
            this.textBox32.TabIndex = 3;
            this.textBox32.Text = "0";
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(97, 29);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(84, 20);
            this.textBox31.TabIndex = 2;
            this.textBox31.Text = "0";
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(7, 29);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(84, 20);
            this.textBox30.TabIndex = 1;
            this.textBox30.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 12);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(20, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "P1";
            // 
            // tabPage19
            // 
            this.tabPage19.Controls.Add(this.label40);
            this.tabPage19.Controls.Add(this.textBox44);
            this.tabPage19.Controls.Add(this.button12);
            this.tabPage19.Controls.Add(this.dataGridView3);
            this.tabPage19.Location = new System.Drawing.Point(4, 22);
            this.tabPage19.Name = "tabPage19";
            this.tabPage19.Size = new System.Drawing.Size(304, 394);
            this.tabPage19.TabIndex = 1;
            this.tabPage19.Text = "Поверхня Кунса";
            this.tabPage19.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(45, 328);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(87, 13);
            this.label40.TabIndex = 31;
            this.label40.Text = "кількість кроків";
            // 
            // textBox44
            // 
            this.textBox44.Location = new System.Drawing.Point(138, 325);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(100, 20);
            this.textBox44.TabIndex = 30;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(3, 351);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(294, 40);
            this.button12.TabIndex = 29;
            this.button12.Text = "Створити";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(291, 312);
            this.dataGridView3.TabIndex = 2;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "P";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 30;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "X";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Y";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Z";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 75;
            // 
            // tabPage20
            // 
            this.tabPage20.Controls.Add(this.label41);
            this.tabPage20.Controls.Add(this.textBox45);
            this.tabPage20.Controls.Add(this.button13);
            this.tabPage20.Controls.Add(this.dataGridView4);
            this.tabPage20.Location = new System.Drawing.Point(4, 22);
            this.tabPage20.Name = "tabPage20";
            this.tabPage20.Size = new System.Drawing.Size(304, 394);
            this.tabPage20.TabIndex = 2;
            this.tabPage20.Text = "Поверхня Без\'є";
            this.tabPage20.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(47, 328);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(95, 13);
            this.label41.TabIndex = 35;
            this.label41.Text = "довжина сторони";
            // 
            // textBox45
            // 
            this.textBox45.Location = new System.Drawing.Point(140, 325);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(100, 20);
            this.textBox45.TabIndex = 34;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(5, 351);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(294, 40);
            this.button13.TabIndex = 33;
            this.button13.Text = "Створити";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView4.Location = new System.Drawing.Point(5, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(291, 312);
            this.dataGridView4.TabIndex = 32;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(325, 426);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Рух";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Рух!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(134, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "рук по z";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "рук по у";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "рук по х";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.textBox4);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.textBox5);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.textBox6);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(325, 426);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Поворот";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "Поворот!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(146, 83);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "поворот по φyz";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(146, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "поворот по φxz";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(146, 31);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "поворот по φxy";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button4);
            this.tabPage6.Controls.Add(this.textBox7);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.textBox8);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.textBox9);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(325, 426);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Розтяг";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(102, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 46);
            this.button4.TabIndex = 13;
            this.button4.Text = "Розтяг!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(152, 82);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "розтяг по z";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(152, 56);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "розтяг по у";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(152, 30);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "розтяг по х";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.button5);
            this.tabPage7.Controls.Add(this.checkBox3);
            this.tabPage7.Controls.Add(this.checkBox2);
            this.tabPage7.Controls.Add(this.checkBox1);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(325, 426);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Відзеркалення";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(87, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 46);
            this.button5.TabIndex = 14;
            this.button5.Text = "Відзеркалення!";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(76, 80);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(183, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Відзеркалити по z (відносно xy)";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(76, 57);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(183, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Відзеркалити по у (відносно xz)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(76, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(183, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Відзеркалити по х (відносно уz)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(325, 426);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Набір команд";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.checkBox6);
            this.tabPage9.Controls.Add(this.radioButton15);
            this.tabPage9.Controls.Add(this.radioButton14);
            this.tabPage9.Controls.Add(this.radioButton13);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(325, 426);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Аксонометрія";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(58, 3);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(210, 17);
            this.checkBox6.TabIndex = 16;
            this.checkBox6.Text = "Включити аксонометричну проекцію";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(106, 96);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(77, 17);
            this.radioButton15.TabIndex = 15;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "Триметрія";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(106, 73);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(73, 17);
            this.radioButton14.TabIndex = 14;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "Диметрія";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(106, 50);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(73, 17);
            this.radioButton13.TabIndex = 13;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "Ізометрія";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.textBox16);
            this.tabPage10.Controls.Add(this.label16);
            this.tabPage10.Controls.Add(this.textBox17);
            this.tabPage10.Controls.Add(this.label17);
            this.tabPage10.Controls.Add(this.checkBox5);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(325, 426);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Косокутна";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(102, 52);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 13;
            this.textBox16.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(82, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(10, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "f";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(102, 26);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 11;
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(82, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "α";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(58, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(178, 17);
            this.checkBox5.TabIndex = 1;
            this.checkBox5.Text = "Включити косокутну проекцію";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.textBox13);
            this.tabPage11.Controls.Add(this.label13);
            this.tabPage11.Controls.Add(this.textBox14);
            this.tabPage11.Controls.Add(this.label14);
            this.tabPage11.Controls.Add(this.textBox15);
            this.tabPage11.Controls.Add(this.label15);
            this.tabPage11.Controls.Add(this.checkBox4);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(325, 426);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "Перспектива";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(119, 87);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 11;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(99, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "c";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(119, 61);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 9;
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(99, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "b";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(119, 35);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 7;
            this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(99, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "a";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(58, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(197, 17);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Включити перспективну проекцію";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.checkBox7);
            this.tabPage15.Controls.Add(this.textBox10);
            this.tabPage15.Controls.Add(this.label10);
            this.tabPage15.Controls.Add(this.textBox11);
            this.tabPage15.Controls.Add(this.label11);
            this.tabPage15.Controls.Add(this.textBox12);
            this.tabPage15.Controls.Add(this.label12);
            this.tabPage15.Location = new System.Drawing.Point(4, 22);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Size = new System.Drawing.Size(325, 426);
            this.tabPage15.TabIndex = 11;
            this.tabPage15.Text = "Камера";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(76, 161);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(109, 17);
            this.checkBox7.TabIndex = 20;
            this.checkBox7.Text = "Метод Робертса";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(163, 99);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 19;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "положення камери (z)";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(163, 73);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 17;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "положення камери (y)";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(163, 47);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 15;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "положення камери (х)";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "X";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 75;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Y";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 75;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Z";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 75;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1181, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.PanelFor2d.ResumeLayout(false);
            this.PanelFor2d.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage17.ResumeLayout(false);
            this.tabPage17.PerformLayout();
            this.tabPage18.ResumeLayout(false);
            this.tabPage18.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage14.ResumeLayout(false);
            this.tabPage14.PerformLayout();
            this.tabPage19.ResumeLayout(false);
            this.tabPage19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage20.ResumeLayout(false);
            this.tabPage20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.tabPage15.ResumeLayout(false);
            this.tabPage15.PerformLayout();
            this.ResumeLayout(false);

        }

        public MainForm()
        {
            InitializeComponent();
            MyGraph = panel1.CreateGraphics();
            dataGridView3.Rows.Add();
            dataGridView3.Rows[0].Cells[0].Value = "P00";
            dataGridView3.Rows[0].Cells[1].Value = 0;
            dataGridView3.Rows[0].Cells[2].Value = 0;
            dataGridView3.Rows[0].Cells[3].Value = 0;

            dataGridView3.Rows.Add();
            dataGridView3.Rows[1].Cells[0].Value = "P01";
            dataGridView3.Rows[1].Cells[1].Value = 0;
            dataGridView3.Rows[1].Cells[2].Value = 0;
            dataGridView3.Rows[1].Cells[3].Value = 0;

            dataGridView3.Rows.Add();
            dataGridView3.Rows[2].Cells[0].Value = "P10";
            dataGridView3.Rows[2].Cells[1].Value = 0;
            dataGridView3.Rows[2].Cells[2].Value = 0;
            dataGridView3.Rows[2].Cells[3].Value = 0;

            dataGridView3.Rows.Add();
            dataGridView3.Rows[3].Cells[0].Value = "P11";
            dataGridView3.Rows[3].Cells[1].Value = 0;
            dataGridView3.Rows[3].Cells[2].Value = 0;
            dataGridView3.Rows[3].Cells[3].Value = 0;


            dataGridView3.Rows.Add();
            dataGridView3.Rows[4].Cells[0].Value = "Pu00";
            dataGridView3.Rows[4].Cells[1].Value = 0;
            dataGridView3.Rows[4].Cells[2].Value = 0;
            dataGridView3.Rows[4].Cells[3].Value = 0;

            dataGridView3.Rows.Add();
            dataGridView3.Rows[5].Cells[0].Value = "Pu01";
            dataGridView3.Rows[5].Cells[1].Value = 0;
            dataGridView3.Rows[5].Cells[2].Value = 0;
            dataGridView3.Rows[5].Cells[3].Value = 0;

            dataGridView3.Rows.Add();
            dataGridView3.Rows[6].Cells[0].Value = "Pu10";
            dataGridView3.Rows[6].Cells[1].Value = 0;
            dataGridView3.Rows[6].Cells[2].Value = 0;
            dataGridView3.Rows[6].Cells[3].Value = 0;

            dataGridView3.Rows.Add();
            dataGridView3.Rows[7].Cells[0].Value = "Pu11";
            dataGridView3.Rows[7].Cells[1].Value = 0;
            dataGridView3.Rows[7].Cells[2].Value = 0;
            dataGridView3.Rows[7].Cells[3].Value = 0;


            dataGridView3.Rows.Add();
            dataGridView3.Rows[8].Cells[0].Value = "Pv00";
            dataGridView3.Rows[8].Cells[1].Value = 0;
            dataGridView3.Rows[8].Cells[2].Value = 0;
            dataGridView3.Rows[8].Cells[3].Value = 0;

            dataGridView3.Rows.Add();
            dataGridView3.Rows[9].Cells[0].Value = "Pv01";
            dataGridView3.Rows[9].Cells[1].Value = 0;
            dataGridView3.Rows[9].Cells[2].Value = 0;
            dataGridView3.Rows[9].Cells[3].Value = 0;

            dataGridView3.Rows.Add();
            dataGridView3.Rows[10].Cells[0].Value = "Pv10";
            dataGridView3.Rows[10].Cells[1].Value = 0;
            dataGridView3.Rows[10].Cells[2].Value = 0;
            dataGridView3.Rows[10].Cells[3].Value = 0;

            dataGridView3.Rows.Add();
            dataGridView3.Rows[11].Cells[0].Value = "Pv11";
            dataGridView3.Rows[11].Cells[1].Value = 0;
            dataGridView3.Rows[11].Cells[2].Value = 0;
            dataGridView3.Rows[11].Cells[3].Value = 0;

            dataGridView3.Rows.Add();
            dataGridView3.Rows[12].Cells[0].Value = "Puv00";
            dataGridView3.Rows[12].Cells[1].Value = 0;
            dataGridView3.Rows[12].Cells[2].Value = 0;
            dataGridView3.Rows[12].Cells[3].Value = 0;

            dataGridView3.Rows.Add();
            dataGridView3.Rows[13].Cells[0].Value = "Puv01";
            dataGridView3.Rows[13].Cells[1].Value = 0;
            dataGridView3.Rows[13].Cells[2].Value = 0;
            dataGridView3.Rows[13].Cells[3].Value = 0;

            dataGridView3.Rows.Add();
            dataGridView3.Rows[14].Cells[0].Value = "Puv10";
            dataGridView3.Rows[14].Cells[1].Value = 0;
            dataGridView3.Rows[14].Cells[2].Value = 0;
            dataGridView3.Rows[14].Cells[3].Value = 0;

            dataGridView3.Rows.Add();
            dataGridView3.Rows[15].Cells[0].Value = "Puv11";
            dataGridView3.Rows[15].Cells[1].Value = 0;
            dataGridView3.Rows[15].Cells[2].Value = 0;
            dataGridView3.Rows[15].Cells[3].Value = 0;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyCont.DrawAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;
            try
            {
                x = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                if (textBox1.Text == "")
                {
                    x = 0;
                }
                else
                 return;
            }
            try
            {
                y = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                if (textBox2.Text == "")
                {
                    y = 0;
                }
                else
                    return;
            }
            try
            {
                z = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                if (textBox3.Text == "")
                {
                    z = 0;
                }
                else
                    return;
            }
            MyCont.Move(x, y, z);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double fxy, fyz, fxz;
            try
            {
                fxy= Convert.ToDouble(textBox6.Text);
            }
            catch
            {
                if (textBox6.Text == "")
                {
                    fxy = 0;
                }
                else
                    return;
            }
            try
            {
                fyz = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                if (textBox4.Text == "")
                {
                    fyz = 0;
                }
                else
                    return;
            }
            try
            {
                fxz = Convert.ToDouble(textBox5.Text);
            }
            catch
            {
                if (textBox5.Text == "")
                {
                    fxz = 0;
                }
                else
                    return;
            }
            MyCont.Turn(fxy, fyz, fxz);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x, y, z;
            try
            {
                x = Convert.ToDouble(textBox9.Text);
            }
            catch
            {
                if (textBox9.Text == "")
                {
                    x = 1;
                }
                else
                    return;
            }
            try
            {
                y = Convert.ToDouble(textBox8.Text);
            }
            catch
            {
                if (textBox8.Text == "")
                {
                    y = 1;
                }
                else
                    return;
            }
            try
            {
                z = Convert.ToDouble(textBox7.Text);
            }
            catch
            {
                if (textBox7.Text == "")
                {
                    z = 1;
                }
                else
                    return;
            }
            MyCont.Stretch(x, y, z);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x=1, y=1, z=1;
            if (checkBox1.Checked)
            {
                x = -1;
            }
            if (checkBox2.Checked)
            {
                y = -1;
            }
            if (checkBox3.Checked)
            {
                z = -1;
            }
            MyCont.Stretch(x, y, z);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            double NewX;
            try
            {
                NewX = Convert.ToDouble(textBox12.Text);
            }
            catch
            {
                return;
            }
            MyCont.ChangeCenter(true,false,false,NewX,0,0);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            double NewY;
            try
            {
                NewY = Convert.ToDouble(textBox11.Text);
            }
            catch
            {
                return;
            }
            MyCont.ChangeCenter(false, true, false, 0, NewY, 0);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            double NewZ;
            try
            {
                NewZ = Convert.ToDouble(textBox10.Text);
            }
            catch
            {
                return;
            }
            MyCont.ChangeCenter(false, false, true, 0, 0, NewZ);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.A && e.KeyCode != Keys.D && e.KeyCode != Keys.W && e.KeyCode != Keys.S && e.KeyCode != Keys.Q && e.KeyCode != Keys.E)
            {
                return;
            }
            if (e.KeyCode == Keys.A)
            {
                MyCont.TurnCamera(5,0,0);
            }
            if (e.KeyCode == Keys.D)
            {
                MyCont.TurnCamera(-5, 0, 0);
            }
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.A && e.KeyCode != Keys.D && e.KeyCode != Keys.W && e.KeyCode != Keys.S && e.KeyCode != Keys.Q && e.KeyCode != Keys.E)
            {
                return;
            }
            if (e.KeyCode == Keys.A)
            {
                MyCont.TurnCamera(3, 0, 0);
            }
            if (e.KeyCode == Keys.D)
            {
                MyCont.TurnCamera(-3, 0, 0);
            }
            if (e.KeyCode == Keys.W)
            {
                MyCont.TurnCamera(0, 3, 0);
            }
            if (e.KeyCode == Keys.S)
            {
                MyCont.TurnCamera(0, -3, 0);
            }
            if (e.KeyCode == Keys.Q)
            {
                MyCont.TurnCamera(0, 0, 3);
            }
            if (e.KeyCode == Keys.E)
            {
                MyCont.TurnCamera(0, 0, -3);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                MyCont.Persp = true;
                double a, b, c;
                try
                {
                    a = Convert.ToDouble(textBox15.Text);
                    if (a == 0)
                        throw new Exception();
                }
                catch
                {
                    a = double.MaxValue / 2;
                }
                try
                {
                    b = Convert.ToDouble(textBox14.Text);
                    if (b == 0)
                        throw new Exception();
                }
                catch
                {
                    b = double.MaxValue / 2;
                }
                try
                {
                    c = Convert.ToDouble(textBox13.Text);
                    if (c == 0)
                        throw new Exception();
                }
                catch
                {
                    c = double.MaxValue / 2;
                }
                MyCont.PerspPar = new double[] { a,b,c };
            }
            else
            {
                MyCont.Persp = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox4.Checked = false;
                checkBox6.Checked = false;
                MyCont.Cosc = true;
                double a, f;
                try
                {
                    a = Convert.ToDouble(textBox17.Text);
                }
                catch
                {
                    a = 0;
                }
                try
                {
                    f = Convert.ToDouble(textBox16.Text);
                    if (f == 0)
                        throw new Exception();
                }
                catch
                {
                    f = double.MaxValue / 2;
                }
                MyCont.CoscPar = new double[] { (a* Math.PI) / 180, f};
            }
            else
            {
                MyCont.Cosc = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox5.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                double a;
                try
                {
                    a = Convert.ToDouble(textBox15.Text);
                    if(a==0)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    return;
                }
                MyCont.PerspPar[0] = a;
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                double b;
                try
                {
                    b = Convert.ToDouble(textBox14.Text);
                    if (b == 0)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    return;
                }
                MyCont.PerspPar[1] = b;
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                double c;
                try
                {
                    c = Convert.ToDouble(textBox13.Text);
                    if (c == 0)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    return;
                }
                MyCont.PerspPar[2] = c;
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                double a;
                try
                {
                    a = Convert.ToDouble(textBox17.Text);
                    if (a == 0)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    return;
                }
                MyCont.CoscPar[0] = (a * Math.PI) / 180 ;
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                double f;
                try
                {
                    f = Convert.ToDouble(textBox16.Text);
                }
                catch
                {
                    return;
                }
                MyCont.CoscPar[1] = f;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                MyCont.Roberts = true;
            }
            else
            {
                MyCont.Roberts = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i, j, k;
            if (dataGridView1.Rows.Count < 2)
            {
                return;
            }
            List<MPoint> NewLine = new List<MPoint>();
            try
            {
                for (i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    NewLine.Add(new MPoint(Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value),Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value),Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value)));
                }
            }
            catch
            {
                return;
            }
            MyCont.AddLine(NewLine,"broken");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double lt, rt;
            int step;
            string xt, yt, zt;
            xt = textBox18.Text;
            yt = textBox19.Text;
            zt = textBox20.Text;
            try
            {
                lt = Convert.ToDouble(textBox21.Text);
                rt = Convert.ToDouble(textBox22.Text);
                if (lt >= rt)
                    throw new Exception();
                step = Convert.ToInt32(textBox23.Text);
                if (step < 2)
                    throw new Exception();
            }
            catch
            {
                return;
            }
            Parser MyPars = new Parser();
            MyPars.AddVariable("e",Math.E);
            MyPars.AddVariable("pi", Math.PI);
            try
            {
                MyPars.AddVariable("t", lt);
                MyPars.SimplifyDouble(xt);
                MyPars.RemoveAllVariables();
            }
            catch
            {
                return;
            }
            MyCont.AddFormulaLine(xt,yt,zt,step,lt,rt);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double lt, rt;
            int step;
            string xt, yt, zt;
            xt = textBox29.Text;
            yt = textBox28.Text;
            zt = textBox27.Text;
            try
            {
                lt = Convert.ToDouble(textBox26.Text);
                rt = Convert.ToDouble(textBox25.Text);
                if (lt >= rt)
                    throw new Exception();
                step = Convert.ToInt32(textBox24.Text);
                if (step < 2)
                    throw new Exception();
            }
            catch
            {
                return;
            }
            Parser MyPars = new Parser();
            MyPars.AddVariable("e", Math.E);
            MyPars.AddVariable("pi", Math.PI);
            try
            {
                MyPars.AddVariable("t", lt);
                MyPars.SimplifyDouble(xt);
                MyPars.RemoveAllVariables();
            }
            catch
            {
                return;
            }
            MyCont.AddSplain(xt, yt, zt, step, lt, rt);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int i, j, k;
            if (dataGridView2.Rows.Count < 2)
            {
                return;
            }
            List<MPoint> NewLine = new List<MPoint>();
            try
            {
                for (i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    NewLine.Add(new MPoint(Convert.ToDouble(dataGridView2.Rows[i].Cells[0].Value), Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value), Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value)));
                }
            }
            catch
            {
                return;
            }
            MyCont.AddLine(NewLine, "bez");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int i, j, k;
            List<MPoint> NewLine = new List<MPoint>();
            NewLine.Add(new MPoint(0, 0));
            NewLine.Add(new MPoint(200, 100));
            NewLine.Add(new MPoint(400, 0));
            MyCont.AddLine(NewLine, "bez");

            NewLine = new List<MPoint>();
            NewLine.Add(new MPoint(0, -100));
            NewLine.Add(new MPoint(200, -200));
            NewLine.Add(new MPoint(400, -100));
            MyCont.AddLine(NewLine, "bez");

            NewLine = new List<MPoint>();
            NewLine.Add(new MPoint(0, -100));
            NewLine.Add(new MPoint(150, -150));
            NewLine.Add(new MPoint(300, -80));
            MyCont.AddLine(NewLine, "bez");

            NewLine = new List<MPoint>();
            NewLine.Add(new MPoint(0, 0));
            NewLine.Add(new MPoint(150, 50));
            NewLine.Add(new MPoint(300, -20));
            MyCont.AddLine(NewLine, "bez");

            NewLine = new List<MPoint>();
            NewLine.Add(new MPoint(400, -100));
            NewLine.Add(new MPoint(300, -50));
            NewLine.Add(new MPoint(400, 0));
            MyCont.AddLine(NewLine, "bez");

            NewLine = new List<MPoint>();
            NewLine.Add(new MPoint(400, -100));
            NewLine.Add(new MPoint(550, -65));
            NewLine.Add(new MPoint(550, -35));
            NewLine.Add(new MPoint(400, 0));
            MyCont.AddLine(NewLine, "bez");

            NewLine = new List<MPoint>();
            NewLine.Add(new MPoint(00, -100));
            NewLine.Add(new MPoint(50, -65));
            NewLine.Add(new MPoint(50, -35));
            NewLine.Add(new MPoint(00, 0));
            MyCont.AddLine(NewLine, "bez");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2, z1, z2;
            try
            {
                x1 = Convert.ToDouble(textBox30.Text);
                y1 = Convert.ToDouble(textBox31.Text);
                z1 = Convert.ToDouble(textBox32.Text);
                x2 = Convert.ToDouble(textBox33.Text);
                y2 = Convert.ToDouble(textBox34.Text);
                z2 = Convert.ToDouble(textBox35.Text);
            }
            catch
            {
                return;
            }
            double lt, rt;
            int stept,stepfi,stepfismal;
            string xt, yt, zt;
            xt = textBox41.Text;
            yt = textBox40.Text;
            zt = textBox39.Text;
            try
            {
                lt = Convert.ToDouble(textBox38.Text);
                rt = Convert.ToDouble(textBox37.Text);
                if (lt >= rt)
                    throw new Exception();
                stept = Convert.ToInt32(textBox36.Text);
                if (stept < 2)
                    throw new Exception();
                stepfi = Convert.ToInt32(textBox42.Text);
                if (stepfi < 2)
                    throw new Exception();
                stepfismal = Convert.ToInt32(textBox43.Text);
                if (stepfismal < 2)
                    throw new Exception();
            }
            catch
            {
                return;
            }
            Parser MyPars = new Parser();
            MyPars.AddVariable("e", Math.E);
            MyPars.AddVariable("pi", Math.PI);
            try
            {
                MyPars.AddVariable("t", lt);
                MyPars.SimplifyDouble(xt);
                MyPars.RemoveAllVariables();
            }
            catch
            {
                return;
            }
            MyCont.AddRoundPlane(xt,yt,zt,lt,rt,stept,stepfi,stepfismal, new MPoint(x1,y1,z1), new MPoint(x2,y2,z2));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double[,] Xmat = new double[4, 4], Ymat = new double[4, 4], Zmat = new double[4, 4];
            int steps;
            try
            {
                //steps = Convert.ToInt32(textBox44.Text);


                Xmat[0, 0] = Convert.ToDouble(dataGridView3.Rows[0].Cells[1].Value);
                Xmat[0, 1] = Convert.ToDouble(dataGridView3.Rows[1].Cells[1].Value);
                Xmat[1, 0] = Convert.ToDouble(dataGridView3.Rows[2].Cells[1].Value);
                Xmat[1, 1] = Convert.ToDouble(dataGridView3.Rows[3].Cells[1].Value);

                Xmat[2, 0] = Convert.ToDouble(dataGridView3.Rows[4].Cells[1].Value);
                Xmat[2, 1] = Convert.ToDouble(dataGridView3.Rows[5].Cells[1].Value);
                Xmat[3, 0] = Convert.ToDouble(dataGridView3.Rows[6].Cells[1].Value);
                Xmat[3, 1] = Convert.ToDouble(dataGridView3.Rows[7].Cells[1].Value);

                Xmat[0, 2] = Convert.ToDouble(dataGridView3.Rows[8].Cells[1].Value);
                Xmat[0, 3] = Convert.ToDouble(dataGridView3.Rows[9].Cells[1].Value);
                Xmat[1, 2] = Convert.ToDouble(dataGridView3.Rows[10].Cells[1].Value);
                Xmat[1, 3] = Convert.ToDouble(dataGridView3.Rows[11].Cells[1].Value);

                Xmat[2, 2] = Convert.ToDouble(dataGridView3.Rows[12].Cells[1].Value);
                Xmat[2, 3] = Convert.ToDouble(dataGridView3.Rows[13].Cells[1].Value);
                Xmat[3, 2] = Convert.ToDouble(dataGridView3.Rows[14].Cells[1].Value);
                Xmat[3, 3] = Convert.ToDouble(dataGridView3.Rows[15].Cells[1].Value);

                //////

                Ymat[0, 0] = Convert.ToDouble(dataGridView3.Rows[0].Cells[2].Value);
                Ymat[0, 1] = Convert.ToDouble(dataGridView3.Rows[1].Cells[2].Value);
                Ymat[1, 0] = Convert.ToDouble(dataGridView3.Rows[2].Cells[2].Value);
                Ymat[1, 1] = Convert.ToDouble(dataGridView3.Rows[3].Cells[2].Value);

                Ymat[2, 0] = Convert.ToDouble(dataGridView3.Rows[4].Cells[2].Value);
                Ymat[2, 1] = Convert.ToDouble(dataGridView3.Rows[5].Cells[2].Value);
                Ymat[3, 0] = Convert.ToDouble(dataGridView3.Rows[6].Cells[2].Value);
                Ymat[3, 1] = Convert.ToDouble(dataGridView3.Rows[7].Cells[2].Value);

                Ymat[0, 2] = Convert.ToDouble(dataGridView3.Rows[8].Cells[2].Value);
                Ymat[0, 3] = Convert.ToDouble(dataGridView3.Rows[9].Cells[2].Value);
                Ymat[1, 2] = Convert.ToDouble(dataGridView3.Rows[10].Cells[2].Value);
                Ymat[1, 3] = Convert.ToDouble(dataGridView3.Rows[11].Cells[2].Value);

                Ymat[2, 2] = Convert.ToDouble(dataGridView3.Rows[12].Cells[2].Value);
                Ymat[2, 3] = Convert.ToDouble(dataGridView3.Rows[13].Cells[2].Value);
                Ymat[3, 2] = Convert.ToDouble(dataGridView3.Rows[14].Cells[2].Value);
                Ymat[3, 3] = Convert.ToDouble(dataGridView3.Rows[15].Cells[2].Value);

                ///////

                Zmat[0, 0] = Convert.ToDouble(dataGridView3.Rows[0].Cells[3].Value);
                Zmat[0, 1] = Convert.ToDouble(dataGridView3.Rows[1].Cells[3].Value);
                Zmat[1, 0] = Convert.ToDouble(dataGridView3.Rows[2].Cells[3].Value);
                Zmat[1, 1] = Convert.ToDouble(dataGridView3.Rows[3].Cells[3].Value);

                Zmat[2, 0] = Convert.ToDouble(dataGridView3.Rows[4].Cells[3].Value);
                Zmat[2, 1] = Convert.ToDouble(dataGridView3.Rows[5].Cells[3].Value);
                Zmat[3, 0] = Convert.ToDouble(dataGridView3.Rows[6].Cells[3].Value);
                Zmat[3, 1] = Convert.ToDouble(dataGridView3.Rows[7].Cells[3].Value);

                Zmat[0, 2] = Convert.ToDouble(dataGridView3.Rows[8].Cells[3].Value);
                Zmat[0, 3] = Convert.ToDouble(dataGridView3.Rows[9].Cells[3].Value);
                Zmat[1, 2] = Convert.ToDouble(dataGridView3.Rows[10].Cells[3].Value);
                Zmat[1, 3] = Convert.ToDouble(dataGridView3.Rows[11].Cells[3].Value);

                Zmat[2, 2] = Convert.ToDouble(dataGridView3.Rows[12].Cells[3].Value);
                Zmat[2, 3] = Convert.ToDouble(dataGridView3.Rows[13].Cells[3].Value);
                Zmat[3, 2] = Convert.ToDouble(dataGridView3.Rows[14].Cells[3].Value);
                Zmat[3, 3] = Convert.ToDouble(dataGridView3.Rows[15].Cells[3].Value);
            }
            catch
            {
                return;
            }

            MyCont.BuildKuns(Xmat,Ymat,Zmat,5);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int length;
            List<MPoint> ML = new List<MPoint>();
            try
            {
                length = Convert.ToInt32(textBox45.Text);
                if ((((double)(dataGridView4.Rows.Count - 1)) / length - Math.Round(((double)(dataGridView4.Rows.Count - 1)) / length))>0.00001)
                    throw new Exception();
                for (int i = 0; i < dataGridView4.Rows.Count - 1; i++)
                {
                    ML.Add(new MPoint(Convert.ToDouble(dataGridView4.Rows[i].Cells[0].Value), Convert.ToDouble(dataGridView4.Rows[i].Cells[1].Value), Convert.ToDouble(dataGridView4.Rows[i].Cells[2].Value)));
                }
            }
            catch
            {
                return;
            }
            MyCont.BuildPlaneBez(ML,length);
        }
    }
}
