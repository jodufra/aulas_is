﻿using SoftwareOrganizationOOP.Contexts;
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
    public partial class PersonIndexForm : Form
    {
        private Type type;
        private Form parent;

        public PersonIndexForm(Form parent, Type type)
        {
            this.parent = parent;
            this.type = type;
            InitializeComponent();
            InitPersonsList();

            parent.Hide();
        }

        public void InitPersonsList()
        {
            PersonsContext.Current.Persons[type].ForEach(p => personsList.Items.Add(new ListViewItem(p.Print())));
        }

        private void personsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool hasSelection = (personsList.SelectedIndices.Count != 0);
            personEditBtn.Enabled = hasSelection;
            personRemoveBtn.Enabled = hasSelection;
        }

        private void personAddBtn_Click(object sender, EventArgs e)
        {
            new PersonDetailForm(this, type).Show();
        }

        private void personEditBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in personsList.SelectedIndices)
            {
                var index = Int32.Parse(item.ToString());
                var person = PersonsContext.Current.Persons[type].ElementAt(index);
                if (person != null)
                    new PersonDetailForm(this, type, person).Show();
            }  
        }

        private void personRemoveBtn_Click(object sender, EventArgs e)
        {
            string confirmTitle = "Confirm Delete!!";
            string personType = type.ToString();
            //string confirmMsg = "Are you sure to delete this " + personType.Substring(personType.LastIndexOf("."), personType.Length - 1) + " ?";
            string confirmMsg = "Are you sure to delete this " + personType + " ?";
            var confirmResult = MessageBox.Show(confirmMsg, confirmTitle, MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                foreach (var item in personsList.SelectedItems)
                {
                    var index = Int32.Parse(item.ToString());
                    var person = PersonsContext.Current.Persons[type].ElementAt(index);
                    if (person != null)
                        PersonsContext.Current.Persons.RemovePerson(person);
                }
            }
        }

        private void goback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            parent.Show();
            this.Close();
        }
    }
}
