using Service_Management_System.POS.Login_Page_Front___Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Service_Management_System.Properties.DASHBOARD;
using Service_Management_System.POS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Service_Management_System.Registration
{


    public partial class acctRegistration_form : Form
    {
        public acctRegistration_form()
        {
            InitializeComponent();
            passwordValue.PasswordChar = '*'; // Hide password characters
            confirmPasswordValue.PasswordChar = '*';// Hide password characters
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 mainForm = new Form2();
            mainForm.Show(); // Show the main form
            this.Hide(); // Hide the splash screen
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form2 mainForm = new Form2();
            mainForm.Show(); // Show the main form
            this.Hide(); // Hide the splash screen
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Retrieve values from input fields
            string firstName = FirstNameValue.Text;
            string lastName = LastNameValue.Text;
            string email = EmailValue.Text;
            string phoneNumber = phoneNumberValue.Text;
            string password = passwordValue.Text;
            string confirmPassword = confirmPasswordValue.Text;

            // Validate inputs (optional)
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
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

            // If validation passes, proceed with registration logic (example)
            try
            {
                // Example: Insert user data into a database
                OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString);
                string query = "INSERT INTO Users (Firstname, LastName, Email, PhoneNumber, [Password]) " +
                               "VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Password)";

                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User registered successfully.");
                    // Optionally, clear input fields or reset form state
                    FirstNameValue.Text = "";
                    LastNameValue.Text = "";
                    EmailValue.Text = "";
                    phoneNumberValue.Text = "";
                    passwordValue.Text = "";
                    confirmPasswordValue.Text = "";

                    POSForm mainForm = new POSForm(); // proceeds to POSForm
                    mainForm.Show();
                    this.Hide();// Hide the splash screen
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

        private void button3_Click(object sender, EventArgs e)
        {
            // Test connection string
            OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString);



            try
            {
                connection.Open();
                MessageBox.Show("Connection successful!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed. Error message: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            if (checkBox1.Checked)
            {
                passwordValue.PasswordChar = '\0'; // Show password characters
                confirmPasswordValue.PasswordChar= '\0';// Show password characters
            }
            else
            {
                passwordValue.PasswordChar = '*'; // Hide password characters
                confirmPasswordValue.PasswordChar = '*';// Hide password characters
            }
        }
    }
}
