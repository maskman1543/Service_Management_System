namespace Service_Management_System.DASHBOARD
{
    partial class DocumentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentsForm));
            panel8 = new Panel();
            pictureBox9 = new PictureBox();
            label19 = new Label();
            SM = new TextBox();
            SearchBtn = new Button();
            dataGridView1 = new DataGridView();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(3, 83, 115);
            panel8.Controls.Add(pictureBox9);
            panel8.Controls.Add(label19);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(706, 106);
            panel8.TabIndex = 19;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(20, 2);
            pictureBox9.Margin = new Padding(3, 2, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(40, 40);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 3;
            pictureBox9.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(67, 7);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(125, 21);
            label19.TabIndex = 2;
            label19.Text = "Mechanic History";
            // 
            // SM
            // 
            SM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SM.ForeColor = Color.Gray;
            SM.Location = new Point(11, 110);
            SM.Margin = new Padding(2);
            SM.Multiline = true;
            SM.Name = "SM";
            SM.Size = new Size(209, 29);
            SM.TabIndex = 20;
            SM.Text = "Mechanic ID";
            SM.TextChanged += SM_TextChanged;
            // 
            // SearchBtn
            // 
            SearchBtn.AutoSize = true;
            SearchBtn.BackColor = Color.FromArgb(3, 83, 115);
            SearchBtn.BackgroundImageLayout = ImageLayout.Stretch;
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SearchBtn.Location = new Point(234, 110);
            SearchBtn.Margin = new Padding(2);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Padding = new Padding(28, 0, 28, 0);
            SearchBtn.Size = new Size(111, 29);
            SearchBtn.TabIndex = 21;
            SearchBtn.Text = "Search";
            SearchBtn.TextAlign = ContentAlignment.MiddleRight;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 164);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(682, 551);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DocumentsForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(706, 738);
            Controls.Add(dataGridView1);
            Controls.Add(SearchBtn);
            Controls.Add(SM);
            Controls.Add(panel8);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "DocumentsForm";
            Text = "DocumentsForm";
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel8;
        private PictureBox pictureBox9;
        private Label label19;
        private TextBox SM;
        private Button SearchBtn;
        private DataGridView dataGridView1;
    }
}