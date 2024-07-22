namespace Service_Management_System.DASHBOARD
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            panel_TimeDate = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblTimeAndDateNow = new Label();
            lblClock = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            panel5 = new Panel();
            panel6 = new Panel();
            guna2Elipse_panel2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_panel3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_panel4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_panel5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_panel6 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_TimeDate = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel_TimeDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel_TimeDate
            // 
            panel_TimeDate.BackColor = Color.Black;
            panel_TimeDate.Controls.Add(label2);
            panel_TimeDate.Controls.Add(label1);
            panel_TimeDate.Controls.Add(lblTimeAndDateNow);
            panel_TimeDate.Controls.Add(lblClock);
            panel_TimeDate.Location = new Point(886, 28);
            panel_TimeDate.Name = "panel_TimeDate";
            panel_TimeDate.Size = new Size(199, 142);
            panel_TimeDate.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(25, 23);
            label2.Name = "label2";
            label2.Size = new Size(37, 28);
            label2.TabIndex = 3;
            label2.Text = "     ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(25, 88);
            label1.Name = "label1";
            label1.Size = new Size(37, 28);
            label1.TabIndex = 2;
            label1.Text = "     ";
            label1.Click += label1_Click;
            // 
            // lblTimeAndDateNow
            // 
            lblTimeAndDateNow.AutoSize = true;
            lblTimeAndDateNow.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimeAndDateNow.ForeColor = Color.White;
            lblTimeAndDateNow.Location = new Point(78, 90);
            lblTimeAndDateNow.Name = "lblTimeAndDateNow";
            lblTimeAndDateNow.Size = new Size(51, 25);
            lblTimeAndDateNow.TabIndex = 1;
            lblTimeAndDateNow.Text = "Date";
            lblTimeAndDateNow.Click += lblTimeAndDateNow_Click;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblClock.ForeColor = Color.White;
            lblClock.Location = new Point(78, 24);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(53, 25);
            lblClock.TabIndex = 0;
            lblClock.Text = "Time";
            lblClock.Click += lblClock_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(857, 185);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Location = new Point(12, 215);
            panel3.Name = "panel3";
            panel3.Size = new Size(556, 221);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Location = new Point(583, 215);
            panel4.Name = "panel4";
            panel4.Size = new Size(502, 221);
            panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 693);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(556, 201);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(583, 693);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(502, 201);
            dataGridView2.TabIndex = 5;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Location = new Point(12, 453);
            panel5.Name = "panel5";
            panel5.Size = new Size(556, 221);
            panel5.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gainsboro;
            panel6.Location = new Point(583, 453);
            panel6.Name = "panel6";
            panel6.Size = new Size(502, 221);
            panel6.TabIndex = 7;
            // 
            // guna2Elipse_panel2
            // 
            guna2Elipse_panel2.BorderRadius = 10;
            guna2Elipse_panel2.TargetControl = panel2;
            // 
            // guna2Elipse_panel3
            // 
            guna2Elipse_panel3.BorderRadius = 10;
            guna2Elipse_panel3.TargetControl = panel3;
            // 
            // guna2Elipse_panel4
            // 
            guna2Elipse_panel4.BorderRadius = 10;
            guna2Elipse_panel4.TargetControl = panel4;
            // 
            // guna2Elipse_panel5
            // 
            guna2Elipse_panel5.BorderRadius = 10;
            guna2Elipse_panel5.TargetControl = panel5;
            // 
            // guna2Elipse_panel6
            // 
            guna2Elipse_panel6.BorderRadius = 10;
            guna2Elipse_panel6.TargetControl = panel6;
            // 
            // guna2Elipse_TimeDate
            // 
            guna2Elipse_TimeDate.BorderRadius = 10;
            guna2Elipse_TimeDate.TargetControl = panel_TimeDate;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1097, 906);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel_TimeDate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            panel_TimeDate.ResumeLayout(false);
            panel_TimeDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_TimeDate;
        private Label lblTimeAndDateNow;
        private Label lblClock;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Panel panel5;
        private Panel panel6;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panel4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panel5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panel6;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_TimeDate;
    }
}