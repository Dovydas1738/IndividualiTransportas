using Microsoft.IdentityModel.Tokens;
using System;
using IndividualiTransportas.Models;
using IndividualiTransportas.Repositories;
using IndividualiTransportas.Contracts;
using MongoDB.Driver;

namespace MyProgram
{
    public class MainClass
    {
        public static void Main(string[] args)
        {

            IVehicleRepository _vehicleRepository = new VehicleRepository();
            IMongoClient _mongoClient = new MongoClient("mongodb+srv://dovism:SLAPTAZODIS@cluster0.dh7gm.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
            IWorkerMongoRepository _workerMongoRepository = new WorkerMongoRepository(_mongoClient);

            Console.WriteLine("Truck or Car? (1 - truck, 2 - car, 3-skip)");
            int vehicleChoice = int.Parse(Console.ReadLine());
            if (vehicleChoice == 1)
            {
                Console.WriteLine("Maker:");
                string maker = Console.ReadLine();

                Console.WriteLine("Model:");
                string model = Console.ReadLine();

                Console.WriteLine("Year:");
                int year = int.Parse(Console.ReadLine());

                Console.WriteLine("Max load:");
                int maxLoad = int.Parse(Console.ReadLine());

                Truck newTruck = new Truck(maker, model, year, maxLoad);
                _vehicleRepository.AddTruck(newTruck);

                Console.WriteLine("Truck added successfully!");
                Console.WriteLine();
                Console.WriteLine("All cars:");
                foreach (Car c in _vehicleRepository.ReadAllCars().Result)
                {
                    Console.WriteLine(c);
                }
                Console.WriteLine();
                Console.WriteLine("All trucks:");
                foreach (Truck t in _vehicleRepository.ReadAllTrucks().Result)
                {
                    Console.WriteLine(t);
                }
                Console.WriteLine();


            }
            else if (vehicleChoice == 2)
            {
                Console.WriteLine("Maker:");
                string maker = Console.ReadLine();

                Console.WriteLine("Model:");
                string model = Console.ReadLine();

                Console.WriteLine("Year:");
                int year = int.Parse(Console.ReadLine());

                Console.WriteLine("Door count:");
                int doorCount = int.Parse(Console.ReadLine());

                Car newCar = new Car(maker, model, year, doorCount);
                _vehicleRepository.AddCar(newCar);

                Console.WriteLine("Car added successfully!");

                Console.WriteLine("Truck added successfully!");
                Console.WriteLine();
                Console.WriteLine("All cars:");
                foreach (Car c in _vehicleRepository.ReadAllCars().Result)
                {
                    Console.WriteLine(c);
                }
                Console.WriteLine();
                Console.WriteLine("All trucks:");
                foreach (Truck t in _vehicleRepository.ReadAllTrucks().Result)
                {
                    Console.WriteLine(t);
                }
                Console.WriteLine();

            }


            Console.WriteLine("Adding worker. 1-office worker, 2-production worker, 3-exit");
            int workerChoice = int.Parse(Console.ReadLine());

            switch (workerChoice)
            {
                case 1:

                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Surname:");
                    string surname = Console.ReadLine();

                    Console.WriteLine("Age:");
                    int age = int.Parse(Console.ReadLine());

                    Console.WriteLine("Department:");
                    string department = Console.ReadLine();

                    OfficeWorker newOfficeWorker = new OfficeWorker(name, surname, age, department);
                    _workerMongoRepository.AddOfficeWorker(newOfficeWorker);

                    Console.WriteLine("Office worker added successfully!");

                    Console.WriteLine();
                    Console.WriteLine("All office workers:");
                    foreach (OfficeWorker o in _workerMongoRepository.ReadAllOfficeWorkers().Result)
                    {
                        Console.WriteLine(o);
                    }
                    Console.WriteLine();
                    Console.WriteLine("All production workers:");
                    foreach (ProductionWorker p in _workerMongoRepository.ReadAllProductionWorkers().Result)
                    {
                        Console.WriteLine(p);
                    }
                    Console.WriteLine();


                    break;

                case 2:

                    Console.WriteLine("Name:");
                    string nameProd = Console.ReadLine();

                    Console.WriteLine("Surname:");
                    string surnameProd = Console.ReadLine();

                    Console.WriteLine("Age:");
                    int ageProd = int.Parse(Console.ReadLine());

                    Console.WriteLine("Shift:");
                    string shift = Console.ReadLine();

                    ProductionWorker newProductionWorker = new ProductionWorker(nameProd, surnameProd, ageProd, shift);
                    _workerMongoRepository.AddProductionWorker(newProductionWorker);

                    Console.WriteLine("Office worker added successfully!");

                    Console.WriteLine();
                    Console.WriteLine("All office workers:");
                    foreach (OfficeWorker o in _workerMongoRepository.ReadAllOfficeWorkers().Result)
                    {
                        Console.WriteLine(o);
                    }
                    Console.WriteLine();
                    Console.WriteLine("All production workers:");
                    foreach (ProductionWorker p in _workerMongoRepository.ReadAllProductionWorkers().Result)
                    {
                        Console.WriteLine(p);
                    }
                    Console.WriteLine();

                    break;

                case 3:
                    break;

            }
        }
    }
}

