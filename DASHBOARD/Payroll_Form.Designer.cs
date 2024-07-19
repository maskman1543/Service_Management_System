namespace Service_Management_System.DASHBOARD
{
    partial class Payroll_Form
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
            Payroll = new Label();
            SuspendLayout();
            // 
            // Payroll
            // 
            Payroll.AutoSize = true;
            Payroll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Payroll.Location = new Point(479, 439);
            Payroll.Name = "Payroll";
            Payroll.Size = new Size(78, 28);
            Payroll.TabIndex = 2;
            Payroll.Text = "Payroll";
            // 
            // Payroll_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 906);
            Controls.Add(Payroll);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payroll_Form";
            Text = "Payroll_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Payroll;
    }
}