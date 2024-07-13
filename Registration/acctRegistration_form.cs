using Service_Management_System.POS.Login_Page_Front___Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Management_System.Registration
{
    public partial class acctRegistration_form : Form
    {
        public acctRegistration_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 mainForm = new Form2();
            mainForm.Show(); // Show the main form
            this.Hide(); // Hide the splash screen
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form2 mainForm = new Form2();
            mainForm.Show(); // Show the main form
            this.Hide(); // Hide the splash screen
        }
    }
}
