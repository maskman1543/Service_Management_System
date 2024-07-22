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
                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
                {
                    string query = "SELECT jobOrderJunctionTb.JobOrderID, CustomerTb.LastName, VehicleTb.Model\r\nFROM VehicleTb INNER JOIN (CustomerTb INNER JOIN jobOrderJunctionTb ON CustomerTb.CustomerID = jobOrderJunctionTb.CustomerID) ON VehicleTb.VehicleID = CustomerTb.VehicleID;\r\n";
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

    }

}
