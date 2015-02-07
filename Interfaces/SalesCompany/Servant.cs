namespace SalesCompany
{
    using System;

    public abstract class Servant : Person, IServant
    {
        private decimal salary;


        public Servant()
        {

        }  

        public Servant (string name, string family, int egn, decimal salary, Department department)
            : base (name, family, egn)
	    {
            this.Salary = salary;
            this.Department = department;
	    }


        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value < 340)
                {
                    throw new ArgumentOutOfRangeException("Salary should be higher than the minimum 340lv");
                }
                if (3000 < value)
                {
                    throw new ArgumentOutOfRangeException("salary must be more than 3500lv");
                }
                this.salary = value;
            }
        }

        public Department Department { get; set; }


        public override string GetInfo()
        {
            string output = String.Format("{0, -15}{1,8}{2, 14}{3, 16:C}", (this.Name + " " + this.Family), this.EGN, 
                this.Department, this.Salary);
            return output;
        }
    }
}
