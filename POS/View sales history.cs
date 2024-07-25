using Service_Management_System.Login_Page_Front___Backend;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Service_Management_System.POS
{
    public partial class View_sales_history : Form
    {
        private PrintDocument printDocument;
        private OleDbConnection _connection;

        public View_sales_history()
        {
            InitializeComponent();
            _connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2);
            LoadAllData();
            guna2DataGridView1.CellClick += Guna2DataGridView1_CellClick;
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void View_sales_history_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
            POSForm backPOS = new POSForm();
            backPOS.ShowDialog();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Show PrintDialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Example of printing content
            string salesHistory = "Sales History:\n"; // You should replace this with actual sales data
            salesHistory += "Date\t\tItem\t\tAmount\n";
            salesHistory += "01/01/2024\tItem1\t$100\n";
            salesHistory += "02/01/2024\tItem2\t$200\n";

            // Draw the string on the document
            e.Graphics.DrawString(salesHistory, new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
        }

        private void LoadAllData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                {
                    string query = @"
                        SELECT 
                            CustomerName, 
                            CustomerContact, 
                            DateCreated, 
                            Vehicle, 
                            PlateNo, 
                            Amount, 
                            SubTotal, 
                            Tax, 
                            Total, 
                            Discount, 
                            [Change], 
                            PaymentMethod, 
                            Status
                        FROM 
                            SalesHistory";

                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        guna2DataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Do something when a cell is clicked if necessary
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
            POSForm pOSForm = new POSForm();
            pOSForm.Show();
            this.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = "Document no.";
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}



/*private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
{
    // Ensure a valid row and cell are clicked
    if (e.RowIndex >= 0)
    {
        // Assuming the JobOrderID is in the first column
        if (int.TryParse(JobOrderHistoryView.Rows[e.RowIndex].Cells[0].Value.ToString(), out int jobOrderID))
        {
            LoadItemsForJobOrder(jobOrderID);
        }
        else
        {
            MessageBox.Show("Invalid Job Order ID.");
        }
    }
}*/

/*private void LoadItemsForJobOrder(int jobOrderID)
{
    try
    {
        _connection.Open();
        string query = "SELECT * FROM JobOrderItems WHERE JobOrderID = ?";

        using (OleDbCommand cmd = new OleDbCommand(query, _connection))
        {
            cmd.Parameters.AddWithValue("?", jobOrderID);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error loading items: " + ex.Message);
    }
    finally
    {
        _connection.Close();
    }
}*/

/*private void LoadJobOrderHistory()
{
    try
    {
        using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
        {
            string query = @"
                SELECT 
                    SalesHistory.SalesHistoryID, 
                    CustomerName, 
                    CustomerContact, 
                    DateCreated, 
                    Vehicle, 
                    PlateNo, 
                    Amount, 
                    SalesHistory.SubTotal, 
                    Tax, 
                    Total, 
                    Discount, 
                    [Change], 
                    PaymentMethod, 
                    Status.SubTotal AS StatusSubTotal
                FROM 
                    SalesHistory
                JOIN 
                    Status ON SalesHistory.StatusID = Status.StatusID";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            JobOrderHistoryView.DataSource = dataTable;
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("An error occurred: " + ex.Message);
    }
}*/

/*private void JobOrderHistoryView_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
    // Ensure a valid row and cell are clicked
    if (e.RowIndex >= 0)
    {
        // Assuming the JobOrderID is in the first column
        if (int.TryParse(JobOrderHistoryView.Rows[e.RowIndex].Cells[0].Value.ToString(), out int jobOrderID))
        {
            LoadDetails(jobOrderID);
        }
        else
        {
            MessageBox.Show("Invalid Job Order ID.");
        }
    }
}*/

/*private void LoadDetails(int jobOrderID)
{
    try
    {
        _connection.Open();
        // Adjust the SQL query to match your database schema
        string query = @"
            SELECT 
                JobOrderItem.JobOrderItemsID, 
                Products.ProductName, 
                Products.Price
            FROM 
                Products 
            INNER JOIN 
                ((JobOrders 
            INNER JOIN 
                (Sales 
            INNER JOIN 
                SalesHistory ON Sales.SaleID = SalesHistory.SaleID) 
            ON 
                JobOrders.JobOrderID = Sales.JobOrderID) 
            INNER JOIN 
                JobOrderItem ON JobOrders.JobOrderID = JobOrderItem.JobOrderID) 
            ON 
                Products.ProductID = JobOrderItem.ProductID
            WHERE 
                JobOrders.JobOrderID = @JobOrderID";

        using (OleDbCommand cmd = new OleDbCommand(query, _connection))
        {
            cmd.Parameters.AddWithValue("@JobOrderID", jobOrderID);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            JobOrderHistoryView.DataSource = dt;
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error loading details: " + ex.Message);
    }
    finally
    {
        _connection.Close();
    }
}*/


