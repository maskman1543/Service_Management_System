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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            panelUpper = new Panel();
            panel7 = new Panel();
            comboBox2 = new ComboBox();
            label20 = new Label();
            textBox12 = new TextBox();
            label21 = new Label();
            textBox13 = new TextBox();
            label22 = new Label();
            label19 = new Label();
            label18 = new Label();
            textBox8 = new TextBox();
            label14 = new Label();
            textBox9 = new TextBox();
            label15 = new Label();
            textBox10 = new TextBox();
            label16 = new Label();
            textBox11 = new TextBox();
            label17 = new Label();
            label13 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnsave = new FontAwesome.Sharp.IconButton();
            textBox6 = new TextBox();
            label12 = new Label();
            DescriptionValue = new TextBox();
            label11 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            BarcodeValue = new TextBox();
            label8 = new Label();
            textBox2 = new TextBox();
            btnCode = new Label();
            ProductNameValue = new TextBox();
            label7 = new Label();
            panel5 = new Panel();
            button8 = new Button();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            panel4 = new Panel();
            Details = new Guna.UI2.WinForms.Guna2Elipse(components);
            StockControl = new Guna.UI2.WinForms.Guna2Elipse(components);
            sidebar_addproducts = new System.Windows.Forms.Timer(components);
            Upper_timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)PSView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panelpro_service.SuspendLayout();
            panelUpper.SuspendLayout();
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
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges3;
            guna2CustomGradientPanel1.Location = new Point(15, 128);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            button6.Click += button6_Click;
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
            panel3.Location = new Point(672, 122);
            panel3.MaximumSize = new Size(425, 784);
            panel3.MinimumSize = new Size(0, 784);
            panel3.Name = "panel3";
            panel3.Size = new Size(425, 784);
            panel3.TabIndex = 25;
            panel3.Paint += panel3_Paint;
            // 
            // panelpro_service
            // 
            panelpro_service.Controls.Add(panelUpper);
            panelpro_service.Controls.Add(label13);
            panelpro_service.Controls.Add(iconButton1);
            panelpro_service.Controls.Add(btnsave);
            panelpro_service.Controls.Add(textBox6);
            panelpro_service.Controls.Add(label12);
            panelpro_service.Controls.Add(DescriptionValue);
            panelpro_service.Controls.Add(label11);
            panelpro_service.Controls.Add(textBox4);
            panelpro_service.Controls.Add(label10);
            panelpro_service.Controls.Add(comboBox1);
            panelpro_service.Controls.Add(label9);
            panelpro_service.Controls.Add(BarcodeValue);
            panelpro_service.Controls.Add(label8);
            panelpro_service.Controls.Add(textBox2);
            panelpro_service.Controls.Add(btnCode);
            panelpro_service.Controls.Add(ProductNameValue);
            panelpro_service.Controls.Add(label7);
            panelpro_service.Dock = DockStyle.Fill;
            panelpro_service.Location = new Point(0, 99);
            panelpro_service.Name = "panelpro_service";
            panelpro_service.Size = new Size(425, 685);
            panelpro_service.TabIndex = 6;
            // 
            // panelUpper
            // 
            panelUpper.Controls.Add(panel7);
            panelUpper.Controls.Add(comboBox2);
            panelUpper.Controls.Add(label20);
            panelUpper.Controls.Add(textBox12);
            panelUpper.Controls.Add(label21);
            panelUpper.Controls.Add(textBox13);
            panelUpper.Controls.Add(label22);
            panelUpper.Controls.Add(label19);
            panelUpper.Controls.Add(label18);
            panelUpper.Controls.Add(textBox8);
            panelUpper.Controls.Add(label14);
            panelUpper.Controls.Add(textBox9);
            panelUpper.Controls.Add(label15);
            panelUpper.Controls.Add(textBox10);
            panelUpper.Controls.Add(label16);
            panelUpper.Controls.Add(textBox11);
            panelUpper.Controls.Add(label17);
            panelUpper.Dock = DockStyle.Top;
            panelUpper.Location = new Point(0, 0);
            panelUpper.MaximumSize = new Size(425, 611);
            panelUpper.MinimumSize = new Size(425, 0);
            panelUpper.Name = "panelUpper";
            panelUpper.Size = new Size(425, 0);
            panelUpper.TabIndex = 17;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(6, 337);
            panel7.Name = "panel7";
            panel7.Size = new Size(425, 3);
            panel7.TabIndex = 31;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(3, 83, 115);
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(22, 432);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(310, 28);
            comboBox2.TabIndex = 37;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(22, 409);
            label20.Name = "label20";
            label20.Size = new Size(66, 20);
            label20.TabIndex = 36;
            label20.Text = "Supplier";
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.FromArgb(3, 83, 115);
            textBox12.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox12.ForeColor = Color.White;
            textBox12.Location = new Point(20, 570);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(127, 30);
            textBox12.TabIndex = 35;
            textBox12.Text = "0";
            textBox12.TextAlign = HorizontalAlignment.Right;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(20, 547);
            label21.Name = "label21";
            label21.Size = new Size(141, 20);
            label21.TabIndex = 34;
            label21.Text = "Preffered quantity";
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.FromArgb(3, 83, 115);
            textBox13.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox13.ForeColor = Color.White;
            textBox13.Location = new Point(22, 500);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(125, 30);
            textBox13.TabIndex = 33;
            textBox13.Text = "0";
            textBox13.TextAlign = HorizontalAlignment.Right;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.White;
            label22.Location = new Point(22, 477);
            label22.Name = "label22";
            label22.Size = new Size(104, 20);
            label22.TabIndex = 32;
            label22.Text = "Reader point";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(24, 363);
            label19.Name = "label19";
            label19.Size = new Size(211, 37);
            label19.TabIndex = 31;
            label19.Text = "Stock Control";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(16, 11);
            label18.Name = "label18";
            label18.Size = new Size(211, 37);
            label18.TabIndex = 30;
            label18.Text = "Price and Tax";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(3, 83, 115);
            textBox8.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.ForeColor = Color.White;
            textBox8.Location = new Point(23, 290);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 30);
            textBox8.TabIndex = 29;
            textBox8.Text = "0";
            textBox8.TextAlign = HorizontalAlignment.Right;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(23, 267);
            label14.Name = "label14";
            label14.Size = new Size(81, 20);
            label14.TabIndex = 28;
            label14.Text = "Sale price";
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.FromArgb(3, 83, 115);
            textBox9.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.ForeColor = Color.White;
            textBox9.Location = new Point(22, 219);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(127, 30);
            textBox9.TabIndex = 27;
            textBox9.Text = "0";
            textBox9.TextAlign = HorizontalAlignment.Right;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(22, 196);
            label15.Name = "label15";
            label15.Size = new Size(66, 20);
            label15.TabIndex = 26;
            label15.Text = "Markup";
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.FromArgb(3, 83, 115);
            textBox10.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.ForeColor = Color.White;
            textBox10.Location = new Point(24, 149);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 30);
            textBox10.TabIndex = 25;
            textBox10.Text = "0";
            textBox10.TextAlign = HorizontalAlignment.Right;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(24, 126);
            label16.Name = "label16";
            label16.Size = new Size(42, 20);
            label16.TabIndex = 24;
            label16.Text = "Cost";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.FromArgb(3, 83, 115);
            textBox11.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox11.ForeColor = Color.White;
            textBox11.Location = new Point(23, 81);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(310, 30);
            textBox11.TabIndex = 23;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(22, 58);
            label17.Name = "label17";
            label17.Size = new Size(47, 20);
            label17.TabIndex = 22;
            label17.Text = "Taxes";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(16, 21);
            label13.Name = "label13";
            label13.Size = new Size(113, 37);
            label13.TabIndex = 16;
            label13.Text = "Details";
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
            btnsave.Click += btnsave_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(3, 83, 115);
            textBox6.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(14, 301);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 30);
            textBox6.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(14, 278);
            label12.Name = "label12";
            label12.Size = new Size(160, 20);
            label12.TabIndex = 12;
            label12.Text = "Unit of measurement";
            // 
            // DescriptionValue
            // 
            DescriptionValue.BackColor = Color.FromArgb(3, 83, 115);
            DescriptionValue.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionValue.ForeColor = Color.White;
            DescriptionValue.Location = new Point(15, 486);
            DescriptionValue.Multiline = true;
            DescriptionValue.Name = "DescriptionValue";
            DescriptionValue.Size = new Size(401, 116);
            DescriptionValue.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(15, 463);
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
            textBox4.Location = new Point(12, 429);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(401, 30);
            textBox4.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(12, 406);
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
            comboBox1.Location = new Point(14, 366);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(310, 28);
            comboBox1.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(13, 343);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 6;
            label9.Text = "Group";
            // 
            // BarcodeValue
            // 
            BarcodeValue.BackColor = Color.FromArgb(3, 83, 115);
            BarcodeValue.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BarcodeValue.ForeColor = Color.White;
            BarcodeValue.Location = new Point(13, 230);
            BarcodeValue.Name = "BarcodeValue";
            BarcodeValue.Size = new Size(401, 30);
            BarcodeValue.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 207);
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
            textBox2.Location = new Point(15, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 30);
            textBox2.TabIndex = 3;
            // 
            // btnCode
            // 
            btnCode.AutoSize = true;
            btnCode.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCode.ForeColor = Color.White;
            btnCode.Location = new Point(15, 139);
            btnCode.Name = "btnCode";
            btnCode.Size = new Size(51, 20);
            btnCode.TabIndex = 2;
            btnCode.Text = "Code";
            // 
            // ProductNameValue
            // 
            ProductNameValue.BackColor = Color.FromArgb(3, 83, 115);
            ProductNameValue.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ProductNameValue.ForeColor = Color.White;
            ProductNameValue.Location = new Point(14, 94);
            ProductNameValue.Name = "ProductNameValue";
            ProductNameValue.Size = new Size(310, 30);
            ProductNameValue.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 71);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 0;
            label7.Text = "Name";
            // 
            // panel5
            // 
            panel5.Controls.Add(button8);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(panel4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(425, 99);
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
            button8.Size = new Size(414, 31);
            button8.TabIndex = 5;
            button8.Text = "Price and Tax / Stock Control";
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
            // Upper_timer
            // 
            Upper_timer.Interval = 1;
            Upper_timer.Tick += Upper_timer_Tick;
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
            panelUpper.ResumeLayout(false);
            panelUpper.PerformLayout();
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
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2Elipse Details;
        private Guna.UI2.WinForms.Guna2Elipse StockControl;
        private Panel panel5;
        private Panel panelpro_service;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer sidebar_addproducts;
        private Button button8;
        private TextBox ProductNameValue;
        private Label label7;
        private ComboBox comboBox1;
        private Label label9;
        private TextBox BarcodeValue;
        private Label label8;
        private TextBox textBox2;
        private Label btnCode;
        private TextBox textBox4;
        private Label label10;
        private TextBox textBox6;
        private Label label12;
        private TextBox DescriptionValue;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnsave;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label13;
        private Panel panelUpper;
        private Label label18;
        private TextBox textBox8;
        private Label label14;
        private TextBox textBox9;
        private Label label15;
        private TextBox textBox10;
        private Label label16;
        private TextBox textBox11;
        private Label label17;
        private Panel panel7;
        private Label label19;
        private ComboBox comboBox2;
        private Label label20;
        private TextBox textBox12;
        private Label label21;
        private TextBox textBox13;
        private Label label22;
        private System.Windows.Forms.Timer Upper_timer;
    }
}