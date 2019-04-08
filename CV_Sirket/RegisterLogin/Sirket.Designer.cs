namespace RegisterLogin
{
    partial class Sirket
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
            this.lbl_Vakansiya_adi = new System.Windows.Forms.Label();
            this.txbx_vakansiyaAdi = new System.Windows.Forms.TextBox();
            this.lbl_EmekHaqqi = new System.Windows.Forms.Label();
            this.lbl_teleb = new System.Windows.Forms.Label();
            this.txbx_Teleb = new System.Windows.Forms.TextBox();
            this.txbx_EmekHaqqi = new System.Windows.Forms.TextBox();
            this.Add_vakansiya = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getPostCV = new System.Windows.Forms.LinkLabel();
            this.lbl_sirketVakansiyalarLink = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Vakansiya_adi
            // 
            this.lbl_Vakansiya_adi.AutoSize = true;
            this.lbl_Vakansiya_adi.Location = new System.Drawing.Point(75, 40);
            this.lbl_Vakansiya_adi.Name = "lbl_Vakansiya_adi";
            this.lbl_Vakansiya_adi.Size = new System.Drawing.Size(77, 13);
            this.lbl_Vakansiya_adi.TabIndex = 0;
            this.lbl_Vakansiya_adi.Text = "Vakansiya Adi:";
            // 
            // txbx_vakansiyaAdi
            // 
            this.txbx_vakansiyaAdi.Location = new System.Drawing.Point(78, 70);
            this.txbx_vakansiyaAdi.Name = "txbx_vakansiyaAdi";
            this.txbx_vakansiyaAdi.Size = new System.Drawing.Size(271, 20);
            this.txbx_vakansiyaAdi.TabIndex = 1;
            // 
            // lbl_EmekHaqqi
            // 
            this.lbl_EmekHaqqi.AutoSize = true;
            this.lbl_EmekHaqqi.Location = new System.Drawing.Point(78, 112);
            this.lbl_EmekHaqqi.Name = "lbl_EmekHaqqi";
            this.lbl_EmekHaqqi.Size = new System.Drawing.Size(68, 13);
            this.lbl_EmekHaqqi.TabIndex = 2;
            this.lbl_EmekHaqqi.Text = "Emek Haqqi:";
            // 
            // lbl_teleb
            // 
            this.lbl_teleb.AutoSize = true;
            this.lbl_teleb.Location = new System.Drawing.Point(78, 185);
            this.lbl_teleb.Name = "lbl_teleb";
            this.lbl_teleb.Size = new System.Drawing.Size(37, 13);
            this.lbl_teleb.TabIndex = 3;
            this.lbl_teleb.Text = "Teleb:";
            // 
            // txbx_Teleb
            // 
            this.txbx_Teleb.Location = new System.Drawing.Point(81, 213);
            this.txbx_Teleb.Name = "txbx_Teleb";
            this.txbx_Teleb.Size = new System.Drawing.Size(268, 20);
            this.txbx_Teleb.TabIndex = 4;
            // 
            // txbx_EmekHaqqi
            // 
            this.txbx_EmekHaqqi.Location = new System.Drawing.Point(78, 137);
            this.txbx_EmekHaqqi.Name = "txbx_EmekHaqqi";
            this.txbx_EmekHaqqi.Size = new System.Drawing.Size(271, 20);
            this.txbx_EmekHaqqi.TabIndex = 2;
            // 
            // Add_vakansiya
            // 
            this.Add_vakansiya.Location = new System.Drawing.Point(171, 270);
            this.Add_vakansiya.Name = "Add_vakansiya";
            this.Add_vakansiya.Size = new System.Drawing.Size(75, 23);
            this.Add_vakansiya.TabIndex = 5;
            this.Add_vakansiya.Text = "Add";
            this.Add_vakansiya.UseVisualStyleBackColor = true;
            this.Add_vakansiya.Click += new System.EventHandler(this.Add_vakansiya_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Add_vakansiya);
            this.groupBox1.Controls.Add(this.txbx_EmekHaqqi);
            this.groupBox1.Controls.Add(this.txbx_Teleb);
            this.groupBox1.Controls.Add(this.lbl_teleb);
            this.groupBox1.Controls.Add(this.lbl_EmekHaqqi);
            this.groupBox1.Controls.Add(this.txbx_vakansiyaAdi);
            this.groupBox1.Controls.Add(this.lbl_Vakansiya_adi);
            this.groupBox1.Location = new System.Drawing.Point(28, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 333);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // getPostCV
            // 
            this.getPostCV.AutoSize = true;
            this.getPostCV.Location = new System.Drawing.Point(601, 13);
            this.getPostCV.Name = "getPostCV";
            this.getPostCV.Size = new System.Drawing.Size(69, 13);
            this.getPostCV.TabIndex = 2;
            this.getPostCV.TabStop = true;
            this.getPostCV.Text = "Gelen CV- ler";
            this.getPostCV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.getPostCV_LinkClicked);
            // 
            // lbl_sirketVakansiyalarLink
            // 
            this.lbl_sirketVakansiyalarLink.AutoSize = true;
            this.lbl_sirketVakansiyalarLink.Location = new System.Drawing.Point(601, 50);
            this.lbl_sirketVakansiyalarLink.Name = "lbl_sirketVakansiyalarLink";
            this.lbl_sirketVakansiyalarLink.Size = new System.Drawing.Size(67, 13);
            this.lbl_sirketVakansiyalarLink.TabIndex = 3;
            this.lbl_sirketVakansiyalarLink.TabStop = true;
            this.lbl_sirketVakansiyalarLink.Text = "Vakansiyalar";
            this.lbl_sirketVakansiyalarLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_sirketVakansiyalarLink_LinkClicked);
            // 
            // Sirket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 425);
            this.Controls.Add(this.lbl_sirketVakansiyalarLink);
            this.Controls.Add(this.getPostCV);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sirket";
            this.Text = " Sirket Vakansiya Add";
            this.Load += new System.EventHandler(this.Sirket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl_Vakansiya_adi;
        public System.Windows.Forms.TextBox txbx_vakansiyaAdi;
        public System.Windows.Forms.Label lbl_EmekHaqqi;
        public System.Windows.Forms.Label lbl_teleb;
        public System.Windows.Forms.TextBox txbx_Teleb;
        public System.Windows.Forms.TextBox txbx_EmekHaqqi;
        public System.Windows.Forms.Button Add_vakansiya;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.LinkLabel getPostCV;
        public System.Windows.Forms.LinkLabel lbl_sirketVakansiyalarLink;
    }
}