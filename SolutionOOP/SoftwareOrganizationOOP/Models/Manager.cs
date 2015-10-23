using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOrganizationOOP.Models
{
    public class Manager : Employee
    {
        private List<Programmer> _programmers;

        public List<Programmer> Programmers
        {
            get { return _programmers; }
        }

        public int NumberOfProgrammers
        {
            get { return _programmers.Count; }
        }

        public Programmer this[int index]
        {
            get { return _programmers.Count < index ? _programmers.ElementAt(index) : null; }
        }

        public Manager(string firstname, string lastname, DateTime birthdate, double salary)
            : base(firstname, lastname, birthdate, salary)
        {
            this._programmers = new List<Programmer>();
        }

        public void AddProgrammer(Programmer programmer)
        {
            if (programmer == null) return;
            _programmers.Add(programmer);
        }

        public override string Print()
        {
            return base.Fullname + ", " + base.Age + " anos, " + base.Salary + " euros, " + NumberOfProgrammers;
        }
    }
}
