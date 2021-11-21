using Module2HW4.Config.Enum;

namespace Module2HW4.Model.WarmBlooded
{
    public class Tyger : Mammals
    {
        public Tyger()
        {
            Cover = CoverType.Wool;
            Region = RegionType.Asia;
        }

        public TigerType TigerType { get; }
    }
}
