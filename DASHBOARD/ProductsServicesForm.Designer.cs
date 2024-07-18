namespace Service_Management_System.DASHBOARD
{
    partial class ProductsServicesForm
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
            label1 = new Label();
            PSView = new DataGridView();
            ServiceBtn = new Button();
            productBtn = new Button();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PSView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 21);
            label1.TabIndex = 1;
            label1.Text = "Products and Services";
            label1.Click += label1_Click;
            // 
            // PSView
            // 
            PSView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PSView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PSView.Location = new Point(12, 128);
            PSView.Name = "PSView";
            PSView.RowTemplate.Height = 25;
            PSView.Size = new Size(696, 596);
            PSView.TabIndex = 2;
            PSView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ServiceBtn
            // 
            ServiceBtn.Location = new Point(633, 99);
            ServiceBtn.Name = "ServiceBtn";
            ServiceBtn.Size = new Size(75, 23);
            ServiceBtn.TabIndex = 3;
            ServiceBtn.Text = "Services";
            ServiceBtn.UseVisualStyleBackColor = true;
            ServiceBtn.Click += button1_Click;
            // 
            // productBtn
            // 
            productBtn.Location = new Point(552, 99);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(75, 23);
            productBtn.TabIndex = 4;
            productBtn.Text = "Products";
            productBtn.UseVisualStyleBackColor = true;
            productBtn.Click += productBtn_Click;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.ForeColor = Color.Gray;
            textBox7.Location = new Point(11, 84);
            textBox7.Margin = new Padding(2);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(400, 38);
            textBox7.TabIndex = 11;
            textBox7.Text = "Search";
            // 
            // ProductsServicesForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(720, 776);
            Controls.Add(textBox7);
            Controls.Add(productBtn);
            Controls.Add(ServiceBtn);
            Controls.Add(PSView);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ProductsServicesForm";
            Text = "ProductsServicesForm";
            ((System.ComponentModel.ISupportInitialize)PSView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView PSView;
        private Button ServiceBtn;
        private Button productBtn;
        private TextBox textBox7;
    }
}