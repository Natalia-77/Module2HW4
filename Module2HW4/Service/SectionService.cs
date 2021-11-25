using System;
using Module2HW4.Helpers;
using Module2HW4.Model;
using Module2HW4.Provider.Abstractions;
using Module2HW4.Service.Abstractions;

namespace Module2HW4.Service
{
    public class SectionService : ISectionService
    {
        private readonly IAnimalProvider _animalProvider;
        private readonly ISectionProvider _sectionProvider;
        public SectionService(IAnimalProvider animalProvider, ISectionProvider sectionProvider)
        {
            _animalProvider = animalProvider;
            _sectionProvider = sectionProvider;
        }

        public void AddAnimalToSection()
        {
            const int animalInSection = 5;
            Animal[] animals = new Animal[animalInSection];
            for (var i = 0; i < animals.Length; i++)
            {
                animals[i] = _animalProvider.Animals[new Random().Next(0, _animalProvider.Animals.Length)];
                _sectionProvider.AnimalInSection = animals;
            }
        }

        public void SortAnimalByName()
        {
            Array.Sort(_sectionProvider.AnimalInSection, new AninalComparer());
        }

        public void SortAnimalByWeight()
        {
            Array.Sort(_sectionProvider.AnimalInSection, new AnimalWeightComparer());
        }
    }
}
