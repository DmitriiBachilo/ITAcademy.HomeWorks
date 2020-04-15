using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Shapes
{
    class Triangle : Shape
    {
        public double TriangleBase { get; }

        public double TriangleHeight { get; }

        public Triangle(double triangleBase, double triangleHeight)
        {
            TriangleBase = triangleBase;
            TriangleHeight = triangleHeight;
        }

        public override double CalculateArea()
        {
            return 0.5 * TriangleBase * TriangleHeight;
        }
    }
}
