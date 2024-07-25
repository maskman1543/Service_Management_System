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

namespace Service_Management_System.POS
{
    public partial class Payment : Form
    {

        public Payment()
        {
            InitializeComponent();
            LoadData();

        }

        private void LoadData()//Load JobOrder Table to dataGridView1
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                {
                    string query = "SELECT JobOrderID, CustomerName, CustomerContact, DateCreated, Vehicle, PlateNo, Subtotal, Tax, Total, Amount, Discount, Change, PaymentMethod, Status  FROM JobOrders WHERE Status = False";
                    ;
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            POSForm pOSForm = new POSForm();
            pOSForm.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new POSForm().Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            string[] values = textBox5.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);


            if (values.Length > 0)
            {

                textBox3.Text = values.Length > 0 ? values[0] : string.Empty;
            }
            else
            {

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            CalculateAndDisplayChange();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayChange();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow clickedRow = dataGridView1.Rows[e.RowIndex];

                var totalCell = clickedRow.Cells["Total"];
                var subtotalCell = clickedRow.Cells["Subtotal"];
                var taxCell = clickedRow.Cells["Tax"];

                if (totalCell.Value != null && subtotalCell.Value != null && taxCell.Value != null)
                {
                    textBox5.Text = totalCell.Value.ToString();
                    textBox1.Text = subtotalCell.Value.ToString();
                    textBox2.Text = taxCell.Value.ToString();
                }
                else
                {
                    textBox5.Text = string.Empty;
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                }
            }
        }

        private void CalculateAndDisplayChange()
        {
            decimal value1, value2;

            bool isValidValue1 = decimal.TryParse(textBox5.Text, out value1);
            bool isValidValue2 = decimal.TryParse(textBox4.Text, out value2);

            if (isValidValue1 && isValidValue2)
            {
                decimal result = value1 - value2;
                changelbl.Text = result.ToString("F2");
            }
            else
            {
                changelbl.Text = "Invalid input";
            }
        }


        private void changelbl_TextChanged(object sender, EventArgs e)
        {
            //CalculateAndDisplayChange();
        }

        private void button2_Click(object sender, EventArgs e)//cashbutton
        {
            UpdatePaymentMethod("Cash");
            
        }

        private void btncreditCard_Click(object sender, EventArgs e)
        {
            UpdatePaymentMethod("CreditCard");
            
        }

        private void btndebitCard_Click(object sender, EventArgs e)
        {
            UpdatePaymentMethod("DebitCard");
            
        }

        private void btngiftCard_Click(object sender, EventArgs e)
        {
            
            UpdatePaymentMethod("GiftCard");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["JobOrderID"].Value);
                decimal value2, changeValue;

                if (decimal.TryParse(textBox4.Text, out value2) && decimal.TryParse(changelbl.Text, out changeValue))
                {
                    int JobOrderNumber = Class1.GlobalVariables.JobOrderNumber; // Get the current JobOrderNumber

                    using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                    {
                        string updateJobOrderQuery = "UPDATE JobOrders SET Amount = @Amount, Change = @Change, Status = @Status WHERE JobOrderID = @JobOrderID";
                        OleDbCommand updateJobOrderCommand = new OleDbCommand(updateJobOrderQuery, connection);
                        //updateJobOrderCommand.Parameters.AddWithValue("@SalesID", JobOrderNumber);
                        updateJobOrderCommand.Parameters.AddWithValue("@Amount", value2);
                        updateJobOrderCommand.Parameters.AddWithValue("@Change", changeValue);
                        updateJobOrderCommand.Parameters.AddWithValue("@Status", true); // Assuming Status is a boolean field
                        updateJobOrderCommand.Parameters.AddWithValue("@JobOrderID", selectedRowId);

                        string insertSalesHistoryQuery = @"
                INSERT INTO SalesHistory (CustomerName, CustomerContact, DateCreated, Vehicle, PlateNo, Amount, SubTotal, Tax, Total, Discount, Change, PaymentMethod, Status)
                SELECT CustomerName, CustomerContact, DateCreated, Vehicle, PlateNo, Amount, SubTotal, Tax, Total, Discount, Change, PaymentMethod, Status
                FROM JobOrders WHERE JobOrderID = @JobOrderID";
                        OleDbCommand insertSalesHistoryCommand = new OleDbCommand(insertSalesHistoryQuery, connection);
                        insertSalesHistoryCommand.Parameters.AddWithValue("@JobOrderID", selectedRowId);

                        try
                        {
                            connection.Open();
                            updateJobOrderCommand.ExecuteNonQuery();
                            insertSalesHistoryCommand.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error submitting data: " + ex.Message);
                            return;
                        }
                    }

                    LoadDataGridView();
                    MessageBox.Show("Data submitted successfully!");
                }
                else
                {
                    MessageBox.Show("Invalid values in textBox4 or changelbl.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to submit.");
            }
        }

        private void LoadDataGridView()
        {
            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                string query = "SELECT * FROM JobOrders";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void UpdatePaymentMethod(string paymentMethod)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["JobOrderID"].Value);

                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                {
                    string query = "UPDATE JobOrders SET PaymentMethod = @PaymentMethod WHERE JobOrderID = @JobOrderID";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    command.Parameters.AddWithValue("@JobOrderID", selectedRowId);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating PaymentMethod: " + ex.Message);
                        return;
                    }
                }

                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a row to update the payment method.");
            }
        }
    }
}
