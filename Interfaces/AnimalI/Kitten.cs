namespace AnimalI
{
    using System;

    public class Kitten : Cat, ISound
    {
        private Sex sex;

        public Kitten()
        {

        }

        public Kitten(string name, int age, Sex sex)
            : base(name, age, sex)
        {
            this.Name = name;
            this.Age = age;
            this.SexAnimal = sex;
        }
         

        public Sex SexAnimal
        {
            get
            {
                return this.sex;
            }
            set
            {
                if (value == Sex.Male)
                {
                    throw new ArgumentException("The sex must be female");
                }
                this.sex = value;
            }
        }


        public override void ProduceSound()
        {
            Console.WriteLine(this.Name + " sed: " + "miau, miau");
        }

        public override void GetInfo()
        {
            Console.WriteLine(this.Name + " " + this.Age + " " + this.SexAnimal);
        }
    }
}
