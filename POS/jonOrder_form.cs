using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Service_Management_System.POS
{
    public partial class jonOrder_form : Form
    {
       int jobOrderNumber = Class1.GlobalVariables.JobOrderNumber;
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

           

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                connection.Open();
                OleDbTransaction transaction = connection.BeginTransaction();
                
                try
                {
           
                    

                    string insertCustomerQuery = "INSERT INTO JobOrders (CustomerName, CustomerContact, Vehicle, PlateNo) VALUES (@CustomerName, @CustomerContact, @Vehicle, @PlateNo)";
                    using (OleDbCommand cmdCustomer = new OleDbCommand(insertCustomerQuery, connection, transaction))
                    {
                        cmdCustomer.Parameters.AddWithValue("@CustomerName", FirstNameValue.Text);
                        cmdCustomer.Parameters.AddWithValue("@CustomerContact", textBox1.Text);
                        cmdCustomer.Parameters.AddWithValue("@Vehicle", textBox2.Text);
                        cmdCustomer.Parameters.AddWithValue("@PlateNo", textBox3.Text);
                        cmdCustomer.ExecuteNonQuery();
                    }
                    Class1.GlobalVariables.JobOrderNumber = Class1.GetJobOrderID(insertCustomerQuery);
                    MessageBox.Show("Job Order Number: "+Class1.GlobalVariables.JobOrderNumber);
                    transaction.Commit();
                    MessageBox.Show("Data inserted successfully!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
            
            POSForm pOSForm = new POSForm();
            this.Close();   
        }
       
        public void ClearDataGridView()
        {

        }
        private void jonOrder_form_Load(object sender, EventArgs e)
        {

        }
    }
}
