using Module2HW4.Config.Enum;

namespace Module2HW4.Model.ColdBlooded
{
    public abstract class ColdBlooded : Animal
    {
        public override BloodedType Blood => BloodedType.Cold;
        public override bool IsHasGills => true;
    }
}
