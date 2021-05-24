using System;
using System.Collections.Generic;

namespace InterfaceExamples
{
    class Testy
    {
        public Testy(IAnimal animal)
        {
            var d = new Dictionary<Type, string>
            {
                {typeof(Dog), "Doggy" },
                {typeof(Cat), "Mr. Grumpy Pants" },
                {typeof(Cow), "Milk supplier" }
            };
            Console.WriteLine($"Hi {d[animal.GetType()]}");
        }
    }
}
