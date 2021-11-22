using Module2HW4.Configs.Enum;

namespace Module2HW4.Model.WarmBlooded
{
    public class Tyger : Mammals
    {
        public Tyger()
        {
            Cover = CoverType.Wool;
            Region = RegionType.Asia;
        }

        public TigerType TigerType { get; set; }

        public override bool IsHasBeak => false;
    }
}
