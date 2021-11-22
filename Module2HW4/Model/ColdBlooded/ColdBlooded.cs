using Module2HW4.Configs.Enum;

namespace Module2HW4.Model.ColdBlooded
{
    public abstract class ColdBlooded : Animal
    {
        public override BloodedType Blood => BloodedType.Cold;
        public override BodyTemperature Temperature => BodyTemperature.Unstable;

    }
}
