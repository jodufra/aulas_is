using SoftwareOrganizationOOP.Contexts;
using SoftwareOrganizationOOP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApplicationOOP.Forms
{
    public partial class PersonDetailForm : Form
    {
        private Form parent;
        private Type type;
        private Person person;


        public PersonDetailForm(Form parent, Type type)
        {
            this.parent = parent;
            this.type = type;
            InitializeComponent();
            InitInputs();

            parent.Hide();
        }

        public PersonDetailForm(Form parent, Type type, Person person)
        {
            this.parent = parent;
            this.type = type;
            this.person = person;
            InitializeComponent();
            InitInputs();

            parent.Hide();
        }

        private void InitInputs()
        {
            if (person != null)
            {
                i_firstname.Text = person.FirstName;
                i_lastname.Text = person.LastName;
            }

            if (type == typeof(Customer))
            {
                i_address.Enabled = true;
                if (person != null)
                    i_address.Text = ((Customer)person).Address;
            }

            if (type == typeof(Employee) || type == typeof(Manager) || type == typeof(Programmer))
            {
                i_salary.Enabled = true;
                if (person != null)
                    i_salary.Text = ((Employee)person).Salary.ToString();
            }

            if (type == typeof(Manager))
            {
                l_allProgrammers.Enabled = true;
                l_myProgrammers.Enabled = true;

                var availableProgs = PersonsContext.Current.Persons[typeof(Programmer)].Select(p => (Programmer) p).ToList();
                var allProgs = new List<Programmer>();
                var myProgs = new List<Programmer>();

                if (person != null)
                {
                    myProgs = ((Manager)person).Programmers;
                    allProgs = availableProgs.Where(p => !myProgs.Contains(p)).ToList();
                }
                else
                {
                    allProgs = availableProgs;
                }

                l_allProgrammers.Items.AddRange(allProgs.Select(p => p.Print()).ToArray());
                l_myProgrammers.Items.AddRange(myProgs.Select(p => p.Print()).ToArray());
            }
        }

        private void b_add_Click(object sender, EventArgs e)
        {

        }

        private void b_remove_Click(object sender, EventArgs e)
        {

        }

        private void b_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }
    }
}
