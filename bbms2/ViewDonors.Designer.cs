namespace bbms2
{
    partial class ViewDonors
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label8 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            DonorGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DonorGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 757);
            panel1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(35, 603);
            label8.Name = "label8";
            label8.Size = new Size(171, 35);
            label8.TabIndex = 11;
            label8.Text = "DashBoard";
            label8.Click += label8_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(12, 199);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 40);
            panel3.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(35, 523);
            label7.Name = "label7";
            label7.Size = new Size(221, 35);
            label7.TabIndex = 5;
            label7.Text = "Blood Transfer";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(35, 437);
            label6.Name = "label6";
            label6.Size = new Size(178, 35);
            label6.TabIndex = 4;
            label6.Text = "Blood Stock";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(35, 351);
            label5.Name = "label5";
            label5.Size = new Size(195, 35);
            label5.TabIndex = 3;
            label5.Text = "View Patient";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(35, 277);
            label4.Name = "label4";
            label4.Size = new Size(118, 35);
            label4.TabIndex = 2;
            label4.Text = "Patient";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(35, 204);
            label3.Name = "label3";
            label3.Size = new Size(190, 35);
            label3.TabIndex = 1;
            label3.Text = "View Donors";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(35, 121);
            label2.Name = "label2";
            label2.Size = new Size(99, 35);
            label2.TabIndex = 0;
            label2.Text = "Donor";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(268, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1093, 57);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(287, 9);
            label1.Name = "label1";
            label1.Size = new Size(478, 35);
            label1.TabIndex = 0;
            label1.Text = "Blood Bank Management System";
            // 
            // DonorGrid
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DonorGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DonorGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DonorGrid.ColumnHeadersHeight = 25;
            DonorGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DonorGrid.DefaultCellStyle = dataGridViewCellStyle3;
            DonorGrid.GridColor = Color.White;
            DonorGrid.Location = new Point(341, 235);
            DonorGrid.Name = "DonorGrid";
            DonorGrid.RowHeadersVisible = false;
            DonorGrid.RowHeadersWidth = 51;
            DonorGrid.RowTemplate.Height = 25;
            DonorGrid.Size = new Size(898, 374);
            DonorGrid.TabIndex = 25;
            DonorGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DonorGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            DonorGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DonorGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DonorGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DonorGrid.ThemeStyle.BackColor = Color.White;
            DonorGrid.ThemeStyle.GridColor = Color.White;
            DonorGrid.ThemeStyle.HeaderStyle.BackColor = Color.Red;
            DonorGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DonorGrid.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DonorGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DonorGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DonorGrid.ThemeStyle.HeaderStyle.Height = 25;
            DonorGrid.ThemeStyle.ReadOnly = false;
            DonorGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            DonorGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DonorGrid.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DonorGrid.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            DonorGrid.ThemeStyle.RowsStyle.Height = 25;
            DonorGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.Crimson;
            DonorGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(685, 121);
            label9.Name = "label9";
            label9.Size = new Size(232, 35);
            label9.TabIndex = 26;
            label9.Text = "Donor Details";
            // 
            // ViewDonors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1361, 757);
            Controls.Add(label9);
            Controls.Add(DonorGrid);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewDonors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewDonors";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DonorGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2DataGridView DonorGrid;
        private Label label8;
        private Label label9;
    }
}