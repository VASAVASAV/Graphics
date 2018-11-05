using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Figure
    {
        List<Tuple<double[], List<double>>> cells = new List<Tuple<double[], List<double>>>(); // array - 3 double values, coordinates x,y,z. List - numbers of cells, to which one is connected
        bool isChangeable; // Desribes ability to be changed by affine transformation. 

        bool IsChangeable
        {
            get 
            {
                return isChangeable;
            }

        }

        //List<Tuple<double[], List<double>>> Cells
        //{
        //    get
        //    {
        //        return cells;
        //    }

        //}

        Figure(List<Tuple<double[], List<double>>> newCells, bool InputChangeable)
        {
            isChangeable = InputChangeable;
            cells = newCells;
        }
        
        void AddCell



    }
}
