using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriH2
{
    class Rectangle : Square
    {
        public Rectangle(double _side, double _sideB) : base(_side, _sideB)
        {
            Side = _side;
            SideB = _sideB;
        }
        public override double Perimeter()
        {
            return 2 * (Side + SideB);
        }
        public override double Areal()
        {
            return (Side * SideB);
        }
    }
}
