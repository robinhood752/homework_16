using System;

namespace Exercise_16
{
    class Program
    {
        public static void Main()
        {
            Animal[] animals = new Animal[]
            {
                new Dog("Meat", "Dogmeat"),
                new Horse(true, "Plotva"),
                new Wolf("Pack", "Humans", "Beta"),
                new Poodle(0, "Humans", "Wolfie")
            };

            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
