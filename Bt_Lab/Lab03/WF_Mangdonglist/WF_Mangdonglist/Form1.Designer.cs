namespace WF_Mangdonglist
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
            txtsophantu = new TextBox();
            txtgiatri = new TextBox();
            btntaomang = new Button();
            btnxoamang = new Button();
            btntim = new Button();
            btnxoa = new Button();
            txtkq = new TextBox();
            label3 = new Label();
            btnreset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 0;
            label1.Text = "SỐ PHẦN TỬ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 9F, FontStyle.Bold);
            label2.Location = new Point(43, 163);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 1;
            label2.Text = "GIÁ TRỊ";
            // 
            // txtsophantu
            // 
            txtsophantu.Font = new Font("Century", 9F, FontStyle.Bold);
            txtsophantu.Location = new Point(195, 80);
            txtsophantu.Name = "txtsophantu";
            txtsophantu.Size = new Size(200, 36);
            txtsophantu.TabIndex = 2;
            // 
            // txtgiatri
            // 
            txtgiatri.Font = new Font("Century", 9F, FontStyle.Bold);
            txtgiatri.Location = new Point(195, 156);
            txtgiatri.Name = "txtgiatri";
            txtgiatri.Size = new Size(200, 36);
            txtgiatri.TabIndex = 3;
            // 
            // btntaomang
            // 
            btntaomang.Font = new Font("Century", 9F, FontStyle.Bold);
            btntaomang.ForeColor = Color.Blue;
            btntaomang.Location = new Point(423, 80);
            btntaomang.Name = "btntaomang";
            btntaomang.Size = new Size(175, 46);
            btntaomang.TabIndex = 4;
            btntaomang.Text = "TẠO MẢNG";
            btntaomang.UseVisualStyleBackColor = true;
            btntaomang.Click += btntaomang_Click;
            // 
            // btnxoamang
            // 
            btnxoamang.Font = new Font("Century", 9F, FontStyle.Bold);
            btnxoamang.ForeColor = Color.FromArgb(255, 128, 0);
            btnxoamang.Location = new Point(621, 80);
            btnxoamang.Name = "btnxoamang";
            btnxoamang.Size = new Size(167, 46);
            btnxoamang.TabIndex = 5;
            btnxoamang.Text = "XÓA MẢNG";
            btnxoamang.UseVisualStyleBackColor = true;
            btnxoamang.Click += btnxoamang_Click;
            // 
            // btntim
            // 
            btntim.Font = new Font("Century", 9F, FontStyle.Bold);
            btntim.ForeColor = Color.FromArgb(128, 255, 128);
            btntim.Location = new Point(466, 149);
            btntim.Name = "btntim";
            btntim.Size = new Size(88, 46);
            btntim.TabIndex = 6;
            btntim.Text = "TÌM";
            btntim.UseVisualStyleBackColor = true;
            btntim.Click += btntim_Click;
            // 
            // btnxoa
            // 
            btnxoa.Font = new Font("Century", 9F, FontStyle.Bold);
            btnxoa.ForeColor = Color.Red;
            btnxoa.Location = new Point(660, 149);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(88, 46);
            btnxoa.TabIndex = 7;
            btnxoa.Text = "XÓA";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // txtkq
            // 
            txtkq.Location = new Point(163, 264);
            txtkq.Multiline = true;
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(486, 158);
            txtkq.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 9F, FontStyle.Bold);
            label3.Location = new Point(313, 18);
            label3.Name = "label3";
            label3.Size = new Size(206, 28);
            label3.TabIndex = 9;
            label3.Text = "BÀI TẬP MẢNG";
            // 
            // btnreset
            // 
            btnreset.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnreset.ForeColor = Color.Fuchsia;
            btnreset.Location = new Point(540, 201);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(134, 46);
            btnreset.TabIndex = 10;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnreset);
            Controls.Add(label3);
            Controls.Add(txtkq);
            Controls.Add(btnxoa);
            Controls.Add(btntim);
            Controls.Add(btnxoamang);
            Controls.Add(btntaomang);
            Controls.Add(txtgiatri);
            Controls.Add(txtsophantu);
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
        private TextBox txtsophantu;
        private TextBox txtgiatri;
        private Button btntaomang;
        private Button btnxoamang;
        private Button btntim;
        private Button btnxoa;
        private TextBox txtkq;
        private Label label3;
        private Button btnreset;
    }
}
