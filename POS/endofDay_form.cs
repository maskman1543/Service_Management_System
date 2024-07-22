using Service_Management_System.DASHBOARD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Management_System.POS
{
    public partial class endofDay_form : Form
    {
        private Form currentChildForm;
        public endofDay_form()
        {
            InitializeComponent();
        }
        private void OpenchildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenchildForm(new history_form());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is history_form)
                {
                    form.Hide(); // Hide the AnalysisForm if it is open
                    return; // Exit the method
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            POSForm pOS = new POSForm();
            pOS.Show();
            this.Close();
        }
    }
}
