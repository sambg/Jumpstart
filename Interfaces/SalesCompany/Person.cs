namespace SalesCompany
{
    using System;

    public abstract class Person : IPerson
    {
        private string name;
        private string family;
        private int egn;


        public Person()
        {

        }

        public Person(string name, string family, int egn)
        {
            this.Name = name;
            this.Family = family;
            this.EGN = egn;
        }


        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                ValidationOfName( value );
                this.name = value; 
            }
        }

        public string Family
        {
            get
            {
                return this.family;
            }
            set
            {
                ValidationOfName(value);
                this.family = value;
            }
        }

        public int EGN
        {
            get
            {
                return this.egn;
            }
            set 
            {
                if ((value < 1000) || (value > 999999))
                {
                    throw new ArgumentOutOfRangeException(" EGN must be six digit ");
                }
                this.egn = value;
            }
            
        }


        private void ValidationOfName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name cannot be null or empty");
            }
            if (value.Length < 4)
            {
                throw new ArgumentException("Name is too short, must have at least 3 letters");
            }
        }

        public virtual string GetInfo()
        {
            return "name: " + this.Name + " " + this.Family + " EGN: " + this.EGN;
        }
    }
}
