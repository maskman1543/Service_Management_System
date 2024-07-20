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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsServicesForm));
            label1 = new Label();
            PSView = new DataGridView();
            ServiceBtn = new Button();
            productBtn = new Button();
            textBox7 = new TextBox();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            searchbar = new Guna.UI2.WinForms.Guna2Elipse(components);
            pictureBox1 = new PictureBox();
            dgv_sidepanel = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel3 = new Panel();
            panelpro_service = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnsave = new FontAwesome.Sharp.IconButton();
            textBox6 = new TextBox();
            label12 = new Label();
            textBox5 = new TextBox();
            label11 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox2 = new TextBox();
            btnCode = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            panel5 = new Panel();
            button8 = new Button();
            pictureBox2 = new PictureBox();
            btnDetails = new Button();
            label6 = new Label();
            btnStockControl = new Button();
            panel4 = new Panel();
            Details = new Guna.UI2.WinForms.Guna2Elipse(components);
            StockControl = new Guna.UI2.WinForms.Guna2Elipse(components);
            sidebar_addproducts = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)PSView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panelpro_service.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
            label1.TabIndex = 1;
            label1.Text = "Products and Services";
            label1.Click += label1_Click;
            // 
            // PSView
            // 
            PSView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PSView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PSView.BackgroundColor = Color.White;
            PSView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PSView.GridColor = Color.Gray;
            PSView.Location = new Point(304, 171);
            PSView.Margin = new Padding(4);
            PSView.MaximumSize = new Size(1357, 722);
            PSView.MinimumSize = new Size(789, 722);
            PSView.Name = "PSView";
            PSView.RowHeadersWidth = 51;
            PSView.RowTemplate.Height = 25;
            PSView.Size = new Size(789, 722);
            PSView.TabIndex = 2;
            PSView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ServiceBtn
            // 
            ServiceBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ServiceBtn.BackColor = Color.FromArgb(3, 83, 115);
            ServiceBtn.FlatAppearance.BorderSize = 0;
            ServiceBtn.FlatStyle = FlatStyle.Flat;
            ServiceBtn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ServiceBtn.ForeColor = Color.White;
            ServiceBtn.Location = new Point(979, 128);
            ServiceBtn.Margin = new Padding(4);
            ServiceBtn.Name = "ServiceBtn";
            ServiceBtn.Size = new Size(114, 35);
            ServiceBtn.TabIndex = 3;
            ServiceBtn.Text = "Services";
            ServiceBtn.UseVisualStyleBackColor = false;
            ServiceBtn.Click += button1_Click;
            // 
            // productBtn
            // 
            productBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            productBtn.BackColor = Color.FromArgb(3, 83, 115);
            productBtn.FlatAppearance.BorderSize = 0;
            productBtn.FlatStyle = FlatStyle.Flat;
            productBtn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productBtn.ForeColor = Color.White;
            productBtn.Location = new Point(854, 128);
            productBtn.Margin = new Padding(4);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(114, 35);
            productBtn.TabIndex = 4;
            productBtn.Text = "Products";
            productBtn.UseVisualStyleBackColor = false;
            productBtn.Click += productBtn_Click;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox7.BackColor = Color.FromArgb(224, 224, 224);
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.ForeColor = Color.Gray;
            textBox7.Location = new Point(304, 128);
            textBox7.Margin = new Padding(2);
            textBox7.MaximumSize = new Size(807, 37);
            textBox7.MinimumSize = new Size(544, 37);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(544, 37);
            textBox7.TabIndex = 11;
            textBox7.Text = "Search";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 83, 115);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 46);
            panel1.TabIndex = 12;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(3, 83, 115);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.HandHolding;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(19, -1);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BackColor = Color.White;
            guna2CustomGradientPanel1.Controls.Add(dataGridView1);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel1.Location = new Point(15, 128);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel1.Size = new Size(282, 765);
            guna2CustomGradientPanel1.TabIndex = 13;
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
            button2.Text = "New Group";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(1097, 76);
            panel2.TabIndex = 14;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(979, 44);
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
            label4.Location = new Point(979, 18);
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
            label3.Location = new Point(854, 44);
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
            label2.Location = new Point(854, 18);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 21;
            label2.Text = "Product count:";
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.TopCenter;
            button7.Location = new Point(644, 3);
            button7.Name = "button7";
            button7.Size = new Size(114, 66);
            button7.TabIndex = 20;
            button7.Text = "Delete Product";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(542, 3);
            button6.Name = "button6";
            button6.Size = new Size(96, 66);
            button6.TabIndex = 19;
            button6.Text = "Edit Product";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(431, 3);
            button5.Name = "button5";
            button5.Size = new Size(105, 66);
            button5.TabIndex = 18;
            button5.Text = "Add Product";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
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
            button4.Size = new Size(104, 66);
            button4.TabIndex = 17;
            button4.Text = "Delete Group";
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
            button3.Text = "Edit Group";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // searchbar
            // 
            searchbar.BorderRadius = 25;
            searchbar.TargetControl = textBox7;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(812, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // dgv_sidepanel
            // 
            dgv_sidepanel.BorderRadius = 18;
            dgv_sidepanel.TargetControl = dataGridView1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(3, 83, 115);
            panel3.Controls.Add(panelpro_service);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1097, 122);
            panel3.MaximumSize = new Size(425, 784);
            panel3.MinimumSize = new Size(0, 784);
            panel3.Name = "panel3";
            panel3.Size = new Size(0, 784);
            panel3.TabIndex = 25;
            panel3.Paint += panel3_Paint;
            // 
            // panelpro_service
            // 
            panelpro_service.Controls.Add(iconButton1);
            panelpro_service.Controls.Add(btnsave);
            panelpro_service.Controls.Add(textBox6);
            panelpro_service.Controls.Add(label12);
            panelpro_service.Controls.Add(textBox5);
            panelpro_service.Controls.Add(label11);
            panelpro_service.Controls.Add(textBox4);
            panelpro_service.Controls.Add(label10);
            panelpro_service.Controls.Add(comboBox1);
            panelpro_service.Controls.Add(label9);
            panelpro_service.Controls.Add(textBox3);
            panelpro_service.Controls.Add(label8);
            panelpro_service.Controls.Add(textBox2);
            panelpro_service.Controls.Add(btnCode);
            panelpro_service.Controls.Add(textBox1);
            panelpro_service.Controls.Add(label7);
            panelpro_service.Dock = DockStyle.Fill;
            panelpro_service.Location = new Point(0, 99);
            panelpro_service.Name = "panelpro_service";
            panelpro_service.Size = new Size(0, 685);
            panelpro_service.TabIndex = 6;
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
            iconButton1.Location = new Point(284, 629);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 0, 0);
            iconButton1.Size = new Size(137, 43);
            iconButton1.TabIndex = 15;
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
            btnsave.Location = new Point(144, 629);
            btnsave.Name = "btnsave";
            btnsave.Padding = new Padding(10, 0, 0, 0);
            btnsave.Size = new Size(137, 43);
            btnsave.TabIndex = 14;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(3, 83, 115);
            textBox6.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(14, 249);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 30);
            textBox6.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(14, 226);
            label12.Name = "label12";
            label12.Size = new Size(160, 20);
            label12.TabIndex = 12;
            label12.Text = "Unit of measurement";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(3, 83, 115);
            textBox5.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(15, 439);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(401, 116);
            textBox5.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(15, 416);
            label11.Name = "label11";
            label11.Size = new Size(91, 20);
            label11.TabIndex = 10;
            label11.Text = "Description";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(3, 83, 115);
            textBox4.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(12, 373);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(401, 30);
            textBox4.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(12, 350);
            label10.Name = "label10";
            label10.Size = new Size(115, 20);
            label10.TabIndex = 8;
            label10.Text = "Age restriction";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(3, 83, 115);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 314);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(310, 28);
            comboBox1.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(13, 291);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 6;
            label9.Text = "Group";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(3, 83, 115);
            textBox3.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(13, 178);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(401, 30);
            textBox3.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 155);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 4;
            label8.Text = "Barcode";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(3, 83, 115);
            textBox2.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(15, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 30);
            textBox2.TabIndex = 3;
            // 
            // btnCode
            // 
            btnCode.AutoSize = true;
            btnCode.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCode.ForeColor = Color.White;
            btnCode.Location = new Point(15, 85);
            btnCode.Name = "btnCode";
            btnCode.Size = new Size(51, 20);
            btnCode.TabIndex = 2;
            btnCode.Text = "Code";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(3, 83, 115);
            textBox1.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(14, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 30);
            textBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 17);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 0;
            label7.Text = "Name";
            // 
            // panel5
            // 
            panel5.Controls.Add(button8);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(btnDetails);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(btnStockControl);
            panel5.Controls.Add(panel4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(0, 99);
            panel5.TabIndex = 5;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatAppearance.BorderColor = Color.White;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.FromArgb(3, 83, 115);
            button8.Location = new Point(7, 62);
            button8.Name = "button8";
            button8.Size = new Size(132, 31);
            button8.TabIndex = 5;
            button8.Text = "Details";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(376, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.White;
            btnDetails.FlatAppearance.BorderColor = Color.White;
            btnDetails.FlatAppearance.BorderSize = 0;
            btnDetails.FlatStyle = FlatStyle.Flat;
            btnDetails.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetails.ForeColor = Color.FromArgb(3, 83, 115);
            btnDetails.Location = new Point(140, 62);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(141, 31);
            btnDetails.TabIndex = 3;
            btnDetails.Text = "Price and Tax";
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 16);
            label6.Name = "label6";
            label6.Size = new Size(247, 23);
            label6.TabIndex = 0;
            label6.Text = "New products / services";
            // 
            // btnStockControl
            // 
            btnStockControl.BackColor = Color.White;
            btnStockControl.FlatAppearance.BorderColor = Color.White;
            btnStockControl.FlatAppearance.BorderSize = 0;
            btnStockControl.FlatStyle = FlatStyle.Flat;
            btnStockControl.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnStockControl.ForeColor = Color.FromArgb(3, 83, 115);
            btnStockControl.Location = new Point(282, 62);
            btnStockControl.Name = "btnStockControl";
            btnStockControl.Size = new Size(132, 31);
            btnStockControl.TabIndex = 4;
            btnStockControl.Text = "Stock control";
            btnStockControl.UseVisualStyleBackColor = false;
            btnStockControl.Click += btnStockControl_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(2, 95);
            panel4.Name = "panel4";
            panel4.Size = new Size(425, 2);
            panel4.TabIndex = 2;
            // 
            // Details
            // 
            Details.BorderRadius = 25;
            // 
            // StockControl
            // 
            StockControl.BorderRadius = 25;
            // 
            // sidebar_addproducts
            // 
            sidebar_addproducts.Interval = 2;
            sidebar_addproducts.Tick += sidebar_addproducts_Tick;
            // 
            // ProductsServicesForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1097, 906);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(guna2CustomGradientPanel1);
            Controls.Add(panel1);
            Controls.Add(textBox7);
            Controls.Add(productBtn);
            Controls.Add(ServiceBtn);
            Controls.Add(PSView);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ProductsServicesForm";
            Text = "ProductsServicesForm";
            ((System.ComponentModel.ISupportInitialize)PSView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panelpro_service.ResumeLayout(false);
            panelpro_service.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView PSView;
        private Button ServiceBtn;
        private Button productBtn;
        private TextBox textBox7;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Guna.UI2.WinForms.Guna2Elipse searchbar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Elipse dgv_sidepanel;
        private Panel panel3;
        private Label label6;
        private Button btnDetails;
        private Panel panel4;
        private Button btnStockControl;
        private Guna.UI2.WinForms.Guna2Elipse Details;
        private Guna.UI2.WinForms.Guna2Elipse StockControl;
        private Panel panel5;
        private Panel panelpro_service;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer sidebar_addproducts;
        private Button button8;
        private TextBox textBox1;
        private Label label7;
        private ComboBox comboBox1;
        private Label label9;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox2;
        private Label btnCode;
        private TextBox textBox4;
        private Label label10;
        private TextBox textBox6;
        private Label label12;
        private TextBox textBox5;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnsave;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}