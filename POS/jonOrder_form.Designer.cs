namespace Service_Management_System.POS
{
    partial class jonOrder_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jonOrder_form));
            FirstNameValue = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            name = new Guna.UI2.WinForms.Guna2Elipse(components);
            Elipse1Phone = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2ElipseVehicle = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2ElipsePlate = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnContiue = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnCancel = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // FirstNameValue
            // 
            FirstNameValue.Cursor = Cursors.IBeam;
            FirstNameValue.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameValue.ForeColor = Color.Silver;
            FirstNameValue.Location = new Point(178, 176);
            FirstNameValue.Name = "FirstNameValue";
            FirstNameValue.Size = new Size(350, 28);
            FirstNameValue.TabIndex = 8;
            FirstNameValue.Text = "Customer name";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(178, 213);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 28);
            textBox1.TabIndex = 9;
            textBox1.Text = "Phone no.";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Silver;
            textBox2.Location = new Point(178, 249);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 28);
            textBox2.TabIndex = 10;
            textBox2.Text = "Vehicle type";
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Silver;
            textBox3.Location = new Point(178, 285);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(350, 28);
            textBox3.TabIndex = 11;
            textBox3.Text = "Plate no.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(133, 119);
            label1.Name = "label1";
            label1.Size = new Size(458, 44);
            label1.TabIndex = 12;
            label1.Text = "Order or customer name";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(237, 329);
            button1.Name = "button1";
            button1.Size = new Size(104, 37);
            button1.TabIndex = 13;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(347, 329);
            button2.Name = "button2";
            button2.Size = new Size(104, 37);
            button2.TabIndex = 14;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(304, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // name
            // 
            name.BorderRadius = 10;
            name.TargetControl = FirstNameValue;
            // 
            // Elipse1Phone
            // 
            Elipse1Phone.BorderRadius = 10;
            Elipse1Phone.TargetControl = textBox1;
            // 
            // guna2ElipseVehicle
            // 
            guna2ElipseVehicle.BorderRadius = 10;
            guna2ElipseVehicle.TargetControl = textBox2;
            // 
            // guna2ElipsePlate
            // 
            guna2ElipsePlate.BorderRadius = 10;
            guna2ElipsePlate.TargetControl = textBox3;
            // 
            // btnContiue
            // 
            btnContiue.BorderRadius = 10;
            btnContiue.TargetControl = button1;
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 10;
            btnCancel.TargetControl = button2;
            // 
            // jonOrder_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 83, 115);
            ClientSize = new Size(672, 435);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(FirstNameValue);
            FormBorderStyle = FormBorderStyle.None;
            Name = "jonOrder_form";
            Text = "jonOrder_form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstNameValue;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse name;
        private Guna.UI2.WinForms.Guna2Elipse Elipse1Phone;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseVehicle;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipsePlate;
        private Guna.UI2.WinForms.Guna2Elipse btnContiue;
        private Guna.UI2.WinForms.Guna2Elipse btnCancel;
    }
}