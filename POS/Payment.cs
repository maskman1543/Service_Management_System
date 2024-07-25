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

        private void LoadData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                {
                    string query = "SELECT CustomerName, CustomerContact, DateCreated, Vehicle, PlateNo, Subtotal, Tax, Total FROM JobOrders WHERE Status = False";
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

        private void textBox4_TextChanged(object sender, EventArgs e)
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
            // Split the value in textBox5 by spaces or commas (or any other delimiter)
            string[] values = textBox5.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Assign the values to textBox3 if they exist
            if (values.Length > 0)
            {
                //textBox1.Text = values.Length > 0 ? values[0] : string.Empty;
                //textBox2.Text = values.Length > 1 ? values[1] : string.Empty;
                textBox3.Text = values.Length > 0 ? values[0] : string.Empty;
            }
            else
            {
                // Clear the textboxes if textBox5 is empty or doesn't have enough values
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is part of the content (not header or out of bounds)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Retrieve the row that was clicked
                DataGridViewRow clickedRow = dataGridView1.Rows[e.RowIndex];

                // Assuming "Total", "Subtotal", and "Tax" are the names of the columns you want to display in textBox5, textBox1, and textBox2
                // Ensure the column names match exactly the ones in your DataGridView
                var totalCell = clickedRow.Cells["Total"];
                var subtotalCell = clickedRow.Cells["Subtotal"];
                var taxCell = clickedRow.Cells["Tax"];

                // Check if the cells are not null and have values before setting the textboxes
                if (totalCell.Value != null && subtotalCell.Value != null && taxCell.Value != null)
                {
                    // Set the values of the text boxes to the values of the respective cells
                    textBox5.Text = totalCell.Value.ToString();
                    textBox1.Text = subtotalCell.Value.ToString();
                    textBox2.Text = taxCell.Value.ToString();
                }
                else
                {
                    // If any of the cells are null, clear the text boxes
                    textBox5.Text = string.Empty;
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                }
            }
        }

    }
}
