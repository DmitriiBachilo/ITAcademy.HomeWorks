using Shapes;
using System;
using System.Security.Cryptography.X509Certificates;

namespace HW11_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Shape[] shapes = new Shape[]
            {
                new Circle(rand.Next(1, 10)),
                new Triangle(rand.Next(1, 10), rand.Next(1, 10)),
                new Square(rand.Next(1, 10))
            };

            ShapesInfo(shapes);
        }

        public static void ShapesInfo(Shape[] shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine($"This is {shape.GetType().Name}. CLR type is {shape.GetType()}. Square is {shape.CalculateArea()}");
            }
        }
    }
}
