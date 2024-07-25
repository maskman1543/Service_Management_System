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
using System.Xml;

namespace Service_Management_System.DASHBOARD
{
    public partial class DocumentsForm : Form
    {
        public DocumentsForm()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Get the MechanicID from the TextBox
            string mechanicID = SM.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(mechanicID))
            {
                MessageBox.Show("Please enter a Mechanic ID.");
                return;
            }

            // Database connection string
            string connectionString = Class1.GlobalVariables.ConnectionString2; // Use your actual connection string

            // SQL query to search for records by MechanicID
            string query = "SELECT MechanicID, MechanicName, MechanicLastName, taskAssign FROM MechanicPayroll_query WHERE MechanicID = ?";

            // Create and open a connection
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("?", mechanicID);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    // Check if any data was returned
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found for the provided Mechanic ID.");
                    }
                    // Bind the results to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
