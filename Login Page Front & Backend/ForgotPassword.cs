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
using Service_Management_System.POS.Login_Page_Front___Backend;

namespace Service_Management_System.Login_Page_Front___Backend
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text.Trim();
            string newPassword = tbxNewPass.Text.Trim();
            string confirmPassword = tbxConfirmPass.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter email, new password, and confirm password.");
                return;
            }

            // Check if new password and confirm password match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.");
                return;
            }

            // Hash the new password
            string hashedPassword = HashPassword(newPassword);

            try
            {
                bool isPasswordReset = ResetUserPassword(email, hashedPassword) || ResetEmployeePassword(email, hashedPassword);

                if (isPasswordReset)
                {
                    MessageBox.Show("Password reset successful!");
                }
                else
                {
                    MessageBox.Show("Email not found in both Users and Employees tables. Please check and try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private bool ResetUserPassword(string email, string hashedPassword)
        {
            // Construct the UPDATE query to reset the password in Users table
            string query = "UPDATE Users SET [Password] = @Password WHERE Email = @Email";
            return ExecutePasswordUpdateQuery(email, hashedPassword, query, Class1.GlobalVariables.ConnectionString);
        }

        private bool ResetEmployeePassword(string email, string hashedPassword)
        {
            // Construct the UPDATE query to reset the password in Employees table
            string query = "UPDATE Employees SET [Password] = @Password WHERE Email = @Email";
            return ExecutePasswordUpdateQuery(email, hashedPassword, query, Class1.GlobalVariables.ConnectionString2);
        }

        private bool ExecutePasswordUpdateQuery(string email, string hashedPassword, string query, string connectionString)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    // Add parameters for Email and hashed password
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@Email", email);

                    // Open the connection
                    connection.Open();

                    // Execute the query to update the password
                    int rowsAffected = command.ExecuteNonQuery();

                    // Close the connection
                    connection.Close();

                    // Return true if the password was successfully updated
                    return rowsAffected > 0;
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



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkblSignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
