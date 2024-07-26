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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyticsForm));
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
            panel3 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            guna2Elipse_panel3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_panel4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_panel5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            label4 = new Label();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label7 = new Label();
            panel7 = new Panel();
            pictureBox2 = new PictureBox();
            label17 = new Label();
            label6 = new Label();
            panel8 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(12, 170);
            panel3.Name = "panel3";
            panel3.Size = new Size(1067, 161);
            panel3.TabIndex = 4;
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
            guna2Elipse_panel3.TargetControl = panel3;
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(3, 83, 115);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(816, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(263, 95);
            panel4.TabIndex = 18;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(26, 8);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(89, 59);
            label8.Name = "label8";
            label8.Size = new Size(145, 23);
            label8.TabIndex = 4;
            label8.Text = "Total Product Sold";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(136, 20);
            label4.Name = "label4";
            label4.Size = new Size(37, 39);
            label4.TabIndex = 3;
            label4.Text = "0";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(3, 83, 115);
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(550, 60);
            panel6.Name = "panel6";
            panel6.Size = new Size(263, 95);
            panel6.TabIndex = 17;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(120, 27);
            label2.Name = "label2";
            label2.Size = new Size(96, 22);
            label2.TabIndex = 3;
            label2.Text = "Php. 0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(103, 59);
            label7.Name = "label7";
            label7.Size = new Size(113, 23);
            label7.TabIndex = 3;
            label7.Text = "Total Revenue";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(3, 83, 115);
            panel7.Controls.Add(pictureBox2);
            panel7.Controls.Add(label17);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(283, 60);
            panel7.Name = "panel7";
            panel7.Size = new Size(263, 95);
            panel7.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(125, 27);
            label17.Name = "label17";
            label17.Size = new Size(96, 22);
            label17.TabIndex = 2;
            label17.Text = "Php. 0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(59, 59);
            label6.Name = "label6";
            label6.Size = new Size(202, 23);
            label6.TabIndex = 2;
            label6.Text = "Average Salary/Employee";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(3, 83, 115);
            panel8.Controls.Add(pictureBox1);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(17, 60);
            panel8.Name = "panel8";
            panel8.Size = new Size(263, 95);
            panel8.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(90, 59);
            label5.Name = "label5";
            label5.Size = new Size(166, 23);
            label5.TabIndex = 1;
            label5.Text = "Total salary expenses";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(112, 27);
            label1.Name = "label1";
            label1.Size = new Size(96, 22);
            label1.TabIndex = 0;
            label1.Text = "Php. 0.00";
            // 
            // AnalyticsForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1097, 906);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnalyticsForm";
            Text = "AnalyticsForm";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel3;
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
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label label8;
        private Label label4;
        private Panel panel6;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label7;
        private Panel panel7;
        private PictureBox pictureBox2;
        private Label label17;
        private Label label6;
        private Panel panel8;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label1;
        private Label label3;
    }
}