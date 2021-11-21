using Module2HW4.Config.Enum;

namespace Module2HW4.Model.WarmBlooded
{
    public class Colibri : Birds
    {
        public Colibri()
        {
            Cover = CoverType.Feather;
            Region = RegionType.America;
        }

        public ColibriType ColibriType { get; }
    }
}
