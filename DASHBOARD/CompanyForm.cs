using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Service_Management_System.DASHBOARD
{
    public partial class CompanyForm : Form
    {
        private PrintDocument printDocument;

        public CompanyForm()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Get the EmployeeID from the TextBox
            string employeeID = EmployeeID.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(employeeID))
            {
                MessageBox.Show("Please enter an Employee ID.");
                return;
            }

            // Database connection string
            string connectionString = Class1.GlobalVariables.ConnectionString2; // Use your actual connection string

            // SQL query to search for records by EmployeeID
            string query = "SELECT EmployeeID, FirstName, LastName, DateIn FROM EmpAtt_Query WHERE EmployeeID = ?";

            // Create and open a connection
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("?", employeeID);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Check if any data was returned
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found for the provided Employee ID.");
                    }

                    // Bind the results to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
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

        private void EmployeeID_TextChanged(object sender, EventArgs e)
        {
            // Optionally, you can automatically search as the user types
            // LoadEmployeeAttendance(EmployeeID.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events if needed
        }
    }
}
