using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLHandler
{
    public partial class Form1 : Form
    {
        private string xmlFilePath;
        private string xsdFilePath;
        private XmlHandler handler;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_xml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = @"D:\School\IS\isaulas\XML\bookstore.xml";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                xmlFilePath = openFileDialog.FileName;
                label1.Text = xmlFilePath;
            }
        }

        private void btn_xsd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = @"D:\School\IS\isaulas\XML\bookstore.xsd";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                xsdFilePath = openFileDialog.FileName;
                label2.Text = xsdFilePath;
            }
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(xmlFilePath) && !String.IsNullOrEmpty(xsdFilePath))
            {
                handler = new XmlHandler(xmlFilePath, xsdFilePath);
                var isValidated = handler.ValidateXml();

                string message = handler.ValidationMessage;
                string caption = isValidated ? "Is valid" : "Not valid";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);

                if (isValidated) LoadListView();
            }
        }

        private void LoadListView()
        {
            if (!String.IsNullOrEmpty(xmlFilePath))
            {
                var titles = handler.GetTitles();
                foreach (var item in titles)
                {
                    listView1.Items.Add(new ListViewItem(item));
                }
            }
        }

        private void btnExecuteXPath_Click(object sender, EventArgs e)
        {

        }

    }
}
