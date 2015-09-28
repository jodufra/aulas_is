using SoftwareOrganizationOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            List<Manager> managers = new List<Manager>();
            List<Programmer> programmers = new List<Programmer>();

            for (int i = 0; i < 3; i++)
            {
                customers.Add(new Customer("ACustomer", i.ToString(), new DateTime((1975 + i), 1, 1), "my a customer address"));
                customers.Add(new Customer("BCustomer", i.ToString(), new DateTime((2000 + i), 1, 1), "my b customer address"));
            }

            managers.Add(new Manager("Manager", "0", new DateTime((1990), 1, 1), 2000));

            for (int i = 0; i < 5; i++)
            {
                programmers.Add(new Programmer("Programmer", i.ToString(), new DateTime((1990), 1, 1), 1000));
            }

            programmers.ForEach(p => managers.First().AddProgrammer(p));

            Console.WriteLine("# Costummers:");
            customers.ForEach(c => Console.WriteLine(c.Print()));

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("# Managers:");
            managers.ForEach(c => Console.WriteLine(c.Print()));

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("# Programmers:");
            programmers.ForEach(c => Console.WriteLine(c.Print()));


            var costumersA = customers.Where(c => c.Fullname.StartsWith("A"));
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("# Costummers, Name starts with 'A':");
            costumersA.OrderBy(c => c.Fullname).ToList().
                ForEach(c => Console.WriteLine(c.Print()));

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("# How many Costummers, Name starts with 'A': " + costumersA.Count());

            var costumersA40 = costumersA.Where(c => c.Age > 40);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("# How many Costummers, Name starts with 'A' and age > 40: " + costumersA40.Count());


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("# All Persons:");
            Persons persons = new Persons();
            customers.OrderBy(c => c.Fullname).ToList().ForEach(p => persons.AddPerson(p));
            managers.OrderBy(c => c.Fullname).ToList().ForEach(p => persons.AddPerson(p));
            programmers.OrderBy(c => c.Fullname).ToList().ForEach(p => persons.AddPerson(p));
            persons.ToList().ForEach(p => Console.WriteLine(p.Print()));

        }
    }
}
