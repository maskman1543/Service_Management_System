namespace Service_Management_System.POS
{
    partial class AccessRequest
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
            components = new System.ComponentModel.Container();
            lblPassword = new Label();
            tbxPassword = new TextBox();
            btnEnter = new Button();
            btnCancel = new Button();
            label2 = new Label();
            guna2Elipse_AccessRequest = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_btnEnter = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_btnCancel = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(120, 117);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 28);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = Color.FromArgb(3, 83, 115);
            tbxPassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbxPassword.ForeColor = Color.White;
            tbxPassword.Location = new Point(120, 163);
            tbxPassword.Multiline = true;
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '•';
            tbxPassword.Size = new Size(309, 49);
            tbxPassword.TabIndex = 1;
            tbxPassword.TextChanged += textBox1_TextChanged;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.FromArgb(0, 192, 0);
            btnEnter.FlatAppearance.BorderSize = 0;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(131, 236);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(132, 41);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(290, 236);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 41);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(141, 43);
            label2.Name = "label2";
            label2.Size = new Size(260, 46);
            label2.TabIndex = 4;
            label2.Text = "Access Request";
            // 
            // guna2Elipse_AccessRequest
            // 
            guna2Elipse_AccessRequest.BorderRadius = 25;
            guna2Elipse_AccessRequest.TargetControl = this;
            // 
            // guna2Elipse_btnEnter
            // 
            guna2Elipse_btnEnter.BorderRadius = 10;
            guna2Elipse_btnEnter.TargetControl = btnEnter;
            // 
            // guna2Elipse_btnCancel
            // 
            guna2Elipse_btnCancel.BorderRadius = 10;
            guna2Elipse_btnCancel.TargetControl = btnCancel;
            // 
            // AccessRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 83, 115);
            ClientSize = new Size(543, 366);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnEnter);
            Controls.Add(tbxPassword);
            Controls.Add(lblPassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccessRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccessRequest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private TextBox tbxPassword;
        private Button btnEnter;
        private Button btnCancel;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_AccessRequest;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_btnEnter;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_btnCancel;
    }
}