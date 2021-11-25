using Module2HW4.Model;

namespace Module2HW4.Provider.Abstractions
{
    public interface ISectionProvider
    {
        public Animal[] AnimalInSection { get; set; }
    }
}
