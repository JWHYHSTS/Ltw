namespace WF_MyVietlott
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
            btnGenerate = new Button();
            txtKq = new TextBox();
            rad645 = new RadioButton();
            rad655 = new RadioButton();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnGenerate.Location = new Point(322, 188);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(150, 46);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtKq
            // 
            txtKq.Location = new Point(139, 286);
            txtKq.Multiline = true;
            txtKq.Name = "txtKq";
            txtKq.Size = new Size(517, 114);
            txtKq.TabIndex = 1;
            // 
            // rad645
            // 
            rad645.AutoSize = true;
            rad645.Checked = true;
            rad645.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            rad645.Location = new Point(113, 49);
            rad645.Name = "rad645";
            rad645.Size = new Size(172, 36);
            rad645.TabIndex = 2;
            rad645.TabStop = true;
            rad645.Text = "Mega 6/45";
            rad645.UseVisualStyleBackColor = true;
            // 
            // rad655
            // 
            rad655.AutoSize = true;
            rad655.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            rad655.Location = new Point(477, 55);
            rad655.Name = "rad655";
            rad655.Size = new Size(180, 36);
            rad655.TabIndex = 3;
            rad655.Text = "Power 6/55";
            rad655.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rad655);
            Controls.Add(rad645);
            Controls.Add(txtKq);
            Controls.Add(btnGenerate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private TextBox txtKq;
        private RadioButton rad645;
        private RadioButton rad655;
    }
}
