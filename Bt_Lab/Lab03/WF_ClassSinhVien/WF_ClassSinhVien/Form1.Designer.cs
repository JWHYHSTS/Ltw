namespace WF_ClassSinhVien
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
            Label label1;
            Button btnthem;
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnsua = new Button();
            btnxoa = new Button();
            btnreset = new Button();
            dataGridView1 = new DataGridView();
            txtmasv = new TextBox();
            txtsdt = new TextBox();
            txthoten = new TextBox();
            txtgpa = new TextBox();
            txtxeploai = new TextBox();
            label1 = new Label();
            btnthem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 9F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(310, 27);
            label1.Name = "label1";
            label1.Size = new Size(312, 29);
            label1.TabIndex = 0;
            label1.Text = "HỆ THỐNG QUẢN LÝ ĐIỂM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Times New Roman", 9F);
            label2.Location = new Point(62, 87);
            label2.Name = "label2";
            label2.Size = new Size(80, 29);
            label2.TabIndex = 1;
            label2.Text = "Mã SV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Times New Roman", 9F);
            label3.Location = new Point(75, 148);
            label3.Name = "label3";
            label3.Size = new Size(57, 29);
            label3.TabIndex = 2;
            label3.Text = "SDT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Times New Roman", 9F);
            label4.Location = new Point(58, 211);
            label4.Name = "label4";
            label4.Size = new Size(86, 29);
            label4.TabIndex = 3;
            label4.Text = "Họ Tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Times New Roman", 9F);
            label5.Location = new Point(550, 100);
            label5.Name = "label5";
            label5.Size = new Size(60, 29);
            label5.TabIndex = 4;
            label5.Text = "GPA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Times New Roman", 9F);
            label6.Location = new Point(526, 166);
            label6.Name = "label6";
            label6.Size = new Size(104, 29);
            label6.TabIndex = 5;
            label6.Text = "Xếp Loại";
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.Lime;
            btnthem.Font = new Font("Times New Roman", 9F);
            btnthem.ForeColor = Color.Black;
            btnthem.Location = new Point(80, 284);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(150, 46);
            btnthem.TabIndex = 6;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(192, 255, 192);
            btnsua.Font = new Font("Times New Roman", 9F);
            btnsua.Location = new Point(283, 284);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(150, 46);
            btnsua.TabIndex = 7;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.Cyan;
            btnxoa.Font = new Font("Times New Roman", 9F);
            btnxoa.Location = new Point(483, 284);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(150, 46);
            btnxoa.TabIndex = 8;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = false;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnreset
            // 
            btnreset.BackColor = Color.Fuchsia;
            btnreset.Font = new Font("Times New Roman", 9F);
            btnreset.Location = new Point(692, 284);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(150, 46);
            btnreset.TabIndex = 9;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = false;
            btnreset.Click += btnreset_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(87, 350);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(729, 238);
            dataGridView1.TabIndex = 10;
            // 
            // txtmasv
            // 
            txtmasv.Font = new Font("Times New Roman", 9F);
            txtmasv.Location = new Point(228, 93);
            txtmasv.Name = "txtmasv";
            txtmasv.Size = new Size(200, 35);
            txtmasv.TabIndex = 11;
            // 
            // txtsdt
            // 
            txtsdt.Font = new Font("Times New Roman", 9F);
            txtsdt.Location = new Point(228, 155);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(200, 35);
            txtsdt.TabIndex = 12;
            // 
            // txthoten
            // 
            txthoten.Font = new Font("Times New Roman", 9F);
            txthoten.Location = new Point(228, 211);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(601, 35);
            txthoten.TabIndex = 13;
            // 
            // txtgpa
            // 
            txtgpa.Font = new Font("Times New Roman", 9F);
            txtgpa.Location = new Point(664, 97);
            txtgpa.Name = "txtgpa";
            txtgpa.Size = new Size(69, 35);
            txtgpa.TabIndex = 14;
            // 
            // txtxeploai
            // 
            txtxeploai.Font = new Font("Times New Roman", 9F);
            txtxeploai.Location = new Point(664, 163);
            txtxeploai.Name = "txtxeploai";
            txtxeploai.ReadOnly = true;
            txtxeploai.Size = new Size(69, 35);
            txtxeploai.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 631);
            Controls.Add(txtxeploai);
            Controls.Add(txtgpa);
            Controls.Add(txthoten);
            Controls.Add(txtsdt);
            Controls.Add(txtmasv);
            Controls.Add(dataGridView1);
            Controls.Add(btnreset);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnthem;
        private Button btnsua;
        private Button btnxoa;
        private Button btnreset;
        private DataGridView dataGridView1;
        private TextBox txtmasv;
        private TextBox txtsdt;
        private TextBox txthoten;
        private TextBox txtgpa;
        private TextBox txtxeploai;
    }
}
