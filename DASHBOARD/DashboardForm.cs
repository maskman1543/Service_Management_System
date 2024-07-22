using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Management_System.DASHBOARD
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            lblClock.Text = DateTime.Now.ToLongTimeString();
            lblTimeAndDateNow.Text = DateTime.Now.ToString("MM-dd-yyyy");

        }
        private void lblClock_Click(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblTimeAndDateNow_Click(object sender, EventArgs e)
        {
            var formattedDate = DateTime.Now.ToString("MM-dd-yyyy");
            lblTimeAndDateNow.Text = formattedDate;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
