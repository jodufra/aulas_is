using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareOrganizationOOP.Exceptions;

namespace SoftwareOrganizationOOP.Models
{
    public class Persons : Collection<Person>
    {

        public Person this[int index]
        {
            get
            {
                return index < this.Count && index > 0 ? this.ElementAt(index) : null;
            }
        }

        public List<Person> this[Type t]
        {
            get
            {
                return this.Where(p => p.GetType() == t).ToList();
            }
        }

        public void AddPerson(Person newPerson)
        {
            if (newPerson == null) return;

            if (this.Contains(newPerson))
                throw new ExPersonAlreadyExists(newPerson);

            this.Add(newPerson);
        }

        public int NumberOfPersons()
        {
            return this.Where(p => p.GetType() == typeof(Person)).Count();
        }

        public int NumberOfProgrammers()
        {
            return this.Where(p => p.GetType() == typeof(Programmer)).Count();
        }

        public int NumberOfManagers()
        {
            return this.Where(p => p.GetType() == typeof(Manager)).Count();
        }

        public void RemovePerson(Person oldPerson)
        {
            if (oldPerson == null) return;

            if (!this.Contains(oldPerson))
                throw new ExPersonDoNotExists(oldPerson);

            this.Remove(oldPerson);
        }

    }
}
