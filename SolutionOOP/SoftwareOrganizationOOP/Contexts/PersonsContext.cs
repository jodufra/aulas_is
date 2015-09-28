using SoftwareOrganizationOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOrganizationOOP.Contexts
{
    public class PersonsContext
    {

        private static PersonsContext _context = null;

        public static PersonsContext Current
        {
            get
            {
                if (_context == null)
                    _context = new PersonsContext();
                return _context;
            }
        }

        public PersonsContext()
        {
            Persons = new Persons();

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

            customers.OrderBy(c => c.Fullname).ToList().ForEach(p => Persons.AddPerson(p));
            managers.OrderBy(c => c.Fullname).ToList().ForEach(p => Persons.AddPerson(p));
            programmers.OrderBy(c => c.Fullname).ToList().ForEach(p => Persons.AddPerson(p));

        }

        public Persons Persons { get; set; }



    }
}
