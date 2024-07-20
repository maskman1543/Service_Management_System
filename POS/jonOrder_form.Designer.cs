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
            btnContinue = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            name = new Guna.UI2.WinForms.Guna2Elipse(components);
            Elipse1Phone = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2ElipseVehicle = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2ElipsePlate = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnContiue = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnCancel = new Guna.UI2.WinForms.Guna2Elipse(components);
            elipseForm = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // FirstNameValue
            // 
            FirstNameValue.Cursor = Cursors.IBeam;
            FirstNameValue.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameValue.ForeColor = Color.Silver;
            FirstNameValue.Location = new Point(156, 132);
            FirstNameValue.Margin = new Padding(3, 2, 3, 2);
            FirstNameValue.Name = "FirstNameValue";
            FirstNameValue.Size = new Size(307, 24);
            FirstNameValue.TabIndex = 8;
            FirstNameValue.Text = "Customer name";
            FirstNameValue.Enter += FirstNameValue_Enter;
            FirstNameValue.Leave += FirstNameValue_Leave;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(156, 160);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 24);
            textBox1.TabIndex = 9;
            textBox1.Text = "Phone no.";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Silver;
            textBox2.Location = new Point(156, 187);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 24);
            textBox2.TabIndex = 10;
            textBox2.Text = "Vehicle type";
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Silver;
            textBox3.Location = new Point(156, 214);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(307, 24);
            textBox3.TabIndex = 11;
            textBox3.Text = "Plate no.";
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(116, 89);
            label1.Name = "label1";
            label1.Size = new Size(374, 37);
            label1.TabIndex = 12;
            label1.Text = "Order or customer name";
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.FromArgb(0, 192, 0);
            btnContinue.FlatAppearance.BorderSize = 0;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnContinue.ForeColor = Color.White;
            btnContinue.Location = new Point(207, 247);
            btnContinue.Margin = new Padding(3, 2, 3, 2);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(91, 28);
            btnContinue.TabIndex = 13;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(304, 247);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(91, 28);
            button2.TabIndex = 14;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(266, 12);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
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
            btnContiue.TargetControl = btnContinue;
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 10;
            btnCancel.TargetControl = button2;
            // 
            // elipseForm
            // 
            elipseForm.BorderRadius = 20;
            elipseForm.TargetControl = this;
            // 
            // jonOrder_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 83, 115);
            ClientSize = new Size(588, 326);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(btnContinue);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(FirstNameValue);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "jonOrder_form";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private Button btnContinue;
    }
}