using Microsoft.Extensions.DependencyInjection;
using Module2HW4.Model;
using Module2HW4.Model.WarmBlooded;
using Module2HW4.Provider;
using Module2HW4.Provider.Abstractions;
using Module2HW4.Service;
using Module2HW4.Service.Abstractions;

namespace Module2HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var starter = new Starter();
            starter.Run();
        }
    }
}
