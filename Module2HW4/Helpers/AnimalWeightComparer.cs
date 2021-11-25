using System.Collections.Generic;
using Module2HW4.Model;

namespace Module2HW4.Helpers
{
    public class AnimalWeightComparer : IComparer<Animal>
    {
        public int Compare(Animal first, Animal second)
        {
            if (first.Weight > second.Weight)
            {
                return 1;
            }
            else if (first.Weight < second.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
