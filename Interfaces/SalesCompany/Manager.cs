namespace SalesCompany
{
    using System; 

    class Manager : Servant
    {
        public Manager()
        {

        }

        public Manager(string name, string family, int egn, decimal salary, Department department)
            : base(name, family, egn, salary, department)
        {
                
        }

        //public override string GetInfo()
        //{
        //    return "name: " + this.Name + " " + this.Family + " EGN: " + this.EGN + "salary: " + this.Salary + " " + this.Department;
        //}
    }
}
