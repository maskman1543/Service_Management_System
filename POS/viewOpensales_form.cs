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

namespace Service_Management_System.POS
{
    public partial class viewOpensales_form : Form
    {
        public viewOpensales_form()
        {
            InitializeComponent();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            POSForm pOSForm = new POSForm();
            pOSForm.Show();
            this.Close();
        }
        private void LoadData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                {
                    string query = "SELECT CustomerName, CustomerContact, DateCreated, Vehicle, PlateNo FROM JobOrders WHERE Status = False";
                    ;
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure it's not a header row
            {
                // Get the selected JobOrderID (assuming it's in the first column)
                int jobOrderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                // Set the JobOrderID in Class1
                Class1.GlobalVariables.JobOrderNumber = jobOrderID;
            }
        }

    }
}
