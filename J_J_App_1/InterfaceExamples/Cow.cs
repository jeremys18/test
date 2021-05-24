using System;

namespace InterfaceExamples
{
    class Cow : IAnimal
    {
        private decimal _age;
        public int Age { get => (int)_age; set => _age = (decimal)value; }

        public Cow()
        {
            Age = 90;
        }

        public void Talk()
        {
            Console.WriteLine("MOOOOOO!!!\n");
        }

        public void Walk()
        {
            Console.WriteLine("Stomp Stomp Stompy\n");
        }

        public void Hidden()
        {
            Console.WriteLine("Noooo! You found me\n");
        }
    }
}
