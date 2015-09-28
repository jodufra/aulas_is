using FormsApplicationOOP.Forms;
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

namespace FormsApplicationOOP
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void customersIndex_Click(object sender, EventArgs e)
        {
            new PersonIndexForm(this, typeof(Customer)).Show();
        }

        private void employeesIndex_Click(object sender, EventArgs e)
        {
            new PersonIndexForm(this, typeof(Employee)).Show();
        }

        private void managersIndex_Click(object sender, EventArgs e)
        {
            new PersonIndexForm(this, typeof(Manager)).Show();
        }

        private void programmersIndex_Click(object sender, EventArgs e)
        {
            new PersonIndexForm(this, typeof(Programmer)).Show();
        }
    }
}
