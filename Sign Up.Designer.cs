namespace Project
{
    partial class signUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signUpBtn1 = new System.Windows.Forms.Button();
            this.techCheckBox = new System.Windows.Forms.CheckBox();
            this.promptLabel = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.enterPassword = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.eMailBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.signUpBtn1);
            this.panel1.Controls.Add(this.techCheckBox);
            this.panel1.Controls.Add(this.promptLabel);
            this.panel1.Controls.Add(this.confirmPassword);
            this.panel1.Controls.Add(this.enterPassword);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.eMailBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 297);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Re-enter Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Enter Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Email:";
            // 
            // signUpBtn1
            // 
            this.signUpBtn1.Location = new System.Drawing.Point(179, 242);
            this.signUpBtn1.Name = "signUpBtn1";
            this.signUpBtn1.Size = new System.Drawing.Size(75, 23);
            this.signUpBtn1.TabIndex = 17;
            this.signUpBtn1.Text = "Sign Up";
            this.signUpBtn1.UseVisualStyleBackColor = true;
            this.signUpBtn1.Click += new System.EventHandler(this.signUpBtn1_Click);
            // 
            // techCheckBox
            // 
            this.techCheckBox.AutoSize = true;
            this.techCheckBox.Location = new System.Drawing.Point(164, 193);
            this.techCheckBox.Name = "techCheckBox";
            this.techCheckBox.Size = new System.Drawing.Size(126, 17);
            this.techCheckBox.TabIndex = 16;
            this.techCheckBox.Text = "Are You Technician?";
            this.techCheckBox.UseVisualStyleBackColor = true;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(186, 216);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(65, 13);
            this.promptLabel.TabIndex = 15;
            this.promptLabel.Text = "promptLabel";
            this.promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.promptLabel.Visible = false;
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(204, 157);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(100, 20);
            this.confirmPassword.TabIndex = 14;
            this.confirmPassword.UseSystemPasswordChar = true;
            // 
            // enterPassword
            // 
            this.enterPassword.Location = new System.Drawing.Point(204, 112);
            this.enterPassword.Name = "enterPassword";
            this.enterPassword.Size = new System.Drawing.Size(100, 20);
            this.enterPassword.TabIndex = 13;
            this.enterPassword.UseSystemPasswordChar = true;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(204, 66);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 12;
            // 
            // eMailBox
            // 
            this.eMailBox.AcceptsReturn = true;
            this.eMailBox.Location = new System.Drawing.Point(204, 24);
            this.eMailBox.Name = "eMailBox";
            this.eMailBox.Size = new System.Drawing.Size(100, 20);
            this.eMailBox.TabIndex = 11;
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "signUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.signUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signUpBtn1;
        private System.Windows.Forms.CheckBox techCheckBox;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.TextBox enterPassword;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox eMailBox;
    }
}

