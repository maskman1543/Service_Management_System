﻿namespace Service_Management_System.DASHBOARD
{
    partial class stockControl_form
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
            textBox3 = new TextBox();
            label8 = new Label();
            textBox2 = new TextBox();
            btnCode = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnsave = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(3, 83, 115);
            textBox3.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(10, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 30);
            textBox3.TabIndex = 15;
            textBox3.Text = "0";
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(10, 156);
            label8.Name = "label8";
            label8.Size = new Size(141, 20);
            label8.TabIndex = 14;
            label8.Text = "Preffered quantity";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(3, 83, 115);
            textBox2.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(12, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 30);
            textBox2.TabIndex = 13;
            textBox2.Text = "0";
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCode
            // 
            btnCode.AutoSize = true;
            btnCode.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCode.ForeColor = Color.White;
            btnCode.Location = new Point(12, 86);
            btnCode.Name = "btnCode";
            btnCode.Size = new Size(104, 20);
            btnCode.TabIndex = 12;
            btnCode.Text = "Reader point";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 16;
            label1.Text = "Supplier";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(3, 83, 115);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(310, 28);
            comboBox1.TabIndex = 17;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderColor = Color.White;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 28;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(279, 630);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 0, 0);
            iconButton1.Size = new Size(137, 43);
            iconButton1.TabIndex = 19;
            iconButton1.Text = "Cancel";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            btnsave.FlatAppearance.BorderColor = Color.White;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnsave.ForeColor = Color.White;
            btnsave.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnsave.IconColor = Color.White;
            btnsave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsave.IconSize = 28;
            btnsave.ImageAlign = ContentAlignment.MiddleLeft;
            btnsave.Location = new Point(139, 630);
            btnsave.Name = "btnsave";
            btnsave.Padding = new Padding(10, 0, 0, 0);
            btnsave.Size = new Size(137, 43);
            btnsave.TabIndex = 18;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            // 
            // stockControl_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 83, 115);
            ClientSize = new Size(425, 685);
            Controls.Add(iconButton1);
            Controls.Add(btnsave);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(btnCode);
            FormBorderStyle = FormBorderStyle.None;
            Name = "stockControl_form";
            Text = "stockControl_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label8;
        private TextBox textBox2;
        private Label btnCode;
        private Label label1;
        private ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnsave;
    }
}