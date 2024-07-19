namespace Service_Management_System.DASHBOARD
{
    partial class UserSecurityForm
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
            label1 = new Label();
            EmployeeView = new DataGridView();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)EmployeeView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 0;
            label1.Text = "User and Security";
            label1.Click += label1_Click;
            // 
            // EmployeeView
            // 
            EmployeeView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeView.Location = new Point(15, 150);
            EmployeeView.Margin = new Padding(4, 4, 4, 4);
            EmployeeView.Name = "EmployeeView";
            EmployeeView.RowHeadersWidth = 51;
            EmployeeView.RowTemplate.Height = 25;
            EmployeeView.Size = new Size(870, 756);
            EmployeeView.TabIndex = 1;
            EmployeeView.CellContentClick += EmployeeView_CellContentClick;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.ForeColor = Color.Gray;
            textBox7.Location = new Point(15, 96);
            textBox7.Margin = new Padding(2);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(520, 46);
            textBox7.TabIndex = 11;
            textBox7.Text = "Search";
            // 
            // UserSecurityForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(900, 970);
            Controls.Add(textBox7);
            Controls.Add(EmployeeView);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "UserSecurityForm";
            Text = "UserSecurityForm";
            ((System.ComponentModel.ISupportInitialize)EmployeeView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView EmployeeView;
        private TextBox textBox7;
    }
}