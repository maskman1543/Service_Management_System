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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.VisualBasic.ApplicationServices;

namespace Service_Management_System.DASHBOARD
{
    public partial class UserSecurityForm : Form
    {
        bool sidebarExpand;
        bool sidebarExpandbtnEdit;
        private string userRole;
        bool upper;

        public UserSecurityForm()
        {
            InitializeComponent();
            LoadEmployeesView();
            LoadMechanicsView();
            EPasswordValue.PasswordChar = '*'; // Hide password characters
            ECPasswordValue.PasswordChar = '*';// Hide password characters

            this.btnMechanic.Click += new System.EventHandler(this.button10_Click);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadEmployeesView()
        {
            string query = "SELECT * FROM Employees";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Check if the "Password" column exists and remove it
                    if (dataTable.Columns.Contains("Password"))
                    {
                        dataTable.Columns.Remove("Password");
                    }

                    EmployeeView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadMechanicsView()
        {
            // Update query to select only FirstName and LastName from the Mechanics table
            string query = "SELECT FirstName, LastName FROM Mechanics";

            using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Set the DataSource of EmployeeView to the DataTable
                    mechanicsView.DataSource = dataTable;
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
            sidebar_EditUserInfo.Visible = false;
            sidebar_AddUser.Visible = true;
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
                sidebar_AddUser.Width -= 50;
                if (sidebar_AddUser.Width == sidebar_AddUser.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar_AddUser.Width += 50;
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
            try
            {

                if (string.IsNullOrEmpty(userRole))
                {
                    MessageBox.Show("Please choose a role");
                    return;
                }
                if (userRole == "Cashier")
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
                    // Example: Insert user data into a database
                    OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2);
                    string query = "INSERT INTO Employees (Firstname, LastName, Email, [Password]) " +
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
                        LoadEmployeesView();
                        // Close the registration form
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to register user. Please try again.");
                    }
                }
                else if (userRole == "Mechanic")
                {
                    // Retrieve values from input fields
                    string firstName = EFirstNameValue.Text;
                    string lastName = ELastNameValue.Text;

                    // Validate inputs (optional)
                    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                    {
                        MessageBox.Show("Please fill in all required fields.");
                        return;
                    }
                    OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2);
                    string query = "INSERT INTO Mechanics (Firstname, LastName) " +
                                   "VALUES (@FirstName, @LastName)";

                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);


                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User registered successfully.");
                        // Optionally, clear input fields or reset form state
                        EFirstNameValue.Text = "";
                        ELastNameValue.Text = "";
                        LoadMechanicsView();
                        // Close the registration form
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to register user. Please try again.");
                    }
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
                sidebar_EditUserInfo.Width -= 50;
                if (sidebar_EditUserInfo.Width == sidebar_EditUserInfo.MinimumSize.Width)
                {
                    sidebarExpandbtnEdit = false;
                    sidebarTimerbtnEdit.Stop();
                }
            }
            else
            {
                sidebar_EditUserInfo.Width += 50;
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
            sidebar_AddUser.Visible = false;
            sidebar_EditUserInfo.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbEmail.Text))
            {
                if (mechanicsView.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = mechanicsView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = mechanicsView.Rows[selectedRowIndex];

                    // Assuming you have input fields to update these values
                    string newFirstName = txbFname.Text;
                    string newLastName = txbLname.Text;

                    // Get the original values for comparison or to use in the query
                    string originalFirstName = selectedRow.Cells["FirstName"].Value.ToString();
                    string originalLastName = selectedRow.Cells["LastName"].Value.ToString();

                    using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                    {
                        string query = "UPDATE Mechanics SET FirstName = @NewFirstName, LastName = @NewLastName " +
                                       "WHERE FirstName = @OriginalFirstName AND LastName = @OriginalLastName";

                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@NewFirstName", newFirstName);
                        command.Parameters.AddWithValue("@NewLastName", newLastName);
                        command.Parameters.AddWithValue("@OriginalFirstName", originalFirstName);
                        command.Parameters.AddWithValue("@OriginalLastName", originalLastName);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record updated successfully.");
                                LoadMechanicsView(); // Refresh the DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Record update failed.");
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
                    MessageBox.Show("Please select a cell to update.");
                }
            }
            else
            {
                // Check if a row is selected
                if (EmployeeView.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = EmployeeView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = EmployeeView.Rows[selectedRowIndex];
                    int id = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value); // Assuming "EmployeeID" is the primary key column

                    // Retrieve updated values from the textboxes
                    string firstName = txbFname.Text;
                    string lastName = txbLname.Text;
                    string email = txbEmail.Text;

                    // Validate inputs
                    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))
                    {
                        MessageBox.Show("Please fill in all required fields.");
                        return;
                    }

                    // Construct the SQL update query
                    string query = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE EmployeeID = @ID";

                    using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                    {
                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@ID", id);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record updated successfully.");
                                txbFname.Text = "";
                                txbLname.Text = "";
                                txbEmail.Text = "";
                                LoadEmployeesView(); // Refresh the DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Failed to update record. Please try again.");
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
                    MessageBox.Show("Please select a row to update.");
                }
            }
        }



        private void rdbmechanic1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EEmailValue.Enabled = false;
            EPasswordValue.Enabled = false;
            ECPasswordValue.Enabled = false;
            EEmailValue.BackColor = Color.LightGray;
            EPasswordValue.BackColor = Color.LightGray;
            ECPasswordValue.BackColor = Color.LightGray;
            EEmailValue.Text = "";
            EPasswordValue.Text = "";
            ECPasswordValue.Text = "";
            userRole = "Mechanic";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Enable the EEmailValue textbox
            EEmailValue.Enabled = true;
            EPasswordValue.Enabled = true;
            ECPasswordValue.Enabled = true;

            // Change the background color to the specified RGB value
            EEmailValue.BackColor = Color.FromArgb(3, 83, 115);
            EPasswordValue.BackColor = Color.FromArgb(3, 83, 115);
            ECPasswordValue.BackColor = Color.FromArgb(3, 83, 115);
            userRole = "Cashier";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            LoadEmployeesView();
            LoadMechanicsView();
            EPasswordValue.PasswordChar = '*'; // Hide password characters
            ECPasswordValue.PasswordChar = '*';// Hide password characters

            this.btnMechanic.Click += new System.EventHandler(this.button10_Click);
        }

        private void EmployeeView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = EmployeeView.Rows[e.RowIndex];

                // Set the values from the selected row to the text boxes
                txbFname.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txbLname.Text = selectedRow.Cells["LastName"].Value.ToString();
                txbEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txbEmail.BackColor = Color.FromArgb(3, 83, 115);
                txbEmail.ForeColor = Color.White;
            }
        }

        private void btnCancelAddUsers_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnCancelEditUsers_Click(object sender, EventArgs e)
        {
            sidebarTimerbtnEdit.Start();
        }

        private void mechanicsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = EmployeeView.Rows[e.RowIndex];

                // Set the values from the selected row to the text boxes
                txbFname.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txbLname.Text = selectedRow.Cells["LastName"].Value.ToString();
                txbEmail.Enabled = false;
                txbEmail.Text = "";
                txbEmail.BackColor = Color.LightGray;
            }
        }

        private void resetPas_Tick(object sender, EventArgs e)
        {
            if (upper)
            {
                panelUpper.Height -= 50;
                if (panelUpper.Height == panelUpper.MinimumSize.Height)
                {
                    upper = false;
                    resetPas.Stop();
                }
            }
            else
            {
                panelUpper.Height += 50;
                if (panelUpper.Height == panelUpper.MaximumSize.Height)
                {
                    upper = true;
                    resetPas.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            resetPas.Start();
        }
        private string HashPassword1(string password)
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
        private string DecryptPassword(string encryptedPassword)
        {
            // Implement your decryption logic here. Example using AES (replace with your logic).
            using (Aes aes = Aes.Create())
            {
                byte[] key = Encoding.UTF8.GetBytes("your-encryption-key"); // Adjust key and IV accordingly
                byte[] iv = Encoding.UTF8.GetBytes("your-encryption-iv");

                aes.Key = key;
                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(encryptedPassword)))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cs))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeView.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = EmployeeView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = EmployeeView.Rows[selectedRowIndex];
                    int id = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value); // Assuming "EmployeeID" is the primary key column

                    // Retrieve the encrypted password from the selected row
                    string encryptedPassword = selectedRow.Cells["Password"].Value.ToString();
                    string decryptedPassword = DecryptPassword(encryptedPassword);

                    // Validate the current password
                    if (txboldPass.Text != decryptedPassword)
                    {
                        MessageBox.Show("The current password is incorrect.");
                        return;
                    }

                    // Validate that the new password and confirm password match
                    if (txbnewPass.Text != txbconPass.Text)
                    {
                        MessageBox.Show("The new password and confirm password do not match.");
                        return;
                    }

                    // Hash the new password
                    string hashedNewPassword = HashPassword1(txbnewPass.Text);

                    // Update the password in the database
                    using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
                    {
                        string query = "UPDATE Employees SET [Password] = @Password WHERE EmployeeID = @ID";

                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@Password", hashedNewPassword);
                        command.Parameters.AddWithValue("@ID", id);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.");
                            txboldPass.Text = "";
                            txbnewPass.Text = "";
                            txbconPass.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to update password. Please try again.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void sidebar_EditUserInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
