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
using System.Windows.Controls;
using System.Windows.Forms;

namespace Service_Management_System.DASHBOARD
{
    public partial class ProductsServicesForm : Form
    {
        POSForm POSForm = new POSForm();
        bool sidebarExpand;
        bool sidebarExpand2;
        bool upper;
        private bool isDetails = true;
        private Form currentChildForm;

        public ProductsServicesForm()
        {
            InitializeComponent();
            DisplayProductCountRecord();
            DisplayServiceCountRecord();
        }

        private void DisplayProductCountRecord()
        {

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                string query = "SELECT COUNT(*) FROM Products";

                OleDbCommand command = new OleDbCommand(query, connection);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    label4.Text = $"{count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void DisplayServiceCountRecord()
        {
            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                string query = "SELECT COUNT(*) FROM Services";

                OleDbCommand command = new OleDbCommand(query, connection);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    label5.Text = $"{count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
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
                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                {
                    string query = "SELECT * FROM Services";
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
                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                {
                    string query = "SELECT * FROM Products";
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

        private void sidebar_addproducts_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panel3.Width -= 50;
                if (panel3.Width == panel3.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebar_addproducts.Stop();
                }
            }
            else
            {
                panel3.Width += 50;
                if (panel3.Width == panel3.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebar_addproducts.Stop();
                }
            }
        }
        private void OpenchildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelpro_service.Controls.Add(childForm);
            panelpro_service.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidebar_addproducts.Start();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sidebar_addproducts.Start();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            OpenchildForm(new priceandtax_form());
        }

        private void btnStockControl_Click(object sender, EventArgs e)
        {
            OpenchildForm(new stockControl_form());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Upper_timer.Start();
            if (isDetails)
            {
                button8.Text = "Details";
            }
            else
            {
                button8.Text = "Price and Tax / Stock Control";
            }
            isDetails = !isDetails;
        }

        private void Upper_timer_Tick(object sender, EventArgs e)
        {
            if (upper)
            {
                panelUpper.Height -= 50;
                if (panelUpper.Height == panelUpper.MinimumSize.Height)
                {
                    upper = false;
                    Upper_timer.Stop();
                }
            }
            else
            {
                panelUpper.Height += 50;
                if (panelUpper.Height == panelUpper.MaximumSize.Height)
                {
                    upper = true;
                    Upper_timer.Stop();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            string productName = ProductNameValue.Text;
            decimal price = decimal.Parse(txtPriceValue.Text);
            int quantityInStock = int.Parse(QuantityInStock.Text);
            decimal cost = decimal.Parse(txtCostValue.Text);
            string barcode = BarcodeValue.Text;




            // Create the SQL INSERT statement
            string insertQuery = "INSERT INTO Products (ProductName, Price, QuantityInStock, Cost, Barcode) VALUES (@ProductName, @Price, @QuantityInStock, @Cost, @Barcode)";

            // Create a connection object
            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                // Create a command object
                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Cost", cost);
                    command.Parameters.AddWithValue("@QuantityInStock", quantityInStock);
                    command.Parameters.AddWithValue("@Barcode", barcode);
                    // Open the connection
                    connection.Open();

                    // Execute the command
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Product saved successfully.");
                        DisplayProductCountRecord();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }

        private void servicesidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand2)
            {
                panel6.Width -= 50;
                if (panel6.Width == panel6.MinimumSize.Width)
                {
                    sidebarExpand2 = false;
                    servicesidebar.Stop();
                }
            }
            else
            {
                panel6.Width += 50;
                if (panel6.Width == panel6.MaximumSize.Width)
                {
                    sidebarExpand2 = true;
                    servicesidebar.Stop();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            servicesidebar.Start();
        }

        private void btnSaveService_Click(object sender, EventArgs e)
        {
            string serviceName = txtServiceName.Text;
            decimal servicePrice = decimal.Parse(txtServicePrice.Text);


            // Create the SQL INSERT statement
            string insertQuery = "INSERT INTO Services (ServiceName, Price) VALUES (@ServiceName, @Price)";

            // Create a connection object
            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                // Create a command object
                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@ServiceName", serviceName);
                    command.Parameters.AddWithValue("@Price", servicePrice);


                    // Open the connection
                    connection.Open();

                    // Execute the command
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Service saved successfully.");
                        DisplayServiceCountRecord();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
