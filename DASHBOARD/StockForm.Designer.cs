namespace Service_Management_System.DASHBOARD
{
    partial class StockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            sidebar_addproducts = new System.Windows.Forms.Timer(components);
            Details = new Guna.UI2.WinForms.Guna2Elipse(components);
            StockControl = new Guna.UI2.WinForms.Guna2Elipse(components);
            Upper_timer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            textBox7 = new TextBox();
            productBtn = new Button();
            ServiceBtn = new Button();
            SPView = new DataGridView();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label11 = new Label();
            panel5 = new Panel();
            label9 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dgv_sidepanel = new Guna.UI2.WinForms.Guna2Elipse(components);
            pictureBox1 = new PictureBox();
            searchbar = new Guna.UI2.WinForms.Guna2Elipse(components);
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SPView).BeginInit();
            guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // sidebar_addproducts
            // 
            sidebar_addproducts.Interval = 2;
            // 
            // Details
            // 
            Details.BorderRadius = 25;
            // 
            // StockControl
            // 
            StockControl.BorderRadius = 25;
            // 
            // Upper_timer
            // 
            Upper_timer.Interval = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 1;
            label1.Text = "Stock";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 83, 115);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 46);
            panel1.TabIndex = 30;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox7.BackColor = Color.FromArgb(224, 224, 224);
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.ForeColor = Color.Gray;
            textBox7.Location = new Point(304, 135);
            textBox7.Margin = new Padding(2);
            textBox7.MaximumSize = new Size(807, 37);
            textBox7.MinimumSize = new Size(544, 37);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(544, 37);
            textBox7.TabIndex = 29;
            textBox7.Text = "Search";
            // 
            // productBtn
            // 
            productBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            productBtn.BackColor = Color.FromArgb(3, 83, 115);
            productBtn.FlatAppearance.BorderSize = 0;
            productBtn.FlatStyle = FlatStyle.Flat;
            productBtn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productBtn.ForeColor = Color.White;
            productBtn.Location = new Point(854, 135);
            productBtn.Margin = new Padding(4);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(114, 35);
            productBtn.TabIndex = 28;
            productBtn.Text = "Products";
            productBtn.UseVisualStyleBackColor = false;
            // 
            // ServiceBtn
            // 
            ServiceBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ServiceBtn.BackColor = Color.FromArgb(3, 83, 115);
            ServiceBtn.FlatAppearance.BorderSize = 0;
            ServiceBtn.FlatStyle = FlatStyle.Flat;
            ServiceBtn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ServiceBtn.ForeColor = Color.White;
            ServiceBtn.Location = new Point(979, 135);
            ServiceBtn.Margin = new Padding(4);
            ServiceBtn.Name = "ServiceBtn";
            ServiceBtn.Size = new Size(114, 35);
            ServiceBtn.TabIndex = 27;
            ServiceBtn.Text = "Services";
            ServiceBtn.UseVisualStyleBackColor = false;
            // 
            // SPView
            // 
            SPView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SPView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SPView.BackgroundColor = Color.White;
            SPView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SPView.GridColor = Color.Gray;
            SPView.Location = new Point(304, 178);
            SPView.Margin = new Padding(4);
            SPView.MaximumSize = new Size(1357, 722);
            SPView.MinimumSize = new Size(789, 630);
            SPView.Name = "SPView";
            SPView.RowHeadersWidth = 51;
            SPView.RowTemplate.Height = 25;
            SPView.Size = new Size(789, 630);
            SPView.TabIndex = 26;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BackColor = Color.White;
            guna2CustomGradientPanel1.Controls.Add(dataGridView1);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel1.Location = new Point(15, 135);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel1.Size = new Size(282, 765);
            guna2CustomGradientPanel1.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(282, 765);
            dataGridView1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.Controls.Add(label11);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(1097, 76);
            panel2.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(730, 45);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 27;
            label11.Text = "0";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Green;
            panel5.Controls.Add(label9);
            panel5.Location = new Point(999, 39);
            panel5.Name = "panel5";
            panel5.Size = new Size(81, 34);
            panel5.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(30, 8);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 26;
            label9.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(3, 83, 115);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(914, 38);
            panel4.Name = "panel4";
            panel4.Size = new Size(81, 34);
            panel4.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(30, 8);
            label8.Name = "label8";
            label8.Size = new Size(17, 20);
            label8.TabIndex = 26;
            label8.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(827, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(81, 34);
            panel3.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(32, 7);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 27;
            label10.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(30, 8);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 26;
            label7.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(609, 47);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 25;
            label6.Text = "Product count:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1876, 44);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 24;
            label5.Text = "0";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1876, 18);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 23;
            label4.Text = "0";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1751, 44);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 22;
            label3.Text = "Service count:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1751, 18);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 21;
            label2.Text = "Product count:";
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(321, 3);
            button4.Name = "button4";
            button4.Size = new Size(177, 66);
            button4.TabIndex = 17;
            button4.Text = "inventory count report";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(219, 3);
            button3.Name = "button3";
            button3.Size = new Size(96, 66);
            button3.TabIndex = 16;
            button3.Text = "Save as PDF";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(117, 6);
            button2.Name = "button2";
            button2.Size = new Size(96, 66);
            button2.TabIndex = 15;
            button2.Text = "Excel";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
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
            button1.Size = new Size(99, 66);
            button1.TabIndex = 14;
            button1.Text = "Refresh";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // dgv_sidepanel
            // 
            dgv_sidepanel.BorderRadius = 18;
            dgv_sidepanel.TargetControl = dataGridView1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(812, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // searchbar
            // 
            searchbar.BorderRadius = 25;
            searchbar.TargetControl = textBox7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(512, 812);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(102, 28);
            label12.TabIndex = 34;
            label12.Text = "Cost Price";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(805, 812);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(99, 28);
            label13.TabIndex = 35;
            label13.Text = "Sale Price";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(512, 845);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(76, 20);
            label14.TabIndex = 36;
            label14.Text = "Total Cost:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(512, 865);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(126, 20);
            label15.TabIndex = 37;
            label15.Text = "Total Cost inc. Tax:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(812, 865);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(93, 20);
            label16.TabIndex = 39;
            label16.Text = "Total inc. Tax:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(812, 845);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(43, 20);
            label17.TabIndex = 38;
            label17.Text = "Total:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.Black;
            label18.Location = new Point(662, 845);
            label18.Name = "label18";
            label18.Size = new Size(17, 20);
            label18.TabIndex = 40;
            label18.Text = "0";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Black;
            label19.Location = new Point(662, 865);
            label19.Name = "label19";
            label19.Size = new Size(17, 20);
            label19.TabIndex = 41;
            label19.Text = "0";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.Black;
            label20.Location = new Point(930, 845);
            label20.Name = "label20";
            label20.Size = new Size(17, 20);
            label20.TabIndex = 42;
            label20.Text = "0";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.Black;
            label21.Location = new Point(930, 865);
            label21.Name = "label21";
            label21.Size = new Size(17, 20);
            label21.TabIndex = 43;
            label21.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(812, 141);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1097, 906);
            Controls.Add(pictureBox3);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(panel1);
            Controls.Add(textBox7);
            Controls.Add(productBtn);
            Controls.Add(ServiceBtn);
            Controls.Add(SPView);
            Controls.Add(guna2CustomGradientPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "StockForm";
            Text = "StockForm";
            Load += StockForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)SPView).EndInit();
            guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer sidebar_addproducts;
        private Guna.UI2.WinForms.Guna2Elipse Details;
        private Guna.UI2.WinForms.Guna2Elipse StockControl;
        private System.Windows.Forms.Timer Upper_timer;
        private Label label1;
        private Panel panel1;
        private TextBox textBox7;
        private Button productBtn;
        private Button ServiceBtn;
        private DataGridView SPView;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Guna.UI2.WinForms.Guna2Elipse dgv_sidepanel;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse searchbar;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private Label label11;
        private Panel panel5;
        private Label label9;
        private Panel panel4;
        private Label label8;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private PictureBox pictureBox2;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private PictureBox pictureBox3;
    }
}