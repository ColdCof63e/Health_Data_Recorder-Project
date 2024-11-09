namespace Project
{
    partial class Login
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
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.forgotPassword = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(224, 44);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 20);
            this.emailBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(224, 89);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 2;
            // 
            // forgotPassword
            // 
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.Location = new System.Drawing.Point(202, 137);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(92, 13);
            this.forgotPassword.TabIndex = 4;
            this.forgotPassword.Text = "Forgot Password?";
            this.forgotPassword.Click += new System.EventHandler(this.forgotPassword_Click);
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(210, 180);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(68, 13);
            this.promptLabel.TabIndex = 5;
            this.promptLabel.Text = "prompt Label";
            this.promptLabel.Visible = false;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(205, 222);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(203, 261);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create Account";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.forgotPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label forgotPassword;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}