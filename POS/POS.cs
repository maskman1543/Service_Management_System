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
using static Service_Management_System.POS.Login_Page_Front___Backend.LoginForm;
//using Service_Management_System.Registration;

namespace Service_Management_System.POS
{

    public partial class POSForm : Form
    {
        bool sidebarExpand;
        bool sidebarExpandDiscount;
        bool sidebarExpandMechanic;
        bool sidebarExpandUserInfo;
        private jonOrder_form orderForm;
        private const decimal VAT_RATE = 0.12m;
        //ss


        public POSForm()
        {
            InitializeComponent();
            InitializeProductOrderedView();
            InitializeJobOrderedView();
            MechanicTable();
            dgvRowCount();
            //this.BackColor = ColorTranslator.FromHtml("#1A5F7A");
            DisplayUserInfo();


        }
        private void DisplayUserInfo()
        {
            tbxFirstName.Text = UserInfo.FirstName;
            tbxLastName.Text = UserInfo.LastName;
            tbxEmail.Text = UserInfo.Email;
            tbxContactNumber.Text = UserInfo.Contact;
            tbxPosition.Text = UserInfo.Position;
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
            string query = $"SELECT ProductID, ProductName, Price FROM Products WHERE ProductID = {productID}";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
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

                        foreach (DataGridViewRow row in productOrderedView.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["ProductID"].Value) == productID)
                            {
                                row.Cells["Quantity"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) + 1;
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            productOrderedView.Rows.Add(productRow["ProductID"], productRow["ProductName"], productRow["Price"], 1);
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
                DisplaySubTotal();
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
            //productOrderedView.Columns.Add("ProductGroup", "Product Group");
            productOrderedView.Columns.Add("ProductName", "Product Name");
            productOrderedView.Columns.Add("Price", "Price");
            productOrderedView.Columns.Add("Quantity", "Quantity");
            //productOrderedView.Columns.Add("Barcode", "Barcode");
        }

        private void LoadProductOrderedView(int productID)
        {
            string query = $"SELECT ProductID, ProductName, Price FROM Products WHERE ProductID = {productID}";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
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
            jobOrderedView.Columns.Add("ServiceID", "Service ID");
            //jobOrderedView.Columns.Add("serviceType", "Service Type");
            jobOrderedView.Columns.Add("ServiceName", "Service Name");
            jobOrderedView.Columns.Add("Price", "Service Rate");
        }
        private void LoadServiceOrderedView(int serviceID)
        {
            string query = $"SELECT ServiceID, ServiceName, Price FROM Services";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
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
            string query = "SELECT ProductID, Productname, Price FROM Products";


            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
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
            string query = "SELECT ServiceID, ServiceName, Price FROM Services WHERE ServiceID = @ServiceID";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@ServiceID", serviceID);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow serviceRow = dataTable.Rows[0];

                        // Add new row for service
                        jobOrderedView.Rows.Add(serviceRow["ServiceID"], serviceRow["ServiceName"], serviceRow["Price"]);
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
                if (selectedRow.Cells["ServiceID"].Value != null)
                {
                    int serviceID = Convert.ToInt32(selectedRow.Cells["ServiceID"].Value);
                    AddServiceToOrderedView(serviceID);
                }
            }
        }

        private void LoadServiceView()
        {
            string query = "SELECT ServiceID, ServiceName, Price FROM Services";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
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
                if (row.Cells["Price"].Value != null)
                {
                    decimal serviceRate = 0;
                    if (decimal.TryParse(row.Cells["Price"].Value.ToString(), out serviceRate))
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

        /*
        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            int JobOrderNumber = Class1.GlobalVariables.JobOrderNumber; // JobOrderNumber is typically the JobOrderID

            // Retrieve the CustomerName associated with the JobOrderNumber
            string CustomerName;
            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                string selectCustomerNameQuery = "SELECT CustomerName FROM JobOrders WHERE JobOrderID = @JobOrderID";
                OleDbCommand command = new OleDbCommand(selectCustomerNameQuery, connection);
                command.Parameters.AddWithValue("@JobOrderID", JobOrderNumber);

                try
                {
                    connection.Open();
                    CustomerName = (string)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving CustomerName: " + ex.Message);
                    return;
                }
            }

            DateTime DateSaved = DateTime.Now;

            int CartID;
            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                string insertCartQuery = "INSERT INTO CartTb_2 (CustomerName, DateSaved) VALUES (@CustomerName, @DateSaved)";
                OleDbCommand command = new OleDbCommand(insertCartQuery, connection);

                command.Parameters.AddWithValue("@CustomerName", CustomerName);
                command.Parameters.Add("@DateSaved", OleDbType.Date).Value = DateSaved; // Correctly handling the Date/Time parameter

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Retrieve the newly generated CartID
                    command.CommandText = "SELECT @@IDENTITY";
                    CartID = Convert.ToInt32(command.ExecuteScalar()); // Correct casting to int
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating new CartID: " + ex.Message);
                    return;
                }
            }

            List<(int ProductID, int Quantity)> productDetails = new List<(int, int)>();
            foreach (DataGridViewRow row in productOrderedView.Rows)
            {
                if (row.Cells["ProductID"].Value != null && row.Cells["Quantity"].Value != null)
                {
                    int productID = Convert.ToInt32(row.Cells["ProductID"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value); // Assuming Quantity column exists
                    productDetails.Add((productID, quantity));
                }
                else
                {
                    MessageBox.Show("ProductID or Quantity is null in one of the rows.");
                }
            }

            // Get the subtotal value from lblsubtotal.Text and parse it as a decimal
            string subtotalText = lblsubtotal.Text.Replace("₱", "").Trim();
            decimal subtotal = decimal.Parse(subtotalText, System.Globalization.NumberStyles.Currency);

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                try
                {
                    connection.Open();
                    foreach (var (productID, quantity) in productDetails)
                    {
                        // Insert into JobOrderItem table
                        string query = "INSERT INTO JobOrderItem (JobOrderID, Quantity, CartID) VALUES (@JobOrderID, @Quantity, @CartID)";
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@JobOrderID", JobOrderNumber);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.Parameters.AddWithValue("@CartID", CartID);
                            command.ExecuteNonQuery();
                        }

                        // Insert into CartProductsTb table
                        string query2 = "INSERT INTO CartProductsTb (CartID, ProductID, Quantity, Subtotal) VALUES (@CartID, @ProductID, @Quantity, @Subtotal)";
                        using (OleDbCommand command2 = new OleDbCommand(query2, connection))
                        {
                            command2.Parameters.AddWithValue("@CartID", CartID);
                            command2.Parameters.AddWithValue("@ProductID", productID);
                            command2.Parameters.AddWithValue("@Quantity", quantity);
                            command2.Parameters.AddWithValue("@Subtotal", subtotal);
                            command2.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting into JobOrderItem, CartProductsTb: " + ex.Message);
                }
            }

            MessageBox.Show("Sale saved successfully!");
        }

        */
        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            int JobOrderNumber = Class1.GlobalVariables.JobOrderNumber; // JobOrderNumber is typically the JobOrderID

            // Retrieve the CustomerName associated with the JobOrderNumber
            string CustomerName;
            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                string selectCustomerNameQuery = "SELECT CustomerName FROM JobOrders WHERE JobOrderID = @JobOrderID";
                OleDbCommand command = new OleDbCommand(selectCustomerNameQuery, connection);
                command.Parameters.AddWithValue("@JobOrderID", JobOrderNumber);

                try
                {
                    connection.Open();
                    CustomerName = (string)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving CustomerName: " + ex.Message);
                    return;
                }
            }

            DateTime DateSaved = DateTime.Now;

            List<(int ProductID, int Quantity)> productDetails = new List<(int, int)>();
            foreach (DataGridViewRow row in productOrderedView.Rows)
            {
                int productID = Convert.ToInt32(row.Cells["ProductID"].Value);
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value); // Assuming Quantity column exists
                productDetails.Add((productID, quantity));
            }

            List<int> serviceDetails = new List<int>();
            foreach (DataGridViewRow row in jobOrderedView.Rows)
            {
                int serviceID = Convert.ToInt32(row.Cells["ServiceID"].Value);
                serviceDetails.Add(serviceID);
            }

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                try
                {
                    connection.Open();

                    // Insert into JobOrderItem table
                    foreach (var (productID, quantity) in productDetails)
                    {
                        string query = "INSERT INTO JobOrderItem (JobOrderID, ProductID, Quantity) VALUES (@JobOrderID, @ProductID, @Quantity)";
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@JobOrderID", JobOrderNumber);
                            command.Parameters.AddWithValue("@ProductID", productID);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Insert into JobOrderService table for services
                    foreach (int serviceID in serviceDetails)
                    {
                        string query3 = "INSERT INTO JobOrderService (JobOrderID, ServiceID) VALUES (@JobOrderID, @ServiceID)";
                        using (OleDbCommand command3 = new OleDbCommand(query3, connection))
                        {
                            command3.Parameters.AddWithValue("@JobOrderID", JobOrderNumber);
                            command3.Parameters.AddWithValue("@ServiceID", serviceID);
                            command3.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting into JobOrderItem or JobOrderService: " + ex.Message);
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
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            View_sales_history View = new View_sales_history();
            View.Show();
            this.Close();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
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
            string query = "SELECT ProductID, ProductName, Price " +
                      "FROM Products " +
                      "WHERE Products.ProductName LIKE ? OR Products.Barcode LIKE ?";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
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
                query = "SELECT ServiceID, ServiceName, Price FROM Services";
            }
            else
            {
                query = "SELECT ServiceID, ServiceName, Price " +
                        "FROM Services " +
                        "WHERE ServiceName LIKE ?";
            }

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
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
            btnUserInfo.Width = 275;
            btnUserInfo.Height = 62;
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            btnUserInfo.Width = 265;
            btnUserInfo.Height = 57;
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

        private void panel_Discount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
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

        private void panel_Mechanic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMechanic_Click(object sender, EventArgs e)
        {
            timerMechanic.Start();

        }

        private void timerMechanic_Tick(object sender, EventArgs e)
        {
            if (sidebarExpandMechanic)
            {
                panel_Mechanic.Height -= 70;
                if (panel_Mechanic.Height <= panel_Mechanic.MinimumSize.Height)
                {
                    panel_Mechanic.Height = panel_Mechanic.MinimumSize.Height; // Ensure it doesn't go below minimum size
                    sidebarExpandMechanic = false;
                    timerMechanic.Stop();
                }
            }
            else
            {
                panel_Mechanic.Height += 70;
                if (panel_Mechanic.Height >= panel_Mechanic.MaximumSize.Height)
                {
                    panel_Mechanic.Height = panel_Mechanic.MaximumSize.Height; // Ensure it doesn't exceed maximum size
                    sidebarExpandMechanic = true;
                    timerMechanic.Stop();
                }
            }
        }

        private void dgvMechanic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMechanic.Rows[e.RowIndex];
                tbxMechanicID.Text = row.Cells["MechanicID"].Value.ToString();
                tbxMechanicName.Text = row.Cells["FirstName"].Value.ToString();
                tbxMechanicLastName.Text = row.Cells["LastName"].Value.ToString();
            }
        }
        private void MechanicTable()
        {
            string query = "SELECT Mechanics.MechanicID, Mechanics.FirstName, Mechanics.LastName, Mechanics.JobOrderServiceID, Mechanics.Salary " +
                   "FROM Mechanics";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    dgvMechanic.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timerMechanic.Start();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            timerMechanic.Start();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }
        private void dgvRowCount()
        {
            int rowCount = productOrderedView.Rows.Count;
            textBox1.Text = rowCount.ToString();
        }

        private void productOrderedView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvRowCount();
        }

        private void productOrderedView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dgvRowCount();
        }

        private void tbxContactNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserInfoBack_Click(object sender, EventArgs e)
        {
            timerUserInfo.Start();
            sidepanelPOS.Visible = true;
        }

        private void timerUserInfo_Tick(object sender, EventArgs e)
        {
            if (sidebarExpandUserInfo)
            {
                panel_UserInfo.Height -= 70;
                if (panel_UserInfo.Height <= panel_UserInfo.MinimumSize.Height)
                {
                    panel_UserInfo.Height = panel_UserInfo.MinimumSize.Height; // Ensure it doesn't go below minimum size
                    sidebarExpandUserInfo = false;
                    timerUserInfo.Stop();
                }
            }
            else
            {
                panel_UserInfo.Height += 70;
                if (panel_UserInfo.Height >= panel_UserInfo.MaximumSize.Height)
                {
                    panel_UserInfo.Height = panel_UserInfo.MaximumSize.Height; // Ensure it doesn't exceed maximum size
                    sidebarExpandUserInfo = true;
                    timerUserInfo.Stop();
                }
            }
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            timerUserInfo.Start();
            sidepanelPOS.Visible = false;
        }

        private void panel_UserInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            if (clickedButton != null)
            {
                if (tbxDiscount.Text.Contains("%"))
                {

                    int percentIndex = tbxDiscount.Text.IndexOf("%");
                    tbxDiscount.Text = tbxDiscount.Text.Insert(percentIndex, clickedButton.Text);
                }
                else
                {
                    tbxDiscount.Text += clickedButton.Text;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxDiscount.Text))
            {
                tbxDiscount.Text = tbxDiscount.Text.Substring(0, tbxDiscount.Text.Length - 1);
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!tbxDiscount.Text.Contains("."))
            {
                if (string.IsNullOrEmpty(tbxDiscount.Text))
                {
                    tbxDiscount.Text = "0.";
                }
                else
                {
                    tbxDiscount.Text += ".";
                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tbxDiscount.Text = string.Empty;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            tbxDiscount.Text = tbxDiscount.Text.Replace("₱", "");

            // Add percent sign if not already present
            if (!tbxDiscount.Text.Contains("%"))
            {
                if (double.TryParse(tbxDiscount.Text, out double number))
                {
                    tbxDiscount.Text = number.ToString() + "%";
                }
            }
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            tbxDiscount.Text = tbxDiscount.Text.Replace("%", "");

            // Add pesos sign if not already present
            if (!tbxDiscount.Text.Contains("₱"))
            {
                if (double.TryParse(tbxDiscount.Text, out double number))
                {
                    tbxDiscount.Text = "₱" + number.ToString();
                }
            }
        }



        /*private void button12_MouseEnter(object sender, EventArgs e)
        {

        }*/
    }
}
