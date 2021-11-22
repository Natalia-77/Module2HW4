using Module2HW4.Model.WarmBlooded;
using Module2HW4.Provider.Abstractions;
using Module2HW4.Service.Abstractions;

namespace Module2HW4
{
    public class Application
    {
        private readonly ISectionProvider _sectionProvider;
        private readonly ISectionService _sectionService;
        private readonly ISearchService _searchService;
        private readonly ICountService _countService;

        public Application(ISectionProvider sectionProvider, ISectionService sectionService, ISearchService searchService, ICountService countService)
        {
            _sectionProvider = sectionProvider;
            _sectionService = sectionService;
            _searchService = searchService;
            _countService = countService;
        }

        public void Start()
        {
            _sectionService.AddAnimalToSection();
            _sectionService.SortAnimalByName();
            _sectionService.SortAnimalByWeight();
            var sectionAnimals = _sectionProvider.AnimalInSection;
            _searchService.FindAnimals(sectionAnimals, "Misha");
            _searchService.FindAnimalByType(sectionAnimals, typeof(Bear));
            _countService.TypesCount(typeof(Eagle));
        }
    }
}
