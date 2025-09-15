namespace WF_QuanlyHCN
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
            groupBox1 = new GroupBox();
            radHT = new RadioButton();
            radHCN = new RadioButton();
            groupBoxHCN = new GroupBox();
            txtRong = new TextBox();
            txtDai = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBoxHT = new GroupBox();
            txtBanKinh = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            btnXoa = new Button();
            btnReset = new Button();
            btnSua = new Button();
            btnxuatJson = new Button();
            btnxuattext = new Button();
            groupBox1.SuspendLayout();
            groupBoxHCN.SuspendLayout();
            groupBoxHT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radHT);
            groupBox1.Controls.Add(radHCN);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(69, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(950, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại Hình Học";
            // 
            // radHT
            // 
            radHT.AutoSize = true;
            radHT.Location = new Point(651, 67);
            radHT.Name = "radHT";
            radHT.Size = new Size(150, 30);
            radHT.TabIndex = 1;
            radHT.TabStop = true;
            radHT.Text = "Hình Tròn";
            radHT.UseVisualStyleBackColor = true;
            // 
            // radHCN
            // 
            radHCN.AutoSize = true;
            radHCN.Location = new Point(72, 67);
            radHCN.Name = "radHCN";
            radHCN.Size = new Size(201, 30);
            radHCN.TabIndex = 0;
            radHCN.TabStop = true;
            radHCN.Text = "Hình Chữ Nhật";
            radHCN.UseVisualStyleBackColor = true;
            radHCN.CheckedChanged += radHCN_CheckedChanged;
            // 
            // groupBoxHCN
            // 
            groupBoxHCN.Controls.Add(txtRong);
            groupBoxHCN.Controls.Add(txtDai);
            groupBoxHCN.Controls.Add(label2);
            groupBoxHCN.Controls.Add(label1);
            groupBoxHCN.Enabled = false;
            groupBoxHCN.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            groupBoxHCN.Location = new Point(69, 232);
            groupBoxHCN.Name = "groupBoxHCN";
            groupBoxHCN.Size = new Size(434, 200);
            groupBoxHCN.TabIndex = 1;
            groupBoxHCN.TabStop = false;
            groupBoxHCN.Text = "Hình chữ nhật";
            groupBoxHCN.Enter += groupBoxHCN_Enter;
            // 
            // txtRong
            // 
            txtRong.Location = new Point(204, 126);
            txtRong.Name = "txtRong";
            txtRong.Size = new Size(200, 35);
            txtRong.TabIndex = 3;
            // 
            // txtDai
            // 
            txtDai.Location = new Point(204, 58);
            txtDai.Name = "txtDai";
            txtDai.Size = new Size(200, 35);
            txtDai.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 126);
            label2.Name = "label2";
            label2.Size = new Size(66, 26);
            label2.TabIndex = 1;
            label2.Text = "Rộng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 58);
            label1.Name = "label1";
            label1.Size = new Size(48, 26);
            label1.TabIndex = 0;
            label1.Text = "Dài";
            // 
            // groupBoxHT
            // 
            groupBoxHT.Controls.Add(txtBanKinh);
            groupBoxHT.Controls.Add(label3);
            groupBoxHT.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            groupBoxHT.Location = new Point(546, 232);
            groupBoxHT.Name = "groupBoxHT";
            groupBoxHT.Size = new Size(473, 200);
            groupBoxHT.TabIndex = 2;
            groupBoxHT.TabStop = false;
            groupBoxHT.Text = "Hình Tròn";
            // 
            // txtBanKinh
            // 
            txtBanKinh.Location = new Point(184, 98);
            txtBanKinh.Name = "txtBanKinh";
            txtBanKinh.Size = new Size(200, 35);
            txtBanKinh.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 98);
            label3.Name = "label3";
            label3.Size = new Size(111, 26);
            label3.TabIndex = 0;
            label3.Text = "Bán Kính";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 518);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1050, 178);
            dataGridView1.TabIndex = 3;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnThem.Location = new Point(69, 454);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnXoa.Location = new Point(353, 454);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnReset.Location = new Point(869, 454);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 46);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnSua.Location = new Point(548, 454);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnxuatJson
            // 
            btnxuatJson.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnxuatJson.Location = new Point(1039, 255);
            btnxuatJson.Name = "btnxuatJson";
            btnxuatJson.Size = new Size(197, 46);
            btnxuatJson.TabIndex = 8;
            btnxuatJson.Text = "Xuất File JSON";
            btnxuatJson.UseVisualStyleBackColor = true;
            btnxuatJson.Click += btnxuatJson_Click;
            // 
            // btnxuattext
            // 
            btnxuattext.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnxuattext.Location = new Point(1039, 349);
            btnxuattext.Name = "btnxuattext";
            btnxuattext.Size = new Size(197, 46);
            btnxuattext.TabIndex = 9;
            btnxuattext.Text = "Xuất File TEXT";
            btnxuattext.UseVisualStyleBackColor = true;
            btnxuattext.Click += btnxuattext_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 708);
            Controls.Add(btnxuattext);
            Controls.Add(btnxuatJson);
            Controls.Add(btnSua);
            Controls.Add(btnReset);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(groupBoxHT);
            Controls.Add(groupBoxHCN);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxHCN.ResumeLayout(false);
            groupBoxHCN.PerformLayout();
            groupBoxHT.ResumeLayout(false);
            groupBoxHT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radHT;
        private RadioButton radHCN;
        private GroupBox groupBoxHCN;
        private TextBox txtRong;
        private TextBox txtDai;
        private Label label2;
        private Label label1;
        private GroupBox groupBoxHT;
        private TextBox txtBanKinh;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnReset;
        private Button btnSua;
        private Button btnxuatJson;
        private Button btnxuattext;
    }
}
