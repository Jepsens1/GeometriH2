using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriH2
{
    class Parallelogram : Square
    {
        public double Angle { get; set; }
        public Parallelogram(double _side, double _sideB, double _angle) : base(_side, _sideB)
        {
            Side = _side;
            SideB = _sideB;
            Angle = _angle;
        }
        public override double Areal()
        {
            return Side * SideB * Math.Sin(Angle);
        }
    }
}
