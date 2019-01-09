using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Exercise_6_Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(" ").ToArray();
            List<Cars> cars = new List<Cars>();
            List<Trucks> trucks = new List<Trucks>();
            var totalCarPower = 0;
            var totalTruckPower = 0;


            while (commands[0] != "End")
            {
                string vehicle = commands[0];

                if (vehicle == "car")
                {
                    Cars car = new Cars();
                    car.Model = commands[1];
                    car.Color = commands[2];
                    car.HorsePower = int.Parse(commands[3]);
                    cars.Add(car);
                    totalCarPower += car.HorsePower;
                }
                else if (vehicle == "truck")
                {
                    Trucks truck = new Trucks();
                    truck.Model = commands[1];
                    truck.Color = commands[2];
                    truck.HorsePower = int.Parse(commands[3]);
                    trucks.Add(truck);
                    totalTruckPower += truck.HorsePower;
                }
                commands = Console.ReadLine().Split(" ").ToArray();
            }
            string modelOfCar = Console.ReadLine();

            while (modelOfCar != "Close the Catalogue")
            {
                foreach (var car in cars)
                {
                    if (car.Model == modelOfCar)
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                    }
                }
                foreach (var truck in trucks)
                {
                    if (truck.Model == modelOfCar)
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.HorsePower}");
                    }
                }
                modelOfCar = Console.ReadLine();
            }

            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {(decimal)totalCarPower / cars.Count:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {(decimal)totalTruckPower / trucks.Count:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }
    class Cars
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
    class Trucks
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
}
