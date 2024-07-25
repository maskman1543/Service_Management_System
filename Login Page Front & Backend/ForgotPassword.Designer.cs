namespace Service_Management_System.Login_Page_Front___Backend
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lnkblSignin = new LinkLabel();
            tbxConfirmPass = new TextBox();
            label4 = new Label();
            label3 = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            tbxEmail = new TextBox();
            cbxShowPassword = new CheckBox();
            label1 = new Label();
            tbxNewPass = new TextBox();
            label2 = new Label();
            btnResetPass = new Button();
            pictureBox2 = new PictureBox();
            guna2Elipse_ForgotPassword = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_panel1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_button1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(494, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 33);
            btnClose.TabIndex = 9;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 83, 115);
            panel1.Controls.Add(lnkblSignin);
            panel1.Controls.Add(tbxConfirmPass);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Controls.Add(tbxEmail);
            panel1.Controls.Add(cbxShowPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbxNewPass);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnResetPass);
            panel1.Location = new Point(41, 279);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 491);
            panel1.TabIndex = 11;
            // 
            // lnkblSignin
            // 
            lnkblSignin.AutoSize = true;
            lnkblSignin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lnkblSignin.LinkColor = Color.White;
            lnkblSignin.Location = new Point(179, 445);
            lnkblSignin.Name = "lnkblSignin";
            lnkblSignin.Size = new Size(67, 28);
            lnkblSignin.TabIndex = 26;
            lnkblSignin.TabStop = true;
            lnkblSignin.Text = "Signin";
            lnkblSignin.LinkClicked += lnkblSignin_LinkClicked;
            // 
            // tbxConfirmPass
            // 
            tbxConfirmPass.Anchor = AnchorStyles.None;
            tbxConfirmPass.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbxConfirmPass.Location = new Point(59, 303);
            tbxConfirmPass.Name = "tbxConfirmPass";
            tbxConfirmPass.PasswordChar = '•';
            tbxConfirmPass.Size = new Size(331, 43);
            tbxConfirmPass.TabIndex = 25;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(3, 83, 115);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(55, 268);
            label4.Name = "label4";
            label4.Size = new Size(162, 25);
            label4.TabIndex = 24;
            label4.Text = "Confirm Password";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(155, 62);
            label3.Name = "label3";
            label3.Size = new Size(143, 23);
            label3.TabIndex = 23;
            label3.Text = "Enter your details";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(98, 15);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(263, 41);
            guna2HtmlLabel1.TabIndex = 22;
            guna2HtmlLabel1.Text = "Forget Password";
            // 
            // tbxEmail
            // 
            tbxEmail.Anchor = AnchorStyles.None;
            tbxEmail.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbxEmail.Location = new Point(59, 120);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(331, 43);
            tbxEmail.TabIndex = 15;
            // 
            // cbxShowPassword
            // 
            cbxShowPassword.Anchor = AnchorStyles.None;
            cbxShowPassword.AutoSize = true;
            cbxShowPassword.BackColor = Color.FromArgb(3, 83, 115);
            cbxShowPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbxShowPassword.ForeColor = SystemColors.Control;
            cbxShowPassword.Location = new Point(224, 359);
            cbxShowPassword.Name = "cbxShowPassword";
            cbxShowPassword.Size = new Size(166, 27);
            cbxShowPassword.TabIndex = 17;
            cbxShowPassword.Text = "  Show Password";
            cbxShowPassword.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(3, 83, 115);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(56, 86);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 13;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // tbxNewPass
            // 
            tbxNewPass.Anchor = AnchorStyles.None;
            tbxNewPass.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbxNewPass.Location = new Point(59, 209);
            tbxNewPass.Name = "tbxNewPass";
            tbxNewPass.PasswordChar = '•';
            tbxNewPass.Size = new Size(331, 43);
            tbxNewPass.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(3, 83, 115);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(55, 174);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 14;
            label2.Text = "New Password";
            // 
            // btnResetPass
            // 
            btnResetPass.Anchor = AnchorStyles.None;
            btnResetPass.BackColor = Color.FromArgb(78, 177, 217);
            btnResetPass.FlatStyle = FlatStyle.Popup;
            btnResetPass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetPass.ForeColor = Color.White;
            btnResetPass.Location = new Point(55, 390);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Size = new Size(331, 45);
            btnResetPass.TabIndex = 18;
            btnResetPass.Text = "Reset Password";
            btnResetPass.UseVisualStyleBackColor = false;
            btnResetPass.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, 520);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(538, 307);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // guna2Elipse_ForgotPassword
            // 
            guna2Elipse_ForgotPassword.BorderRadius = 20;
            guna2Elipse_ForgotPassword.TargetControl = this;
            // 
            // guna2Elipse_panel1
            // 
            guna2Elipse_panel1.BorderRadius = 25;
            guna2Elipse_panel1.TargetControl = panel1;
            // 
            // guna2Elipse_button1
            // 
            guna2Elipse_button1.BorderRadius = 35;
            guna2Elipse_button1.TargetControl = btnResetPass;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(536, 828);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private TextBox tbxEmail;
        private CheckBox cbxShowPassword;
        private Label label1;
        private TextBox tbxNewPass;
        private Label label2;
        private Button btnResetPass;
        private TextBox tbxConfirmPass;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_ForgotPassword;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_button1;
        private LinkLabel lnkblSignin;
    }
}