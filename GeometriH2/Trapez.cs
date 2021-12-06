using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriH2
{
    class Trapez : Square
    {
        public double Height { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }
        public Trapez(double _side, double _sideB, double _sideC, double _sideD) : base(_side, _sideB)
        {
            Side = _side;
            SideB = _sideB;
            SideC = _sideC;
            SideD = _sideD;
        }
        public double HeightCalculator()
        {
            //Making a variable that find out s
            double s = (Side + SideB - SideC + SideD) / 2;
            //returns the height of the trapez
            Height  = (2 / (Side - SideC)) + (Math.Sqrt(s * (s - Side + SideC) * (s - SideB) * (s - SideD)));
            return Height;
        }
        public override double Areal()
        {
            return 0.5 * (Side + SideC) * HeightCalculator();
        }
        public override double Perimeter()
        {
            return base.Perimeter();
        }
    }
}
