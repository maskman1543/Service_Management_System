namespace Service_Management_System.POS
{
    partial class endofDay_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(endofDay_form));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnsave = new FontAwesome.Sharp.IconButton();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 83, 115);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1480, 49);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(60, 12);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 18;
            label2.Text = "End of day";
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(1480, 61);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(3, 83, 115);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(203, 15);
            button1.Name = "button1";
            button1.Size = new Size(196, 37);
            button1.TabIndex = 4;
            button1.Text = "History";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(3, 83, 115);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(9, 15);
            button2.Name = "button2";
            button2.Size = new Size(196, 37);
            button2.TabIndex = 3;
            button2.Text = "End of day";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(btnsave);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(1480, 627);
            panel3.TabIndex = 2;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(3, 83, 115);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.FromArgb(3, 83, 115);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton1.IconColor = Color.FromArgb(3, 83, 115);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 28;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(1314, 572);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 0, 0);
            iconButton1.Size = new Size(148, 43);
            iconButton1.TabIndex = 17;
            iconButton1.Text = "Cancel";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // btnsave
            // 
            btnsave.FlatAppearance.BorderColor = Color.FromArgb(3, 83, 115);
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnsave.ForeColor = Color.FromArgb(3, 83, 115);
            btnsave.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnsave.IconColor = Color.FromArgb(3, 83, 115);
            btnsave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsave.IconSize = 28;
            btnsave.ImageAlign = ContentAlignment.MiddleLeft;
            btnsave.Location = new Point(1160, 572);
            btnsave.Name = "btnsave";
            btnsave.Padding = new Padding(10, 0, 0, 0);
            btnsave.Size = new Size(148, 43);
            btnsave.TabIndex = 16;
            btnsave.Text = "Continue";
            btnsave.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(3, 83, 115);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(1252, 89);
            button6.Name = "button6";
            button6.Size = new Size(173, 137);
            button6.TabIndex = 4;
            button6.Text = "REPORT";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(3, 83, 115);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(391, 89);
            button5.Name = "button5";
            button5.Size = new Size(173, 137);
            button5.TabIndex = 3;
            button5.Text = "Close register";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(3, 83, 115);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(32, 89);
            button4.Name = "button4";
            button4.Size = new Size(173, 137);
            button4.TabIndex = 2;
            button4.Text = "Cash out";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(3, 83, 115);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(212, 89);
            button3.Name = "button3";
            button3.Size = new Size(173, 137);
            button3.TabIndex = 1;
            button3.Text = "Cash out all users";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(230, 23);
            label1.TabIndex = 0;
            label1.Text = "Select cash out option";
            // 
            // endofDay_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 737);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "endofDay_form";
            Text = "endofDay_form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Panel panel3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnsave;
        private Label label2;
        private PictureBox pictureBox1;
    }
}