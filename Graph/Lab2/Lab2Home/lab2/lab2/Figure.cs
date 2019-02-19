using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Figure
    {
        public List<MPoint> cells = new List<MPoint>();

        bool IsChangeable;

        Figure(List<MPoint> newCells)
        {
            IsChangeable = true;
            for (int i = 0; i < newCells.Count; i++)
            {
                cells.Add(newCells[i]);
            }
        }

        Figure(List<MPoint> newCells, bool ChangeableInput)
        {
            IsChangeable = ChangeableInput;
            for (int i = 0; i < newCells.Count; i++)
            {
                cells.Add(newCells[i]);
            }
        }

        Figure(MPoint newCell)
        {
            IsChangeable = true;
            cells.Add(newCell);
        }

        void AddCell(MPoint newCell)
        {
            cells.Add(newCell);
        }

        void RemovePoint(MPoint CellToDelete)
        {
            while (cells.Contains(CellToDelete))
            {
                cells.Remove(CellToDelete);
            }
        }
    }
}
