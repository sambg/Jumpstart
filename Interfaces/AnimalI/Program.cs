namespace AnimalI
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
          
            var animals = new List<Animal>
            {
                new Dog
                {
                    Name = "Puhcho",
                    Age = 3,
                    SexAnimal = Sex.Male
                },
                new Frog
                {
                    Name = "Karmit",
                    Age = 7,
                    SexAnimal = Sex.Male
                },
                new Kitten
                {
                    Name = "Caty",
                    Age = 7,
                    SexAnimal = Sex.Female
                },
                new TomCat
                {
                    Name = "Tom",
                    Age = 2,
                    SexAnimal = Sex.Male
                },
            };

            foreach (var animal in animals)
            {
                animal.GetInfo();
                animal.ProduceSound();
            }
        }
    }
}
