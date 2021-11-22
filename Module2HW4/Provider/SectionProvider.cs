using Module2HW4.Model;
using Module2HW4.Provider.Abstractions;

namespace Module2HW4.Provider
{
    public class SectionProvider : ISectionProvider
    {
        public Animal[] AnimalInSection { get; set; }
    }
}
