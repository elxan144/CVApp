namespace RegisterLogin
{
    partial class Vakansiyalar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_NameEmailReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_NameEmailReg
            // 
            this.lbl_NameEmailReg.AutoSize = true;
            this.lbl_NameEmailReg.Location = new System.Drawing.Point(539, 22);
            this.lbl_NameEmailReg.Name = "lbl_NameEmailReg";
            this.lbl_NameEmailReg.Size = new System.Drawing.Size(58, 13);
            this.lbl_NameEmailReg.TabIndex = 4;
            this.lbl_NameEmailReg.Text = "Welcome: ";
            this.lbl_NameEmailReg.Click += new System.EventHandler(this.lbl_NameEmailReg_Click);
            // 
            // Vakansiyalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(840, 460);
            this.Controls.Add(this.lbl_NameEmailReg);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Vakansiyalar";
            this.Text = "Vakansiyalar";
            this.Load += new System.EventHandler(this.Vakansiyalar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl_NameEmailReg;
    }
}