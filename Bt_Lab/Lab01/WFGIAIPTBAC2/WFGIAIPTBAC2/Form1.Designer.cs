namespace WFGIAIPTBAC2
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
            txtA = new TextBox();
            label3 = new Label();
            txtB = new TextBox();
            label4 = new Label();
            txtC = new TextBox();
            label5 = new Label();
            btnCalculate = new Button();
            btnReset = new Button();
            txtKetQua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(273, 30);
            label1.Name = "label1";
            label1.Size = new Size(337, 28);
            label1.TabIndex = 0;
            label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label2.Location = new Point(326, 78);
            label2.Name = "label2";
            label2.Size = new Size(202, 26);
            label2.TabIndex = 1;
            label2.Text = "Ax^2 + Bx + C = 0";
            // 
            // txtA
            // 
            txtA.BorderStyle = BorderStyle.FixedSingle;
            txtA.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            txtA.Location = new Point(163, 149);
            txtA.Name = "txtA";
            txtA.Size = new Size(200, 35);
            txtA.TabIndex = 2;
            txtA.TextChanged += txtA_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label3.Location = new Point(42, 152);
            label3.Name = "label3";
            label3.Size = new Size(31, 28);
            label3.TabIndex = 3;
            label3.Text = "A";
            // 
            // txtB
            // 
            txtB.BorderStyle = BorderStyle.FixedSingle;
            txtB.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            txtB.Location = new Point(163, 215);
            txtB.Name = "txtB";
            txtB.Size = new Size(200, 35);
            txtB.TabIndex = 2;
            txtB.TextChanged += txtB_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label4.Location = new Point(42, 218);
            label4.Name = "label4";
            label4.Size = new Size(30, 28);
            label4.TabIndex = 3;
            label4.Text = "B";
            // 
            // txtC
            // 
            txtC.BorderStyle = BorderStyle.FixedSingle;
            txtC.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            txtC.Location = new Point(163, 275);
            txtC.Name = "txtC";
            txtC.Size = new Size(200, 35);
            txtC.TabIndex = 2;
            txtC.TextChanged += txtC_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label5.Location = new Point(42, 278);
            label5.Name = "label5";
            label5.Size = new Size(31, 28);
            label5.TabIndex = 3;
            label5.Text = "C";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnCalculate.Location = new Point(536, 154);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 46);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnReset.Location = new Point(536, 235);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 46);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.BorderStyle = BorderStyle.FixedSingle;
            txtKetQua.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            txtKetQua.Location = new Point(140, 359);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(582, 118);
            txtKetQua.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 530);
            Controls.Add(txtKetQua);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
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
        private TextBox txtA;
        private Label label3;
        private TextBox txtB;
        private Label label4;
        private TextBox txtC;
        private Label label5;
        private Button btnCalculate;
        private Button btnReset;
        private TextBox txtKetQua;
    }
}
