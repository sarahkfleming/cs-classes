using System;
using System.Collections.Generic;

namespace UrbanPlanner
{
    public class City
    {
        public City(string cityName)
        {
            _cityName = cityName;
        }
        private string _cityName;
        private int _yearEstablished;
        public void EstablishCity(int year)
        {
            _yearEstablished = year;
        }
        public string Mayor { get; set; }
        public List<Building> buildings = new List<Building>();
        
        public void AddBuilding(Building building)
        {
            buildings.Add(building);
        }
        public void PrintCityInfo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"{_cityName}");
            Console.WriteLine("----------------------");
            Console.WriteLine($"Mayor: {Mayor}");
            Console.WriteLine($"Established: {_yearEstablished}");
            Console.WriteLine();
        }
    }
}