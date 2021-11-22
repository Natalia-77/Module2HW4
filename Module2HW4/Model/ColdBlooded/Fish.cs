using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Model.ColdBlooded
{
    public abstract class Fish : ColdBlooded
    {
        // наличие жабров.
        public abstract bool IsHasGills { get; }
    }
}
