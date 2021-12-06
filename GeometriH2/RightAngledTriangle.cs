using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriH2
{
    class RightAngledTriangle : Shapes
    {
        public double SideC { get; set; }
        public RightAngledTriangle(double _side, double _sideB) : base(_side, _sideB)
        {
            //Math.sqrt finds the square root of a number
            SideC = Math.Sqrt(_side * _side + _sideB * _sideB);
        }
        public override double Perimeter()
        {
            return Side + SideB + SideC;
        }
        public override double Areal()
        {
            return 0.5 * (Side + SideB);
        }


    }
}
