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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is part of the content (not header or out of bounds)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Retrieve the row that was clicked
                DataGridViewRow clickedRow = dataGridView1.Rows[e.RowIndex];

                // Assuming "Total" is the name of the column you want to display in textBox5
                // Ensure the column name matches exactly the one in your DataGridView
                var totalCell = clickedRow.Cells["Total"];

                if (totalCell.Value != null)
                {
                    // Set the value of textBox5 to the value of the "Total" cell
                    textBox5.Text = totalCell.Value.ToString();
                }
                else
                {
                    // If the cell is null, clear the textBox5
                    textBox5.Text = string.Empty;
                }
            }
        }
    }
}
