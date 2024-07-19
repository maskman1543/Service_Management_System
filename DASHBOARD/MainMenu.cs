using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Service_Management_System.POS;

namespace Service_Management_System.DASHBOARD
{
    public partial class MainMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        bool sidebarExpand;

        public MainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(242, 242, 242);
            public static Color color2 = Color.FromArgb(242, 242, 242);
            public static Color color3 = Color.FromArgb(242, 242, 242);
            public static Color color4 = Color.FromArgb(242, 242, 242);
            public static Color color5 = Color.FromArgb(242, 242, 242);
            public static Color color6 = Color.FromArgb(242, 242, 242);
            public static Color color7 = Color.FromArgb(242, 242, 242);
        }
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(3, 83, 115);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void OpenchildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenchildForm(new DashboardForm());
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenchildForm(new DocumentsForm());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenchildForm(new ProductsServicesForm());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenchildForm(new StockForm());
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            OpenchildForm(new AnalyticsForm());
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            OpenchildForm(new UserSecurityForm());
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color7);
            OpenchildForm(new CompanyForm());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            POSForm pOSForm = new POSForm();
            pOSForm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sidebar_Timer(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelMenu.Width -= 10;
                if (panelMenu.Width == panelMenu.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                panelMenu.Width += 10;
                if (panelMenu.Width == panelMenu.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenchildForm(new Payroll_Form());
        }
    }
}
