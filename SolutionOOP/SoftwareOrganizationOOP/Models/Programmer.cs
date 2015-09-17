using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOrganizationOOP.Models
{
    public class Programmer : Employee
    {
        public Programmer(string firstname, string lastname, DateTime birthdate, double salary)
            : base(firstname, lastname, birthdate, salary)
        {
        }
    }
}
