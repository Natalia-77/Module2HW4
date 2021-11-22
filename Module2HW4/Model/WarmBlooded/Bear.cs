using Module2HW4.Configs.Enum;

namespace Module2HW4.Model.WarmBlooded
{
    public class Bear : Mammals
    {
        public Bear()
        {
            Cover = CoverType.Wool;
            Region = RegionType.Asia;
        }

        public BearType BearType { get; set; }
    }
}
