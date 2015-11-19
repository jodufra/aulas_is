using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebServices
{
    public partial class Form1 : Form
    {
        private SapoServiceHoliday.HolidaySoapClient service;
        public Form1()
        {
            InitializeComponent();
            service = new SapoServiceHoliday.HolidaySoapClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var holidays = service.GetHolidaysByMunicipalityId(DateTime.Now.Year, "Leiria", true);
            foreach (var item in holidays)
            {
                listBox1.Items.Add(item.Date.ToShortDateString() + " " + item.Name);
            }
        }
    }
}
