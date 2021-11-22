using Module2HW4.Configs.Enum;

namespace Module2HW4.Model.WarmBlooded
{
    public class Eagle : Birds
    {
        public Eagle()
        {
            Cover = CoverType.Feather;
            Region = RegionType.East;
        }

        public EagleType EagleType { get; set; }

        public override bool IsHasBeak => true;
    }
}
