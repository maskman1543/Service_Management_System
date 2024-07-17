namespace Service_Management_System.POS
{
    partial class AfterPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfterPayment));
            panel1 = new Panel();
            btnExGF = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            btnPrintrcp = new Button();
            btnsvPDF = new Button();
            btnaddNts = new Button();
            btnsndEmail = new Button();
            btnPrintinv = new Button();
            btnDone = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExGF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 67, 89);
            panel1.Controls.Add(btnExGF);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-3, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1469, 69);
            panel1.TabIndex = 0;
            // 
            // btnExGF
            // 
            btnExGF.BackgroundImage = (Image)resources.GetObject("btnExGF.BackgroundImage");
            btnExGF.BackgroundImageLayout = ImageLayout.Stretch;
            btnExGF.Location = new Point(1425, 16);
            btnExGF.Name = "btnExGF";
            btnExGF.Size = new Size(28, 25);
            btnExGF.TabIndex = 10;
            btnExGF.TabStop = false;
            btnExGF.Click += btnExGF_Click;
            btnExGF.MouseEnter += btnExGF_MouseEnter;
            btnExGF.MouseLeave += btnExGF_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(59, 28);
            label1.TabIndex = 5;
            label1.Text = "Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(353, 13);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 4;
            label2.Text = "Actions";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(323, 431);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(0, 491);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 200);
            panel2.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(11, 67, 89);
            label7.Location = new Point(2, 155);
            label7.Name = "label7";
            label7.Size = new Size(52, 23);
            label7.TabIndex = 14;
            label7.Text = "Cash:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(11, 67, 89);
            label6.Location = new Point(3, 99);
            label6.Name = "label6";
            label6.Size = new Size(54, 23);
            label6.TabIndex = 13;
            label6.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(11, 67, 89);
            label5.Location = new Point(0, 49);
            label5.Name = "label5";
            label5.Size = new Size(42, 23);
            label5.TabIndex = 12;
            label5.Text = "Tax:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(11, 67, 89);
            label4.Location = new Point(2, 13);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 11;
            label4.Text = "Subtotal:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DimGray;
            panel5.Location = new Point(0, 142);
            panel5.Name = "panel5";
            panel5.Size = new Size(324, 10);
            panel5.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Location = new Point(0, 86);
            panel4.Name = "panel4";
            panel4.Size = new Size(324, 10);
            panel4.TabIndex = 4;
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // btnPrintrcp
            // 
            btnPrintrcp.BackgroundImage = (Image)resources.GetObject("btnPrintrcp.BackgroundImage");
            btnPrintrcp.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrintrcp.FlatAppearance.BorderSize = 0;
            btnPrintrcp.FlatStyle = FlatStyle.Flat;
            btnPrintrcp.Location = new Point(329, 201);
            btnPrintrcp.Name = "btnPrintrcp";
            btnPrintrcp.Size = new Size(362, 98);
            btnPrintrcp.TabIndex = 3;
            btnPrintrcp.UseVisualStyleBackColor = true;
            btnPrintrcp.MouseEnter += btnPrintrcp_MouseEnter;
            btnPrintrcp.MouseLeave += btnPrintrcp_MouseLeave;
            // 
            // btnsvPDF
            // 
            btnsvPDF.BackgroundImage = (Image)resources.GetObject("btnsvPDF.BackgroundImage");
            btnsvPDF.BackgroundImageLayout = ImageLayout.Stretch;
            btnsvPDF.FlatAppearance.BorderSize = 0;
            btnsvPDF.FlatStyle = FlatStyle.Flat;
            btnsvPDF.Location = new Point(329, 320);
            btnsvPDF.Name = "btnsvPDF";
            btnsvPDF.Size = new Size(362, 98);
            btnsvPDF.TabIndex = 4;
            btnsvPDF.UseVisualStyleBackColor = true;
            btnsvPDF.MouseEnter += btnsvPDF_MouseEnter;
            btnsvPDF.MouseLeave += btnsvPDF_MouseLeave;
            // 
            // btnaddNts
            // 
            btnaddNts.BackgroundImage = (Image)resources.GetObject("btnaddNts.BackgroundImage");
            btnaddNts.BackgroundImageLayout = ImageLayout.Stretch;
            btnaddNts.FlatAppearance.BorderSize = 0;
            btnaddNts.FlatStyle = FlatStyle.Flat;
            btnaddNts.Location = new Point(709, 320);
            btnaddNts.Name = "btnaddNts";
            btnaddNts.Size = new Size(362, 98);
            btnaddNts.TabIndex = 5;
            btnaddNts.UseVisualStyleBackColor = true;
            btnaddNts.Click += btnaddNts_Click;
            btnaddNts.MouseEnter += btnaddNts_MouseEnter;
            btnaddNts.MouseLeave += btnaddNts_MouseLeave;
            // 
            // btnsndEmail
            // 
            btnsndEmail.BackgroundImage = (Image)resources.GetObject("btnsndEmail.BackgroundImage");
            btnsndEmail.BackgroundImageLayout = ImageLayout.Stretch;
            btnsndEmail.FlatAppearance.BorderSize = 0;
            btnsndEmail.FlatStyle = FlatStyle.Flat;
            btnsndEmail.Location = new Point(1088, 201);
            btnsndEmail.Name = "btnsndEmail";
            btnsndEmail.Size = new Size(362, 98);
            btnsndEmail.TabIndex = 6;
            btnsndEmail.UseVisualStyleBackColor = true;
            btnsndEmail.MouseEnter += btnsndEmail_MouseEnter;
            btnsndEmail.MouseLeave += btnsndEmail_MouseLeave;
            // 
            // btnPrintinv
            // 
            btnPrintinv.BackgroundImage = (Image)resources.GetObject("btnPrintinv.BackgroundImage");
            btnPrintinv.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrintinv.FlatAppearance.BorderSize = 0;
            btnPrintinv.FlatStyle = FlatStyle.Flat;
            btnPrintinv.Location = new Point(709, 201);
            btnPrintinv.Name = "btnPrintinv";
            btnPrintinv.Size = new Size(362, 98);
            btnPrintinv.TabIndex = 7;
            btnPrintinv.UseVisualStyleBackColor = true;
            btnPrintinv.MouseEnter += btnPrintinv_MouseEnter;
            btnPrintinv.MouseLeave += btnPrintinv_MouseLeave;
            // 
            // btnDone
            // 
            btnDone.BackgroundImage = (Image)resources.GetObject("btnDone.BackgroundImage");
            btnDone.BackgroundImageLayout = ImageLayout.Stretch;
            btnDone.FlatAppearance.BorderSize = 0;
            btnDone.FlatStyle = FlatStyle.Flat;
            btnDone.Location = new Point(1292, 614);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(158, 55);
            btnDone.TabIndex = 8;
            btnDone.UseVisualStyleBackColor = true;
            btnDone.MouseEnter += btnDone_MouseEnter;
            btnDone.MouseLeave += btnDone_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(798, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 46);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(11, 67, 89);
            label3.Location = new Point(857, 94);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 6;
            label3.Text = "Change:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(11, 67, 89);
            linkLabel1.Location = new Point(939, 99);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(45, 23);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "0.00";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Location = new Point(-2, 491);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 10);
            panel3.TabIndex = 3;
            // 
            // AfterPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1462, 690);
            Controls.Add(panel3);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnDone);
            Controls.Add(btnPrintinv);
            Controls.Add(btnsndEmail);
            Controls.Add(btnaddNts);
            Controls.Add(btnsvPDF);
            Controls.Add(btnPrintrcp);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AfterPayment";
            Text = "AfterPayment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExGF).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private Label label1;
        private Label label2;
        private Button btnPrintrcp;
        private Button btnsvPDF;
        private Button btnaddNts;
        private Button btnsndEmail;
        private Button btnPrintinv;
        private Button btnDone;
        private PictureBox pictureBox1;
        private Label label3;
        private LinkLabel linkLabel1;
        private PictureBox btnExGF;
        private Panel panel4;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel5;
    }
}