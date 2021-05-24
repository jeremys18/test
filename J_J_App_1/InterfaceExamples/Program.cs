using System;
using System.Collections.Generic;

namespace InterfaceExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var farm = new List<IAnimal> { new Dog(), new Cat(), new Cow()};
            new Testy(new Dog());

            for(var i = 0; i < farm.Count; i++)
            {
                farm[i].Walk();
                farm[i].Talk();
                var t = farm[i];
                i = new Random().Next(0, 2);
                if(t.GetType() == typeof(Cow))
                {
                    ((Cow)t).Hidden();
                    i = 3;
                }
            }
            Console.Read();
        }
    }
}
