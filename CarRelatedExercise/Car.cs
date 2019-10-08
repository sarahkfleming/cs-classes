using System;

namespace CarRelatedExercise
{
    public class Car
    {
        // _milesDriven is a field; fields don't have get or set. Fields are usually private.
        private int _milesDriven = 0;
        
        // Constructor
        public Car(int startingMiles)
        {
            _milesDriven = startingMiles;
        }        
        // Get and set are called accessors. They can individually be marked as private, if needed
        // public int MilesDriven { get; private set;}
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        
        // Computed properties example
        public string Description
        {
            get
            {
                return $"A {Year} {Make} {Model}";
            }
        }

        public int Drive(int miles)
        {
            _milesDriven += miles;
            return _milesDriven;
        }

        // Use void if the method doesn't return something
        public void Accelerate()
        {
            Console.WriteLine($"The {Make} {Model} goes Vroom");
        }

        public int GetAge()
        {
            DateTime date = DateTime.Now;
            int currentYear = date.Year;
            return currentYear - Year;
        }
    }
}