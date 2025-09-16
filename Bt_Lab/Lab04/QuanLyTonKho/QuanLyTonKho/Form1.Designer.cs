namespace QuanLyTonKho
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            nudsoluong = new NumericUpDown();
            cbohanghoa = new ComboBox();
            label3 = new Label();
            btnthem = new Button();
            btngiam = new Button();
            lbldongia = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudsoluong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label1.Location = new Point(39, 87);
            label1.Name = "label1";
            label1.Size = new Size(117, 26);
            label1.TabIndex = 0;
            label1.Text = "Hàng Hóa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label2.Location = new Point(287, 87);
            label2.Name = "label2";
            label2.Size = new Size(111, 26);
            label2.TabIndex = 1;
            label2.Text = "Số Lượng";
            // 
            // nudsoluong
            // 
            nudsoluong.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            nudsoluong.Location = new Point(287, 128);
            nudsoluong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudsoluong.Name = "nudsoluong";
            nudsoluong.Size = new Size(195, 35);
            nudsoluong.TabIndex = 2;
            nudsoluong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbohanghoa
            // 
            cbohanghoa.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            cbohanghoa.FormattingEnabled = true;
            cbohanghoa.Location = new Point(39, 128);
            cbohanghoa.Name = "cbohanghoa";
            cbohanghoa.Size = new Size(197, 34);
            cbohanghoa.TabIndex = 3;
            cbohanghoa.SelectedIndexChanged += cbohanghoa_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Times New Roman", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(298, 23);
            label3.Name = "label3";
            label3.Size = new Size(292, 34);
            label3.TabIndex = 4;
            label3.Text = "QUẢN LÝ TỒN KHO";
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.Lime;
            btnthem.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnthem.Location = new Point(567, 124);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(150, 46);
            btnthem.TabIndex = 5;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // btngiam
            // 
            btngiam.BackColor = Color.FromArgb(255, 128, 0);
            btngiam.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btngiam.Location = new Point(735, 124);
            btngiam.Name = "btngiam";
            btngiam.Size = new Size(150, 46);
            btngiam.TabIndex = 6;
            btngiam.Text = "Giảm";
            btngiam.UseVisualStyleBackColor = false;
            btngiam.Click += btngiam_Click;
            // 
            // lbldongia
            // 
            lbldongia.AutoSize = true;
            lbldongia.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            lbldongia.ForeColor = Color.Red;
            lbldongia.Location = new Point(34, 183);
            lbldongia.Name = "lbldongia";
            lbldongia.Size = new Size(49, 26);
            lbldongia.TabIndex = 7;
            lbldongia.Text = "Giá";
            lbldongia.Click += label4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(846, 313);
            dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(735, 573);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 9;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 660);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(lbldongia);
            Controls.Add(btngiam);
            Controls.Add(btnthem);
            Controls.Add(label3);
            Controls.Add(cbohanghoa);
            Controls.Add(nudsoluong);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Quản lý TK";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudsoluong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown nudsoluong;
        private ComboBox cbohanghoa;
        private Label label3;
        private Button btnthem;
        private Button btngiam;
        private Label lbldongia;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
