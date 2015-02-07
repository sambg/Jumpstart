
namespace AnimalI
{
    using System;

    public class Dog : Animal, ISound
    {
        public Dog()
        {

        }

        public Dog(string name, int age, Sex sex)
            :base(name, age, sex)
        {
            this.Name = name;
            this.Age = age;
            this.SexAnimal = sex;
        }

        
        public override void ProduceSound()
        {
            Console.WriteLine(this.Name + " sed: " + "bau, bau");
        }


    }
}
