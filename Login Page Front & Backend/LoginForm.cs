using Service_Management_System.Registration;
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
using Service_Management_System.Login_Page_Front___Backend;
using Service_Management_System.POS.Login_Page_Front___Backend;
using Service_Management_System.POS.Login_Page_Front_and_Back_End;


namespace Service_Management_System.POS.Login_Page_Front___Backend
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '•';
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            acctRegistration_form mainForm = new acctRegistration_form();
            mainForm.Show(); // Show the main form
            this.Hide();// Hide the splash screen
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

        private void button1_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text.Trim();
            string password = PasswordTextBox.Text;
            bool state = true;
            Class1.GlobalVariables.State = state;
            // Validate input
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            // Hash the entered password
            string hashedPassword = HashPassword(password);

            try
            {
                // Construct the SELECT query to fetch user details by Email and hashed Password
                string query = "SELECT * FROM Users WHERE Email = @Email AND [Password] = @Password";

                // Set up OleDb connection and command
                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
                {
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Add parameters for Email and hashed password
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", hashedPassword);

                        // Open the connection
                        connection.Open();

                        // Execute the query to check if the user exists
                        OleDbDataReader reader = command.ExecuteReader();

                        if (reader.Read()) // If user exists
                        {
                            // Successful login
                            MessageBox.Show("Login successful!");
                            // You can perform further actions here after successful login
                            POSForm posform = new POSForm();
                            posform.Show();
                            this.Close();
                        }
                        else // If no matching user found
                        {
                            MessageBox.Show("Invalid email or password. Please try again.");
                        }

                        // Close the reader and connection
                        reader.Close();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                // Handle specific error scenarios or log errors as needed
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordTextBox.PasswordChar = '\0'; // Show password characters
            }
            else
            {
                PasswordTextBox.PasswordChar = '•'; // Hide password characters
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lkblContinueAsEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeLoginForm mainForm = new EmployeeLoginForm();
            mainForm.Show();
            this.Close();//Close the current instance of the login form 
            //MessageBox.Show("LoginForm Closed");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
