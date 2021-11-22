using Module2HW4.Configs.Enum;

namespace Module2HW4.Model.WarmBlooded
{
    public abstract class Mammals : Warmblooded
    {
        // наличие клюва.
        public abstract bool IsHasBeak { get; }
    }
}
