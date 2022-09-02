using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FuckingChess
{
    class Figure
    {
        public Image _figureImage { get; set; }
        protected string _color { set; get; }
    }
    class King : Figure
    {
        public King()
        {
            
        }
    }
    class Queen : Figure
    {

    }
    class Bishop : Figure
    {

    }
    class Knight : Figure
    {

    }
    class Rook : Figure
    { 
        
    }
    class Pawn : Figure
    {
        
    }
}