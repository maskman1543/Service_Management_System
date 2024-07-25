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

            Splash BeginForm = new Splash();
            BeginForm.ShowDialog();

            Application.Run(); // Start the application message loop
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
