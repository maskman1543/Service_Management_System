﻿using Service_Management_System.POS.Login_Page_Front___Backend;
using System;
using System.Windows.Forms; // Ensure this using directive is present for Windows Forms Timer

namespace Service_Management_System.POS.Login_Page_Front_and_Back_End
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();

            // Configure the timer
            timer.Interval = 5000; // 5 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); // Stop the timer to avoid it firing again
            LoginForm mainForm = new LoginForm();
            mainForm.Show(); // Show the main form
            this.Hide(); // Hide the splash screen
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
