namespace Dental_Application_Form
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
            txtkhachhang = new TextBox();
            Chkcaovoi = new CheckBox();
            Chktaytrang = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            btntinhtien = new Button();
            btnluufile = new Button();
            btnxoa = new Button();
            btnthoat = new Button();
            Nudnhorang = new NumericUpDown();
            Nudtramrang = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txttongcong = new TextBox();
            label10 = new Label();
            Nudtrongrang = new NumericUpDown();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)Nudnhorang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Nudtramrang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Nudtrongrang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, 9);
            label1.Name = "label1";
            label1.Size = new Size(405, 45);
            label1.TabIndex = 0;
            label1.Text = "Dental Application Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 90);
            label2.Name = "label2";
            label2.Size = new Size(218, 32);
            label2.TabIndex = 1;
            label2.Text = "Họ tên khách hàng";
            // 
            // txtkhachhang
            // 
            txtkhachhang.Location = new Point(302, 90);
            txtkhachhang.Name = "txtkhachhang";
            txtkhachhang.Size = new Size(555, 39);
            txtkhachhang.TabIndex = 2;
            txtkhachhang.TextChanged += txtkhachhang_TextChanged;
            // 
            // Chkcaovoi
            // 
            Chkcaovoi.AutoSize = true;
            Chkcaovoi.Location = new Point(78, 165);
            Chkcaovoi.Name = "Chkcaovoi";
            Chkcaovoi.Size = new Size(126, 36);
            Chkcaovoi.TabIndex = 3;
            Chkcaovoi.Text = "Cạo vôi";
            Chkcaovoi.UseVisualStyleBackColor = true;
            // 
            // Chktaytrang
            // 
            Chktaytrang.AutoSize = true;
            Chktaytrang.Location = new Point(78, 222);
            Chktaytrang.Name = "Chktaytrang";
            Chktaytrang.Size = new Size(146, 36);
            Chktaytrang.TabIndex = 4;
            Chktaytrang.Text = "Tẩy trắng";
            Chktaytrang.UseVisualStyleBackColor = true;
            Chktaytrang.CheckedChanged += Chktaytrang_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 308);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 5;
            label3.Text = "Nhổ răng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 374);
            label4.Name = "label4";
            label4.Size = new Size(121, 32);
            label4.TabIndex = 6;
            label4.Text = "Trám răng";
            // 
            // btntinhtien
            // 
            btntinhtien.BackColor = Color.FromArgb(128, 255, 128);
            btntinhtien.ForeColor = Color.Black;
            btntinhtien.Location = new Point(71, 577);
            btntinhtien.Name = "btntinhtien";
            btntinhtien.Size = new Size(150, 72);
            btntinhtien.TabIndex = 7;
            btntinhtien.Text = "Tính tiền";
            btntinhtien.UseVisualStyleBackColor = false;
            btntinhtien.Click += btntinhtien_Click;
            // 
            // btnluufile
            // 
            btnluufile.BackColor = Color.FromArgb(255, 255, 128);
            btnluufile.Location = new Point(299, 577);
            btnluufile.Name = "btnluufile";
            btnluufile.Size = new Size(150, 72);
            btnluufile.TabIndex = 8;
            btnluufile.Text = "Lưu File";
            btnluufile.UseVisualStyleBackColor = false;
            btnluufile.Click += btnluufile_Click;
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.FromArgb(255, 128, 0);
            btnxoa.Location = new Point(527, 577);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(150, 72);
            btnxoa.TabIndex = 9;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = false;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.Red;
            btnthoat.Location = new Point(755, 577);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(150, 72);
            btnthoat.TabIndex = 10;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // Nudnhorang
            // 
            Nudnhorang.Location = new Point(257, 305);
            Nudnhorang.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            Nudnhorang.Name = "Nudnhorang";
            Nudnhorang.Size = new Size(118, 39);
            Nudnhorang.TabIndex = 11;
            // 
            // Nudtramrang
            // 
            Nudtramrang.Location = new Point(260, 371);
            Nudtramrang.Name = "Nudtramrang";
            Nudtramrang.Size = new Size(118, 39);
            Nudtramrang.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(705, 167);
            label5.Name = "label5";
            label5.Size = new Size(131, 32);
            label5.TabIndex = 13;
            label5.Text = "100,000 đ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(705, 224);
            label6.Name = "label6";
            label6.Size = new Size(152, 32);
            label6.TabIndex = 14;
            label6.Text = "1,500,000 đ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(705, 308);
            label7.Name = "label7";
            label7.Size = new Size(132, 32);
            label7.TabIndex = 15;
            label7.Text = "500,000 đ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(705, 374);
            label8.Name = "label8";
            label8.Size = new Size(132, 32);
            label8.TabIndex = 16;
            label8.Text = "200,000 đ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(508, 509);
            label9.Name = "label9";
            label9.Size = new Size(154, 37);
            label9.TabIndex = 17;
            label9.Text = "Tổng cộng";
            label9.Click += this.label9_Click;
            // 
            // txttongcong
            // 
            txttongcong.Location = new Point(705, 508);
            txttongcong.Name = "txttongcong";
            txttongcong.ReadOnly = true;
            txttongcong.Size = new Size(200, 39);
            txttongcong.TabIndex = 18;
            txttongcong.TextChanged += txttongcong_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(78, 443);
            label10.Name = "label10";
            label10.Size = new Size(130, 32);
            label10.TabIndex = 19;
            label10.Text = "Trồng răng";
            // 
            // Nudtrongrang
            // 
            Nudtrongrang.Location = new Point(260, 440);
            Nudtrongrang.Name = "Nudtrongrang";
            Nudtrongrang.Size = new Size(118, 39);
            Nudtrongrang.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic);
            label11.Location = new Point(705, 443);
            label11.Name = "label11";
            label11.Size = new Size(170, 32);
            label11.TabIndex = 21;
            label11.Text = "20,000,000 đ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 682);
            Controls.Add(label11);
            Controls.Add(Nudtrongrang);
            Controls.Add(label10);
            Controls.Add(txttongcong);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Nudtramrang);
            Controls.Add(Nudnhorang);
            Controls.Add(btnthoat);
            Controls.Add(btnxoa);
            Controls.Add(btnluufile);
            Controls.Add(btntinhtien);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Chktaytrang);
            Controls.Add(Chkcaovoi);
            Controls.Add(txtkhachhang);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Dental_Application_Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Nudnhorang).EndInit();
            ((System.ComponentModel.ISupportInitialize)Nudtramrang).EndInit();
            ((System.ComponentModel.ISupportInitialize)Nudtrongrang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtkhachhang;
        private CheckBox Chkcaovoi;
        private CheckBox Chktaytrang;
        private Label label3;
        private Label label4;
        private Button btntinhtien;
        private Button btnluufile;
        private Button btnxoa;
        private Button btnthoat;
        private NumericUpDown Nudnhorang;
        private NumericUpDown Nudtramrang;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txttongcong;
        private Label label10;
        private NumericUpDown Nudtrongrang;
        private Label label11;
    }
}
