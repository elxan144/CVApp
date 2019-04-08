namespace RegisterLogin
{
    partial class Form1
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
            this.labelUser = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.GroupBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_txbx_email = new System.Windows.Forms.TextBox();
            this.login_labelEmail = new System.Windows.Forms.Label();
            this.Login_txbx_password = new System.Windows.Forms.TextBox();
            this.login_labelPassword = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.GroupBox();
            this.Register_btn = new System.Windows.Forms.Button();
            this.txbx_surname = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_confirmPassword = new System.Windows.Forms.Label();
            this.txbx_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.txbx_password = new System.Windows.Forms.TextBox();
            this.label_surname = new System.Windows.Forms.Label();
            this.txbx_email = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.Login.SuspendLayout();
            this.Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(444, 293);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(13, 13);
            this.labelUser.TabIndex = 17;
            this.labelUser.Text = "0";
            // 
            // Login
            // 
            this.Login.Controls.Add(this.login_btn);
            this.Login.Controls.Add(this.login_txbx_email);
            this.Login.Controls.Add(this.login_labelEmail);
            this.Login.Controls.Add(this.Login_txbx_password);
            this.Login.Controls.Add(this.login_labelPassword);
            this.Login.Location = new System.Drawing.Point(444, 12);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(318, 229);
            this.Login.TabIndex = 16;
            this.Login.TabStop = false;
            this.Login.Text = "Login";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_btn.Location = new System.Drawing.Point(87, 170);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(82, 30);
            this.login_btn.TabIndex = 15;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_txbx_email
            // 
            this.login_txbx_email.Location = new System.Drawing.Point(29, 68);
            this.login_txbx_email.Name = "login_txbx_email";
            this.login_txbx_email.Size = new System.Drawing.Size(255, 20);
            this.login_txbx_email.TabIndex = 14;
            // 
            // login_labelEmail
            // 
            this.login_labelEmail.AutoSize = true;
            this.login_labelEmail.Location = new System.Drawing.Point(26, 41);
            this.login_labelEmail.Name = "login_labelEmail";
            this.login_labelEmail.Size = new System.Drawing.Size(35, 13);
            this.login_labelEmail.TabIndex = 11;
            this.login_labelEmail.Text = "Email:";
            // 
            // Login_txbx_password
            // 
            this.Login_txbx_password.Location = new System.Drawing.Point(29, 125);
            this.Login_txbx_password.Name = "Login_txbx_password";
            this.Login_txbx_password.Size = new System.Drawing.Size(255, 20);
            this.Login_txbx_password.TabIndex = 13;
            // 
            // login_labelPassword
            // 
            this.login_labelPassword.AutoSize = true;
            this.login_labelPassword.Location = new System.Drawing.Point(26, 102);
            this.login_labelPassword.Name = "login_labelPassword";
            this.login_labelPassword.Size = new System.Drawing.Size(56, 13);
            this.login_labelPassword.TabIndex = 12;
            this.login_labelPassword.Text = "Password:";
            // 
            // Register
            // 
            this.Register.Controls.Add(this.Register_btn);
            this.Register.Controls.Add(this.txbx_surname);
            this.Register.Controls.Add(this.label_name);
            this.Register.Controls.Add(this.label_confirmPassword);
            this.Register.Controls.Add(this.txbx_ConfirmPassword);
            this.Register.Controls.Add(this.txbx_name);
            this.Register.Controls.Add(this.txbx_password);
            this.Register.Controls.Add(this.label_surname);
            this.Register.Controls.Add(this.txbx_email);
            this.Register.Controls.Add(this.label_password);
            this.Register.Controls.Add(this.label_email);
            this.Register.Location = new System.Drawing.Point(39, 3);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(306, 444);
            this.Register.TabIndex = 15;
            this.Register.TabStop = false;
            this.Register.Text = "Register";
            // 
            // Register_btn
            // 
            this.Register_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Register_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Register_btn.Location = new System.Drawing.Point(77, 367);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(82, 30);
            this.Register_btn.TabIndex = 11;
            this.Register_btn.Text = "Register";
            this.Register_btn.UseVisualStyleBackColor = false;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // txbx_surname
            // 
            this.txbx_surname.Location = new System.Drawing.Point(24, 128);
            this.txbx_surname.Name = "txbx_surname";
            this.txbx_surname.Size = new System.Drawing.Size(195, 20);
            this.txbx_surname.TabIndex = 10;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(21, 40);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name:";
            // 
            // label_confirmPassword
            // 
            this.label_confirmPassword.AutoSize = true;
            this.label_confirmPassword.Location = new System.Drawing.Point(21, 290);
            this.label_confirmPassword.Name = "label_confirmPassword";
            this.label_confirmPassword.Size = new System.Drawing.Size(94, 13);
            this.label_confirmPassword.TabIndex = 4;
            this.label_confirmPassword.Text = "Confirm Password:";
            // 
            // txbx_ConfirmPassword
            // 
            this.txbx_ConfirmPassword.Location = new System.Drawing.Point(24, 316);
            this.txbx_ConfirmPassword.Name = "txbx_ConfirmPassword";
            this.txbx_ConfirmPassword.Size = new System.Drawing.Size(195, 20);
            this.txbx_ConfirmPassword.TabIndex = 9;
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(24, 61);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(195, 20);
            this.txbx_name.TabIndex = 5;
            // 
            // txbx_password
            // 
            this.txbx_password.Location = new System.Drawing.Point(24, 247);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.Size = new System.Drawing.Size(195, 20);
            this.txbx_password.TabIndex = 8;
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(21, 101);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(52, 13);
            this.label_surname.TabIndex = 1;
            this.label_surname.Text = "Surname:";
            // 
            // txbx_email
            // 
            this.txbx_email.Location = new System.Drawing.Point(24, 185);
            this.txbx_email.Name = "txbx_email";
            this.txbx_email.Size = new System.Drawing.Size(195, 20);
            this.txbx_email.TabIndex = 7;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(21, 225);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 13);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Password:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(21, 162);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(35, 13);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "Email:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 538);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Register);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.Register.ResumeLayout(false);
            this.Register.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.GroupBox Login;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox login_txbx_email;
        private System.Windows.Forms.Label login_labelEmail;
        private System.Windows.Forms.TextBox Login_txbx_password;
        private System.Windows.Forms.Label login_labelPassword;
        private System.Windows.Forms.GroupBox Register;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.TextBox txbx_surname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_confirmPassword;
        private System.Windows.Forms.TextBox txbx_ConfirmPassword;
        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.TextBox txbx_password;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.TextBox txbx_email;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_email;
    }
}

