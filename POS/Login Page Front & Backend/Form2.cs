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

namespace Service_Management_System.POS.Login_Page_Front___Backend
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            acctRegistration_form mainForm = new acctRegistration_form();
            mainForm.Show(); // Show the main form
            this.Hide();// Hide the splash screen
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text.Trim();
            string password = PasswordTextBox.Text;

            // Validate input
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            try
            {
                // Construct the SELECT query to fetch user details by Email
                string query = "SELECT * FROM Users WHERE Email = @Email AND [Password] = @Password";

                // Set up OleDb connection and command
                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString))
                {
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Add parameters for Email and password
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        // Open the connection
                        connection.Open();

                        // Execute the query to check if the user exists
                        OleDbDataReader reader = command.ExecuteReader();

                        if (reader.Read()) // If user exists
                        {
                            // Successful login
                            MessageBox.Show("Login successful!");
                            // You can perform further actions here after successful login
                            POSForm mainForm = new POSForm(); // proceeds to POSForm
                            mainForm.Show();
                            this.Hide();// Hide the splash screen
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
                PasswordTextBox.PasswordChar = '*'; // Hide password characters
            }
        }
    }
}
