using System.Collections.Generic;
using Module2HW4.Model;

namespace Module2HW4.Helpers
{
    public class AninalComparer : IComparer<Animal>
    {
        public int Compare(Animal first, Animal second)
        {
            if (first.Name.Length > second.Name.Length)
            {
                return 1;
            }
            else if (first.Name.Length < second.Name.Length)
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
