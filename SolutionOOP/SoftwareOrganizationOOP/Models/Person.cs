using SoftwareOrganizationOOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOrganizationOOP.Models
{
    public abstract class Person: IPrintable
    {
        DateTime _birthdate;
        String _firstname;
        String _lastname;

        public int Age
        {
            get
            {
                return (new DateTime(DateTime.Now.Subtract(_birthdate).Ticks)).Year;
            }
        }
        public DateTime BirthDate { get { return _birthdate; } set { _birthdate = value; } }
        public String Fullname { get { return _firstname + " " + _lastname; } }


        public Person() { }
        public Person(string firstname, string lastname, DateTime birthdate)
        {
            this._firstname = firstname;
            this._lastname = lastname;
            this._birthdate = birthdate;
        }

        public virtual String Print()
        {
            return Fullname + ", " + Age + " anos";
        }

        
    }
}
