namespace Service_Management_System.DASHBOARD
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panel1 = new Panel();
            btnMenu = new Button();
            label1 = new Label();
            panelMenu = new Panel();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnCompany = new FontAwesome.Sharp.IconButton();
            btnSecurity = new FontAwesome.Sharp.IconButton();
            btnAnalytics = new FontAwesome.Sharp.IconButton();
            btnStock = new FontAwesome.Sharp.IconButton();
            btnProducts = new FontAwesome.Sharp.IconButton();
            btnDocuments = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            label14 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panelDesktop = new Panel();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panelMenu.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 83, 115);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 34);
            panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.FromArgb(3, 83, 115);
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(3, 0);
            btnMenu.Margin = new Padding(3, 2, 3, 2);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(2, 0, 0, 9);
            btnMenu.Size = new Size(52, 34);
            btnMenu.TabIndex = 13;
            btnMenu.TextAlign = ContentAlignment.BottomCenter;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(998, 0);
            label1.Name = "label1";
            label1.Size = new Size(26, 30);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(3, 83, 115);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(btnCompany);
            panelMenu.Controls.Add(btnSecurity);
            panelMenu.Controls.Add(btnAnalytics);
            panelMenu.Controls.Add(btnStock);
            panelMenu.Controls.Add(btnProducts);
            panelMenu.Controls.Add(btnDocuments);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panel3);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 34);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.MaximumSize = new Size(236, 734);
            panelMenu.MinimumSize = new Size(0, 734);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(236, 734);
            panelMenu.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.OctopusDeploy;
            btnExit.IconColor = Color.White;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 689);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(9, 0, 18, 0);
            btnExit.Size = new Size(236, 45);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCompany
            // 
            btnCompany.Dock = DockStyle.Top;
            btnCompany.FlatAppearance.BorderSize = 0;
            btnCompany.FlatStyle = FlatStyle.Flat;
            btnCompany.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompany.ForeColor = Color.White;
            btnCompany.IconChar = FontAwesome.Sharp.IconChar.Building;
            btnCompany.IconColor = Color.White;
            btnCompany.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCompany.IconSize = 30;
            btnCompany.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompany.Location = new Point(0, 340);
            btnCompany.Margin = new Padding(3, 2, 3, 2);
            btnCompany.Name = "btnCompany";
            btnCompany.Padding = new Padding(9, 0, 18, 0);
            btnCompany.Size = new Size(236, 38);
            btnCompany.TabIndex = 7;
            btnCompany.Text = "My Company";
            btnCompany.TextAlign = ContentAlignment.MiddleLeft;
            btnCompany.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCompany.UseVisualStyleBackColor = true;
            btnCompany.Click += btnCompany_Click;
            // 
            // btnSecurity
            // 
            btnSecurity.Dock = DockStyle.Top;
            btnSecurity.FlatAppearance.BorderSize = 0;
            btnSecurity.FlatStyle = FlatStyle.Flat;
            btnSecurity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSecurity.ForeColor = Color.White;
            btnSecurity.IconChar = FontAwesome.Sharp.IconChar.Key;
            btnSecurity.IconColor = Color.White;
            btnSecurity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSecurity.IconSize = 30;
            btnSecurity.ImageAlign = ContentAlignment.MiddleLeft;
            btnSecurity.Location = new Point(0, 302);
            btnSecurity.Margin = new Padding(3, 2, 3, 2);
            btnSecurity.Name = "btnSecurity";
            btnSecurity.Padding = new Padding(9, 0, 18, 0);
            btnSecurity.Size = new Size(236, 38);
            btnSecurity.TabIndex = 6;
            btnSecurity.Text = "User and Security";
            btnSecurity.TextAlign = ContentAlignment.MiddleLeft;
            btnSecurity.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSecurity.UseVisualStyleBackColor = true;
            btnSecurity.Click += btnSecurity_Click;
            // 
            // btnAnalytics
            // 
            btnAnalytics.Dock = DockStyle.Top;
            btnAnalytics.FlatAppearance.BorderSize = 0;
            btnAnalytics.FlatStyle = FlatStyle.Flat;
            btnAnalytics.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnalytics.ForeColor = Color.White;
            btnAnalytics.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            btnAnalytics.IconColor = Color.White;
            btnAnalytics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnalytics.IconSize = 30;
            btnAnalytics.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnalytics.Location = new Point(0, 264);
            btnAnalytics.Margin = new Padding(3, 2, 3, 2);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Padding = new Padding(9, 0, 18, 0);
            btnAnalytics.Size = new Size(236, 38);
            btnAnalytics.TabIndex = 5;
            btnAnalytics.Text = "Analytics";
            btnAnalytics.TextAlign = ContentAlignment.MiddleLeft;
            btnAnalytics.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAnalytics.UseVisualStyleBackColor = true;
            btnAnalytics.Click += btnAnalytics_Click;
            // 
            // btnStock
            // 
            btnStock.Dock = DockStyle.Top;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnStock.ForeColor = Color.White;
            btnStock.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            btnStock.IconColor = Color.White;
            btnStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStock.IconSize = 30;
            btnStock.ImageAlign = ContentAlignment.MiddleLeft;
            btnStock.Location = new Point(0, 226);
            btnStock.Margin = new Padding(3, 2, 3, 2);
            btnStock.Name = "btnStock";
            btnStock.Padding = new Padding(9, 0, 18, 0);
            btnStock.Size = new Size(236, 38);
            btnStock.TabIndex = 4;
            btnStock.Text = "Stock";
            btnStock.TextAlign = ContentAlignment.MiddleLeft;
            btnStock.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnProducts
            // 
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducts.ForeColor = Color.White;
            btnProducts.IconChar = FontAwesome.Sharp.IconChar.HandHolding;
            btnProducts.IconColor = Color.White;
            btnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProducts.IconSize = 30;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(0, 188);
            btnProducts.Margin = new Padding(3, 2, 3, 2);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(9, 0, 18, 0);
            btnProducts.Size = new Size(236, 38);
            btnProducts.TabIndex = 3;
            btnProducts.Text = "Products and Services";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnDocuments
            // 
            btnDocuments.Dock = DockStyle.Top;
            btnDocuments.FlatAppearance.BorderSize = 0;
            btnDocuments.FlatStyle = FlatStyle.Flat;
            btnDocuments.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDocuments.ForeColor = Color.White;
            btnDocuments.IconChar = FontAwesome.Sharp.IconChar.File;
            btnDocuments.IconColor = Color.White;
            btnDocuments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDocuments.IconSize = 30;
            btnDocuments.ImageAlign = ContentAlignment.MiddleLeft;
            btnDocuments.Location = new Point(0, 150);
            btnDocuments.Margin = new Padding(3, 2, 3, 2);
            btnDocuments.Name = "btnDocuments";
            btnDocuments.Padding = new Padding(9, 0, 18, 0);
            btnDocuments.Size = new Size(236, 38);
            btnDocuments.TabIndex = 2;
            btnDocuments.Text = "Documents";
            btnDocuments.TextAlign = ContentAlignment.MiddleLeft;
            btnDocuments.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDocuments.UseVisualStyleBackColor = true;
            btnDocuments.Click += btnDocuments_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnDashboard.IconColor = Color.White;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 30;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 112);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(9, 0, 18, 0);
            btnDashboard.Size = new Size(236, 38);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 112);
            panel3.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft YaHei", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Gainsboro;
            label14.Location = new Point(83, 74);
            label14.Name = "label14";
            label14.Size = new Size(118, 11);
            label14.TabIndex = 5;
            label14.Text = "Service Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Brush Script MT", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(94, 46);
            label2.Name = "label2";
            label2.Size = new Size(116, 29);
            label2.TabIndex = 1;
            label2.Text = "Service Flow";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 67, 89);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(236, 34);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(788, 7);
            panel2.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(242, 242, 242);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(236, 41);
            panelDesktop.Margin = new Padding(3, 2, 3, 2);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(788, 727);
            panelDesktop.TabIndex = 3;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebar_Timer;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(panelDesktop);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainMenu";
            Text = "Dashboard_form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelMenu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelMenu;
        private Label label1;
        private Button btnMenu;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnDocuments;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnCompany;
        private FontAwesome.Sharp.IconButton btnSecurity;
        private FontAwesome.Sharp.IconButton btnAnalytics;
        private FontAwesome.Sharp.IconButton btnStock;
        private FontAwesome.Sharp.IconButton btnProducts;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label14;
        private Panel panel2;
        private Panel panelDesktop;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}