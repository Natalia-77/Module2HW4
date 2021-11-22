using Module2HW4.Configs.Enum;

namespace Module2HW4.Model.ColdBlooded
{
    public class GoldFish : Fish
    {
        public GoldFish()
        {
            Cover = CoverType.Scales;
            Region = RegionType.Africa;
        }

        public GoldFishType GoldFishType { get; set; }
        public override bool IsHasGills => true;
    }
}
