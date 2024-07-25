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
            CalculateAndDisplayChange();
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

        /*private void TextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayChange();
        }*/

        private void CalculateAndDisplayChange()
        {
            decimal value1, value2;

            // Try to parse values from textBox5 and textBox4
            bool isValidValue1 = decimal.TryParse(textBox5.Text, out value1);
            bool isValidValue2 = decimal.TryParse(textBox4.Text, out value2);

            if (isValidValue1 && isValidValue2)
            {
                // Perform subtraction and display the result
                decimal result = value1 - value2;
                changelbl.Text = result.ToString("F2"); // Format to 2 decimal places
            }
            else
            {
                // Clear the label if inputs are invalid
                changelbl.Text = "Invalid input";
            }
        }

        /*private void Form1_Load(object sender, EventArgs e)
        {
            textBox5.TextChanged += new EventHandler(TextBox_TextChanged);
            textBox4.TextChanged += new EventHandler(TextBox_TextChanged);
        }*/

        private void changelbl_TextChanged(object sender, EventArgs e)
        {
            //CalculateAndDisplayChange();
        }

        

    }
}
