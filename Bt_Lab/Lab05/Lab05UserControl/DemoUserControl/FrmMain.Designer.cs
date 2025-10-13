namespace DemoUserControl
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
            ucDongHo1 = new MyUserControl.UCDongHo();
            ucDongHo2 = new MyUserControl.UCDongHo();
            SuspendLayout();
            // 
            // ucDongHo1
            // 
            ucDongHo1.Location = new Point(73, 27);
            ucDongHo1.Name = "ucDongHo1";
            ucDongHo1.Size = new Size(631, 174);
            ucDongHo1.TabIndex = 0;
            // 
            // ucDongHo2
            // 
            ucDongHo2.Location = new Point(73, 207);
            ucDongHo2.Name = "ucDongHo2";
            ucDongHo2.Size = new Size(631, 174);
            ucDongHo2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ucDongHo2);
            Controls.Add(ucDongHo1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private MyUserControl.UCDongHo ucDongHo1;
        private MyUserControl.UCDongHo ucDongHo2;
    }
}
