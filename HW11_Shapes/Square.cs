using log4net;
using System;

namespace Shapes
{
    class Square : Shape
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Square));

        public double SquareSide { get; }

        public Square(double squareSide)
        {
            Log.Info($"Square created, side: {squareSide}");
            SquareSide = squareSide;
        }

        public override double CalculateArea()
        {
            return Math.Pow(SquareSide, 2);
        }
    }
    
}
