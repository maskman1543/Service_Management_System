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
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
            LoadStockView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadStockView()
        {
            string query = "SELECT productTable.ProductID, productTable.ProductType, productTable.ProductName, StockTb.QStock, productTable.Barcode, productTable.Description\r\nFROM StockTb INNER JOIN productTable ON StockTb.StockID = productTable.StockID;\r\n";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    SPView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void StockForm_Load(object sender, EventArgs e)
        {

        }
    }
}
