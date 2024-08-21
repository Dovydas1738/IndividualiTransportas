using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualiTransportas.Models;
using Microsoft.EntityFrameworkCore;

namespace IndividualiTransportas.Repositories
{
    public class VehicleRepository
    {
        public async Task<List<Car>> ReadAllCars()
        {
            using (var context = new IndividualiTransportasContext())
            {
                List<Car> allCars = await context.Cars.ToListAsync();
                return allCars;
            }
        }

        public async Task<List<Truck>> ReadAllTrucks()
        {
            using (var context = new IndividualiTransportasContext())
            {
                List<Truck> allTrucks = await context.Trucks.ToListAsync();
                return allTrucks;
            }
        }


        public void AddCar(Car car)
        {
            using (var context = new IndividualiTransportasContext())
            {
                context.Cars.Add(car);
                context.SaveChanges();
            }

        }

        public void AddTruck(Truck truck)
        {
            using (var context = new IndividualiTransportasContext())
            {
                context.Trucks.Add(truck);
                context.SaveChanges();
            }

        }

    }
}
