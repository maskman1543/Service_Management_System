﻿namespace Service_Management_System.POS
{
    partial class View_sales_history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_sales_history));
            panel1 = new Panel();
            label1 = new Label();
            btnClose = new Button();
            panel2 = new Panel();
            button10 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            panel4 = new Panel();
            panel3 = new Panel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel5 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button11 = new Button();
            JobOrderHistoryView = new DataGridView();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)JobOrderHistoryView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 67, 89);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 36);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 3;
            label1.Text = "Sales history";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.FromArgb(11, 67, 89);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1154, 4);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(4, 0, 0, 9);
            btnClose.Size = new Size(22, 28);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(3, 83, 115);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 35);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1184, 54);
            panel2.TabIndex = 1;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = Color.White;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.TopCenter;
            button10.Location = new Point(151, 3);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(84, 49);
            button10.TabIndex = 8;
            button10.Text = "dd/mm/yyyy";
            button10.TextAlign = ContentAlignment.BottomCenter;
            button10.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.ForeColor = Color.Gray;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "POS", "POS", "POS" });
            listBox1.Location = new Point(9, 31);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(101, 19);
            listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(9, 7);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 16);
            textBox1.TabIndex = 2;
            textBox1.Text = "Document no.";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(819, 2);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(2, 41);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(416, 2);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 41);
            panel3.TabIndex = 2;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.TopCenter;
            button9.Location = new Point(904, 2);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(64, 50);
            button9.TabIndex = 3;
            button9.Text = "Delete";
            button9.TextAlign = ContentAlignment.BottomCenter;
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.TopCenter;
            button8.Location = new Point(836, 2);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(64, 50);
            button8.TabIndex = 3;
            button8.Text = "Refund";
            button8.TextAlign = ContentAlignment.BottomCenter;
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.TopCenter;
            button7.Location = new Point(729, 2);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(75, 51);
            button7.TabIndex = 3;
            button7.Text = "Send email";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(662, 2);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(64, 51);
            button6.TabIndex = 7;
            button6.Text = "Receipt";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(582, 2);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(75, 51);
            button5.TabIndex = 6;
            button5.Text = "Save as pdf";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(513, 4);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(64, 49);
            button4.TabIndex = 5;
            button4.Text = "Print";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(443, 1);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(65, 52);
            button3.TabIndex = 4;
            button3.Text = "Customer";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(308, 4);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(92, 49);
            button2.TabIndex = 3;
            button2.Text = "Show all users";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(239, 3);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(64, 50);
            button1.TabIndex = 2;
            button1.Text = "Refresh";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(11, 67, 89);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(button11);
            panel5.Location = new Point(0, 527);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1184, 65);
            panel5.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(116, 41);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(51, 16);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(116, 13);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(51, 16);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 39);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 4;
            label3.Text = "Total amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 12);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "Documents count:";
            // 
            // button11
            // 
            button11.BackColor = Color.Red;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.White;
            button11.Location = new Point(1087, 18);
            button11.Margin = new Padding(2);
            button11.Name = "button11";
            button11.Size = new Size(75, 35);
            button11.TabIndex = 3;
            button11.Text = "Close";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // JobOrderHistoryView
            // 
            JobOrderHistoryView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            JobOrderHistoryView.BackgroundColor = Color.White;
            JobOrderHistoryView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JobOrderHistoryView.Location = new Point(0, 111);
            JobOrderHistoryView.Margin = new Padding(2);
            JobOrderHistoryView.Name = "JobOrderHistoryView";
            JobOrderHistoryView.RowHeadersWidth = 51;
            JobOrderHistoryView.RowTemplate.Height = 29;
            JobOrderHistoryView.Size = new Size(1184, 193);
            JobOrderHistoryView.TabIndex = 3;
            JobOrderHistoryView.CellContentClick += JobOrderHistoryView_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 326);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1184, 201);
            dataGridView2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 4);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 5;
            label4.Text = "Documents";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(90, 126, 140);
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(2, 307);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 19);
            label5.TabIndex = 6;
            label5.Text = "Document items";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(90, 126, 140);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(0, 89);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(1184, 23);
            panel6.TabIndex = 7;
            panel6.Paint += panel6_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(90, 126, 140);
            panel7.Location = new Point(0, 302);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(1184, 24);
            panel7.TabIndex = 8;
            panel7.Paint += panel7_Paint;
            // 
            // View_sales_history
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1184, 590);
            Controls.Add(panel6);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(JobOrderHistoryView);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "View_sales_history";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_sales_history";
            Load += View_sales_history_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)JobOrderHistoryView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnClose;
        private Label label1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button9;
        private Button button8;
        private Panel panel4;
        private Panel panel3;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button10;
        private Panel panel5;
        private Label label2;
        private Button button11;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private DataGridView JobOrderHistoryView;
        private DataGridView dataGridView2;
        private Label label4;
        private Label label5;
        private Panel panel6;
        private Panel panel7;
    }
}