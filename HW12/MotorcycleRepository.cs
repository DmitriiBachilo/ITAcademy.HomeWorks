using System.Collections.Generic;
using log4net;

namespace HW12
{
    public class MotorcycleRepository : IMotorcycleRepository
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(MotorcycleRepository));

        private static List<Motorcycle> _motorcycles = new List<Motorcycle>()
        {
            new Motorcycle{Id = 1, Name = "Honda", Model = "Hayabusa", Year = 2012, Odometer = 14000, MaxSpeed = 400, Value = 1300, Price = 9000},
            new Motorcycle{Id = 2, Name = "Ducati", Model = "S1000", Year = 2010, Odometer = 21000, MaxSpeed = 350, Value = 1000, Price = 7000},
            new Motorcycle{Id = 3, Name = "Suzuki", Model = "R900", Year = 2007, Odometer = 8000, MaxSpeed = 340, Value = 900, Price = 6500},
            new Motorcycle{Id = 4, Name = "Yamaha", Model = "Y50", Year = 2005, Odometer = 32500, MaxSpeed = 320, Value = 750, Price = 5000},
            new Motorcycle{Id = 5, Name = "Hongda", Model = "Chineez", Year = 2015, Odometer = 2500, MaxSpeed = 290, Value = 600, Price = 3000}
        };

        public IEnumerable<Motorcycle> GetMotorcycles()
        {
            return _motorcycles;
        }

        public Motorcycle GetMotorcycleById(int id)
        {
            foreach (var item in _motorcycles)
            {
                if (item.Id.Equals(id))
                {
                    Log.Info($"GetMotorcycleById: Motorcycle id = {id} found");
                    return item;
                }
            }
            Log.Info($"GetMotorcycleById: Motorcycle id = {id} not found");

            return null;
        }

        public void AddMotorcycle(Motorcycle moto)
        {
            _motorcycles.Add(moto);
            Log.Info($"AddMotorcycle: Motorcycle id = {moto.Id} added to repository");
        }

        public void UpdateMotorcycle(int id, string name, string model, ushort year, uint odometer, ushort value, ushort maxSpeed,
            double price)
        {
            Motorcycle motorcycle = this.GetMotorcycleById(id);

            if (motorcycle == null)
            {
                Log.Info($"UpdateMotorcycle: Motorcycle id = {id} not found");
            }
            else
            {
                motorcycle.Id = id;
                motorcycle.Name = name;
                motorcycle.Model = model;
                motorcycle.Year = year;
                motorcycle.Odometer = odometer;
                motorcycle.Value = value;
                motorcycle.MaxSpeed = maxSpeed;
                motorcycle.Price = price;

                Log.Info($"UpdateMotorcycle: Motorcycle id = {id} updated");
            }
        }

        public void DeleteMotorcycle(int id)
        {
            Motorcycle motorcycleRemove = this.GetMotorcycleById(id);
            _motorcycles.Remove(motorcycleRemove);
            Log.Info($"DeleteMotorcycle: Motorcycle id = {id} deleted from repository");
        }
    }
}
