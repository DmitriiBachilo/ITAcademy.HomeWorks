using System;
using log4net;

namespace Shapes
{
    class Circle : Shape
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Circle));

        public double CircleRadius { get; }

        public Circle(double circleRadius)
        {
            Log.Info($"Circle created, radius: {circleRadius}");
            CircleRadius = circleRadius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(CircleRadius, 2);
        }
    }
}
