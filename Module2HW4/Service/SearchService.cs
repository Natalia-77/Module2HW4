using Module2HW4.Model;
using Module2HW4.Service.Abstractions;

namespace Module2HW4.Service
{
    public class SearchService : ISearchService
    {
        public Animal[] FindAnimals(Animal[] animals, string name)
        {
            var index = 0;
            var findanimal = new Animal[animals.Length];

            for (var i = 0; i < animals.Length; i++)
            {
                if (animals[i].Name == name || animals[i].Name.ToLower() == name)
                {
                    findanimal[index++] = animals[i];
                    break;
                }
                else
                {
                    i++;
                }
            }

            return findanimal;
        }
    }
}
