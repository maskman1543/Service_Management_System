﻿namespace Service_Management_System.Registration
{
    partial class acctRegistration_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acctRegistration_form));
            panel1 = new Panel();
            button3 = new Button();
            label14 = new Label();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            LastNameValue = new TextBox();
            FirstNameValue = new TextBox();
            label6 = new Label();
            phoneNumberValue = new TextBox();
            EmailValue = new TextBox();
            label7 = new Label();
            label8 = new Label();
            passwordValue = new TextBox();
            label10 = new Label();
            confirmPasswordValue = new TextBox();
            label11 = new Label();
            button2 = new Button();
            label12 = new Label();
            checkBox1 = new CheckBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 83, 115);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 548);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(191, 311);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Gainsboro;
            label14.Location = new Point(41, 206);
            label14.Name = "label14";
            label14.Size = new Size(230, 21);
            label14.TabIndex = 4;
            label14.Text = "Service Management System";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Brush Script MT", 48F, FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(0, 142);
            label13.Name = "label13";
            label13.Size = new Size(307, 79);
            label13.TabIndex = 3;
            label13.Text = "Service Flow";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 22);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 131);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(98, 428);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 1;
            label1.Text = "SIGN IN HERE";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(41, 448);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(230, 37);
            button1.TabIndex = 0;
            button1.Text = "SIGN IN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(3, 83, 115);
            label2.Location = new Point(403, 45);
            label2.Name = "label2";
            label2.Size = new Size(313, 35);
            label2.TabIndex = 2;
            label2.Text = "ACCOUNT REGISTRATION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(353, 118);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 3;
            label3.Text = "Personal Info";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(373, 190);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 4;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(373, 161);
            label5.Name = "label5";
            label5.Size = new Size(72, 17);
            label5.TabIndex = 5;
            label5.Text = "First Name";
            // 
            // LastNameValue
            // 
            LastNameValue.Cursor = Cursors.IBeam;
            LastNameValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameValue.Location = new Point(458, 186);
            LastNameValue.Margin = new Padding(3, 2, 3, 2);
            LastNameValue.Name = "LastNameValue";
            LastNameValue.Size = new Size(254, 26);
            LastNameValue.TabIndex = 6;
            // 
            // FirstNameValue
            // 
            FirstNameValue.Cursor = Cursors.IBeam;
            FirstNameValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameValue.Location = new Point(458, 157);
            FirstNameValue.Margin = new Padding(3, 2, 3, 2);
            FirstNameValue.Name = "FirstNameValue";
            FirstNameValue.Size = new Size(254, 26);
            FirstNameValue.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(353, 244);
            label6.Name = "label6";
            label6.Size = new Size(134, 23);
            label6.TabIndex = 8;
            label6.Text = "Contact Details";
            // 
            // phoneNumberValue
            // 
            phoneNumberValue.Cursor = Cursors.IBeam;
            phoneNumberValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumberValue.Location = new Point(586, 302);
            phoneNumberValue.Margin = new Padding(3, 2, 3, 2);
            phoneNumberValue.Name = "phoneNumberValue";
            phoneNumberValue.Size = new Size(206, 26);
            phoneNumberValue.TabIndex = 12;
            // 
            // EmailValue
            // 
            EmailValue.Cursor = Cursors.IBeam;
            EmailValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmailValue.Location = new Point(353, 302);
            EmailValue.Margin = new Padding(3, 2, 3, 2);
            EmailValue.Name = "EmailValue";
            EmailValue.Size = new Size(220, 26);
            EmailValue.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(643, 284);
            label7.Name = "label7";
            label7.Size = new Size(100, 17);
            label7.TabIndex = 10;
            label7.Text = "Phone Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(431, 284);
            label8.Name = "label8";
            label8.Size = new Size(39, 17);
            label8.TabIndex = 9;
            label8.Text = "Email";
            // 
            // passwordValue
            // 
            passwordValue.Cursor = Cursors.IBeam;
            passwordValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordValue.Location = new Point(127, 28);
            passwordValue.Margin = new Padding(3, 2, 3, 2);
            passwordValue.Name = "passwordValue";
            passwordValue.Size = new Size(220, 26);
            passwordValue.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(130, 10);
            label10.Name = "label10";
            label10.Size = new Size(66, 17);
            label10.TabIndex = 15;
            label10.Text = "Password";
            // 
            // confirmPasswordValue
            // 
            confirmPasswordValue.Cursor = Cursors.IBeam;
            confirmPasswordValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordValue.Location = new Point(127, 77);
            confirmPasswordValue.Margin = new Padding(3, 2, 3, 2);
            confirmPasswordValue.Name = "confirmPasswordValue";
            confirmPasswordValue.Size = new Size(220, 26);
            confirmPasswordValue.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(130, 59);
            label11.Name = "label11";
            label11.Size = new Size(118, 17);
            label11.TabIndex = 17;
            label11.Text = "Confirm Password";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(3, 83, 115);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(130, 137);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(211, 28);
            button2.TabIndex = 2;
            button2.Text = "SIGN UP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(798, 0);
            label12.Name = "label12";
            label12.Size = new Size(18, 19);
            label12.TabIndex = 2;
            label12.Text = "X";
            label12.Click += label12_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(231, 103);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(passwordValue);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(confirmPasswordValue);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(331, 358);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(486, 190);
            panel2.TabIndex = 3;
            // 
            // acctRegistration_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 548);
            Controls.Add(panel2);
            Controls.Add(label12);
            Controls.Add(phoneNumberValue);
            Controls.Add(EmailValue);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(FirstNameValue);
            Controls.Add(LastNameValue);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "acctRegistration_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "acctRegistration_form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox LastNameValue;
        private TextBox FirstNameValue;
        private Label label6;
        private TextBox phoneNumberValue;
        private TextBox EmailValue;
        private Label label7;
        private Label label8;
        private TextBox passwordValue;
        private Label label10;
        private TextBox confirmPasswordValue;
        private Label label11;
        private Button button2;
        private Label label12;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label14;
        private Label label13;
        private Button button3;
    }
}