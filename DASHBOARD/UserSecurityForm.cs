using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Management_System.DASHBOARD
{
    public partial class UserSecurityForm : Form
    {
        bool sidebarExpand;
        public UserSecurityForm()
        {
            InitializeComponent();
            LoadEmployeesView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadEmployeesView()
        {
            string query = "SELECT EmployeeTb.EmployeeID, EmployeeTb.FirstName, EmployeeTb.LastName, EmployeeTb.Email, EmployeeTb.Contact\r\nFROM EmployeeTb;\r\n";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    EmployeeView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void EmployeeView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        private void sidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar_AddUser.Width -= 10;
                if (sidebar_AddUser.Width == sidebar_AddUser.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar_AddUser.Width += 10;
                if (sidebar_AddUser.Width == sidebar_AddUser.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            sidebarTimer.Stop();
        }
    }
}
