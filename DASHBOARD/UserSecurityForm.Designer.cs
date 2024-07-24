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
            btnEdit = new Button();
            btnAddUser = new Button();
            button7 = new Button();
            button1 = new Button();
            sidebar_AddUser = new Panel();
            textBox1 = new TextBox();
            btnMechanic = new Button();
            btnCashier = new Button();
            label8 = new Label();
            EEmailValue = new TextBox();
            label5 = new Label();
            button6 = new Button();
            button5 = new Button();
            lblBack = new Label();
            ECPasswordValue = new TextBox();
            label7 = new Label();
            EPasswordValue = new TextBox();
            label6 = new Label();
            ELastNameValue = new TextBox();
            label4 = new Label();
            EFirstNameValue = new TextBox();
            label3 = new Label();
            label2 = new Label();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebar_EditUserInfo = new Panel();
            conPass = new TextBox();
            label16 = new Label();
            button8 = new Button();
            button9 = new Button();
            lblBackEdit = new Label();
            newPass = new TextBox();
            label9 = new Label();
            oldPass = new TextBox();
            label10 = new Label();
            txbEmail = new TextBox();
            label11 = new Label();
            txbLname = new TextBox();
            label12 = new Label();
            txbFname = new TextBox();
            label13 = new Label();
            label14 = new Label();
            sidebarTimerbtnEdit = new System.Windows.Forms.Timer(components);
            panel8 = new Panel();
            label17 = new Label();
            panel3 = new Panel();
            label18 = new Label();
            mechanicsView = new DataGridView();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)EmployeeView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            sidebar_AddUser.SuspendLayout();
            sidebar_EditUserInfo.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mechanicsView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(3, 83, 115);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee Info";
            label1.Click += label1_Click;
            // 
            // EmployeeView
            // 
            EmployeeView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeView.BackgroundColor = Color.White;
            EmployeeView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeView.Location = new Point(13, 174);
            EmployeeView.Margin = new Padding(4);
            EmployeeView.Name = "EmployeeView";
            EmployeeView.ReadOnly = true;
            EmployeeView.RowHeadersWidth = 51;
            EmployeeView.RowTemplate.Height = 25;
            EmployeeView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeView.Size = new Size(1071, 306);
            EmployeeView.TabIndex = 1;
            EmployeeView.CellClick += EmployeeView_CellClick;
            EmployeeView.CellContentClick += EmployeeView_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 83, 115);
            panel1.Controls.Add(label1);
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
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnAddUser);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(1097, 67);
            panel2.TabIndex = 13;
            panel2.Paint += panel2_Paint;
            // 
            // btnEdit
            // 
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.TopCenter;
            btnEdit.Location = new Point(222, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(99, 60);
            btnEdit.TabIndex = 23;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.BottomCenter;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
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
            button1.Click += button1_Click;
            // 
            // sidebar_AddUser
            // 
            sidebar_AddUser.BackColor = Color.FromArgb(3, 83, 115);
            sidebar_AddUser.Controls.Add(textBox1);
            sidebar_AddUser.Controls.Add(btnMechanic);
            sidebar_AddUser.Controls.Add(btnCashier);
            sidebar_AddUser.Controls.Add(label8);
            sidebar_AddUser.Controls.Add(EEmailValue);
            sidebar_AddUser.Controls.Add(label5);
            sidebar_AddUser.Controls.Add(button6);
            sidebar_AddUser.Controls.Add(button5);
            sidebar_AddUser.Controls.Add(lblBack);
            sidebar_AddUser.Controls.Add(ECPasswordValue);
            sidebar_AddUser.Controls.Add(label7);
            sidebar_AddUser.Controls.Add(EPasswordValue);
            sidebar_AddUser.Controls.Add(label6);
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
            sidebar_AddUser.Size = new Size(0, 860);
            sidebar_AddUser.TabIndex = 26;
            sidebar_AddUser.Paint += panel3_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(3, 83, 115);
            textBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(28, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 27);
            textBox1.TabIndex = 21;
            // 
            // btnMechanic
            // 
            btnMechanic.BackColor = Color.FromArgb(3, 83, 115);
            btnMechanic.FlatStyle = FlatStyle.Flat;
            btnMechanic.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnMechanic.ForeColor = Color.White;
            btnMechanic.Location = new Point(181, 161);
            btnMechanic.Name = "btnMechanic";
            btnMechanic.Padding = new Padding(10, 0, 10, 0);
            btnMechanic.Size = new Size(119, 37);
            btnMechanic.TabIndex = 20;
            btnMechanic.Text = "Mechanic";
            btnMechanic.UseVisualStyleBackColor = false;
            btnMechanic.Click += button10_Click;
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.FromArgb(3, 83, 115);
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCashier.ForeColor = Color.White;
            btnCashier.Location = new Point(77, 161);
            btnCashier.Name = "btnCashier";
            btnCashier.Padding = new Padding(10, 0, 10, 0);
            btnCashier.Size = new Size(104, 37);
            btnCashier.TabIndex = 19;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(28, 127);
            label8.Name = "label8";
            label8.Size = new Size(67, 23);
            label8.TabIndex = 18;
            label8.Text = "Position";
            // 
            // EEmailValue
            // 
            EEmailValue.BackColor = Color.FromArgb(3, 83, 115);
            EEmailValue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EEmailValue.ForeColor = Color.White;
            EEmailValue.Location = new Point(27, 380);
            EEmailValue.Name = "EEmailValue";
            EEmailValue.Size = new Size(286, 27);
            EEmailValue.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(26, 353);
            label5.Name = "label5";
            label5.Size = new Size(50, 23);
            label5.TabIndex = 15;
            label5.Text = "Email";
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
            ECPasswordValue.Location = new Point(28, 530);
            ECPasswordValue.Name = "ECPasswordValue";
            ECPasswordValue.Size = new Size(286, 27);
            ECPasswordValue.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(27, 503);
            label7.Name = "label7";
            label7.Size = new Size(145, 23);
            label7.TabIndex = 10;
            label7.Text = "Confirm password";
            // 
            // EPasswordValue
            // 
            EPasswordValue.BackColor = Color.FromArgb(3, 83, 115);
            EPasswordValue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EPasswordValue.ForeColor = Color.White;
            EPasswordValue.Location = new Point(27, 453);
            EPasswordValue.Name = "EPasswordValue";
            EPasswordValue.Size = new Size(286, 27);
            EPasswordValue.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(26, 426);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 8;
            label6.Text = "Password";
            // 
            // ELastNameValue
            // 
            ELastNameValue.BackColor = Color.FromArgb(3, 83, 115);
            ELastNameValue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ELastNameValue.ForeColor = Color.White;
            ELastNameValue.Location = new Point(27, 309);
            ELastNameValue.Name = "ELastNameValue";
            ELastNameValue.Size = new Size(286, 27);
            ELastNameValue.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(26, 282);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 4;
            label4.Text = "Last name";
            // 
            // EFirstNameValue
            // 
            EFirstNameValue.BackColor = Color.FromArgb(3, 83, 115);
            EFirstNameValue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EFirstNameValue.ForeColor = Color.White;
            EFirstNameValue.Location = new Point(27, 239);
            EFirstNameValue.Name = "EFirstNameValue";
            EFirstNameValue.Size = new Size(286, 27);
            EFirstNameValue.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 212);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
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
            sidebarTimer.Interval = 1;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // sidebar_EditUserInfo
            // 
            sidebar_EditUserInfo.BackColor = Color.FromArgb(3, 83, 115);
            sidebar_EditUserInfo.Controls.Add(label15);
            sidebar_EditUserInfo.Controls.Add(conPass);
            sidebar_EditUserInfo.Controls.Add(label16);
            sidebar_EditUserInfo.Controls.Add(button8);
            sidebar_EditUserInfo.Controls.Add(button9);
            sidebar_EditUserInfo.Controls.Add(lblBackEdit);
            sidebar_EditUserInfo.Controls.Add(newPass);
            sidebar_EditUserInfo.Controls.Add(label9);
            sidebar_EditUserInfo.Controls.Add(oldPass);
            sidebar_EditUserInfo.Controls.Add(label10);
            sidebar_EditUserInfo.Controls.Add(txbEmail);
            sidebar_EditUserInfo.Controls.Add(label11);
            sidebar_EditUserInfo.Controls.Add(txbLname);
            sidebar_EditUserInfo.Controls.Add(label12);
            sidebar_EditUserInfo.Controls.Add(txbFname);
            sidebar_EditUserInfo.Controls.Add(label13);
            sidebar_EditUserInfo.Controls.Add(label14);
            sidebar_EditUserInfo.Dock = DockStyle.Right;
            sidebar_EditUserInfo.Location = new Point(754, 46);
            sidebar_EditUserInfo.MaximumSize = new Size(343, 860);
            sidebar_EditUserInfo.MinimumSize = new Size(0, 860);
            sidebar_EditUserInfo.Name = "sidebar_EditUserInfo";
            sidebar_EditUserInfo.Size = new Size(343, 860);
            sidebar_EditUserInfo.TabIndex = 26;
            // 
            // conPass
            // 
            conPass.BackColor = Color.FromArgb(3, 83, 115);
            conPass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            conPass.ForeColor = Color.White;
            conPass.Location = new Point(29, 606);
            conPass.Name = "conPass";
            conPass.Size = new Size(286, 27);
            conPass.TabIndex = 31;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(28, 579);
            label16.Name = "label16";
            label16.Size = new Size(145, 23);
            label16.TabIndex = 30;
            label16.Text = "Confirm password";
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(3, 83, 115);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(91, 811);
            button8.Name = "button8";
            button8.Padding = new Padding(10, 0, 10, 0);
            button8.Size = new Size(128, 37);
            button8.TabIndex = 26;
            button8.Text = "Update";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(3, 83, 115);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(225, 811);
            button9.Name = "button9";
            button9.Size = new Size(104, 37);
            button9.TabIndex = 25;
            button9.Text = "Cancel";
            button9.TextAlign = ContentAlignment.MiddleRight;
            button9.UseVisualStyleBackColor = false;
            // 
            // lblBackEdit
            // 
            lblBackEdit.AutoSize = true;
            lblBackEdit.BackColor = Color.FromArgb(3, 83, 115);
            lblBackEdit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBackEdit.ForeColor = Color.White;
            lblBackEdit.Image = (Image)resources.GetObject("lblBackEdit.Image");
            lblBackEdit.Location = new Point(295, 21);
            lblBackEdit.Margin = new Padding(2, 0, 2, 0);
            lblBackEdit.Name = "lblBackEdit";
            lblBackEdit.Size = new Size(34, 41);
            lblBackEdit.TabIndex = 24;
            lblBackEdit.Text = "  ";
            lblBackEdit.Click += lblBackEdit_Click;
            // 
            // newPass
            // 
            newPass.BackColor = Color.FromArgb(3, 83, 115);
            newPass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            newPass.ForeColor = Color.White;
            newPass.Location = new Point(28, 533);
            newPass.Name = "newPass";
            newPass.Size = new Size(286, 27);
            newPass.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(27, 506);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 22;
            label9.Text = "New password";
            // 
            // oldPass
            // 
            oldPass.BackColor = Color.FromArgb(3, 83, 115);
            oldPass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            oldPass.ForeColor = Color.White;
            oldPass.Location = new Point(27, 456);
            oldPass.Name = "oldPass";
            oldPass.Size = new Size(286, 27);
            oldPass.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(26, 429);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 20;
            label10.Text = "Old password";
            // 
            // txbEmail
            // 
            txbEmail.BackColor = Color.FromArgb(3, 83, 115);
            txbEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txbEmail.ForeColor = Color.White;
            txbEmail.Location = new Point(27, 313);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(286, 27);
            txbEmail.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(26, 286);
            label11.Name = "label11";
            label11.Size = new Size(46, 20);
            label11.TabIndex = 18;
            label11.Text = "Email";
            // 
            // txbLname
            // 
            txbLname.BackColor = Color.FromArgb(3, 83, 115);
            txbLname.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txbLname.ForeColor = Color.White;
            txbLname.Location = new Point(27, 197);
            txbLname.Name = "txbLname";
            txbLname.Size = new Size(286, 27);
            txbLname.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(26, 170);
            label12.Name = "label12";
            label12.Size = new Size(76, 20);
            label12.TabIndex = 16;
            label12.Text = "Last name";
            // 
            // txbFname
            // 
            txbFname.BackColor = Color.FromArgb(3, 83, 115);
            txbFname.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txbFname.ForeColor = Color.White;
            txbFname.Location = new Point(27, 127);
            txbFname.Name = "txbFname";
            txbFname.Size = new Size(286, 27);
            txbFname.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(26, 100);
            label13.Name = "label13";
            label13.Size = new Size(77, 20);
            label13.TabIndex = 14;
            label13.Text = "First name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(3, 83, 115);
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(16, 24);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(253, 31);
            label14.TabIndex = 13;
            label14.Text = "Edit users information";
            // 
            // sidebarTimerbtnEdit
            // 
            sidebarTimerbtnEdit.Interval = 1;
            sidebarTimerbtnEdit.Tick += sidebarTimerbtnEdit_Tick;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(90, 126, 140);
            panel8.Controls.Add(label17);
            panel8.Location = new Point(13, 118);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(1071, 56);
            panel8.TabIndex = 27;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(440, 8);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(144, 34);
            label17.TabIndex = 0;
            label17.Text = "CASHIERS";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(90, 126, 140);
            panel3.Controls.Add(label18);
            panel3.Location = new Point(11, 493);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1071, 56);
            panel3.TabIndex = 28;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(440, 8);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(182, 34);
            label18.TabIndex = 0;
            label18.Text = "MECHANICS";
            // 
            // mechanicsView
            // 
            mechanicsView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mechanicsView.BackgroundColor = Color.White;
            mechanicsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mechanicsView.Location = new Point(11, 547);
            mechanicsView.Margin = new Padding(4);
            mechanicsView.Name = "mechanicsView";
            mechanicsView.ReadOnly = true;
            mechanicsView.RowHeadersWidth = 51;
            mechanicsView.RowTemplate.Height = 25;
            mechanicsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mechanicsView.Size = new Size(1071, 306);
            mechanicsView.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(3, 83, 115);
            label15.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(27, 380);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(171, 31);
            label15.TabIndex = 32;
            label15.Text = "Reset Password";
            // 
            // UserSecurityForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1097, 906);
            Controls.Add(sidebar_AddUser);
            Controls.Add(sidebar_EditUserInfo);
            Controls.Add(panel2);
            Controls.Add(EmployeeView);
            Controls.Add(panel1);
            Controls.Add(panel8);
            Controls.Add(panel3);
            Controls.Add(mechanicsView);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "UserSecurityForm";
            Text = "UserSecurityForm";
            ((System.ComponentModel.ISupportInitialize)EmployeeView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            sidebar_AddUser.ResumeLayout(false);
            sidebar_AddUser.PerformLayout();
            sidebar_EditUserInfo.ResumeLayout(false);
            sidebar_EditUserInfo.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mechanicsView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView EmployeeView;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button btnAddUser;
        private Button button7;
        private Button btnEdit;
        private Panel sidebar_AddUser;
        private Label label2;
        private TextBox EFirstNameValue;
        private Label label3;
        private TextBox ECPasswordValue;
        private Label label7;
        private TextBox EPasswordValue;
        private Label label6;
        private TextBox ELastNameValue;
        private Label label4;
        private Button button5;
        private Label lblBack;
        private Button button6;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel sidebar_EditUserInfo;
        private Button button8;
        private Button button9;
        private Label lblBackEdit;
        private TextBox newPass;
        private Label label9;
        private TextBox oldPass;
        private Label label10;
        private TextBox txbEmail;
        private Label label11;
        private TextBox txbLname;
        private Label label12;
        private TextBox txbFname;
        private Label label13;
        private Label label14;
        private System.Windows.Forms.Timer sidebarTimerbtnEdit;
        private TextBox EEmailValue;
        private Label label5;
        private Label label8;
        private TextBox conPass;
        private Label label16;
        private Button btnMechanic;
        private Button btnCashier;
        private TextBox textBox1;
        private Panel panel8;
        private Label label17;
        private Panel panel3;
        private Label label18;
        private DataGridView mechanicsView;
        private Label label15;
    }
}