namespace AnimalI
{
    using System;
    public abstract class Cat : Animal, ISound
    {
        public Cat()
        {

        } 

        public Cat (string name, int age, Sex sex)
            :base(name, age, sex)
        {
            this.Name = name;
            this.Age = age;
            this.SexAnimal = sex;
        }

        public override void ProduceSound()
        {
            Console.WriteLine(this.Name + "sed: " + "miau, miau");
        }

        public override void GetInfo()
        {
            Console.WriteLine(this.Name + " " + this.Age + " " + this.SexAnimal);
        }
    }
}
