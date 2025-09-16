namespace WF_MenuMonAn
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
            txttenmon = new TextBox();
            btnthem = new Button();
            lstthucdon = new ListBox();
            lstchon = new ListBox();
            btnchon = new Button();
            btnchontatca = new Button();
            btnxoa = new Button();
            btnxoatatca = new Button();
            btnexit = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label1.Location = new Point(59, 124);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên Món";
            // 
            // txttenmon
            // 
            txttenmon.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            txttenmon.Location = new Point(209, 120);
            txttenmon.Name = "txttenmon";
            txttenmon.Size = new Size(382, 35);
            txttenmon.TabIndex = 1;
            txttenmon.KeyPress += txttenmon_KeyPress;
            txttenmon.KeyUp += txttenmon_KeyUp;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.Cyan;
            btnthem.Enabled = false;
            btnthem.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnthem.Location = new Point(647, 114);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(150, 46);
            btnthem.TabIndex = 2;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // lstthucdon
            // 
            lstthucdon.BorderStyle = BorderStyle.FixedSingle;
            lstthucdon.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            lstthucdon.FormattingEnabled = true;
            lstthucdon.ItemHeight = 26;
            lstthucdon.Location = new Point(60, 224);
            lstthucdon.Name = "lstthucdon";
            lstthucdon.SelectionMode = SelectionMode.MultiSimple;
            lstthucdon.Size = new Size(311, 418);
            lstthucdon.TabIndex = 3;
            // 
            // lstchon
            // 
            lstchon.BorderStyle = BorderStyle.FixedSingle;
            lstchon.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            lstchon.FormattingEnabled = true;
            lstchon.ItemHeight = 26;
            lstchon.Location = new Point(486, 224);
            lstchon.Name = "lstchon";
            lstchon.SelectionMode = SelectionMode.MultiSimple;
            lstchon.Size = new Size(311, 418);
            lstchon.TabIndex = 4;
            // 
            // btnchon
            // 
            btnchon.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnchon.Location = new Point(396, 297);
            btnchon.Name = "btnchon";
            btnchon.Size = new Size(68, 46);
            btnchon.TabIndex = 5;
            btnchon.Text = ">";
            btnchon.UseVisualStyleBackColor = true;
            btnchon.Click += btnchon_Click;
            // 
            // btnchontatca
            // 
            btnchontatca.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnchontatca.Location = new Point(396, 388);
            btnchontatca.Name = "btnchontatca";
            btnchontatca.Size = new Size(68, 46);
            btnchontatca.TabIndex = 6;
            btnchontatca.Text = ">>";
            btnchontatca.UseVisualStyleBackColor = true;
            btnchontatca.Click += btnchontatca_Click;
            // 
            // btnxoa
            // 
            btnxoa.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnxoa.Location = new Point(396, 473);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(68, 46);
            btnxoa.TabIndex = 7;
            btnxoa.Text = "<";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnxoatatca
            // 
            btnxoatatca.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnxoatatca.Location = new Point(396, 561);
            btnxoatatca.Name = "btnxoatatca";
            btnxoatatca.Size = new Size(68, 46);
            btnxoatatca.TabIndex = 8;
            btnxoatatca.Text = "<<";
            btnxoatatca.UseVisualStyleBackColor = true;
            btnxoatatca.Click += btnxoatatca_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.Red;
            btnexit.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnexit.Location = new Point(647, 669);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(150, 46);
            btnexit.TabIndex = 9;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Yellow;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Times New Roman", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(336, 29);
            label2.Name = "label2";
            label2.Size = new Size(197, 35);
            label2.TabIndex = 10;
            label2.Text = "ĐẶT MÓN ĂN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 742);
            Controls.Add(label2);
            Controls.Add(btnexit);
            Controls.Add(btnxoatatca);
            Controls.Add(btnxoa);
            Controls.Add(btnchontatca);
            Controls.Add(btnchon);
            Controls.Add(lstchon);
            Controls.Add(lstthucdon);
            Controls.Add(btnthem);
            Controls.Add(txttenmon);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ĐẶT MÓN ĂN";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txttenmon;
        private Button btnthem;
        private ListBox lstthucdon;
        private ListBox lstchon;
        private Button btnchon;
        private Button btnchontatca;
        private Button btnxoa;
        private Button btnxoatatca;
        private Button btnexit;
        private Label label2;
    }
}
