namespace WF_KTNamNhuan
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
            txtNam = new TextBox();
            txtThang = new TextBox();
            btnCheck = new Button();
            txtKQ = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(201, 25);
            label1.Name = "label1";
            label1.Size = new Size(280, 30);
            label1.TabIndex = 0;
            label1.Text = "KIỂM TRA NĂM NHUẬN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(57, 98);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 1;
            label2.Text = "NĂM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(57, 168);
            label3.Name = "label3";
            label3.Size = new Size(98, 30);
            label3.TabIndex = 2;
            label3.Text = "THÁNG";
            // 
            // txtNam
            // 
            txtNam.BorderStyle = BorderStyle.FixedSingle;
            txtNam.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic);
            txtNam.Location = new Point(236, 98);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(200, 35);
            txtNam.TabIndex = 3;
            // 
            // txtThang
            // 
            txtThang.BorderStyle = BorderStyle.FixedSingle;
            txtThang.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic);
            txtThang.Location = new Point(236, 165);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(200, 35);
            txtThang.TabIndex = 4;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic);
            btnCheck.Location = new Point(261, 228);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(150, 46);
            btnCheck.TabIndex = 5;
            btnCheck.Text = "CHECK";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // txtKQ
            // 
            txtKQ.BorderStyle = BorderStyle.FixedSingle;
            txtKQ.Location = new Point(57, 329);
            txtKQ.Multiline = true;
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(517, 154);
            txtKQ.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 567);
            Controls.Add(txtKQ);
            Controls.Add(btnCheck);
            Controls.Add(txtThang);
            Controls.Add(txtNam);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "APP KT_NAM_NHUAN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNam;
        private TextBox txtThang;
        private Button btnCheck;
        private TextBox txtKQ;
    }
}
