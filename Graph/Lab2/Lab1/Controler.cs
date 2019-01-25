using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    abstract class Controler
    {
        private Form View;
        private Model MModel;
        bool isActive;

        Controler(Model ModelForUse)
        {
            MModel = ModelForUse;
        }

        abstract void DrawObjects()
    }

}
