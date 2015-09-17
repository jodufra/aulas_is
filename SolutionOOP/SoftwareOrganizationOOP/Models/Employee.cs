using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOrganizationOOP.Models
{
    public abstract class Employee : Person
    {

        double _salary;
        public double Salary { get { return _salary; } }

        public Employee(string firstname, string lastname, DateTime birthdate, double salary)
            : base(firstname, lastname, birthdate)
        {
            this._salary = salary;
        }

        public override string Print()
        {
            return base.Fullname + ", " + base.Age + " anos, " + Salary + " euros";
        }

    }
}
