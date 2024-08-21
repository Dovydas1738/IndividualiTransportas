using IndividualiTransportas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualiTransportas.Contracts
{
    public interface IVehicleRepository
    {
        Task<List<Car>> ReadAllCars();
        Task<List<Truck>> ReadAllTrucks();
        void AddCar(Car car);
        void AddTruck(Truck truck);
    }
}
