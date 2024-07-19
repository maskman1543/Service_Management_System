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
    }
}
