using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriH2
{
    public class Square : Shapes
    {
        public Square(double _side, double _sideB) : base(_side, _sideB)
        {
            Side = _side;
            SideB = _sideB;
        }
    }
}
