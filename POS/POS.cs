using Service_Management_System.DASHBOARD;
using Service_Management_System.Login_Page_Front___Backend;
using Service_Management_System.POS.Login_Page_Front___Backend;
using Service_Management_System.POS.Login_Page_Front_and_Back_End;
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
//using Service_Management_System.Registration;

namespace Service_Management_System.POS
{

    public partial class POSForm : Form
    {
        bool sidebarExpand;
        bool sidebarExpandDiscount;
        private jonOrder_form orderForm;
        private const decimal VAT_RATE = 0.12m;
        //ss


        public POSForm()
        {
            InitializeComponent();
            InitializeProductOrderedView();
            InitializeJobOrderedView();
            //this.BackColor = ColorTranslator.FromHtml("#1A5F7A");
        }


        private void timerSfx_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidepanelPOS.Width -= 30;
                if (sidepanelPOS.Width == sidepanelPOS.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timerSfx.Stop();
                }
            }
            else
            {
                sidepanelPOS.Width += 30;
                if (sidepanelPOS.Width == sidepanelPOS.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timerSfx.Stop();
                }
            }
        }

        private void btnmenU2_Click(object sender, EventArgs e)
        {
            timerSfx.Start();
        }


        private void POS_Load(object sender, EventArgs e)
        {
            LoadPartsView();
            LoadServiceView();
        }

        private void AddOrUpdateProductOrderedView(int productID)
        {
            string query = $"SELECT productTable.ProductID, productTable.ProductType, productTable.ProductName, productTable.Price, productTable.Quantity, productTable.Barcode " +
                   $"FROM productTable " +
                   $"WHERE productTable.ProductID = {productID}";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow productRow = dataTable.Rows[0];
                        bool found = false;

                        // Check if the product is already in the target DataGridView
                        foreach (DataGridViewRow row in productOrderedView.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["ProductID"].Value) == productID)
                            {
                                // Update the quantity
                                row.Cells["Quantity"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) + 1;
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            // Add new row if not found
                            productOrderedView.Rows.Add(productRow.ItemArray);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
                DisplaySubTotal(); // Make sure this is properly defined and updates the total
            }
        }

        private void partsServicesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = partsView.Rows[e.RowIndex];
                int productID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);

                AddOrUpdateProductOrderedView(productID);
            }
        }
        private void InitializeProductOrderedView()
        {
            productOrderedView.Columns.Add("ProductID", "Product ID");
            productOrderedView.Columns.Add("ProductGroup", "Product Group");
            productOrderedView.Columns.Add("ProductName", "Product Name");
            productOrderedView.Columns.Add("Price", "Price");
            productOrderedView.Columns.Add("Quantity", "Quantity");
            productOrderedView.Columns.Add("Barcode", "Barcode");
        }

        private void LoadProductOrderedView(int productID)
        {
            string query = $"SELECT productTable.ProductID, productTable.ProductType, productTable.ProductName, productTable.Price, productTable.Quantity, productTable.Barcode " +
                    $"FROM productTable " +
                    $"WHERE productTable.ProductID = {productID}";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    productOrderedView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void InitializeJobOrderedView()
        {
            jobOrderedView.Columns.Add("serviceID", "Service ID");
            jobOrderedView.Columns.Add("serviceType", "Service Type");
            jobOrderedView.Columns.Add("serviceName", "Service Name");
            jobOrderedView.Columns.Add("serviceRate", "Service Rate");
        }
        private void LoadServiceOrderedView(int serviceID)
        {
            string query = $"SELECT servicesTb.serviceID, servicesTb.serviceType, servicesTb.serviceName, servicesTb.serviceRate " +
                   $"FROM servicesTb " +
                   $"WHERE servicesTb.serviceID = {serviceID}";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow serviceRow = dataTable.Rows[0];

                        // Add new row for service
                        jobOrderedView.Rows.Add(serviceRow["serviceID"], serviceRow["serviceType"], serviceRow["serviceName"], serviceRow["serviceRate"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void LoadPartsView()
        {
            string query = "SELECT productTable.ProductID, productTable.ProductType, productTable.ProductName, productTable.Price, productTable.Barcode " +
                   "FROM productTable";

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

        private void AddServiceToOrderedView(int serviceID)
        {
            string query = $"SELECT serviceID, serviceType, serviceName, serviceRate " +
                           $"FROM servicesTb " +
                           $"WHERE serviceID = {serviceID}";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow serviceRow = dataTable.Rows[0];

                        // Add new row for service
                        jobOrderedView.Rows.Add(serviceRow["serviceID"], serviceRow["serviceType"], serviceRow["serviceName"], serviceRow["serviceRate"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            DisplaySubTotal();
        }


        private void servicesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = servicesView.Rows[e.RowIndex];
                if (selectedRow.Cells["serviceID"].Value != null)
                {
                    int serviceID = Convert.ToInt32(selectedRow.Cells["serviceID"].Value);
                    AddServiceToOrderedView(serviceID);
                }
            }
        }

        private void LoadServiceView()
        {
            string query = "SELECT serviceID, serviceType, serviceName, serviceRate FROM servicesTb";

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


        private decimal CalculateProductSubTotal()
        {
            decimal productTotal = 0;

            foreach (DataGridViewRow row in productOrderedView.Rows)
            {
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                decimal quantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                productTotal += price * quantity;
            }
            return productTotal;
        }
        private decimal CalculateServiceSubTotal()
        {
            decimal serviceTotal = 0;

            foreach (DataGridViewRow row in jobOrderedView.Rows)
            {
                if (row.Cells["serviceRate"].Value != null)
                {
                    decimal serviceRate = 0;
                    if (decimal.TryParse(row.Cells["serviceRate"].Value.ToString(), out serviceRate))
                    {
                        serviceTotal += serviceRate;
                    }
                    else
                    {
                        // Handle invalid data in serviceRate cell if necessary
                    }
                }
            }
            return serviceTotal;
        }
        private void DisplaySubTotal()
        {
            decimal productTotal = CalculateProductSubTotal();
            decimal ServiceTOtal = CalculateServiceSubTotal();
            decimal subtotal = productTotal + ServiceTOtal;

            decimal vat = subtotal * VAT_RATE;
            decimal total = subtotal + vat;


            lblsubtotal.Text = subtotal.ToString("C");
            lblVaTax.Text = vat.ToString("C");
            lblTotal.Text = total.ToString("C");

        }

        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            int newCartID;
            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                string query = "INSERT INTO CartTb DEFAULT VALUES";
                OleDbCommand command = new OleDbCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Retrieve the newly generated CartID
                    query = "SELECT @@IDENTITY";
                    command.CommandText = query;
                    newCartID = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating new CartID: " + ex.Message);
                    return;
                }
            }

            List<int> productIDs = new List<int>();
            foreach (DataGridViewRow row in productOrderedView.Rows)
            {
                int productID = Convert.ToInt32(row.Cells["ProductID"].Value);
                productIDs.Add(productID);
            }

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                try
                {
                    connection.Open();
                    foreach (int productID in productIDs)
                    {
                        string query = "INSERT INTO CartTb (CartID, ProductID) VALUES (@CartID, @ProductID)";
                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@CartID", newCartID);
                        command.Parameters.AddWithValue("@ProductID", productID);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting into CartProductsTb: " + ex.Message);
                }
            }

            MessageBox.Show("Sale saved successfully!");
        }



        private void button12_Click(object sender, EventArgs e)
        {

            bool state = Class1.GlobalVariables.State;

            if (state == false)
            {
                AccessRequest accessRequest = new AccessRequest();
                accessRequest.Show();
                this.Close();
            }
            else
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Close();
            }

        }


        private void moveup_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            View_sales_history View = new View_sales_history();
            View.Show();
            this.Close();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            Splash loginForm = new Splash();
            loginForm.Show();
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            cashInOut_Form cashInOut_Form = new cashInOut_Form();
            cashInOut_Form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if the form is already open
            if (orderForm == null || orderForm.IsDisposed)
            {
                // If not, create a new instance and show it
                orderForm = new jonOrder_form();
                orderForm.Show();
            }
            else
            {
                // If already open, bring it to the front
                orderForm.BringToFront();
            }
        }


        private void timer_Discount_Tick(object sender, EventArgs e)
        {
            if (sidebarExpandDiscount)
            {
                panel_Discount.Height -= 70;
                if (panel_Discount.Height <= panel_Discount.MinimumSize.Height)
                {
                    panel_Discount.Height = panel_Discount.MinimumSize.Height; // Ensure it doesn't go below minimum size
                    sidebarExpandDiscount = false;
                    timer_Discount.Stop();
                }
            }
            else
            {
                panel_Discount.Height += 70;
                if (panel_Discount.Height >= panel_Discount.MaximumSize.Height)
                {
                    panel_Discount.Height = panel_Discount.MaximumSize.Height; // Ensure it doesn't exceed maximum size
                    sidebarExpandDiscount = true;
                    timer_Discount.Stop();
                }
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            timer_Discount.Start();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            endofDay_form endofDay_Form = new endofDay_form();
            endofDay_Form.Show();
            this.Close();
        }

        // Existing search zlogic
        private int _selectedProductID = -1; // Use -1 to indicate no selection

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(textBox7.Text.Trim());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox7.Text.Trim();
            if (!string.IsNullOrEmpty(searchQuery))
            {
                DataTable dataTable = (DataTable)partsView.DataSource;
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    int productID = Convert.ToInt32(dataTable.Rows[0]["ProductID"]);
                    AddOrUpdateProductOrderedView(productID);
                }
            }
            else
            {
                LoadPartsView(); // Reload all products if search query is empty
            }
        }

        private void SearchProduct(string searchTerm)
        {
            string query = "SELECT productTable.ProductID, productTable.ProductType, productTable.ProductName, productTable.Price, productTable.Barcode " +
                      "FROM productTable " +
                      "WHERE productTable.ProductName LIKE ? OR productTable.ProductType LIKE ? OR productTable.Barcode LIKE ?";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);

                // Clear existing parameters
                adapter.SelectCommand.Parameters.Clear();

                // Add parameters for the search term
                adapter.SelectCommand.Parameters.AddWithValue("?", "%" + searchTerm + "%");
                adapter.SelectCommand.Parameters.AddWithValue("?", "%" + searchTerm + "%");
                adapter.SelectCommand.Parameters.AddWithValue("?", "%" + searchTerm + "%");

                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    partsView.DataSource = dataTable;
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            SearchService(textBox8.Text.Trim());
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)servicesView.DataSource;
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Assuming you want to add the first service from the search results
                int serviceID = Convert.ToInt32(dataTable.Rows[0]["serviceID"]);
                AddServiceToOrderedView(serviceID);
            }
        }
        private void SearchService(string searchTerm)
        {
            string query;

            if (string.IsNullOrEmpty(searchTerm))
            {
                query = "SELECT serviceID, serviceType, serviceName, serviceRate FROM servicesTb";
            }
            else
            {
                query = "SELECT serviceID, serviceType, serviceName, serviceRate " +
                        "FROM servicesTb " +
                        "WHERE serviceName LIKE ? OR serviceType LIKE ?";
            }

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("?", "%" + searchTerm + "%");
                    adapter.SelectCommand.Parameters.AddWithValue("?", "%" + searchTerm + "%");
                }

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in productOrderedView.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    productOrderedView.Rows.Remove(row);
                }
            }


            foreach (DataGridViewRow row in jobOrderedView.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    jobOrderedView.Rows.Remove(row);
                }
            }
        }





        private void textBox7_Enter(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            textBox7.Text = "Search Product";
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            textBox8.Text = "";
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            textBox8.Text = "Search Services";
        }


        private void btnPayment_Click(object sender, EventArgs e)
        {
            new Payment().Show();
            this.Hide();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            new AfterPayment().Show();
            this.Hide();
        }




        private void button14_Click(object sender, EventArgs e)
        {
            viewOpensales_form opensales_Form = new viewOpensales_form();
            opensales_Form.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchService(textBox8.Text.Trim());
            SearchProduct(textBox7.Text.Trim());
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            button12.Width = 275;
            button12.Height = 62;
            sidepanelPOS.BringToFront();
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            button12.Width = 265;
            button12.Height = 57;
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            button13.Width = 275;
            button13.Height = 62;
            sidepanelPOS.BringToFront();
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            button13.Width = 265;
            button13.Height = 57;
        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            btnViewopensales.Width = 275;
            btnViewopensales.Height = 62;
            sidepanelPOS.BringToFront();
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            btnViewopensales.Width = 265;
            btnViewopensales.Height = 57;
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            button15.Width = 275;
            button15.Height = 62;
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            button15.Width = 265;
            button15.Height = 57;
        }

        private void button19_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            button19.Width = 275;
            button19.Height = 62;
        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            button19.Width = 265;
            button19.Height = 57;
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            button18.Width = 275;
            button18.Height = 62;
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            button18.Width = 265;
            button18.Height = 57;
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            btnSignout.Width = 275;
            btnSignout.Height = 62;
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            btnSignout.Width = 265;
            btnSignout.Height = 57;
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            button16.Width = 275;
            button16.Height = 62;
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            button16.Width = 265;
            button16.Height = 57;
        }

        private void moveup_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            moveup.Width = 44;
            moveup.Height = 43;
            //40, 39
        }

        private void moveup_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            moveup.Width = 40;
            moveup.Height = 39;
        }
        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            btnSearch.Width = 79;
            btnSearch.Height = 71;
            //75, 67, orrig
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.Width = 75;
            btnSearch.Height = 67;
            //75, 67, orrig
        }

        private void btnCustomer_MouseEnter(object sender, EventArgs e)
        {
            btnCustomer.Width = 79;
            btnCustomer.Height = 71;
            //75, 67, orrig
        }

        private void btnCustomer_MouseLeave(object sender, EventArgs e)
        {
            btnCustomer.Width = 75;
            btnCustomer.Height = 67;
            //75, 67, orrig
        }

        private void btnDiscount_MouseEnter(object sender, EventArgs e)
        {
            btnDiscount.Width = 79;
            btnDiscount.Height = 71;
            //75, 67, orrig
        }

        private void btnDiscount_MouseLeave(object sender, EventArgs e)
        {
            btnDiscount.Width = 75;
            btnDiscount.Height = 67;
            //75, 67, orrig
        }

        private void btnNewSale_MouseEnter(object sender, EventArgs e)
        {
            btnNewSale.Width = 79;
            btnNewSale.Height = 71;
            //75, 67, orrig
        }

        private void btnNewSale_MouseLeave(object sender, EventArgs e)
        {
            btnNewSale.Width = 75;
            btnNewSale.Height = 67;
            //75, 67, orrig
        }

        private void btnRefund_MouseEnter(object sender, EventArgs e)
        {
            btnRefund.Width = 79;
            btnRefund.Height = 71;
            //75, 67, orrig
        }

        private void btnRefund_MouseLeave(object sender, EventArgs e)
        {
            btnRefund.Width = 75;
            btnRefund.Height = 67;
            //75, 67, orrig
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Width = 79;
            button2.Height = 71;
            //75, 67, orrig
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Width = 75;
            button2.Height = 67;
            //75, 67, orrig
        }

        private void btnSaveSale_MouseEnter(object sender, EventArgs e)
        {
            btnSaveSale.Width = 79;
            btnSaveSale.Height = 71;
            //75, 67, orrig
        }

        private void btnSaveSale_MouseLeave(object sender, EventArgs e)
        {
            btnSaveSale.Width = 75;
            btnSaveSale.Height = 67;
            //75, 67, orrig
        }

        private void btnPayment_MouseEnter(object sender, EventArgs e)
        {
            btnPayment.Width = 79;
            btnPayment.Height = 71;
            //75, 67, orrig
        }

        private void btnPayment_MouseLeave(object sender, EventArgs e)
        {
            btnPayment.Width = 75;
            btnPayment.Height = 67;
            //75, 67, orrig
        }

        private void btnCash_MouseEnter(object sender, EventArgs e)
        {
            btnCash.Width = 79;
            btnCash.Height = 71;
            //75, 67, orrig
        }

        private void btnCash_MouseLeave(object sender, EventArgs e)
        {
            btnCash.Width = 75;
            btnCash.Height = 67;
            //75, 67, orrig
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.Width = 160;
            btnDelete.Height = 55;
            //156, 51 orrig
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.Width = 156;
            btnDelete.Height = 51;
            //156, 51 orrig
        }



        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Width = 116;
            button3.Height = 74;
            //112, 70 orrig
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Width = 112;
            button3.Height = 70;
            //112, 70 orrig
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Width = 116;
            button4.Height = 74;
            //112, 70 orrig
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {

            button4.Width = 112;
            button4.Height = 70;
            //112, 70 orrig
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.Width = 116;
            button11.Height = 74;
            //112, 70 orrig
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.Width = 112;
            button11.Height = 70;
            //112, 70 orrig
        }

        private void btnmenU2_MouseEnter(object sender, EventArgs e)
        {
            btnmenU2.Width = 55;
            btnmenU2.Height = 46;
            //51, 42 orrig
        }

        private void btnmenU2_MouseLeave(object sender, EventArgs e)
        {
            btnmenU2.Width = 51;
            btnmenU2.Height = 42;
            //51, 42 orrig
        }


        private void sidepanelPOS_MouseEnter(object sender, EventArgs e)
        {
            sidepanelPOS.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnQuantity_MouseEnter(object sender, EventArgs e)
        {

        }

        private void allout_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void btnQuantity_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {

        }


        private void button1_MouseEnter_1(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {

        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {

        }
        private void sidepanelPOS_MouseEnter_1(object sender, EventArgs e)
        {

        }

        private void productOrderedView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void jobOrderedView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblsubtotal_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {

        }

        private void panel_Discount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            // Check if the form is already open
            if (orderForm == null || orderForm.IsDisposed)
            {
                // If not, create a new instance and show it
                orderForm = new jonOrder_form();
                orderForm.Show();
            }
            else
            {
                // If already open, bring it to the front
                orderForm.BringToFront();
            }
        }

        private void btnPayment_Click_1(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Close();
        }

        private void btnCash_Click_1(object sender, EventArgs e)
        {
            AfterPayment payment = new AfterPayment();
            payment.Show();
            this.Close();
        }



        /*private void button12_MouseEnter(object sender, EventArgs e)
        {

        }*/
    }
}
