using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Service_Management_System.DASHBOARD
{
    public partial class DocumentsForm : Form
    {
        private System.Drawing.Printing.PrintDocument printDocument;

        public DocumentsForm()
        {
            InitializeComponent();
            printDocument = new System.Drawing.Printing.PrintDocument();
            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Get the MechanicID from the TextBox
            string mechanicID = SM.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(mechanicID))
            {
                MessageBox.Show("Please enter a Mechanic ID.");
                return;
            }

            // Database connection string
            string connectionString = Class1.GlobalVariables.ConnectionString2; // Use your actual connection string

            // SQL query to search for records by MechanicID
            string query = "SELECT MechanicID, MechanicName, MechanicLastName ,CustomerName , Vehicle, Subtotal, Status , taskAssign FROM MechanicPayroll_query WHERE MechanicID = ?";

            // Create and open a connection
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("?", mechanicID);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    // Check if any data was returned
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found for the provided Mechanic ID.");
                    }
                    // Bind the results to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SM_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font("Arial", 10);
            Brush printBrush = Brushes.Black;

            float yPos = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;
            float lineHeight = printFont.GetHeight(e.Graphics);
            int count = 0;

            // Define column widths
            float[] columnWidths = new float[dataGridView1.Columns.Count];
            for (int i = 0; i < columnWidths.Length; i++)
            {
                columnWidths[i] = 100; // Adjust as needed
            }

            // Print column headers
            float xPos = leftMargin;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                e.Graphics.DrawString(column.HeaderText, printFont, printBrush, xPos, yPos);
                xPos += columnWidths[column.Index];
            }

            yPos += lineHeight;

            // Print rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                xPos = leftMargin;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string cellText = cell.Value != null ? cell.Value.ToString() : "";
                    e.Graphics.DrawString(cellText, printFont, printBrush, xPos, yPos);
                    xPos += columnWidths[cell.ColumnIndex];
                }

                yPos += lineHeight;

                // Check if the text will fit on the current page
                if (yPos + lineHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }
    }
}
