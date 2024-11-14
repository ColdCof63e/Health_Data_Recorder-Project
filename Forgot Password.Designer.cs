namespace Project
{
    partial class Forgot_Password
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
            this.requestEmail = new System.Windows.Forms.Label();
            this.enterMail = new System.Windows.Forms.TextBox();
            this.enterVerificationCode = new System.Windows.Forms.TextBox();
            this.codeVerification = new System.Windows.Forms.Label();
            this.enterPasswordBox = new System.Windows.Forms.TextBox();
            this.enterPassword = new System.Windows.Forms.Label();
            this.confirmPasswordBox = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.uniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // requestEmail
            // 
            this.requestEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.requestEmail.AutoSize = true;
            this.requestEmail.Location = new System.Drawing.Point(154, 15);
            this.requestEmail.Name = "requestEmail";
            this.requestEmail.Size = new System.Drawing.Size(88, 13);
            this.requestEmail.TabIndex = 0;
            this.requestEmail.Text = "Enter Your Email:";
            // 
            // enterMail
            // 
            this.enterMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterMail.Location = new System.Drawing.Point(248, 12);
            this.enterMail.Name = "enterMail";
            this.enterMail.Size = new System.Drawing.Size(100, 20);
            this.enterMail.TabIndex = 1;
            // 
            // enterVerificationCode
            // 
            this.enterVerificationCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterVerificationCode.Location = new System.Drawing.Point(248, 65);
            this.enterVerificationCode.Name = "enterVerificationCode";
            this.enterVerificationCode.Size = new System.Drawing.Size(100, 20);
            this.enterVerificationCode.TabIndex = 3;
            this.enterVerificationCode.Visible = false;
            // 
            // codeVerification
            // 
            this.codeVerification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeVerification.AutoSize = true;
            this.codeVerification.Location = new System.Drawing.Point(178, 68);
            this.codeVerification.Name = "codeVerification";
            this.codeVerification.Size = new System.Drawing.Size(64, 13);
            this.codeVerification.TabIndex = 2;
            this.codeVerification.Text = "Verify Code:";
            this.codeVerification.Visible = false;
            // 
            // enterPasswordBox
            // 
            this.enterPasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterPasswordBox.Location = new System.Drawing.Point(248, 118);
            this.enterPasswordBox.Name = "enterPasswordBox";
            this.enterPasswordBox.PasswordChar = '*';
            this.enterPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.enterPasswordBox.TabIndex = 5;
            this.enterPasswordBox.Visible = false;
            // 
            // enterPassword
            // 
            this.enterPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterPassword.AutoSize = true;
            this.enterPassword.Location = new System.Drawing.Point(158, 122);
            this.enterPassword.Name = "enterPassword";
            this.enterPassword.Size = new System.Drawing.Size(84, 13);
            this.enterPassword.TabIndex = 4;
            this.enterPassword.Text = "Enter Password:";
            this.enterPassword.Visible = false;
            // 
            // confirmPasswordBox
            // 
            this.confirmPasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPasswordBox.Location = new System.Drawing.Point(248, 171);
            this.confirmPasswordBox.Name = "confirmPasswordBox";
            this.confirmPasswordBox.PasswordChar = '*';
            this.confirmPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.confirmPasswordBox.TabIndex = 7;
            this.confirmPasswordBox.Visible = false;
            // 
            // confirmPassword
            // 
            this.confirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Location = new System.Drawing.Point(148, 176);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(94, 13);
            this.confirmPassword.TabIndex = 6;
            this.confirmPassword.Text = "Confirm Password:";
            this.confirmPassword.Visible = false;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(215, 223);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(68, 13);
            this.promptLabel.TabIndex = 8;
            this.promptLabel.Text = "prompt Label";
            this.promptLabel.Visible = false;
            // 
            // uniButton
            // 
            this.uniButton.Location = new System.Drawing.Point(207, 261);
            this.uniButton.Name = "uniButton";
            this.uniButton.Size = new System.Drawing.Size(75, 23);
            this.uniButton.TabIndex = 9;
            this.uniButton.Text = "Send Code";
            this.uniButton.UseVisualStyleBackColor = true;
            this.uniButton.Click += new System.EventHandler(this.uniButton_Click);
            // 
            // Forgot_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.uniButton);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.confirmPasswordBox);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.enterPasswordBox);
            this.Controls.Add(this.enterPassword);
            this.Controls.Add(this.enterVerificationCode);
            this.Controls.Add(this.codeVerification);
            this.Controls.Add(this.enterMail);
            this.Controls.Add(this.requestEmail);
            this.Name = "Forgot_Password";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.Forgot_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label requestEmail;
        private System.Windows.Forms.TextBox enterMail;
        private System.Windows.Forms.TextBox enterVerificationCode;
        private System.Windows.Forms.Label codeVerification;
        private System.Windows.Forms.TextBox enterPasswordBox;
        private System.Windows.Forms.Label enterPassword;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.Label confirmPassword;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button uniButton;
    }
}