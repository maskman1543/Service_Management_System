namespace Service_Management_System.DASHBOARD
{
    partial class Payroll_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payroll_Form));
            panel8 = new Panel();
            pictureBox9 = new PictureBox();
            label19 = new Label();
            dataGridView1 = new DataGridView();
            panel9 = new Panel();
            label20 = new Label();
            panel10 = new Panel();
            SearchBtn = new Button();
            SearchEmpIDTextBox = new TextBox();
            panel11 = new Panel();
            panel12 = new Panel();
            CalSal = new Button();
            SaveBtn = new Button();
            EmpID = new TextBox();
            NetSalary = new TextBox();
            SSS = new TextBox();
            PagIbig = new TextBox();
            SalaryTxb = new TextBox();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(3, 83, 115);
            panel8.Controls.Add(pictureBox9);
            panel8.Controls.Add(label19);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(960, 106);
            panel8.TabIndex = 18;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(20, 2);
            pictureBox9.Margin = new Padding(3, 2, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(40, 40);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 3;
            pictureBox9.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(67, 7);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(53, 21);
            label19.TabIndex = 2;
            label19.Text = "Payroll";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 421);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(929, 249);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(90, 126, 140);
            panel9.Controls.Add(label20);
            panel9.Location = new Point(15, 365);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(929, 52);
            panel9.TabIndex = 20;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(346, 7);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(229, 25);
            label20.TabIndex = 1;
            label20.Text = "EMPLOYEE PAYROLL";
            // 
            // panel10
            // 
            panel10.Controls.Add(SearchBtn);
            panel10.Controls.Add(SearchEmpIDTextBox);
            panel10.Location = new Point(371, 252);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(573, 109);
            panel10.TabIndex = 21;
            panel10.Paint += panel10_Paint;
            // 
            // SearchBtn
            // 
            SearchBtn.AutoSize = true;
            SearchBtn.BackColor = Color.FromArgb(3, 83, 115);
            SearchBtn.BackgroundImageLayout = ImageLayout.Stretch;
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SearchBtn.Location = new Point(247, 9);
            SearchBtn.Margin = new Padding(2);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Padding = new Padding(28, 0, 28, 0);
            SearchBtn.Size = new Size(111, 40);
            SearchBtn.TabIndex = 18;
            SearchBtn.Text = "Search";
            SearchBtn.TextAlign = ContentAlignment.MiddleRight;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchEmpIDTextBox
            // 
            SearchEmpIDTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchEmpIDTextBox.ForeColor = Color.Gray;
            SearchEmpIDTextBox.Location = new Point(23, 14);
            SearchEmpIDTextBox.Margin = new Padding(2);
            SearchEmpIDTextBox.Multiline = true;
            SearchEmpIDTextBox.Name = "SearchEmpIDTextBox";
            SearchEmpIDTextBox.Size = new Size(209, 29);
            SearchEmpIDTextBox.TabIndex = 15;
            SearchEmpIDTextBox.Text = "Employee ID";
            // 
            // panel11
            // 
            panel11.Location = new Point(371, 118);
            panel11.Margin = new Padding(3, 2, 3, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(573, 135);
            panel11.TabIndex = 22;
            // 
            // panel12
            // 
            panel12.Controls.Add(CalSal);
            panel12.Controls.Add(SaveBtn);
            panel12.Controls.Add(EmpID);
            panel12.Controls.Add(NetSalary);
            panel12.Controls.Add(SSS);
            panel12.Controls.Add(PagIbig);
            panel12.Controls.Add(SalaryTxb);
            panel12.Location = new Point(15, 118);
            panel12.Margin = new Padding(3, 2, 3, 2);
            panel12.Name = "panel12";
            panel12.Size = new Size(356, 243);
            panel12.TabIndex = 22;
            // 
            // CalSal
            // 
            CalSal.AutoSize = true;
            CalSal.BackColor = Color.FromArgb(3, 83, 115);
            CalSal.BackgroundImageLayout = ImageLayout.Stretch;
            CalSal.FlatAppearance.BorderSize = 0;
            CalSal.FlatStyle = FlatStyle.Flat;
            CalSal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CalSal.ForeColor = Color.White;
            CalSal.ImageAlign = ContentAlignment.MiddleLeft;
            CalSal.Location = new Point(233, 115);
            CalSal.Margin = new Padding(2);
            CalSal.Name = "CalSal";
            CalSal.Padding = new Padding(28, 0, 28, 0);
            CalSal.Size = new Size(123, 49);
            CalSal.TabIndex = 17;
            CalSal.Text = "Calculate";
            CalSal.TextAlign = ContentAlignment.MiddleRight;
            CalSal.UseVisualStyleBackColor = false;
            CalSal.Click += CalSal_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.AutoSize = true;
            SaveBtn.BackColor = Color.FromArgb(3, 83, 115);
            SaveBtn.BackgroundImageLayout = ImageLayout.Stretch;
            SaveBtn.FlatAppearance.BorderSize = 0;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SaveBtn.Location = new Point(245, 18);
            SaveBtn.Margin = new Padding(2);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Padding = new Padding(28, 0, 28, 0);
            SaveBtn.Size = new Size(104, 40);
            SaveBtn.TabIndex = 16;
            SaveBtn.Text = "SAVE";
            SaveBtn.TextAlign = ContentAlignment.MiddleRight;
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // EmpID
            // 
            EmpID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmpID.ForeColor = Color.Gray;
            EmpID.Location = new Point(21, 2);
            EmpID.Margin = new Padding(2);
            EmpID.Multiline = true;
            EmpID.Name = "EmpID";
            EmpID.Size = new Size(209, 29);
            EmpID.TabIndex = 14;
            EmpID.Text = "Employee ID";
            EmpID.TextChanged += EmpID_TextChanged;
            // 
            // NetSalary
            // 
            NetSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NetSalary.ForeColor = Color.Gray;
            NetSalary.Location = new Point(21, 196);
            NetSalary.Margin = new Padding(2);
            NetSalary.Multiline = true;
            NetSalary.Name = "NetSalary";
            NetSalary.Size = new Size(209, 29);
            NetSalary.TabIndex = 15;
            NetSalary.Text = "Net Salary";
            NetSalary.TextChanged += NetSalary_TextChanged;
            // 
            // SSS
            // 
            SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SSS.ForeColor = Color.Gray;
            SSS.Location = new Point(21, 148);
            SSS.Margin = new Padding(2);
            SSS.Multiline = true;
            SSS.Name = "SSS";
            SSS.Size = new Size(209, 29);
            SSS.TabIndex = 13;
            SSS.Text = "SSS";
            SSS.TextChanged += SSS_TextChanged;
            // 
            // PagIbig
            // 
            PagIbig.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PagIbig.ForeColor = Color.Gray;
            PagIbig.Location = new Point(21, 97);
            PagIbig.Margin = new Padding(2);
            PagIbig.Multiline = true;
            PagIbig.Name = "PagIbig";
            PagIbig.Size = new Size(209, 29);
            PagIbig.TabIndex = 12;
            PagIbig.Text = "Pag-Ibig";
            PagIbig.TextChanged += PagIbig_TextChanged;
            // 
            // SalaryTxb
            // 
            SalaryTxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SalaryTxb.ForeColor = Color.Gray;
            SalaryTxb.Location = new Point(21, 48);
            SalaryTxb.Margin = new Padding(2);
            SalaryTxb.Multiline = true;
            SalaryTxb.Name = "SalaryTxb";
            SalaryTxb.Size = new Size(209, 29);
            SalaryTxb.TabIndex = 11;
            SalaryTxb.Text = "DaysPresent";
            SalaryTxb.TextChanged += SalaryTxb_TextChanged;
            // 
            // Payroll_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(960, 680);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(dataGridView1);
            Controls.Add(panel8);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Payroll_Form";
            Text = "Payroll_Form";
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel8;
        private Label label19;
        private PictureBox pictureBox9;
        private DataGridView dataGridView1;
        private Panel panel9;
        private Label label20;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private TextBox PagIbig;
        private TextBox SalaryTxb;
        private TextBox EmpID;
        private TextBox SSS;
        private TextBox NetSalary;
        private Button SaveBtn;
        private Button CalSal;
        private Button SearchBtn;
        private TextBox SearchEmpIDTextBox;
    }
}