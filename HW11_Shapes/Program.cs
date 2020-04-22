using Shapes;
using System;
using log4net;
using log4net.Config;
using System.IO;
using System.Reflection;

namespace HW11_Shapes
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            InitLogger();

            Log.Info("Program start");

            Random rand = new Random();

            Shape[] shapes = new Shape[]
            {
                new Circle(rand.Next(1, 10)),
                new Triangle(rand.Next(1, 10), rand.Next(1, 10)),
                new Square(rand.Next(1, 10))
            };

            ShapesInfo(shapes);
        }

        private static void InitLogger()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
        }

        public static void ShapesInfo(Shape[] shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine($"This is {shape.GetType().Name}. CLR type is {shape.GetType()}. Square is {shape.CalculateArea()}");
                Log.Info("output to the console of the figure: {item.Name}");
            }
            Log.Info("Program completed successfully");
        }
    }
}
