using System;
using Module2HW4.Model;

namespace Module2HW4.Service.Abstractions
{
    public interface ISearchService
    {
        public Animal FindAnimals(Animal[] animals, string name);
        public Animal FindAnimalByType(Animal[] animals, Type type);
    }
}
