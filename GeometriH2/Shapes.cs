using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriH2
{
    public class Shapes
    {
        public double Side { get; set; }
        public double SideB { get; set; }
        public Shapes(double _side, double _sideB)
        {
            Side = _side;
            SideB = _sideB;
        }
        //Creating virtual methods that can i override to the specific shape
        public virtual double Perimeter()
        {
            return 0;
        }
        public virtual double Areal()
        {
            return 0;
        }

    }
}
