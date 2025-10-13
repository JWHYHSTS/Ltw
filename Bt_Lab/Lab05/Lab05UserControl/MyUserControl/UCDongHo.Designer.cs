namespace MyUserControl
{
    partial class UCDongHo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Lbldongho = new Label();
            btnstart = new Button();
            btnlap = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Lbldongho
            // 
            Lbldongho.AutoSize = true;
            Lbldongho.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbldongho.ForeColor = Color.FromArgb(0, 0, 192);
            Lbldongho.Location = new Point(202, 47);
            Lbldongho.Name = "Lbldongho";
            Lbldongho.Size = new Size(248, 50);
            Lbldongho.TabIndex = 0;
            Lbldongho.Text = "00:00:00 0000";
            // 
            // btnstart
            // 
            btnstart.Location = new Point(112, 100);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(150, 46);
            btnstart.TabIndex = 1;
            btnstart.Text = "START";
            btnstart.UseVisualStyleBackColor = true;
            btnstart.Click += btnstart_Click;
            // 
            // btnlap
            // 
            btnlap.Location = new Point(382, 100);
            btnlap.Name = "btnlap";
            btnlap.Size = new Size(150, 46);
            btnlap.TabIndex = 2;
            btnlap.Text = "LAP";
            btnlap.UseVisualStyleBackColor = true;
            btnlap.Click += btnlap_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // UCDongHo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnlap);
            Controls.Add(btnstart);
            Controls.Add(Lbldongho);
            Name = "UCDongHo";
            Size = new Size(688, 353);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbldongho;
        private Button btnstart;
        private Button btnlap;
        private System.Windows.Forms.Timer timer1;

        // Add this method to your UCDongHo class (e.g., in UCDongHo.cs)
    }
}
