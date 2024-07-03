namespace bbms2
{
    partial class BloodStock
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label12 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label9 = new Label();
            label8 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            StockGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            DonorGrid2 = new Guna.UI2.WinForms.Guna2DataGridView();
            label10 = new Label();
            label11 = new Label();
            DNameTb = new TextBox();
            button1 = new Button();
            DBGroupTb = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StockGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DonorGrid2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label12);
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Schoolbook", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(35, 603);
            label12.Name = "label12";
            label12.Size = new Size(171, 35);
            label12.TabIndex = 12;
            label12.Text = "DashBoard";
            label12.Click += label12_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(19, 432);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 40);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
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
            label3.Click += label3_Click;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(383, 87);
            label9.Name = "label9";
            label9.Size = new Size(191, 34);
            label9.TabIndex = 23;
            label9.Text = "Blood Stock";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(1056, 87);
            label8.Name = "label8";
            label8.Size = new Size(184, 34);
            label8.TabIndex = 24;
            label8.Text = "Donors List";
            label8.Click += label8_Click;
            // 
            // StockGrid
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            StockGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            StockGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            StockGrid.ColumnHeadersHeight = 4;
            StockGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            StockGrid.DefaultCellStyle = dataGridViewCellStyle3;
            StockGrid.GridColor = Color.FromArgb(231, 229, 255);
            StockGrid.Location = new Point(320, 134);
            StockGrid.Name = "StockGrid";
            StockGrid.RowHeadersVisible = false;
            StockGrid.RowHeadersWidth = 51;
            StockGrid.Size = new Size(343, 379);
            StockGrid.TabIndex = 50;
            StockGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            StockGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            StockGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            StockGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            StockGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            StockGrid.ThemeStyle.BackColor = Color.White;
            StockGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            StockGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            StockGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            StockGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            StockGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            StockGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            StockGrid.ThemeStyle.HeaderStyle.Height = 4;
            StockGrid.ThemeStyle.ReadOnly = false;
            StockGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            StockGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            StockGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            StockGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            StockGrid.ThemeStyle.RowsStyle.Height = 29;
            StockGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            StockGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            StockGrid.CellContentClick += StockGrid_CellContentClick;
            // 
            // DonorGrid2
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            DonorGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DonorGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DonorGrid2.ColumnHeadersHeight = 4;
            DonorGrid2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DonorGrid2.DefaultCellStyle = dataGridViewCellStyle6;
            DonorGrid2.GridColor = Color.FromArgb(231, 229, 255);
            DonorGrid2.Location = new Point(756, 134);
            DonorGrid2.Name = "DonorGrid2";
            DonorGrid2.RowHeadersVisible = false;
            DonorGrid2.RowHeadersWidth = 51;
            DonorGrid2.Size = new Size(593, 379);
            DonorGrid2.TabIndex = 51;
            DonorGrid2.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DonorGrid2.ThemeStyle.AlternatingRowsStyle.Font = null;
            DonorGrid2.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DonorGrid2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DonorGrid2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DonorGrid2.ThemeStyle.BackColor = Color.White;
            DonorGrid2.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DonorGrid2.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DonorGrid2.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DonorGrid2.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DonorGrid2.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DonorGrid2.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DonorGrid2.ThemeStyle.HeaderStyle.Height = 4;
            DonorGrid2.ThemeStyle.ReadOnly = false;
            DonorGrid2.ThemeStyle.RowsStyle.BackColor = Color.White;
            DonorGrid2.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DonorGrid2.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DonorGrid2.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DonorGrid2.ThemeStyle.RowsStyle.Height = 29;
            DonorGrid2.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DonorGrid2.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DonorGrid2.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(539, 516);
            label10.Name = "label10";
            label10.Size = new Size(106, 34);
            label10.TabIndex = 52;
            label10.Text = "Name ";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(865, 516);
            label11.Name = "label11";
            label11.Size = new Size(201, 34);
            label11.TabIndex = 53;
            label11.Text = "Blood Group";
            // 
            // DNameTb
            // 
            DNameTb.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DNameTb.ForeColor = Color.Red;
            DNameTb.Location = new Point(509, 576);
            DNameTb.Name = "DNameTb";
            DNameTb.Size = new Size(228, 26);
            DNameTb.TabIndex = 55;
            DNameTb.TextChanged += PNameTb_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(719, 642);
            button1.Name = "button1";
            button1.Size = new Size(186, 53);
            button1.TabIndex = 56;
            button1.Text = "Donate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DBGroupTb
            // 
            DBGroupTb.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DBGroupTb.ForeColor = Color.Red;
            DBGroupTb.Location = new Point(865, 576);
            DBGroupTb.Name = "DBGroupTb";
            DBGroupTb.Size = new Size(228, 26);
            DBGroupTb.TabIndex = 57;
            DBGroupTb.TextChanged += textBox1_TextChanged;
            // 
            // BloodStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1361, 757);
            Controls.Add(DBGroupTb);
            Controls.Add(button1);
            Controls.Add(DNameTb);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(DonorGrid2);
            Controls.Add(StockGrid);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BloodStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BloodStock";
            Load += BloodStock_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StockGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)DonorGrid2).EndInit();
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
        private Label label9;
        private Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2DataGridView StockGrid;
        private Guna.UI2.WinForms.Guna2DataGridView DonorGrid2;
        private Label label10;
        private Label label11;
        private TextBox DNameTb;
        private Button button1;
        private TextBox DBGroupTb;
        private Label label12;
    }
}