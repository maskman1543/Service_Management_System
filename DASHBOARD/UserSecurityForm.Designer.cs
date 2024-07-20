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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSecurityForm));
            label1 = new Label();
            EmployeeView = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnAddUser = new Button();
            button7 = new Button();
            button1 = new Button();
            sidebar_AddUser = new Panel();
            button6 = new Button();
            button5 = new Button();
            lblBack = new Label();
            ECPasswordValue = new TextBox();
            label7 = new Label();
            EPasswordValue = new TextBox();
            label6 = new Label();
            EEmailValue = new TextBox();
            label5 = new Label();
            ELastNameValue = new TextBox();
            label4 = new Label();
            EFirstNameValue = new TextBox();
            label3 = new Label();
            label2 = new Label();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)EmployeeView).BeginInit();
            panel2.SuspendLayout();
            sidebar_AddUser.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(3, 83, 115);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 0;
            label1.Text = "Users info";
            label1.Click += label1_Click;
            // 
            // EmployeeView
            // 
            EmployeeView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeView.BackgroundColor = Color.White;
            EmployeeView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeView.Location = new Point(13, 135);
            EmployeeView.Margin = new Padding(4);
            EmployeeView.Name = "EmployeeView";
            EmployeeView.RowHeadersWidth = 51;
            EmployeeView.RowTemplate.Height = 25;
            EmployeeView.Size = new Size(1071, 744);
            EmployeeView.TabIndex = 1;
            EmployeeView.CellContentClick += EmployeeView_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 83, 115);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 46);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnAddUser);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(1097, 67);
            panel2.TabIndex = 13;
            panel2.Paint += panel2_Paint;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(556, 4);
            button4.Name = "button4";
            button4.Size = new Size(145, 60);
            button4.TabIndex = 25;
            button4.Text = "Show inactive users";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(432, 5);
            button2.Name = "button2";
            button2.Size = new Size(118, 60);
            button2.TabIndex = 24;
            button2.Text = "Reset password";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(222, 4);
            button3.Name = "button3";
            button3.Size = new Size(99, 60);
            button3.TabIndex = 23;
            button3.Text = "Edit";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddUser.Image = (Image)resources.GetObject("btnAddUser.Image");
            btnAddUser.ImageAlign = ContentAlignment.TopCenter;
            btnAddUser.Location = new Point(117, 4);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(99, 60);
            btnAddUser.TabIndex = 22;
            btnAddUser.Text = "Add user";
            btnAddUser.TextAlign = ContentAlignment.BottomCenter;
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.TopCenter;
            button7.Location = new Point(327, 5);
            button7.Name = "button7";
            button7.Size = new Size(99, 60);
            button7.TabIndex = 21;
            button7.Text = "Delete";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(12, 3);
            button1.Name = "button1";
            button1.Size = new Size(99, 60);
            button1.TabIndex = 15;
            button1.Text = "Refresh";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // sidebar_AddUser
            // 
            sidebar_AddUser.BackColor = Color.FromArgb(3, 83, 115);
            sidebar_AddUser.Controls.Add(button6);
            sidebar_AddUser.Controls.Add(button5);
            sidebar_AddUser.Controls.Add(lblBack);
            sidebar_AddUser.Controls.Add(ECPasswordValue);
            sidebar_AddUser.Controls.Add(label7);
            sidebar_AddUser.Controls.Add(EPasswordValue);
            sidebar_AddUser.Controls.Add(label6);
            sidebar_AddUser.Controls.Add(EEmailValue);
            sidebar_AddUser.Controls.Add(label5);
            sidebar_AddUser.Controls.Add(ELastNameValue);
            sidebar_AddUser.Controls.Add(label4);
            sidebar_AddUser.Controls.Add(EFirstNameValue);
            sidebar_AddUser.Controls.Add(label3);
            sidebar_AddUser.Controls.Add(label2);
            sidebar_AddUser.Dock = DockStyle.Right;
            sidebar_AddUser.Location = new Point(754, 46);
            sidebar_AddUser.MaximumSize = new Size(343, 860);
            sidebar_AddUser.MinimumSize = new Size(0, 860);
            sidebar_AddUser.Name = "sidebar_AddUser";
            sidebar_AddUser.Size = new Size(343, 860);
            sidebar_AddUser.TabIndex = 26;
            sidebar_AddUser.Paint += panel3_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(3, 83, 115);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(115, 811);
            button6.Name = "button6";
            button6.Padding = new Padding(10, 0, 10, 0);
            button6.Size = new Size(104, 37);
            button6.TabIndex = 14;
            button6.Text = "Save";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(3, 83, 115);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(225, 811);
            button5.Name = "button5";
            button5.Size = new Size(104, 37);
            button5.TabIndex = 13;
            button5.Text = "Cancel";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.BackColor = Color.FromArgb(3, 83, 115);
            lblBack.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBack.ForeColor = Color.White;
            lblBack.Image = (Image)resources.GetObject("lblBack.Image");
            lblBack.Location = new Point(295, 17);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(34, 41);
            lblBack.TabIndex = 12;
            lblBack.Text = "  ";
            lblBack.Click += lblBack_Click;
            // 
            // ECPasswordValue
            // 
            ECPasswordValue.BackColor = Color.FromArgb(3, 83, 115);
            ECPasswordValue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ECPasswordValue.ForeColor = Color.White;
            ECPasswordValue.Location = new Point(30, 419);
            ECPasswordValue.Name = "ECPasswordValue";
            ECPasswordValue.Size = new Size(286, 27);
            ECPasswordValue.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(29, 392);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 10;
            label7.Text = "Confirm password";
            // 
            // EPasswordValue
            // 
            EPasswordValue.BackColor = Color.FromArgb(3, 83, 115);
            EPasswordValue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EPasswordValue.ForeColor = Color.White;
            EPasswordValue.Location = new Point(29, 342);
            EPasswordValue.Name = "EPasswordValue";
            EPasswordValue.Size = new Size(286, 27);
            EPasswordValue.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(28, 315);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 8;
            label6.Text = "Password";
            // 
            // EEmailValue
            // 
            EEmailValue.BackColor = Color.FromArgb(3, 83, 115);
            EEmailValue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EEmailValue.ForeColor = Color.White;
            EEmailValue.Location = new Point(28, 268);
            EEmailValue.Name = "EEmailValue";
            EEmailValue.Size = new Size(286, 27);
            EEmailValue.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 241);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "Email";
            // 
            // ELastNameValue
            // 
            ELastNameValue.BackColor = Color.FromArgb(3, 83, 115);
            ELastNameValue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ELastNameValue.ForeColor = Color.White;
            ELastNameValue.Location = new Point(27, 193);
            ELastNameValue.Name = "ELastNameValue";
            ELastNameValue.Size = new Size(286, 27);
            ELastNameValue.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(26, 166);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 4;
            label4.Text = "Last name";
            // 
            // EFirstNameValue
            // 
            EFirstNameValue.BackColor = Color.FromArgb(3, 83, 115);
            EFirstNameValue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EFirstNameValue.ForeColor = Color.White;
            EFirstNameValue.Location = new Point(27, 123);
            EFirstNameValue.Name = "EFirstNameValue";
            EFirstNameValue.Size = new Size(286, 27);
            EFirstNameValue.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 96);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "First name";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(3, 83, 115);
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 20);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 31);
            label2.TabIndex = 1;
            label2.Text = "Add users";
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 2;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // UserSecurityForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1097, 906);
            Controls.Add(sidebar_AddUser);
            Controls.Add(panel2);
            Controls.Add(EmployeeView);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "UserSecurityForm";
            Text = "UserSecurityForm";
            ((System.ComponentModel.ISupportInitialize)EmployeeView).EndInit();
            panel2.ResumeLayout(false);
            sidebar_AddUser.ResumeLayout(false);
            sidebar_AddUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView EmployeeView;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button btnAddUser;
        private Button button7;
        private Button button3;
        private Button button2;
        private Button button4;
        private Panel sidebar_AddUser;
        private Label label2;
        private TextBox EFirstNameValue;
        private Label label3;
        private TextBox ECPasswordValue;
        private Label label7;
        private TextBox EPasswordValue;
        private Label label6;
        private TextBox EEmailValue;
        private Label label5;
        private TextBox ELastNameValue;
        private Label label4;
        private Button button5;
        private Label lblBack;
        private Button button6;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}