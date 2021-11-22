using Microsoft.Extensions.DependencyInjection;
using Module2HW4.Provider;
using Module2HW4.Provider.Abstractions;
using Module2HW4.Service;
using Module2HW4.Service.Abstractions;

namespace Module2HW4
{
   public class Starter
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<ISearchService, SearchService>()
                .AddSingleton<ISectionProvider, SectionProvider>()
                .AddSingleton<IAnimalProvider, AnimalProvider>()
                .AddTransient<ISectionService, SectionService>()
                .AddTransient<ICountService, CountService>()
                .AddTransient<Application>()
                .BuildServiceProvider();

            var start = serviceProvider.GetService<Application>();
            start.Start();
        }
    }
}
