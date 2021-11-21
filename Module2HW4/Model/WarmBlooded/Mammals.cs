using Module2HW4.Config.Enum;

namespace Module2HW4.Model.WarmBlooded
{
    public abstract class Mammals : Warmblooded
    {
        public override BodyTemperature Temperature => BodyTemperature.Stable;
        public override bool IsHasGills => false;
    }
}
