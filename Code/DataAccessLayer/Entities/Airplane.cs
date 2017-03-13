namespace DataAccessLayer.Entities
{
    public class Airplane
    {
        public string Id { get; set; }

        public string Model { get; set; }

        public string PlaneType { get; set; }

        public int CruiseSpeed { get; set; }

        public int EmptyWeight { get; set; }

        public int MaxTakeoffWeight { get; set; }

        public int MinNeededRunwaySize { get; set; }

        public Airplane()
        {
            Id = null;
            Model = null;
            PlaneType = null;
            CruiseSpeed = 0;
            EmptyWeight = 0;
            MaxTakeoffWeight = 0;
            MinNeededRunwaySize = 0;
        }

        public Airplane(string id, string model, string planeType, int cruiseSpeed, int emptyWeight, int maxTakeoffWeight, int minNeededRunwaySize)
        {
            Id = id;
            Model = model;
            PlaneType = planeType;
            CruiseSpeed = cruiseSpeed;
            EmptyWeight = emptyWeight;
            MaxTakeoffWeight = maxTakeoffWeight;
            MinNeededRunwaySize = minNeededRunwaySize;
        }
    }
}
