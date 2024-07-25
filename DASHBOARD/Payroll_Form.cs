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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Service_Management_System.DASHBOARD
{
    public partial class Payroll_Form : Form
    { 
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

        private Panel chartpanel;
        private Chart chart1;

        public Payroll_Form()
        {
            InitializeComponent();
            InitializeChart();
            LoadChartData();
            LoadPayrollData();
            printDocument.PrintPage += PrintDocument_PrintPage;

        }

        private void InitializeChart()
        {
            // Initialize the chart
            chart1 = new Chart
            {
                Location = new System.Drawing.Point(17, 154), // Set location
                Size = new System.Drawing.Size(487, 327), // Set size
                Dock = DockStyle.None // No automatic docking
            };

            // Create a ChartArea and add it to the chart
            ChartArea chartArea = new ChartArea
            {
                // Configure the ChartArea to have a flat design
                Area3DStyle = { Enable3D = false }
            };
            chart1.ChartAreas.Add(chartArea);

            // Configure the legend
            Legend legend = new Legend("Legend")
            {
                // Set the legend to be positioned on the right side of the chart
                Docking = Docking.Right,
                Alignment = System.Drawing.StringAlignment.Center,
                Font = new System.Drawing.Font("Century Gothic", 10f)
            };

            // Add the legend to the chart
            chart1.Legends.Add(legend);

            // Add the chart to the form
            this.Controls.Add(chart1);
        }

        private void LoadChartData()
        {
            chart1.Series.Clear();
            Series series = new Series("PieSeries")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Font = new Font("Century Gothic", 10f)
            };

            series.Points.Add(new DataPoint(0, 10) { LegendText = "Category A" });
            series.Points.Add(new DataPoint(1, 20) { LegendText = "Category B" });
            series.Points.Add(new DataPoint(2, 30) { LegendText = "Category C" });
            series.Points.Add(new DataPoint(3, 25) { LegendText = "Category D" });
            series.Points.Add(new DataPoint(4, 15) { LegendText = "Category E" });

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Century Gothic", 10f);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Century Gothic", 10f);
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmpID.Text))
            {
                MessageBox.Show("Employee ID cannot be empty.");
                return;
            }

            string selectQuery = "SELECT COUNT(*) FROM EmployeePayroll WHERE EmployeeID = ?";
            string insertQuery = "INSERT INTO EmployeePayroll (EmployeeID, DayOfPresent, sss, pagibig, NetSalary, MonthSalary) VALUES (?, ?, ?, ?, ?, ?)";
            string updateQuery = "UPDATE EmployeePayroll SET DayOfPresent = ?, sss = ?, pagibig = ?, NetSalary = ?, MonthSalary = ? WHERE EmployeeID = ?";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                OleDbCommand selectCmd = new OleDbCommand(selectQuery, connection);
                selectCmd.Parameters.AddWithValue("?", EmpID.Text);

                try
                {
                    connection.Open();
                    int recordCount = (int)selectCmd.ExecuteScalar();

                    string currentMonthYear = DateTime.Now.ToString("MM/yyyy");

                    if (recordCount > 0)
                    {
                        using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("?", SalaryTxb.Text);
                            updateCmd.Parameters.AddWithValue("?", SSS.Text);
                            updateCmd.Parameters.AddWithValue("?", PagIbig.Text);
                            updateCmd.Parameters.AddWithValue("?", NetSalary.Text);
                            updateCmd.Parameters.AddWithValue("?", currentMonthYear);
                            updateCmd.Parameters.AddWithValue("?", EmpID.Text);

                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Payroll record updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No rows affected. Please check the EmployeeID.");
                            }
                        }
                    }
                    else
                    {
                        using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, connection))
                        {
                            insertCmd.Parameters.AddWithValue("?", EmpID.Text);
                            insertCmd.Parameters.AddWithValue("?", SalaryTxb.Text);
                            insertCmd.Parameters.AddWithValue("?", SSS.Text);
                            insertCmd.Parameters.AddWithValue("?", PagIbig.Text);
                            insertCmd.Parameters.AddWithValue("?", NetSalary.Text);
                            insertCmd.Parameters.AddWithValue("?", currentMonthYear);

                            int rowsAffected = insertCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Payroll record saved successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to save the payroll record. Please check the details.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            LoadPayrollData();
        }



        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalaryTxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PagIbig_TextChanged(object sender, EventArgs e)
        {

        }

        private void SSS_TextChanged(object sender, EventArgs e)
        {

        }

        private void NetSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalSal_Click(object sender, EventArgs e)
        {
            decimal basicSalary = Convert.ToDecimal(SalaryTxb.Text);
            decimal sss = Convert.ToDecimal(SSS.Text);
            decimal pagibig = Convert.ToDecimal(PagIbig.Text);
            decimal salary = 435;
            decimal deductionPerAbsence = 435;

            decimal totalDeduction = sss + pagibig;
            decimal totalsalary = (salary * basicSalary);
            decimal netSalary = totalsalary - totalDeduction;

            NetSalary.Text = netSalary.ToString();
        }
        private void LoadPayrollData(string employeeID = null)
        {
            string query = "SELECT * FROM EMPpayroll_Query";
            if (!string.IsNullOrEmpty(employeeID))
            {
                query += " WHERE EmployeeID = ?";
            }

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = new OleDbCommand(query, connection);

                if (!string.IsNullOrEmpty(employeeID))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("?", employeeID);
                }

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string employeeID = SearchEmpIDTextBox.Text;
            LoadPayrollData(employeeID);
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define fonts and brushes
            Font printFont = new Font("Arial", 10);
            Brush printBrush = Brushes.Black;

            // Calculate the starting point for printing
            float yPos = e.MarginBounds.Top;
            int count = 0;

            // Define the spacing between lines
            float lineHeight = printFont.GetHeight(e.Graphics);
            float leftMargin = e.MarginBounds.Left;

            // Define column widths (example values)
            float[] columnWidths = new float[dataGridView1.Columns.Count];
            for (int i = 0; i < columnWidths.Length; i++)
            {
                columnWidths[i] = 100; // Adjust width as necessary
            }

            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Loop through each cell in the row
                float xPos = leftMargin;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string cellText = cell.Value != null ? cell.Value.ToString() : "";
                    e.Graphics.DrawString(cellText, printFont, printBrush, xPos, yPos);
                    xPos += columnWidths[cell.ColumnIndex]; // Move to the next column position
                }

                // Move down to the next line
                yPos += lineHeight;

                // Check if the text will fit on the current page
                if (yPos + lineHeight > e.MarginBounds.Bottom)
                {
                    // Indicate that there is more to print on the next page
                    e.HasMorePages = true;
                    return;
                }
            }

            // No more pages to print
            e.HasMorePages = false;
        }



        private void PrintBtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
    }
}