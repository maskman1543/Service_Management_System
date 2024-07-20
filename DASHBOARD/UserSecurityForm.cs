using Service_Management_System.POS.Login_Page_Front___Backend;
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
using System.Security.Cryptography;
using System.Text;
using Service_Management_System.POS.Login_Page_Front_and_Back_End;

namespace Service_Management_System.DASHBOARD
{
    public partial class UserSecurityForm : Form
    {
        bool sidebarExpand;
        bool sidebarExpandbtnEdit;
        public UserSecurityForm()
        {
            InitializeComponent();
            LoadEmployeesView();
            EPasswordValue.PasswordChar = '*'; // Hide password characters
            ECPasswordValue.PasswordChar = '*';// Hide password characters
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadEmployeesView()
        {
            string query = "SELECT EmployeeTb.EmployeeID, EmployeeTb.FirstName, EmployeeTb.LastName, EmployeeTb.Email, EmployeeTb.Contact\r\nFROM EmployeeTb;\r\n";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    EmployeeView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void EmployeeView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar_AddUser.Width -= 10;
                if (sidebar_AddUser.Width == sidebar_AddUser.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar_AddUser.Width += 10;
                if (sidebar_AddUser.Width == sidebar_AddUser.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // Retrieve values from input fields
            string firstName = EFirstNameValue.Text;
            string lastName = ELastNameValue.Text;
            string email = EEmailValue.Text;
            // string phoneNumber = phoneNumberValue.Text;
            string password = EPasswordValue.Text;
            string confirmPassword = ECPasswordValue.Text;

            // Validate inputs (optional)
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email)
               /* string.IsNullOrEmpty(phoneNumber*/ || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please enter matching passwords.");
                return;
            }

            // Hash the password
            string hashedPassword = HashPassword(password);

            // If validation passes, proceed with registration logic (example)
            try
            {
                // Example: Insert user data into a database
                OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString);
                string query = "INSERT INTO EmployeeTb (Firstname, LastName, Email, [Password]) " +
                               "VALUES (@FirstName, @LastName, @Email, @Password)";

                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                //command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@Password", hashedPassword);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User registered successfully.");
                    // Optionally, clear input fields or reset form state
                    EFirstNameValue.Text = "";
                    ELastNameValue.Text = "";
                    EEmailValue.Text = "";
                    //phoneNumberValue.Text = "";
                    EPasswordValue.Text = "";
                    ECPasswordValue.Text = "";

                    // Close the registration form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to register user. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                // Handle any specific error logging or display as needed
            }
        }
        private void DeleteSelectedRow()
        {
            if (EmployeeView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = EmployeeView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = EmployeeView.Rows[selectedRowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value); // Assuming "ID" is the primary key column


                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
                {
                    string query = "DELETE FROM EmployeeTb WHERE EmployeeID = @ID";

                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
                            EmployeeView.Rows.RemoveAt(selectedRowIndex);
                        }
                        else
                        {
                            MessageBox.Show("Record deletion failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a cell to delete.");
            }
        }

        private void sidebarTimerbtnEdit_Tick(object sender, EventArgs e)
        {
            if (sidebarExpandbtnEdit)
            {
                sidebar_EditUserInfo.Width -= 10;
                if (sidebar_EditUserInfo.Width == sidebar_EditUserInfo.MinimumSize.Width)
                {
                    sidebarExpandbtnEdit = false;
                    sidebarTimerbtnEdit.Stop();
                }
            }
            else
            {
                sidebar_EditUserInfo.Width += 10;
                if (sidebar_EditUserInfo.Width == sidebar_EditUserInfo.MaximumSize.Width)
                {
                    sidebarExpandbtnEdit = true;
                    sidebarTimerbtnEdit.Stop();
                }
            }
        }

        private void lblBackEdit_Click(object sender, EventArgs e)
        {
            sidebarTimerbtnEdit.Start();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            sidebarTimerbtnEdit.Start();
        }
    }

}
