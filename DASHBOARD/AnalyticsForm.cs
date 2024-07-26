using Guna.UI2.WinForms.Suite;
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

namespace Service_Management_System.DASHBOARD
{
    public partial class AnalyticsForm : Form
    {

        private string[] arrayDateRange;
        private Chart chart1;
        private Chart horizontalChart;
        public AnalyticsForm()
        {
            InitializeComponent();
            PopulateDateRangeArray();
            InitializeDateTimePickers();
            //PopulateDataGridView();
            InitializeChart();
            LoadChartData();
            //InitializeHorizontalChart();
            //LoadHorizontalChartData();
           // LoadHorizontalChartData();
        }



        private void InitializeChart()
        {
            // Initialize the chart
            chart1 = new Chart
            {
                Location = new Point(12, 590), // Set location
                Size = new Size(1073, 303), // Set size
                Dock = DockStyle.None // No automatic docking
            };

            // Create a ChartArea and add it to the chart
            ChartArea chartArea = new ChartArea
            {
                // Configure the ChartArea
                Area3DStyle = { Enable3D = false }
            };
            chart1.ChartAreas.Add(chartArea);

            // Configure the legend
            Legend legend = new Legend("Legend")
            {
                Docking = Docking.Right,
                Alignment = StringAlignment.Center,
                Font = new Font("Century Gothic", 10f)
            };

            // Add the legend to the chart
            chart1.Legends.Add(legend);

            // Add the chart to the form
            this.Controls.Add(chart1);
        }


        private void LoadChartData()
        {
            // Initialize the chart if not already done
            if (chart1 == null)
            {
                InitializeChart();
            }

            // Clear any existing series
            chart1.Series.Clear();

            // Remove any existing legends
            chart1.Legends.Clear();

            // Create a new series for the vertical bar chart
            Series series = new Series("SalesSeries")
            {
                ChartType = SeriesChartType.Column, // Set the chart type to Column for vertical bars
                IsValueShownAsLabel = true, // Show data values as labels on the bar chart
                Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular), // Set font to Microsoft Sans Serif, size 8, regular style
                BorderWidth = 1 // Optional: Set border width of bars
            };

            // Set constant bar width
            series["PointWidth"] = "0.8"; // Adjust the value to control the width (range: 0 to 1)

            // Fetch and integrate data from the SalesHistory table
            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                try
                {
                    connection.Open();

                    // Construct the query to sum Prices for each DateSale
                    string query = "SELECT DateCreated, SUM(Total) AS TotalPrice " +
                                   "FROM SalesHistory " +
                                   "WHERE DateCreated IN ({0}) " +
                                   "GROUP BY DateCreated";

                    // Construct the IN clause parameters dynamically based on arrayDateRange length
                    string dateParams = string.Join(",", arrayDateRange.Select((s, i) => "@date" + i));
                    query = string.Format(query, dateParams);

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Add date parameters to the command
                        for (int i = 0; i < arrayDateRange.Length; i++)
                        {
                            command.Parameters.AddWithValue("@date" + i, arrayDateRange[i]);
                        }

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime dateSale = reader.GetDateTime(0);
                                decimal totalPrice = reader.GetDecimal(1);

                                if (totalPrice > 0)
                                {
                                    // Add data points to the series
                                    series.Points.Add(new DataPoint(dateSale.ToOADate(), (double)totalPrice)
                                    {
                                        AxisLabel = dateSale.ToString("d/M/yyyy")
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving data: " + ex.Message);
                }
            }

            // Add the series to the chart
            chart1.Series.Add(series);

            // Customize chart area, axis titles, etc.
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
            chart1.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular);

            // Set the title for the X and Y axes
            chart1.ChartAreas[0].AxisX.Title = "Date of Sale";
            chart1.ChartAreas[0].AxisY.Title = "Total Price";

            // Customize the appearance of the chart area
            chart1.ChartAreas[0].BackColor = System.Drawing.Color.White; // Set background color to white
            chart1.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid; // Set border style
            chart1.ChartAreas[0].BorderWidth = 1; // Set border width
            chart1.ChartAreas[0].BorderColor = System.Drawing.Color.Gray; // Set border color

            // Remove gridlines from the X and Y axes
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            // Adjust axis labels to avoid overlap
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 45; // Rotate labels to avoid overlap
            chart1.ChartAreas[0].AxisX.Interval = 1; // Set the interval to 1 to show all labels
            chart1.ChartAreas[0].AxisX.IntervalOffset = 0; // Adjust to avoid unnecessary space
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0; // Remove gridlines
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0; // Remove gridlines
        }
       /* private void InitializeHorizontalChart()
        {
            // Initialize the chart
            horizontalChart = new Chart
            {
                Location = new Point(14, 350), // Set location
                Size = new Size(1063, 206),    // Set size
                Dock = DockStyle.None           // No automatic docking
            };

            // Create a ChartArea and add it to the chart
            ChartArea chartArea = new ChartArea
            {
                // Configure the ChartArea
                Area3DStyle = { Enable3D = false }
            };
            horizontalChart.ChartAreas.Add(chartArea);

            // Configure the legend
            Legend legend = new Legend("Legend")
            {
                Docking = Docking.Right,
                Alignment = StringAlignment.Center,
                Font = new Font("Century Gothic", 10f)
            };

            // Add the legend to the chart
            horizontalChart.Legends.Add(legend);

            // Add the chart to the form
            this.Controls.Add(horizontalChart);
        }

        private void LoadHorizontalChartData()
        {
            // Initialize the chart if not already done
            if (horizontalChart == null)
            {
                InitializeHorizontalChart();
            }

            // Clear any existing series
            horizontalChart.Series.Clear();

            // Remove any existing legends
            horizontalChart.Legends.Clear();

            // Create a new series for the horizontal bar chart
            Series series = new Series("QuantitySeries")
            {
                ChartType = SeriesChartType.Bar, // Set the chart type to Bar for horizontal bars
                IsValueShownAsLabel = true, // Show data values as labels on the bar chart
                Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular), // Set font to Microsoft Sans Serif, size 8, regular style
                BorderWidth = 1 // Optional: Set border width of bars
            };

            // Set constant bar width
            series["PointWidth"] = "0.8"; // Adjust the value to control the width (range: 0 to 1)

            // Fetch and integrate data from the SalesHistory table
            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                try
                {
                    connection.Open();

                    // Construct the query to sum Quantity for each DateSale
                    string query = "SELECT DateCreated, SUM(Quantity) AS TotalQuantity " +
                                   "FROM SalesHistory " +
                                   "WHERE DateCreated IN ({0}) " +
                                   "GROUP BY DateCreated";

                    // Construct the IN clause parameters dynamically based on arrayDateRange length
                    string dateParams = string.Join(",", arrayDateRange.Select((s, i) => "?"));
                    query = string.Format(query, dateParams);

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Add date parameters to the command
                        for (int i = 0; i < arrayDateRange.Length; i++)
                        {
                            command.Parameters.AddWithValue("?", arrayDateRange[i]); // Use "?" for OleDb parameters
                        }

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime dateSale = reader.GetDateTime(0);
                                double totalQuantity = reader.IsDBNull(1) ? 0 : reader.GetDouble(1); // Use GetDouble for Quantity, handle DBNull

                                if (totalQuantity > 0)
                                {
                                    // Add data points to the series
                                    series.Points.Add(new DataPoint(totalQuantity, dateSale.ToOADate())
                                    {
                                        AxisLabel = dateSale.ToString("d/M/yyyy")
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving data: " + ex.Message);
                }
            }

            // Add the series to the chart
            horizontalChart.Series.Add(series);

            // Customize chart area, axis titles, etc.
            horizontalChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
            horizontalChart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
            horizontalChart.ChartAreas[0].AxisX.TitleFont = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
            horizontalChart.ChartAreas[0].AxisY.TitleFont = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);

            // Set the title for the X and Y axes
            horizontalChart.ChartAreas[0].AxisX.Title = "Quantity";
            horizontalChart.ChartAreas[0].AxisY.Title = "Date of Sale";

            // Customize the appearance of the chart area
            horizontalChart.ChartAreas[0].BackColor = Color.White; // Set background color to white
            horizontalChart.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid; // Set border style
            horizontalChart.ChartAreas[0].BorderWidth = 1; // Set border width
            horizontalChart.ChartAreas[0].BorderColor = Color.Gray; // Set border color

            // Remove gridlines from the X and Y axes
            horizontalChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            horizontalChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            // Adjust axis labels to avoid overlap
            horizontalChart.ChartAreas[0].AxisY.LabelStyle.Angle = 45; // Rotate labels to avoid overlap
            horizontalChart.ChartAreas[0].AxisY.Interval = 1; // Set the interval to 1 to show all labels
            horizontalChart.ChartAreas[0].AxisY.IntervalOffset = 0; // Adjust to avoid unnecessary space
            horizontalChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0; // Remove gridlines
            horizontalChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0; // Remove gridlines
        }
        */



        private void PopulateDateRangeArray()
        {
            // Ensure DashboardData.DateStart and DashboardData.DateEnd are set
            if (AnalyticsDateRange.DateStart == null || AnalyticsDateRange.DateEnd == null)
            {
                // Handle error or provide default values
                return;
            }

            // Calculate the number of days in the date range
            TimeSpan span = AnalyticsDateRange.DateEnd - AnalyticsDateRange.DateStart;
            int numDays = span.Days + 1;

            // Initialize the array with the appropriate size
            arrayDateRange = new string[numDays];

            // Populate the array with dates in the "M-d-yyyy" format
            for (int i = 0; i < numDays; i++)
            {
                DateTime date = AnalyticsDateRange.DateStart.AddDays(i);
                arrayDateRange[i] = date.ToString("d/M/yyyy");
            }
        }

        /*private void PopulateDataGridView()
        {
            // Initialize the column if it doesn't exist
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("DateColumn", "Date");
            }

            // Clear the existing rows
            dataGridView1.Rows.Clear();

            // Add the dates from arrayDateRange to the DataGridView
            foreach (string date in arrayDateRange)
            {
                dataGridView1.Rows.Add(date);
            }
        }*/

        private void AnalyticsForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {

        }

        private void btnYearly_Click(object sender, EventArgs e)
        {

        }

        private void btnYearly_Click_1(object sender, EventArgs e)
        {
            AnalyticsDateRange.DateStart = DateTime.ParseExact($"1/1/{DateTime.Now.Year}", "d/M/yyyy", null);
            AnalyticsDateRange.DateEnd = DateTime.ParseExact($"31/12/{DateTime.Now.Year}", "d/M/yyyy", null);
            InitializeDateTimePickers();
            PopulateDateRangeArray();
            LoadChartData();
            //PopulateDataGridView();
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Calculate the first day of the current month
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            AnalyticsDateRange.DateStart = firstDayOfMonth;

            // Set the end date to the current date
            AnalyticsDateRange.DateEnd = currentDate;
            InitializeDateTimePickers();
            PopulateDateRangeArray();
            LoadChartData();
            //PopulateDataGridView();
        }

        private void btnWeekly_Click_1(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            int daysToSubtract = (int)currentDate.DayOfWeek - (int)DayOfWeek.Monday;
            DateTime startOfWeek = currentDate.AddDays(-daysToSubtract);
            AnalyticsDateRange.DateStart = startOfWeek;
            AnalyticsDateRange.DateEnd = currentDate;
            InitializeDateTimePickers();
            PopulateDateRangeArray();
            LoadChartData();
            //PopulateDataGridView();
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            AnalyticsDateRange.DateStart = DateTime.Now.Date;
            AnalyticsDateRange.DateEnd = DateTime.Now.Date;
            InitializeDateTimePickers();
            PopulateDateRangeArray();
            LoadChartData();
            //PopulateDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnalyticsDateRange.DateStart = DateTime.Now.AddDays(-1);
            AnalyticsDateRange.DateEnd = DateTime.Now.AddDays(-1);
            InitializeDateTimePickers();
            PopulateDateRangeArray();
            LoadChartData();
            //PopulateDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePickerStart.Enabled = true;
            dateTimePickerEnd.Enabled = true;
            Okay.Enabled = true;
        }
        private void InitializeDateTimePickers()
        {
            dateTimePickerStart.Enabled = false;
            dateTimePickerEnd.Enabled = false;
            Okay.Enabled = false;
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Okay_Click(object sender, EventArgs e)
        {
            // Get the selected dates from datetimepickers
            DateTime selectedStartDate = dateTimePickerStart.Value;
            DateTime selectedEndDate = dateTimePickerEnd.Value;

            // Format the dates to "M-d-yyyy"
            string formattedStartDate = selectedStartDate.ToString("d/M/yyyy");
            string formattedEndDate = selectedEndDate.ToString("d/Myyyy");

            // Pass the formatted dates to DashboardData fields
            AnalyticsDateRange.DateStart = selectedStartDate;
            AnalyticsDateRange.DateEnd = selectedEndDate;
            PopulateDateRangeArray();
            LoadChartData();
            //PopulateDataGridView();
        }
    }
}
