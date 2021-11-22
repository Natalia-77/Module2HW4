using System;
using Module2HW4.Provider.Abstractions;
using Module2HW4.Service.Abstractions;

namespace Module2HW4
{
    public class Application
    {
        private readonly ISectionProvider _sectionProvider;
        private readonly ISectionService _sectionService;
        private readonly ISearchService _searchService;

        public Application(ISectionProvider sectionProvider, ISectionService sectionService, ISearchService searchService)
        {
            _sectionProvider = sectionProvider;
            _sectionService = sectionService;
            _searchService = searchService;
        }

        public void Start()
        {
            _sectionService.AddAnimalToSection();
            _sectionService.SortAnimalByName();
        }
    }
}
