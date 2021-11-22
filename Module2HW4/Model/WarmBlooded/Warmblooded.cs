using Module2HW4.Configs.Enum;

namespace Module2HW4.Model.WarmBlooded
{
    public abstract class Warmblooded : Animal
    {
        public override BloodedType Blood => BloodedType.Warm;
        public override BodyTemperature Temperature => BodyTemperature.Stable;
    }
}
