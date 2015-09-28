using SoftwareOrganizationOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOrganizationOOP.Exceptions
{
    public class ExPersonAlreadyExists : Exception
    {
        public ExPersonAlreadyExists(Person person)
            : base(person.Fullname + " already Exists.")
        {
        }

        public ExPersonAlreadyExists(Person person, Exception inner)
            : base(person.Fullname + " already Exists.", inner)
        {
        }
    }
}
