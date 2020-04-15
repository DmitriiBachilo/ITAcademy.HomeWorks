using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Shapes
{
    class Circle : Shape
    {
        public double CircleRadius { get; }

        public Circle(double circleRadius)
        {
            CircleRadius = circleRadius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(CircleRadius, 2);
        }
    }
}
