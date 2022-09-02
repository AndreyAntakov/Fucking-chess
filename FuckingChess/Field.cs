using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FuckingChess
{
    enum YCellPositions
    {
        A = 0,
        B = 1,
        C = 2,
        D = 3,
        E = 4,
        F = 5,
        G = 6,
        H = 7,
    }
    internal class Field
    {

        public void InitializeField()
        {
            Figure[,] field = new Figure[8,8];
            field[0, 1] = new King();
        }
        
    }
    class Cell
    {
        
        public int Y;
       
        
    }
}
