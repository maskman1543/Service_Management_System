namespace Service_Management_System.DASHBOARD
{
    partial class CompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyForm));
            panel8 = new Panel();
            pictureBox9 = new PictureBox();
            label19 = new Label();
            PrintBtn = new Button();
            dataGridView1 = new DataGridView();
            SearchBtn = new Button();
            EmployeeID = new TextBox();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(3, 83, 115);
            panel8.Controls.Add(pictureBox9);
            panel8.Controls.Add(label19);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(4, 2, 4, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(900, 132);
            panel8.TabIndex = 20;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(25, 2);
            pictureBox9.Margin = new Padding(4, 2, 4, 2);
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
            label19.Location = new Point(84, 9);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(195, 28);
            label19.TabIndex = 2;
            label19.Text = "Employee Attendance";
            // 
            // PrintBtn
            // 
            PrintBtn.AutoSize = true;
            PrintBtn.BackColor = Color.FromArgb(3, 83, 115);
            PrintBtn.BackgroundImageLayout = ImageLayout.Stretch;
            PrintBtn.FlatAppearance.BorderSize = 0;
            PrintBtn.FlatStyle = FlatStyle.Flat;
            PrintBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PrintBtn.ForeColor = Color.White;
            PrintBtn.ImageAlign = ContentAlignment.MiddleLeft;
            PrintBtn.Location = new Point(458, 147);
            PrintBtn.Margin = new Padding(2);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Padding = new Padding(35, 0, 35, 0);
            PrintBtn.Size = new Size(126, 36);
            PrintBtn.TabIndex = 27;
            PrintBtn.Text = "Print";
            PrintBtn.TextAlign = ContentAlignment.MiddleRight;
            PrintBtn.UseVisualStyleBackColor = false;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 214);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(852, 689);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            SearchBtn.Location = new Point(302, 147);
            SearchBtn.Margin = new Padding(2);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Padding = new Padding(35, 0, 35, 0);
            SearchBtn.Size = new Size(139, 36);
            SearchBtn.TabIndex = 25;
            SearchBtn.Text = "Search";
            SearchBtn.TextAlign = ContentAlignment.MiddleRight;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // EmployeeID
            // 
            EmployeeID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeID.ForeColor = Color.Gray;
            EmployeeID.Location = new Point(24, 147);
            EmployeeID.Margin = new Padding(2);
            EmployeeID.Multiline = true;
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Size = new Size(260, 35);
            EmployeeID.TabIndex = 24;
            EmployeeID.Text = "Employee ID";
            EmployeeID.TextChanged += EmployeeID_TextChanged;
            // 
            // CompanyForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(900, 970);
            Controls.Add(PrintBtn);
            Controls.Add(dataGridView1);
            Controls.Add(SearchBtn);
            Controls.Add(EmployeeID);
            Controls.Add(panel8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CompanyForm";
            Text = "CompanyForm";
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel8;
        private PictureBox pictureBox9;
        private Label label19;
        private Button PrintBtn;
        private DataGridView dataGridView1;
        private Button SearchBtn;
        private TextBox EmployeeID;
    }
}