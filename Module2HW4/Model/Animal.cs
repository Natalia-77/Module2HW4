using Module2HW4.Configs.Enum;

namespace Module2HW4.Model
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public abstract BloodedType Blood { get; }
        public abstract BodyTemperature Temperature { get; }
        public CoverType Cover { get; set; }
        public RegionType Region { get; set; }
    }
}
