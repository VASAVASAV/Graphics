using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
     class Controler
    {
        private Form View;
        private Model MModel;
        bool isActive;

        Controler(Model ModelForUse)
        {
            MModel = ModelForUse;
        }

        void DrawObjects()
        {

        }
    }

}
