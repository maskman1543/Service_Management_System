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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Service_Management_System.DASHBOARD
{
    public partial class Payroll_Form : Form
    {

        private Panel chartpanel;
        private Chart chart1;
        public Payroll_Form()
        {
            InitializeComponent();
            InitializeChart();
            LoadChartData();
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
            // Clear any existing series
            chart1.Series.Clear();

            // Create a new series for the pie chart
            Series series = new Series("PieSeries")
            {
                ChartType = SeriesChartType.Pie, // Set the chart type to Pie
                IsValueShownAsLabel = true, // Show data values as labels on the pie chart
                Font = new System.Drawing.Font("Century Gothic", 10f) // Set font to Century Gothic
            };

            // Add data points to the series
            series.Points.Add(new DataPoint(0, 10) { LegendText = "Category A" });
            series.Points.Add(new DataPoint(1, 20) { LegendText = "Category B" });
            series.Points.Add(new DataPoint(2, 30) { LegendText = "Category C" });
            series.Points.Add(new DataPoint(3, 25) { LegendText = "Category D" });
            series.Points.Add(new DataPoint(4, 15) { LegendText = "Category E" });

            // Add the series to the chart
            chart1.Series.Add(series);

            // Optionally, customize chart area, axis titles, etc.
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 10f);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 10f);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmpID.Text))
            {
                MessageBox.Show("Employee ID cannot be empty.");
                return;
            }

            string selectQuery = "SELECT COUNT(*) FROM EmployeePayroll WHERE EmployeeID = @EmployeeID";
            string insertQuery = "INSERT INTO EmployeePayroll (EmployeeID, DayOfPresent, sss, pagibig, NetSalary) VALUES (@EmployeeID, @BasicSalary, @SSS, @Pagibig, @NetSalary)";
            string updateQuery = "UPDATE EmployeePayroll SET DayOfPresent = @BasicSalary, sss = @SSS, pagibig = @Pagibig, NetSalary = @NetSalaryWHERE EmployeeID = @EmployeeID";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                OleDbCommand selectCmd = new OleDbCommand(selectQuery, connection);
                selectCmd.Parameters.AddWithValue("@EmployeeID", EmpID.Text);

                try
                {
                    connection.Open();
                    int recordCount = (int)selectCmd.ExecuteScalar();

                    OleDbCommand cmd;
                    if (recordCount > 0)
                    {
                        // Update the existing record
                        cmd = new OleDbCommand(updateQuery, connection);
                        MessageBox.Show("Updating existing record.");
                    }
                    else
                    {
                        // Insert a new record
                        cmd = new OleDbCommand(insertQuery, connection);
                        MessageBox.Show("Inserting new record.");
                    }

                    cmd.Parameters.AddWithValue("@BasicSalary", SalaryTxb.Text);
                    cmd.Parameters.AddWithValue("@SSS", SSS.Text);
                    cmd.Parameters.AddWithValue("@Pagibig", PagIbig.Text);
                    cmd.Parameters.AddWithValue("@NetSalary", NetSalary.Text);
                    cmd.Parameters.AddWithValue("@EmployeeID", EmpID.Text); // Parameter for WHERE clause must be added last

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(recordCount > 0 ? "Payroll record updated successfully." : "Payroll record saved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Please check the EmployeeID.");
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
            // Define the deduction per absence (this could be a fixed amount or a calculated value based on salary)
            decimal deductionPerAbsence = 435; // Example: daily deduction if a month has 30 days

            // Calculate the total deduction
            decimal totalDeduction = sss + pagibig ;
            decimal totalsalary = (salary * basicSalary);
            // Calculate the net salary
            decimal netSalary = totalsalary - totalDeduction;

            NetSalary.Text = netSalary.ToString();
        }
        private void LoadPayrollData()
        {
            string query = "SELECT * FROM EMPpayroll_Query";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
