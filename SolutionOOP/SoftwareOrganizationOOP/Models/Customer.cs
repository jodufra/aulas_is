using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOrganizationOOP.Models
{
    public class Customer : Person
    {

        private string _address;

        private string Address { get { return _address; } }

        public Customer(string firstname, string lastname, DateTime birthdate, string address) : base(firstname, lastname, birthdate)
        {
            this._address = address;
        }

        public override string Print()
        {
            return base.Fullname + ", " + base.Age + " anos, " + Address;
        }
    }
}
