using Module2HW4.Model;
using Module2HW4.Model.WarmBlooded;

namespace Module2HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var animals = new Animal[]
                        {
                             new Bear() { Name = "hhh", Weight = 100 }
                        };

            foreach (var item in animals)
            {
                System.Console.WriteLine(item.Region);
            }
        }
    }
}
