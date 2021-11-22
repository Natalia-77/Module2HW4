using Module2HW4.Configs.Enum;
using Module2HW4.Model;
using Module2HW4.Model.WarmBlooded;
using Module2HW4.Provider.Abstractions;

namespace Module2HW4.Provider
{
    public class AnimalProvider : IAnimalProvider
    {
        public AnimalProvider()
        {
            Animals = new Animal[]
            {
                new Bear()
                {
                    Name = "Misha",
                    Weight = 500,
                    BearType = BearType.Panda
                },
                new Colibri()
                {
                     Name = "Orchid of sun",
                     Weight = 20,
                     ColibriType = ColibriType.Topaz
                },
                new Eagle()
                {
                    Name = "Orlan",
                    Weight = 50,
                    EagleType = EagleType.Golden
                },
                new Tyger()
                {
                    Name = "Sherkhan",
                    Weight = 200,
                    TigerType = TigerType.Sumatrae
                }
            };
        }

        public Animal[] Animals { get; }
    }
}
