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
using System.Security.Cryptography;
using System.Text;
using Service_Management_System.POS.Login_Page_Front_and_Back_End;



namespace Service_Management_System.Registration
{


    public partial class acctRegistration_form : Form
    {
        public acctRegistration_form()
        {
            InitializeComponent();
            passwordValue.PasswordChar = '*'; 
            confirmPasswordValue.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Splash mainForm = new Splash();
            mainForm.Show(); 
            this.Hide(); 
        }

        private void label12_Click(object sender, EventArgs e)
        {
            LoginForm mainForm = new LoginForm();
            mainForm.Show(); 
            this.Hide(); 
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
        private void button2_Click(object sender, EventArgs e)
        {
            
            string firstName = FirstNameValue.Text;
            string lastName = LastNameValue.Text;
            string email = EmailValue.Text;
            string phoneNumber = phoneNumberValue.Text;
            string password = passwordValue.Text;
            string confirmPassword = confirmPasswordValue.Text;

           
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

           
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please enter matching passwords.");
                return;
            }

            
            string hashedPassword = HashPassword(password);

           
            try
            {
                
                OleDbConnection connection = new OleDbConnection(Class1.GlobalVariables.ConnectionString);
                string query = "INSERT INTO Users (FirstName, LastName, Email, PhoneNumber, [Password]) " +
                               "VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Password)";

                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@Password", hashedPassword);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User registered successfully.");
                    
                    FirstNameValue.Text = "";
                    LastNameValue.Text = "";
                    EmailValue.Text = "";
                    phoneNumberValue.Text = "";
                    passwordValue.Text = "";
                    confirmPasswordValue.Text = "";

                    
                    this.Close();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Failed to register user. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
         
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
        
            if (checkBox1.Checked)
            {
                passwordValue.PasswordChar = '\0'; 
                confirmPasswordValue.PasswordChar= '\0';
            }
            else
            {
                passwordValue.PasswordChar = '*'; 
                confirmPasswordValue.PasswordChar = '*';
            }
        }
    }
}
