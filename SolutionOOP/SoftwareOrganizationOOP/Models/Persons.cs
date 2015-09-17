using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOrganizationOOP.Models
{
    public class Persons : Collection<Person>
    {

        public Person this[int index] { get { return index < this.Count && index > 0 ? this.ElementAt(index) : null; } }

        public void AddPerson(Person newPerson) { if (newPerson == null) return; this.Add(newPerson); }
        public int NumberOfCostumers() { return this.Where(p => p.GetType() == typeof(Person)).Count(); }
        public int NumberOfProgrammers() { return this.Where(p => p.GetType() == typeof(Programmer)).Count(); }
        public int NumberOfManagers() { return this.Where(p => p.GetType() == typeof(Manager)).Count(); }
        public void RemovePerson(Person oldPerson) { if (oldPerson == null) return; this.Remove(oldPerson); }
    }
}
