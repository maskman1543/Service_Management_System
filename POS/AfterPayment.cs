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
            btnPrintrcp.Width = 340;
            btnPrintrcp.Height = 112;
            //75, 67, orrig
        }

        private void btnPrintrcp_MouseLeave(object sender, EventArgs e)
        {
            btnPrintrcp.Width = 336;
            btnPrintrcp.Height = 108;
            //336, 108 orrig
        }

        private void btnPrintinv_MouseEnter(object sender, EventArgs e)
        {
            btnPrintinv.Width = 340;
            btnPrintinv.Height = 112;
            //75, 67, orrig
        }

        private void btnPrintinv_MouseLeave(object sender, EventArgs e)
        {
            btnPrintinv.Width = 336;
            btnPrintinv.Height = 108;
            //75, 67, orrig
        }

        private void btnsndEmail_MouseEnter(object sender, EventArgs e)
        {
            btnsndEmail.Width = 340;
            btnsndEmail.Height = 112;
            //75, 67, orrig
        }

        private void btnsndEmail_MouseLeave(object sender, EventArgs e)
        {
            btnsndEmail.Width = 336;
            btnsndEmail.Height = 108;
            //75, 67, orrig
        }

        private void btnsvPDF_MouseEnter(object sender, EventArgs e)
        {
            btnsvPDF.Width = 340;
            btnsvPDF.Height = 112;
            //75, 67, orrig
        }


        private void btnsvPDF_MouseLeave(object sender, EventArgs e)
        {
            btnsvPDF.Width = 336;
            btnsvPDF.Height = 108;
            //75, 67, orrig
        }

        private void btnaddNts_MouseEnter(object sender, EventArgs e)
        {
            btnaddNts.Width = 340;
            btnaddNts.Height = 112;
            //75, 67, orrig
        }

        private void btnaddNts_MouseLeave(object sender, EventArgs e)
        {
            btnaddNts.Width = 336;
            btnaddNts.Height = 108;
            //75, 67, orrig
        }

        private void btnDone_MouseEnter(object sender, EventArgs e)
        {
            btnDone.Width = 162;
            btnDone.Height = 59;
            //158, 55 orrig
        }

        private void btnDone_MouseLeave(object sender, EventArgs e)
        {
            btnDone.Width = 158;
            btnDone.Height = 55;

        }

        private void btnExGF_MouseEnter(object sender, EventArgs e)
        {
            btnExGF.Width = 32;
            btnExGF.Height = 29;
            //45, 23, orrig
        }

        private void btnExGF_MouseLeave(object sender, EventArgs e)
        {
            btnExGF.Width = 28;
            btnExGF.Height = 25;
            //28, 25 orrig
        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            linkLabel1.Width = 49;
            linkLabel1.Height = 27;

        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.Width = 45;
            linkLabel1.Height = 23;
            //45, 23 orrig
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            linkLabel1.Width = 49;
            linkLabel1.Height = 27;
        }
    }
}
