using SoftwareOrganizationOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOrganizationOOP.Exceptions
{
    public class ExPersonDoNotExists : Exception
    {
        public ExPersonDoNotExists(Person person)
            : base(person.Fullname + " does not exist.")
        {
        }

        public ExPersonDoNotExists(Person person, Exception inner)
            : base(person.Fullname + " does not exist.", inner)
        {
        }
    }
}
