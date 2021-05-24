using System;

namespace InterfaceExamples
{
    class Dog : IAnimal
    {
        private int _age;
        public int Age { get => _age; set => _age = value; }

        public Dog()
        {
            _age = 6;
        }

        public void Talk()
        {
            Console.WriteLine("Woof Woof!\n");
        }

        public void Walk()
        {
            Console.WriteLine("Rubs butt on carpet\n");
        }
    }
}
