using Module2HW4.Config.Enum;

namespace Module2HW4.Model.WarmBlooded
{
    public class Eagle : Birds
    {
        public Eagle()
        {
            Cover = CoverType.Feather;
            Region = RegionType.East;
        }

        public EagleType EagleType { get; }
    }
}
