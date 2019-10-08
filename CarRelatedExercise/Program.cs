using System;
using System.Collections.Generic;

namespace CarRelatedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of the Car class
            Car car1 = new Car(50000);
            car1.Make = "Ford";
            car1.Model = "Explorer";
            car1.Year = 1999;
            car1.Price = 1000.50;

            Car car2 = new Car(80000)
            {
                Make = "Mazda",
                Model = "B2500",
                Year = 1999,
                Price = 115.99
            };

            Car car3 = new Car(10000)
            {
                Make = "Nissan",
                Model = "GTR",
                Year = 2018,
                Price = 79999.99
            };

            List<Car> garage = new List<Car>();
            garage.Add(car1);
            garage.Add(car2);
            garage.Add(car3);

            foreach (Car car in garage)
            {
                car.Accelerate();
                int carAge = car.GetAge();
                Console.WriteLine($"Car Age: {carAge}");
                Console.WriteLine($"Car Description: {car.Description}");
                Console.WriteLine();
                
                car.Drive(1000);
            }
        }
    }
}
