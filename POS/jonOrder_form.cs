using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Service_Management_System.POS
{
    public partial class jonOrder_form : Form
    {
        public jonOrder_form()
        {
            InitializeComponent();
            btnContinue.Click -= new EventHandler(btnContinue_Click); // Detach any existing handlers
            btnContinue.Click += new EventHandler(btnContinue_Click); // Attach the handler
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirstNameValue_Enter(object sender, EventArgs e)
        {
            if (FirstNameValue.Text == "Customer name")
            {
                FirstNameValue.Text = "";
            }
        }

        private void FirstNameValue_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstNameValue.Text))
            {
                FirstNameValue.Text = "Customer name";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Phone no.")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Phone no.";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Vehicle type")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Vehicle type";
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Plate no.")
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "Plate no.";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstNameValue.Text) || FirstNameValue.Text == "Customer name" ||
                string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "Phone no." ||
                string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text == "Vehicle type" ||
                string.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text == "Plate no.")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Elementz\source\repos\Service_Management_System\bin\Debug\net6.0-windows\ServiceManagementSYstem.accdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbTransaction transaction = connection.BeginTransaction();

                try
                {
                    string insertVehicleQuery = "INSERT INTO VehicleTb (Model, PlateNumber) VALUES (@Model, @PlateNumber)";
                    int vehicleID;
                    using (OleDbCommand cmdVehicle = new OleDbCommand(insertVehicleQuery, connection, transaction))
                    {
                        cmdVehicle.Parameters.AddWithValue("@Model", textBox2.Text);
                        cmdVehicle.Parameters.AddWithValue("@PlateNumber", textBox3.Text);
                        cmdVehicle.ExecuteNonQuery();

                        string getVehicleIDQuery = "SELECT @@IDENTITY";
                        using (OleDbCommand cmdGetVehicleID = new OleDbCommand(getVehicleIDQuery, connection, transaction))
                        {
                            vehicleID = Convert.ToInt32(cmdGetVehicleID.ExecuteScalar());
                        }
                    }

                    string insertCustomerQuery = "INSERT INTO CustomerTb (FirstName, Contact, VehicleID) VALUES (@FirstName, @Contact, @VehicleID)";
                    using (OleDbCommand cmdCustomer = new OleDbCommand(insertCustomerQuery, connection, transaction))
                    {
                        cmdCustomer.Parameters.AddWithValue("@FirstName", FirstNameValue.Text);
                        cmdCustomer.Parameters.AddWithValue("@Contact", textBox1.Text);
                        cmdCustomer.Parameters.AddWithValue("@VehicleID", vehicleID);
                        cmdCustomer.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Data inserted successfully!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
