using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Lab2
{
    class StartPoint
    { 
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); // ususal shit
            MainForm Program = new MainForm();
            Model MainModel = new Model();
            Controler MainControler = new Controler(MainModel, Program);
            Application.Run(Program); //creating and running our form is way to initialize all programm.
        }
    }
}
