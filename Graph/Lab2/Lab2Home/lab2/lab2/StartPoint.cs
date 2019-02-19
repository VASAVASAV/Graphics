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
        Model MainModel = new Model();

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); // ususal shit
            mainForm Program = new mainForm(); 
            Application.Run(Program); //creating and running our form is way to initialize all programm.
        }
    }
}
