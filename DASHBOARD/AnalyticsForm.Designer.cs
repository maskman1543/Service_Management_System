namespace Service_Management_System.DASHBOARD
{
    partial class AnalyticsForm
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
            panel1 = new Panel();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            Okay = new Button();
            button2 = new Button();
            button1 = new Button();
            btnYearly = new Button();
            btnWeekly = new Button();
            btnMonthly = new Button();
            btnDaily = new Button();
            panel5 = new Panel();
            label3 = new Label();
            guna2Elipse_panel3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_panel4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_panel5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 83, 115);
            panel1.Controls.Add(dateTimePickerStart);
            panel1.Controls.Add(dateTimePickerEnd);
            panel1.Controls.Add(Okay);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnYearly);
            panel1.Controls.Add(btnWeekly);
            panel1.Controls.Add(btnMonthly);
            panel1.Controls.Add(btnDaily);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 54);
            panel1.TabIndex = 2;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(45, 16);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(129, 27);
            dateTimePickerStart.TabIndex = 11;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(173, 16);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(129, 27);
            dateTimePickerEnd.TabIndex = 10;
            dateTimePickerEnd.ValueChanged += dateTimePickerStart_ValueChanged;
            // 
            // Okay
            // 
            Okay.BackColor = Color.White;
            Okay.FlatAppearance.BorderSize = 0;
            Okay.FlatStyle = FlatStyle.Flat;
            Okay.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Okay.ForeColor = Color.FromArgb(11, 67, 89);
            Okay.Location = new Point(303, 17);
            Okay.Name = "Okay";
            Okay.Size = new Size(46, 26);
            Okay.TabIndex = 9;
            Okay.Text = "Ok";
            Okay.UseVisualStyleBackColor = false;
            Okay.Click += Okay_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(11, 67, 89);
            button2.Location = new Point(364, 12);
            button2.Name = "button2";
            button2.Size = new Size(121, 35);
            button2.TabIndex = 8;
            button2.Text = "Custom";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(11, 67, 89);
            button1.Location = new Point(485, 12);
            button1.Name = "button1";
            button1.Size = new Size(121, 35);
            button1.TabIndex = 7;
            button1.Text = "Yesterday";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnYearly
            // 
            btnYearly.BackColor = Color.White;
            btnYearly.FlatAppearance.BorderSize = 0;
            btnYearly.FlatStyle = FlatStyle.Flat;
            btnYearly.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnYearly.ForeColor = Color.FromArgb(11, 67, 89);
            btnYearly.Location = new Point(969, 12);
            btnYearly.Name = "btnYearly";
            btnYearly.Size = new Size(121, 35);
            btnYearly.TabIndex = 5;
            btnYearly.Text = "This year";
            btnYearly.UseVisualStyleBackColor = false;
            btnYearly.Click += btnYearly_Click_1;
            // 
            // btnWeekly
            // 
            btnWeekly.BackColor = Color.White;
            btnWeekly.FlatAppearance.BorderSize = 0;
            btnWeekly.FlatStyle = FlatStyle.Flat;
            btnWeekly.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnWeekly.ForeColor = Color.FromArgb(11, 67, 89);
            btnWeekly.Location = new Point(727, 12);
            btnWeekly.Name = "btnWeekly";
            btnWeekly.Size = new Size(121, 35);
            btnWeekly.TabIndex = 6;
            btnWeekly.Text = "Weekly";
            btnWeekly.UseVisualStyleBackColor = false;
            btnWeekly.Click += btnWeekly_Click_1;
            // 
            // btnMonthly
            // 
            btnMonthly.BackColor = Color.White;
            btnMonthly.FlatAppearance.BorderSize = 0;
            btnMonthly.FlatStyle = FlatStyle.Flat;
            btnMonthly.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMonthly.ForeColor = Color.FromArgb(11, 67, 89);
            btnMonthly.Location = new Point(848, 12);
            btnMonthly.Name = "btnMonthly";
            btnMonthly.Size = new Size(121, 35);
            btnMonthly.TabIndex = 4;
            btnMonthly.Text = "Monthly";
            btnMonthly.UseVisualStyleBackColor = false;
            btnMonthly.Click += btnMonthly_Click;
            // 
            // btnDaily
            // 
            btnDaily.BackColor = Color.White;
            btnDaily.FlatAppearance.BorderSize = 0;
            btnDaily.FlatStyle = FlatStyle.Flat;
            btnDaily.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDaily.ForeColor = Color.FromArgb(11, 67, 89);
            btnDaily.Location = new Point(606, 12);
            btnDaily.Name = "btnDaily";
            btnDaily.Size = new Size(121, 35);
            btnDaily.TabIndex = 2;
            btnDaily.Text = "Today";
            btnDaily.UseVisualStyleBackColor = false;
            btnDaily.Click += btnDaily_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(3, 83, 115);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(12, 562);
            panel5.Name = "panel5";
            panel5.Size = new Size(1065, 39);
            panel5.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 4);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 3;
            label3.Text = "Sales / day";
            // 
            // guna2Elipse_panel3
            // 
            guna2Elipse_panel3.BorderRadius = 10;
            // 
            // guna2Elipse_panel4
            // 
            guna2Elipse_panel4.BorderRadius = 10;
            // 
            // guna2Elipse_panel5
            // 
            guna2Elipse_panel5.BorderRadius = 10;
            guna2Elipse_panel5.TargetControl = panel5;
            // 
            // guna2Elipse6
            // 
            guna2Elipse6.BorderRadius = 10;
            // 
            // AnalyticsForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1097, 906);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnalyticsForm";
            Text = "AnalyticsForm";
            Load += AnalyticsForm_Load_1;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnDaily;
        private Panel panel5;
        private Button btnYearly;
        private Button btnMonthly;
        private Button btnWeekly;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panel4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panel5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Button button1;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Button Okay;
        private Button button2;
        private Label label3;
    }
}