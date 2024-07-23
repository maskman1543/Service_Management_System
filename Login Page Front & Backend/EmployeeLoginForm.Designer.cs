namespace Service_Management_System.Login_Page_Front___Backend
{
    partial class EmployeeLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLoginForm));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            EmployeeIDTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            PasswordTextBox = new TextBox();
            panel_loginInfo = new Panel();
            linkLabel3 = new LinkLabel();
            label3 = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnLogin = new Button();
            lkblContinueAsEmployee = new LinkLabel();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            button1 = new Button();
            btnClose = new Button();
            guna2Elipse_EmployeeLoginForm = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_loginInfo = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_btnLogin = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_loginInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, 520);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(538, 307);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // EmployeeIDTextBox
            // 
            EmployeeIDTextBox.Anchor = AnchorStyles.None;
            EmployeeIDTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            EmployeeIDTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            EmployeeIDTextBox.Location = new Point(63, 148);
            EmployeeIDTextBox.Multiline = true;
            EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            EmployeeIDTextBox.Size = new Size(331, 43);
            EmployeeIDTextBox.TabIndex = 8;
            EmployeeIDTextBox.TextChanged += EmployeeIDTextBox_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(3, 83, 115);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(59, 120);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 6;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(3, 83, 115);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(59, 217);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.None;
            PasswordTextBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            PasswordTextBox.Location = new Point(63, 247);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '•';
            PasswordTextBox.Size = new Size(331, 43);
            PasswordTextBox.TabIndex = 9;
            // 
            // panel_loginInfo
            // 
            panel_loginInfo.BackColor = Color.FromArgb(3, 83, 115);
            panel_loginInfo.Controls.Add(linkLabel3);
            panel_loginInfo.Controls.Add(label3);
            panel_loginInfo.Controls.Add(guna2HtmlLabel1);
            panel_loginInfo.Controls.Add(EmployeeIDTextBox);
            panel_loginInfo.Controls.Add(btnLogin);
            panel_loginInfo.Controls.Add(label1);
            panel_loginInfo.Controls.Add(lkblContinueAsEmployee);
            panel_loginInfo.Controls.Add(label2);
            panel_loginInfo.Controls.Add(checkBox1);
            panel_loginInfo.Controls.Add(PasswordTextBox);
            panel_loginInfo.Controls.Add(linkLabel1);
            panel_loginInfo.Location = new Point(41, 279);
            panel_loginInfo.Name = "panel_loginInfo";
            panel_loginInfo.Size = new Size(455, 491);
            panel_loginInfo.TabIndex = 12;
            panel_loginInfo.Paint += panel_loginInfo_Paint;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.Red;
            linkLabel3.Anchor = AnchorStyles.None;
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.FromArgb(3, 83, 115);
            linkLabel3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel3.ForeColor = Color.White;
            linkLabel3.LinkColor = Color.Cyan;
            linkLabel3.Location = new Point(152, 433);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(163, 25);
            linkLabel3.TabIndex = 12;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Continue as Admin";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(117, 67);
            label3.Name = "label3";
            label3.Size = new Size(236, 25);
            label3.TabIndex = 11;
            label3.Text = "Enter your login information";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(109, 18);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(258, 41);
            guna2HtmlLabel1.TabIndex = 10;
            guna2HtmlLabel1.Text = "Employee Login";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(78, 177, 217);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(63, 372);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(331, 45);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lkblContinueAsEmployee
            // 
            lkblContinueAsEmployee.ActiveLinkColor = Color.Red;
            lkblContinueAsEmployee.Anchor = AnchorStyles.None;
            lkblContinueAsEmployee.AutoSize = true;
            lkblContinueAsEmployee.BackColor = Color.FromArgb(3, 83, 115);
            lkblContinueAsEmployee.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lkblContinueAsEmployee.ForeColor = Color.White;
            lkblContinueAsEmployee.LinkColor = Color.White;
            lkblContinueAsEmployee.Location = new Point(262, 629);
            lkblContinueAsEmployee.Name = "lkblContinueAsEmployee";
            lkblContinueAsEmployee.Size = new Size(188, 25);
            lkblContinueAsEmployee.TabIndex = 8;
            lkblContinueAsEmployee.TabStop = true;
            lkblContinueAsEmployee.Text = "Continue as Employee";
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.FromArgb(3, 83, 115);
            checkBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.Control;
            checkBox1.Location = new Point(228, 312);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(166, 27);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "  Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(3, 83, 115);
            linkLabel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = Color.Cyan;
            linkLabel1.Location = new Point(63, 311);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(146, 25);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password";
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Red;
            linkLabel2.Anchor = AnchorStyles.None;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.FromArgb(3, 83, 115);
            linkLabel2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.ForeColor = Color.White;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(230, 565);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(75, 25);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Sign Up";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(78, 177, 217);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(104, 563);
            button1.Name = "button1";
            button1.Size = new Size(331, 45);
            button1.TabIndex = 10;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(494, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.TabIndex = 13;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // guna2Elipse_EmployeeLoginForm
            // 
            guna2Elipse_EmployeeLoginForm.BorderRadius = 20;
            guna2Elipse_EmployeeLoginForm.TargetControl = this;
            // 
            // guna2Elipse_loginInfo
            // 
            guna2Elipse_loginInfo.BorderRadius = 35;
            guna2Elipse_loginInfo.TargetControl = panel_loginInfo;
            // 
            // guna2Elipse_btnLogin
            // 
            guna2Elipse_btnLogin.BorderRadius = 25;
            guna2Elipse_btnLogin.TargetControl = btnLogin;
            // 
            // EmployeeLoginForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(536, 828);
            Controls.Add(btnClose);
            Controls.Add(panel_loginInfo);
            Controls.Add(linkLabel2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeLoginForm";
            Load += EmployeeLoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_loginInfo.ResumeLayout(false);
            panel_loginInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox EmployeeIDTextBox;
        private Label label1;
        private Label label2;
        private TextBox PasswordTextBox;
        private Panel panel_loginInfo;
        private LinkLabel lkblContinueAsEmployee;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Button button1;
        private Button btnLogin;
        private Button btnClose;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_EmployeeLoginForm;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_loginInfo;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_btnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label3;
        private LinkLabel linkLabel3;
    }
}