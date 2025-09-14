namespace GPA_MONHOC
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
            label3 = new Label();
            label4 = new Label();
            txtchuyencan = new TextBox();
            txtdoan = new TextBox();
            txtthuchanh = new TextBox();
            btnsolve = new Button();
            txtkq = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 9F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(124, 21);
            label1.Name = "label1";
            label1.Size = new Size(305, 29);
            label1.TabIndex = 0;
            label1.Text = "TÍNH ĐIỂM GPA MÔN HỌC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Times New Roman", 9F);
            label2.Location = new Point(33, 81);
            label2.Name = "label2";
            label2.Size = new Size(195, 29);
            label2.TabIndex = 1;
            label2.Text = "Chuyên cần (20%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Times New Roman", 9F);
            label3.Location = new Point(39, 157);
            label3.Name = "label3";
            label3.Size = new Size(183, 29);
            label3.TabIndex = 2;
            label3.Text = "Thực hành (20%)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Times New Roman", 9F);
            label4.Location = new Point(61, 241);
            label4.Name = "label4";
            label4.Size = new Size(138, 29);
            label4.TabIndex = 3;
            label4.Text = "Đồ án (60%)";
            // 
            // txtchuyencan
            // 
            txtchuyencan.Font = new Font("Times New Roman", 9F);
            txtchuyencan.Location = new Point(270, 78);
            txtchuyencan.Name = "txtchuyencan";
            txtchuyencan.Size = new Size(200, 35);
            txtchuyencan.TabIndex = 4;
            // 
            // txtdoan
            // 
            txtdoan.Font = new Font("Times New Roman", 9F);
            txtdoan.Location = new Point(270, 241);
            txtdoan.Name = "txtdoan";
            txtdoan.Size = new Size(200, 35);
            txtdoan.TabIndex = 5;
            // 
            // txtthuchanh
            // 
            txtthuchanh.Font = new Font("Times New Roman", 9F);
            txtthuchanh.Location = new Point(270, 157);
            txtthuchanh.Name = "txtthuchanh";
            txtthuchanh.Size = new Size(200, 35);
            txtthuchanh.TabIndex = 6;
            // 
            // btnsolve
            // 
            btnsolve.Font = new Font("Times New Roman", 9F);
            btnsolve.ForeColor = Color.Blue;
            btnsolve.Location = new Point(295, 308);
            btnsolve.Name = "btnsolve";
            btnsolve.Size = new Size(150, 46);
            btnsolve.TabIndex = 7;
            btnsolve.Text = "Solve";
            btnsolve.UseVisualStyleBackColor = true;
            btnsolve.Click += btnsolve_Click;
            // 
            // txtkq
            // 
            txtkq.Font = new Font("Times New Roman", 9F);
            txtkq.Location = new Point(45, 394);
            txtkq.Multiline = true;
            txtkq.Name = "txtkq";
            txtkq.ReadOnly = true;
            txtkq.Size = new Size(506, 125);
            txtkq.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(88, 308);
            button1.Name = "button1";
            button1.Size = new Size(82, 46);
            button1.TabIndex = 9;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 552);
            Controls.Add(button1);
            Controls.Add(txtkq);
            Controls.Add(btnsolve);
            Controls.Add(txtthuchanh);
            Controls.Add(txtdoan);
            Controls.Add(txtchuyencan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "TÍNH ĐIỂM MÔN HỌC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtchuyencan;
        private TextBox txtdoan;
        private TextBox txtthuchanh;
        private Button btnsolve;
        private TextBox txtkq;
        private Button button1;
    }
}
