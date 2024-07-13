using Service_Management_System.Registration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Management_System.POS.Login_Page_Front___Backend
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            acctRegistration_form mainForm = new acctRegistration_form();
            mainForm.Show(); // Show the main form
            this.Hide();// Hide the splash screen
        }
    }
}
