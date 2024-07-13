using System;
using System.Windows.Forms;

namespace Service_Management_System.POS.Login_Page_Front_and_Back_End
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Splash splashForm = new Splash();
            splashForm.Show(); // Show Splash form initially

            // Optionally, navigate to Splash after Form1 initialization
            // Form1 form1 = new Form1();
            // form1.Hide(); // Hide Form1 if navigating to Splash

            Application.Run(); // Start the application message loop
        }
    }
}
