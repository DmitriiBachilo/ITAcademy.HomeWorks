using log4net;

namespace Shapes
{
    class Triangle : Shape
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Triangle));

        public double TriangleBase { get; }

        public double TriangleHeight { get; }

        public Triangle(double triangleBase, double triangleHeight)
        {
            Log.Info($"Triangle created, base: {triangleBase}, height: {triangleHeight}");
            TriangleBase = triangleBase;
            TriangleHeight = triangleHeight;
        }

        public override double CalculateArea()
        {
            return 0.5 * TriangleBase * TriangleHeight;
        }
    }
}
