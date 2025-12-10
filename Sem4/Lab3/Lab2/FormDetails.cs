using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class FormDetails : Form
    {
        public FormDetails()
        {
            InitializeComponent();
        }
        public FormDetails(Person p)
        {
            InitializeComponent();
            label1.Text += " " + p.Name;
            label2.Text += " " + p.Surname;
            label3.Text += " " + p.Mom.ToString();
            label4.Text += " " + p.Dad.ToString();
            label5.Text += " " + p.BirtDate.ToShortDateString();
            label6.Text += " " + p.BirthPlace;
        }
    }
}
