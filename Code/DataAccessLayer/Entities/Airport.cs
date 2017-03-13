namespace DataAccessLayer.Entities
{
    public class Airport
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int RunwaySize { get; set; }

        public int MaxFixedWingParkingPlace { get; set; }

        public int MaxRotatedWingParkingPlace { get; set; }

        public Airport()
        {
            Id = null;
            Name = null;
            RunwaySize = 0;
            MaxFixedWingParkingPlace = 0;
            MaxRotatedWingParkingPlace = 0;
        }

        public Airport(string id, string name, int runwaySize, int maxFixedWingParkingPlace, int maxRotatedWingParkingPlace)
        {
            Id = id;
            Name = name;
            RunwaySize = runwaySize;
            MaxFixedWingParkingPlace = maxFixedWingParkingPlace;
            MaxRotatedWingParkingPlace = maxRotatedWingParkingPlace;
        }
    }
}
