namespace Class_HCN
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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtcd = new TextBox();
            txtcr = new TextBox();
            btnthem = new Button();
            btnxuat = new Button();
            txtkq = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Yellow;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(228, 37);
            label3.Name = "label3";
            label3.Size = new Size(353, 34);
            label3.TabIndex = 7;
            label3.Text = "Tính Diện tích và Chu vi HCN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(69, 109);
            label1.Name = "label1";
            label1.Size = new Size(117, 34);
            label1.TabIndex = 0;
            label1.Text = "Chiều dài";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(69, 200);
            label2.Name = "label2";
            label2.Size = new Size(135, 34);
            label2.TabIndex = 1;
            label2.Text = "Chiều rộng";
            label2.Click += label2_Click;
            // 
            // txtcd
            // 
            txtcd.Location = new Point(251, 106);
            txtcd.Name = "txtcd";
            txtcd.Size = new Size(200, 39);
            txtcd.TabIndex = 2;
            // 
            // txtcr
            // 
            txtcr.Location = new Point(251, 200);
            txtcr.Name = "txtcr";
            txtcr.Size = new Size(200, 39);
            txtcr.TabIndex = 3;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.Lime;
            btnthem.Location = new Point(558, 106);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(150, 46);
            btnthem.TabIndex = 4;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // btnxuat
            // 
            btnxuat.BackColor = Color.Cyan;
            btnxuat.Location = new Point(558, 193);
            btnxuat.Name = "btnxuat";
            btnxuat.Size = new Size(150, 46);
            btnxuat.TabIndex = 5;
            btnxuat.Text = "Reset";
            btnxuat.UseVisualStyleBackColor = false;
            btnxuat.Click += btnxuat_Click;
            // 
            // txtkq
            // 
            txtkq.BorderStyle = BorderStyle.FixedSingle;
            txtkq.Location = new Point(69, 287);
            txtkq.Multiline = true;
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(639, 128);
            txtkq.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtkq);
            Controls.Add(btnxuat);
            Controls.Add(btnthem);
            Controls.Add(txtcr);
            Controls.Add(txtcd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtcd;
        private TextBox txtcr;
        private Button btnthem;
        private Button btnxuat;
        private TextBox txtkq;
        private Label label3;
    }
}
