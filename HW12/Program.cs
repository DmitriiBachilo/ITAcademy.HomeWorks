using System;
using log4net;
using log4net.Config;
using System.IO;
using System.Reflection;

namespace HW12
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            InitLogger();
            Log.Info("Program start");

            Motorcycle newMotorcycle = new Motorcycle()
            {
                Id = 6,
                Name = "Unknown",
                MaxSpeed = 300,
                Model = "Unknown",
                Price = 3_000,
                Value = 1250
            };

            var repo = new MotorcycleRepository();
            repo.DeleteMotorcycle(5);
            repo.AddMotorcycle(newMotorcycle);
            repo.UpdateMotorcycle(7, "Honda", "R900", 2018, 0, 900, 340, 9999);

            var motos = repo.GetMotorcycles();
            foreach (var moto in motos)
            {
                Console.WriteLine($"{moto.Name} - {moto.Model} - {moto.Price}");
            }

            Log.Info("Program completed successfully");
        }

        private static void InitLogger()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
        }
    }
}
