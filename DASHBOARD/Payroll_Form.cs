using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
    }
}
