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
using Service_Management_System.Registration;

namespace Service_Management_System.POS
{
    public partial class POSForm : Form
    {
        public POSForm()
        {
            InitializeComponent();
        }


        private void POS_Load(object sender, EventArgs e)
        {
            LoadPartsView();
            LoadserviceView();
        }

        private void btnSaveSale_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void partsServicesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void LoadPartsView()
        {
            string query = "SELECT productGroup, productName, Price, barcode FROM productTable;";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    partsView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void LoadserviceView()
        {
            string query = "SELECT servicesTb.serviceType, servicesTb.serviceName, servicesTb.serviceRate\r\nFROM servicesTb;\r\n";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    servicesView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void servicesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
