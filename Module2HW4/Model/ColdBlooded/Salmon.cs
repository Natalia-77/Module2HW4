using Module2HW4.Configs.Enum;

namespace Module2HW4.Model.ColdBlooded
{
    public class Salmon : Fish
    {
        public Salmon()
        {
            Cover = CoverType.Scales;
            Region = RegionType.Asia;
        }

        public SalmonType SalmonType { get; set; }
        public override bool IsHasGills => true;
    }
}
