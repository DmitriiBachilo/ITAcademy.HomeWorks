
namespace HW12
{
    public class Motorcycle
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public ushort Year { get; set; }

        public uint Odometer { get; set; }

        public ushort Value { get; set; }

        public ushort MaxSpeed { get; set; }

        public double Price { get; set; }

        public Motorcycle()
        {

        }

        public Motorcycle(int id, string name, string model, ushort year, uint odometer, ushort value, ushort maxSpeed, double price)
        {
            Id = id;
            Name = name;
            Model = model;
            Year = year;
            Odometer = odometer;
            Value = value;
            MaxSpeed = maxSpeed;
            Price = price;
        }
    }
}
