
namespace SalesCompany
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            //var worker = new Worker("Ivan", "Peshev", 700324, 54.32m, Department.Sales);
            //Console.WriteLine(worker.GetInfo());
            //var costumer = new Costumer("Ivan", "Peshev", 700324);
            //Console.WriteLine((costumer.GetInfo());

            var persons = new List<Person>
            {
                new Manager
                {
                    Name = "Ivan",
                    Family = "Geshev",
                    EGN = 780914,
                    Salary = 1800,
                    Department = Department.Marketing
                },
                new Manager
                {
                    Name = "Goro",
                    Family = "Gruev",
                    EGN = 720323,
                    Salary = 2000,
                    Department = Department.Sales
                },
                new Worker
                {
                    Name = "Pesho",
                    Family = "Tishkov",
                    EGN = 640203,
                    Salary = 800,
                    Department = Department.Production
                },
                new Costumer
                {
                    Name = "Preslava",
                    Family = "Belcheva",
                    EGN = 840813,
                }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.GetInfo());
            }
        }
    }
}
