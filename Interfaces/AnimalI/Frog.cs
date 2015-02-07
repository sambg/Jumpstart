namespace AnimalI
{
    using System;

    public class Frog : Animal, ISound
    {
        public Frog()
        {

        }
        public Frog (string name, int age, Sex sex)
            :base(name, age, sex)
        {
            this.Name = name;
            this.Age = age;
            this.SexAnimal = sex;
        }
         

        public override void ProduceSound()
        {
            Console.WriteLine(this.Name + " sed: " + "kva, kva");
        }
    }
}
