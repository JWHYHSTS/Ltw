namespace MyPaint
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
            splitContainer1 = new SplitContainer();
            groupBox2 = new GroupBox();
            btnfill = new Button();
            label5 = new Label();
            groupBox1 = new GroupBox();
            nudsize = new NumericUpDown();
            label3 = new Label();
            btnborder = new Button();
            label2 = new Label();
            cbotype = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudsize).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(cbotype);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.MouseDown += splitContainer1_Panel2_MouseDown;
            splitContainer1.Panel2.MouseUp += splitContainer1_Panel2_MouseUp;
            splitContainer1.Size = new Size(1048, 629);
            splitContainer1.SplitterDistance = 349;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnfill);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(34, 387);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 111);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fill";
            // 
            // btnfill
            // 
            btnfill.BackColor = Color.Black;
            btnfill.FlatStyle = FlatStyle.Flat;
            btnfill.Location = new Point(120, 38);
            btnfill.Name = "btnfill";
            btnfill.Size = new Size(155, 46);
            btnfill.TabIndex = 1;
            btnfill.Text = "button2";
            btnfill.UseVisualStyleBackColor = false;
            btnfill.Click += btnfill_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 45);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 0;
            label5.Text = "Color";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudsize);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnborder);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(34, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 200);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Border";
            // 
            // nudsize
            // 
            nudsize.Location = new Point(120, 133);
            nudsize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudsize.Name = "nudsize";
            nudsize.Size = new Size(149, 39);
            nudsize.TabIndex = 3;
            nudsize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 134);
            label3.Name = "label3";
            label3.Size = new Size(57, 32);
            label3.TabIndex = 2;
            label3.Text = "Size";
            // 
            // btnborder
            // 
            btnborder.BackColor = Color.Black;
            btnborder.FlatStyle = FlatStyle.Flat;
            btnborder.Location = new Point(120, 38);
            btnborder.Name = "btnborder";
            btnborder.Size = new Size(155, 46);
            btnborder.TabIndex = 1;
            btnborder.Text = "button1";
            btnborder.UseVisualStyleBackColor = false;
            btnborder.Click += btnborder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(71, 32);
            label2.TabIndex = 0;
            label2.Text = "Color";
            // 
            // cbotype
            // 
            cbotype.DropDownStyle = ComboBoxStyle.DropDownList;
            cbotype.FormattingEnabled = true;
            cbotype.Items.AddRange(new object[] { "Draw Line", "Draw Rectangle", "Draw Ellipse", "Fill Rectangle", "Fill Ellipse" });
            cbotype.Location = new Point(34, 85);
            cbotype.Name = "cbotype";
            cbotype.Size = new Size(275, 40);
            cbotype.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 0;
            label1.Text = "Type";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 629);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "My Paint";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudsize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private NumericUpDown nudsize;
        private Label label3;
        private Button btnborder;
        private Label label2;
        private ComboBox cbotype;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnfill;
        private Label label5;
    }
}
