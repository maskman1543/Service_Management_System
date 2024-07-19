using Service_Management_System.POS;
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
    public partial class ProductsServicesForm : Form
    {
        POSForm POSForm = new POSForm();

        public ProductsServicesForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
                {
                    string query = "SELECT * FROM servicesTb";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    PSView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occurred: " + ex.Message);
            }
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
                {
                    string query = "SELECT productTable.ProductID, productTable.ProductType, productTable.ProductName, productTable.Cost, productTable.Price, productTable.Barcode, productTable.Description\r\nFROM productTable;\r\n";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    PSView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occurred: " + ex.Message);
            }
        }
    }
}
