using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Management_System.DASHBOARD
{
    public partial class AnalyticsForm : Form
    {

        private string[] arrayDateRange;
        public AnalyticsForm()
        {
            InitializeComponent();
            PopulateDateRangeArray();
            InitializeDateTimePickers();
            PopulateDataGridView();
        }

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

        private void PopulateDataGridView()
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
        }

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
            PopulateDataGridView();
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
            PopulateDataGridView();
        }

        private void btnWeekly_Click_1(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            int daysToSubtract = (int)currentDate.DayOfWeek - (int)DayOfWeek.Monday;
            DateTime startOfWeek = currentDate.AddDays(-daysToSubtract);
            AnalyticsDateRange.DateStart = startOfWeek;
            AnalyticsDateRange.DateEnd = currentDate;
            InitializeDateTimePickers();
            PopulateDataGridView();
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            AnalyticsDateRange.DateStart = DateTime.Now.Date;
            AnalyticsDateRange.DateEnd = DateTime.Now.Date;
            InitializeDateTimePickers();
            PopulateDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnalyticsDateRange.DateStart = DateTime.Now.AddDays(-1);
            AnalyticsDateRange.DateEnd = DateTime.Now.AddDays(-1);
            InitializeDateTimePickers();
            PopulateDataGridView();
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
            PopulateDataGridView();
        }
    }
}
