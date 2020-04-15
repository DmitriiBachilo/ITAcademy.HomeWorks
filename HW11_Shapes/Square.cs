using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square : Shape
    {
        public double SquareSide { get; }

        public Square(double squareSide)
        {
            SquareSide = squareSide;
        }

        public override double CalculateArea()
        {
            return Math.Pow(SquareSide, 2);
        }
    }
    
}
