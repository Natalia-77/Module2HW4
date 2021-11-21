using Module2HW4.Config.Enum;

namespace Module2HW4.Model.WarmBlooded
{
    public abstract class Warmblooded : Animal
    {
        public override BloodedType Blood => BloodedType.Warm;
        public abstract BodyTemperature Temperature { get; }
    }
}
