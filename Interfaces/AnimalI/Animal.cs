namespace AnimalI
{
    using System;

    public abstract class Animal: ISound
    {
        private string name;
        private int age;


        public Animal()
        {

        }

        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.SexAnimal = sex;
        } 


        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty"); 
                }
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Nmae is too short: ", value);
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if ((value < 1) || (value > 20))
                {
                    throw new ArgumentOutOfRangeException("The age must be between 1 and 19");
                }
                this.age = value;
            }
        }

        public Sex SexAnimal;


        public void ProduceSound(string name)
        {
            Console.WriteLine(this.Name + "sed: ");
        }

        public abstract void ProduceSound();

        public virtual void GetInfo()
        {
            Console.WriteLine(this.Name + " " + this.Age + " " + this.SexAnimal);
        }
    }
}
