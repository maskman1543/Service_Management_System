﻿using Service_Management_System.POS;
using Service_Management_System.DASHBOARD;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Service_Management_System.POS.Login_Page_Front___Backend;
using static Service_Management_System.POS.Login_Page_Front___Backend.LoginForm;

namespace Service_Management_System.Login_Page_Front___Backend
{
    public partial class EmployeeLoginForm : Form
    {
        public EmployeeLoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void panel_loginInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = EmployeeIDTextBox.Text.Trim();
            string password = PasswordTextBox.Text;
            bool state = false;
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
                string query = "SELECT * FROM Employees WHERE Email = @Email AND [Password] = @Password";

                // Set up OleDb connection and command
                using (OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString2))
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
                            // Fetch user details
                            string firstName = reader["FirstName"].ToString();
                            string lastName = reader["LastName"].ToString();
                            string userEmail = reader["Email"].ToString();
                            string position = reader["Position"].ToString();

                            // Get the employee ID
                            int employeeId = reader.GetInt32(reader.GetOrdinal("EmployeeID"));

                            // Close the reader
                            reader.Close();

                            // Get the current date
                            string dateString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                            // Insert the login time and date
                            string insertQuery = "INSERT INTO EmployeeAtt (EmployeeID, DateIn) VALUES (@EmployeeID, @DateIn)";
                            using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@EmployeeID", employeeId);
                                insertCommand.Parameters.AddWithValue("@DateIn", dateString);

                                // Execute the insert command
                                insertCommand.ExecuteNonQuery();
                            }

                            // Successful login
                            MessageBox.Show("Login successful!");
                            UserInfo.FirstName = firstName;
                            UserInfo.LastName = lastName;
                            UserInfo.Email = userEmail;
                            UserInfo.Position = position;

                            // You can perform further actions here after successful login
                            POSForm posform = new POSForm();
                            posform.Show();
                            this.Close();
                        }
                        else // If no matching user found
                        {
                            MessageBox.Show("Invalid email or password. Please try again.");
                        }

                        // Close the connection
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ForgotPassword().Show();
            this.Hide();
        }
    }
}