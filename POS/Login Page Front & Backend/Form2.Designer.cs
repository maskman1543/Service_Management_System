namespace Service_Management_System.POS.Login_Page_Front___Backend
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            groupBox1 = new GroupBox();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(512, 804);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Red;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.ForeColor = Color.White;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(212, 641);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(75, 25);
            linkLabel2.TabIndex = 4;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Sign Up";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(180, 682);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(146, 25);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password";
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(87, 574);
            button1.Name = "button1";
            button1.Size = new Size(331, 46);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.Control;
            checkBox1.Location = new Point(87, 512);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(187, 32);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "  Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(87, 436);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(331, 43);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Roboto", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(87, 390);
            label2.Name = "label2";
            label2.Size = new Size(124, 30);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(87, 326);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 43);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Roboto", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(87, 280);
            label1.Name = "label1";
            label1.Size = new Size(126, 30);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 828);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Button button1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}