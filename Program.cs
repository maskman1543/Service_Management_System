using Service_Management_System.DASHBOARD;
using Service_Management_System.Properties.DASHBOARD;
using System;
using System.Windows.Forms;
//using Service_Management_System.POS.AfterPayment;

namespace Service_Management_System.POS.Login_Page_Front_and_Back_End
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //This splash below is the start of the Employee features and tabs.

            /*Splash splashForm = new Splash();
           splashForm.Show(); // Show Splash form initially*/

            //MainMenu mainMenu = new MainMenu();
           // mainMenu.Show();

            //MainMenu mainmenuForm = new MainMenu();
            //mainmenuForm.Show();
            POSForm pOSForm = new POSForm();   
            pOSForm.ShowDialog();


            //This form1 below here is the Dashboard
           
            //AfterPayment formCheck = new AfterPayment();
            //formCheck.Show(); //Showdialog();

            // Optionally, navigate to Splash after Form1 initialization
            // Form1 form1 = new Form1();
            // form1.Hide(); // Hide Form1 if navigating to Splash

            Application.Run(); // Start the application message loop
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
