namespace DataAccessLayer.Entities
{
    public class Helicopter
    {
        public string Id { get; set; }
        public string Model { get; set; }

        public int CruiseSpeed { get; set; }

        public int EmptyWeight { get; set; }

        public int MaxTakeoffWeight { get; set; }

        public int Range { get; set; }

        public Helicopter()
        {
            Id = null;
            Model = null;
            CruiseSpeed = 0;
            EmptyWeight = 0;
            MaxTakeoffWeight = 0;
            Range = 0;
        }

        public Helicopter(string id, string model, int cruiseSpeed, int emptyWeight, int maxTakeoffWeight, int range)
        {
            Id = id;
            Model = model;
            CruiseSpeed = cruiseSpeed;
            EmptyWeight = emptyWeight;
            MaxTakeoffWeight = maxTakeoffWeight;
            Range = range;
        }


    }
}
