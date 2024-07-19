using Service_Management_System.POS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Service_Management_System.DASHBOARD
{
    public partial class ProductsServicesForm : Form
    {
        POSForm POSForm = new POSForm();
        bool sidebarExpand;
        private Form currentChildForm;

        public ProductsServicesForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
                {
                    string query = "SELECT * FROM servicesTb";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    PSView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occurred: " + ex.Message);
            }
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
                {
                    string query = "SELECT productTable.ProductID, productTable.ProductType, productTable.ProductName, productTable.Cost, productTable.Price, productTable.Barcode, productTable.Description\r\nFROM productTable;\r\n";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    PSView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occurred: " + ex.Message);
            }
        }

        private void sidebar_addproducts_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panel3.Width -= 10;
                if (panel3.Width == panel3.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebar_addproducts.Stop();
                }
            }
            else
            {
                panel3.Width += 10;
                if (panel3.Width == panel3.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebar_addproducts.Stop();
                }
            }
        }
        private void OpenchildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelpro_service.Controls.Add(childForm);
            panelpro_service.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidebar_addproducts.Start();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sidebar_addproducts.Start();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            OpenchildForm(new priceandtax_form());
        }

        private void btnStockControl_Click(object sender, EventArgs e)
        {
            OpenchildForm(new stockControl_form());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is stockControl_form)
                {
                    form.Hide(); // Hide the AnalysisForm if it is open
                    return; // Exit the method
                }
                else if (form is priceandtax_form)
                {
                    form.Hide(); // Hide the AnalysisForm if it is open
                    return; // Exit the method
                }
            }
        }
    }
}
