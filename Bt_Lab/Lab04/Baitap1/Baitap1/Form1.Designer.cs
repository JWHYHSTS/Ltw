namespace Baitap1
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
            btnadd = new Button();
            btnclear = new Button();
            btnclose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cobtitle = new ComboBox();
            txtfirstname = new TextBox();
            txtlastname = new TextBox();
            lstdanhsach = new ListBox();
            btnsavefile = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.FromArgb(128, 255, 128);
            btnadd.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnadd.Location = new Point(64, 128);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(150, 46);
            btnadd.TabIndex = 0;
            btnadd.Text = "Add Name";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.FromArgb(255, 255, 128);
            btnclear.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnclear.Location = new Point(337, 128);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(150, 46);
            btnclear.TabIndex = 1;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.Red;
            btnclose.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnclose.Location = new Point(514, 128);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(150, 46);
            btnclose.TabIndex = 2;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label1.Location = new Point(154, 251);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label2.Location = new Point(436, 251);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 4;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label3.Location = new Point(738, 251);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 5;
            label3.Text = "Last Name";
            // 
            // cobtitle
            // 
            cobtitle.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            cobtitle.FormattingEnabled = true;
            cobtitle.Items.AddRange(new object[] { "Mr.", "Miss.", "Mrs.", "Dr." });
            cobtitle.Location = new Point(64, 295);
            cobtitle.Name = "cobtitle";
            cobtitle.Size = new Size(242, 34);
            cobtitle.TabIndex = 6;
            // 
            // txtfirstname
            // 
            txtfirstname.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            txtfirstname.Location = new Point(400, 295);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(200, 35);
            txtfirstname.TabIndex = 7;
            // 
            // txtlastname
            // 
            txtlastname.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            txtlastname.Location = new Point(688, 295);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(200, 35);
            txtlastname.TabIndex = 8;
            // 
            // lstdanhsach
            // 
            lstdanhsach.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            lstdanhsach.FormattingEnabled = true;
            lstdanhsach.ItemHeight = 26;
            lstdanhsach.Location = new Point(64, 421);
            lstdanhsach.Name = "lstdanhsach";
            lstdanhsach.Size = new Size(824, 186);
            lstdanhsach.TabIndex = 9;
            // 
            // btnsavefile
            // 
            btnsavefile.BackColor = Color.FromArgb(128, 255, 255);
            btnsavefile.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnsavefile.Location = new Point(738, 128);
            btnsavefile.Name = "btnsavefile";
            btnsavefile.Size = new Size(150, 46);
            btnsavefile.TabIndex = 10;
            btnsavefile.Text = "Save to file";
            btnsavefile.UseVisualStyleBackColor = false;
            btnsavefile.Click += btnsavefile_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 255, 192);
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(413, 19);
            label4.Name = "label4";
            label4.Size = new Size(126, 30);
            label4.TabIndex = 11;
            label4.Text = "Danh sách ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 665);
            Controls.Add(label4);
            Controls.Add(btnsavefile);
            Controls.Add(lstdanhsach);
            Controls.Add(txtlastname);
            Controls.Add(txtfirstname);
            Controls.Add(cobtitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnclose);
            Controls.Add(btnclear);
            Controls.Add(btnadd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnadd;
        private Button btnclear;
        private Button btnclose;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cobtitle;
        private TextBox txtfirstname;
        private TextBox txtlastname;
        private ListBox lstdanhsach;
        private Button btnsavefile;
        private Label label4;
    }
}
