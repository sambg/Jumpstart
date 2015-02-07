namespace AnimalI
{
    using System;

    class TomCat : Cat, ISound
    {
        private Sex sex;


        public TomCat()
        {

        }

        public TomCat(string name, int age, Sex sex)
            : base (name, age, sex)
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
                if (value == Sex.Female)
                {
                    throw new ArgumentException("The sex must be male");
                }
                this.sex = value;
            }
        }


        public override void ProduceSound()
        {
            Console.WriteLine(this.Name + " sed: " + "mau, mau");
        }
    }
}
