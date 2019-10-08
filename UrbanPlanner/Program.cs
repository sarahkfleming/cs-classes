namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {

            Building FiveOneTwoEighth = new Building("512 8th Avenue")
            {
                Stories = 18,
                Width = 100,
                Depth = 90,
            };

            Building SixEightNineCharlotte = new Building("689 Charlotte Avenue")
            {
                Stories = 9,
                Width = 400,
                Depth = 129,
            };

            Building ThreeZeroOneWestEnd = new Building("301 West End Avenue")
            {
                Stories = 24,
                Width = 900,
                Depth = 567,
            };

            FiveOneTwoEighth.Construct();
            SixEightNineCharlotte.Construct();
            ThreeZeroOneWestEnd.Construct();

            FiveOneTwoEighth.Purchase("Steve Brownlee");
            SixEightNineCharlotte.Purchase("Andy Collins");
            ThreeZeroOneWestEnd.Purchase("Jenna Solis");

            City nashville = new City("Nashville")
            {
                Mayor = "John Cooper"
            };
            
            nashville.EstablishCity(1806);
            
            nashville.PrintCityInfo();
            
            nashville.AddBuilding(FiveOneTwoEighth);
            nashville.AddBuilding(SixEightNineCharlotte);
            nashville.AddBuilding(ThreeZeroOneWestEnd);
            

            foreach (Building building in nashville.buildings)
            {
                building.PrintBuildingInfo();
            }
        }
    }
}
