namespace Baitap2
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
            txtdong = new TextBox();
            txtcot = new TextBox();
            btnkhoitaoform = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 79);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 0;
            label1.Text = "Số dòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 153);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 1;
            label2.Text = "Số cột";
            // 
            // txtdong
            // 
            txtdong.Location = new Point(238, 76);
            txtdong.Name = "txtdong";
            txtdong.Size = new Size(200, 39);
            txtdong.TabIndex = 2;
            // 
            // txtcot
            // 
            txtcot.Location = new Point(238, 150);
            txtcot.Name = "txtcot";
            txtcot.Size = new Size(200, 39);
            txtcot.TabIndex = 3;
            // 
            // btnkhoitaoform
            // 
            btnkhoitaoform.Location = new Point(480, 88);
            btnkhoitaoform.Name = "btnkhoitaoform";
            btnkhoitaoform.Size = new Size(150, 85);
            btnkhoitaoform.TabIndex = 4;
            btnkhoitaoform.Text = "Khởi tạo form";
            btnkhoitaoform.UseVisualStyleBackColor = true;
            btnkhoitaoform.Click += btnkhoitaoform_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 9);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 231);
            Controls.Add(label3);
            Controls.Add(btnkhoitaoform);
            Controls.Add(txtcot);
            Controls.Add(txtdong);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "NHẬP LIỆU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtdong;
        private TextBox txtcot;
        private Button btnkhoitaoform;
        private Label label3;
    }
}
