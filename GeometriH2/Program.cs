using System;
using System.Collections.Generic;

namespace GeometriH2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shapes> shapes = new List<Shapes>();
            shapes.Add(new Trapez(3, 4, 7, 7));
            shapes.Add(new Rectangle(4, 6));
            shapes.Add(new Parallelogram(4, 3, 2.2));
            shapes.Add(new RightAngledTriangle(4, 4));
            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine(shapes[i].Areal());
                Console.WriteLine(shapes[i].Perimeter());
            }
            Console.ReadLine();
        }

    }
}
