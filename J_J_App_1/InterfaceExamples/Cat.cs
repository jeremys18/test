using System;

namespace InterfaceExamples
{
    class Cat : IAnimal
    {
        private int _age;
        public int Age { get => _age; set => _age = value; }

        public Cat()
        {
            Age = 2;
        }

        public void Talk()
        {
            Console.WriteLine("Meow. Purr\n");
        }

        public void Walk()
        {
            Console.WriteLine("Prance Prance Prance\n");
        }
    }
}
