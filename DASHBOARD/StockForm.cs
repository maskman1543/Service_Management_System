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
            string query = "SELECT productTable.productID, productTable.productName, productTable.productGroup, productTable.Cost, productTable.Price, productTable.barcode, StockTb.Stock\r\nFROM StockTb LEFT JOIN productTable ON StockTb.StockID = productTable.stockID;\r\n";

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
    }
}
