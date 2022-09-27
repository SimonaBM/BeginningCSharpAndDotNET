using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal interface Chicken
    {
    }
}

using System;
​
namespace Objects
{
    public class Chicken : Animal
    {
        public Chicken() : base()
        { }
        public Chicken(string name, int age) : base(name, age)
        { }
        public void Cluck()
        {
            Console.WriteLine($"{Name} is Clucking!");
        }
        public void LayEgg()
        {
            Console.WriteLine($"{Name} is laying eggs!");
        }
    }
}
