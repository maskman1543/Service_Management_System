using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Management_System.POS
{
    public partial class AfterPayment : Form
    {
        public AfterPayment()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnPrintrcp_MouseEnter(object sender, EventArgs e)
        {
            btnPrintrcp.Width = 366;
            btnPrintrcp.Height = 102;

        }

        private void btnPrintrcp_MouseLeave(object sender, EventArgs e)
        {
            btnPrintrcp.Width = 362;
            btnPrintrcp.Height = 98;
            //362, 98
        }

        private void btnPrintinv_MouseEnter(object sender, EventArgs e)
        {
            btnPrintinv.Width = 366;
            btnPrintinv.Height = 102;

        }

        private void btnPrintinv_MouseLeave(object sender, EventArgs e)
        {
            btnPrintinv.Width = 362;
            btnPrintinv.Height = 98;

        }

        private void btnsndEmail_MouseEnter(object sender, EventArgs e)
        {
            btnsndEmail.Width = 366;
            btnsndEmail.Height = 102;

        }

        private void btnsndEmail_MouseLeave(object sender, EventArgs e)
        {
            btnsndEmail.Width = 362;
            btnsndEmail.Height = 98;

        }

        private void btnsvPDF_MouseEnter(object sender, EventArgs e)
        {
            btnsvPDF.Width = 366;
            btnsvPDF.Height = 102;

        }


        private void btnsvPDF_MouseLeave(object sender, EventArgs e)
        {
            btnsvPDF.Width = 362;
            btnsvPDF.Height = 98;

        }

        private void btnaddNts_MouseEnter(object sender, EventArgs e)
        {
            btnaddNts.Width = 366;
            btnaddNts.Height = 102;

        }

        private void btnaddNts_MouseLeave(object sender, EventArgs e)
        {
            btnaddNts.Width = 362;
            btnaddNts.Height = 98;

        }

        private void btnDone_MouseEnter(object sender, EventArgs e)
        {
            btnDone.Width = 162;
            btnDone.Height = 59;

        }

        private void btnDone_MouseLeave(object sender, EventArgs e)
        {
            btnDone.Width = 158;
            btnDone.Height = 55;
            //158, 55 orrig
        }

        private void btnExGF_MouseEnter(object sender, EventArgs e)
        {
            btnExGF.Width = 32;
            btnExGF.Height = 29;

        }

        private void btnExGF_MouseLeave(object sender, EventArgs e)
        {
            btnExGF.Width = 28;
            btnExGF.Height = 25;
            //28, 25 orrig
        }

        private void btnExGF_Click(object sender, EventArgs e)
        {

            this.Close();//closes this form
            POSForm xbtn = new POSForm();
            xbtn.ShowDialog();


        }

        private void btnaddNts_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            POSForm pOSForm = new POSForm();
            pOSForm.Show();
            this.Close();
        }
    }
}
