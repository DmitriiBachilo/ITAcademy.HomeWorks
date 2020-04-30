using System.Collections.Generic;

namespace HW12
{
    public interface IMotorcycleRepository
    {
        IEnumerable<Motorcycle> GetMotorcycles();

        Motorcycle GetMotorcycleById(int id);

        void AddMotorcycle(Motorcycle moto);

        void UpdateMotorcycle(int id, string name, string model, ushort year, uint odometer, ushort value, ushort maxSpeed, double price);

        void DeleteMotorcycle(int id);
    }
}
