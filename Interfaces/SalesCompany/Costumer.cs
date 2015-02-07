namespace SalesCompany
{
    using System; 

    public class Costumer : Person
    {
        public Costumer()
        {

        }

        public Costumer(string name, string family, int egn)
            : base(name, family, egn)
        {
            this.Name = name;
            this.Family = family;
            this.EGN = egn;
        }

        public override string GetInfo()
        {
            string output = "name: " + this.Name + " " + this.Family + "    EGN: " + this.EGN;
            return output;
        }
    }
}
