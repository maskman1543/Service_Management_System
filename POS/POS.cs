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
//using Service_Management_System.Registration;

namespace Service_Management_System.POS
{
    public partial class POSForm : Form
    {
        private bool isFadingIn;
        private bool isFadingOut;
        private int fadeDuration = 90; // Duration in milliseconds
        private int fadeStep;
        public POSForm()
        {
            InitializeComponent();
            sidepanelPOS.Hide();
            timerSfx.Interval = 50; // Timer interval for smooth transition
            fadeStep = 255 * timerSfx.Interval / fadeDuration; // Calculate fade step
        }

        private void timerSfx_Tick(object sender, EventArgs e)
        {
            if (isFadingIn)
            {
                int alpha = sidepanelPOS.BackColor.A + fadeStep;
                if (alpha >= 255)
                {
                    alpha = 255;
                    isFadingIn = false;
                    timerSfx.Stop();
                }
                sidepanelPOS.BackColor = Color.FromArgb(alpha, sidepanelPOS.BackColor);
            }
            else if (isFadingOut)
            {
                int alpha = sidepanelPOS.BackColor.A - fadeStep;
                if (alpha <= 0)
                {
                    alpha = 0;
                    isFadingOut = false;
                    timerSfx.Stop();
                    sidepanelPOS.Hide();
                    sidepanelPOS.Width = 10;
                    sidepanelPOS.Height = 10;
                    sidepanelPOS.Location = new Point(1470, 78);
                }
                sidepanelPOS.BackColor = Color.FromArgb(alpha, sidepanelPOS.BackColor);
            }
        }

        private void btnmenU2_Click(object sender, EventArgs e)
        {
            if (sidepanelPOS.Visible)
            {
                isFadingOut = true;
                isFadingIn = false;
            }
            else
            {
                isFadingIn = true;
                isFadingOut = false;
                sidepanelPOS.Width = 256;
                sidepanelPOS.Height = 656;
                sidepanelPOS.Location = new Point(1224, 78); // Set the Location property with a Point
                sidepanelPOS.Show();
            }
            timerSfx.Start();
        }


        private void POS_Load(object sender, EventArgs e)
        {
            LoadPartsView();
            LoadserviceView();
        }

        private void btnSaveSale_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void partsServicesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a valid cell
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = partsView.Rows[e.RowIndex];
                int productID = Convert.ToInt32(selectedRow.Cells["productID"].Value);

                LoadProductOrderedView(productID);
            }
        }


        private void LoadProductOrderedView(int productID)
        {
            string query = $"SELECT productTable.productID, productTable.productGroup, productTable.productName, productTable.Price, productTable.barcode\r\nFROM productTable;\r\n";
                        

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    productOrderedView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void LoadServiceOrderedView(int productID)
        {
            string query = $"SELECT servicesTb.serviceID, servicesTb.serviceName, servicesTb.serviceRate, mechanicTb.mechanicTb\r\nFROM mechanicTb INNER JOIN (servicesTb INNER JOIN JobOrderTb ON servicesTb.serviceID = JobOrderTb.serviceID) ON mechanicTb.mechanicTb = JobOrderTb.mechanicID;\r\n";


            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    jobOrderedView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void LoadPartsView()
        {
            string query = "SELECT productTable.productID, productTable.productGroup, productTable.productName, productTable.Price, productTable.barcode\r\nFROM productTable;\r\n";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    partsView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void servicesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = servicesView.Rows[e.RowIndex];
                if (selectedRow.Cells["serviceID"].Value != null)
                {
                    int serviceID = Convert.ToInt32(selectedRow.Cells["serviceID"].Value);
                    LoadServiceOrderedView(serviceID);
                }
            }
        }

        private void LoadserviceView()
        {
            string query = "SELECT servicesTb.serviceID, servicesTb.serviceType, servicesTb.serviceName, servicesTb.serviceRate FROM servicesTb;";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    servicesView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }







        private void button12_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            button12.Width = 275;
            button12.Height = 62;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            button12.Width = 265;
            button12.Height = 57;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            button13.Width = 275;
            button13.Height = 62;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            button13.Width = 265;
            button13.Height = 57;
        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            button14.Width = 275;
            button14.Height = 62;
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            button14.Width = 265;
            button14.Height = 57;
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            button15.Width = 275;
            button15.Height = 62;
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            button15.Width = 265;
            button15.Height = 57;
        }

        private void button19_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            button19.Width = 275;
            button19.Height = 62;
        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            button19.Width = 265;
            button19.Height = 57;
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            button18.Width = 275;
            button18.Height = 62;
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            button18.Width = 265;
            button18.Height = 57;
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            button17.Width = 275;
            button17.Height = 62;
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            button17.Width = 265;
            button17.Height = 57;
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            button16.Width = 275;
            button16.Height = 62;
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            button16.Width = 265;
            button16.Height = 57;
        }

        private void adjust_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            adjust.Width = 57;
            adjust.Height = 56;
        }

        private void adjust_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            adjust.Width = 52;
            adjust.Height = 51;
        }

        private void allout_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            allout.Width = 57;
            allout.Height = 56;
        }

        private void allout_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            allout.Width = 52;
            allout.Height = 51;
        }

        private void moveup_MouseEnter(object sender, EventArgs e)
        {
            // Increase size when mouse enters
            moveup.Width = 57;
            moveup.Height = 56;
        }

        private void moveup_MouseLeave(object sender, EventArgs e)
        {
            // Restore original size when mouse leaves
            moveup.Width = 52;
            moveup.Height = 51;
        }

        

        /*private void button12_MouseEnter(object sender, EventArgs e)
        {
            
        }*/
    }
}
