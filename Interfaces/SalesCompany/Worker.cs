namespace SalesCompany
{
    using System;

    public class Worker : Servant 
    {
        public Worker()
        {

        }

        public Worker(string name, string family, int egn, decimal salary, Department department)
            : base(name, family, egn, salary, department)
        {
                
        }
    }
}
