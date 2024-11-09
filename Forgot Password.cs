﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Project
{
    public partial class Forgot_Password : Form
    {
        private List<int> codes = new List<int>();
        private int code;
        private Random random = new Random();
        public Forgot_Password()
        {
            InitializeComponent();
            uniButton.Text = "Send Code";
            
            codeVerification.Visible = false;
            enterVerificationCode.Visible = false;

            enterPassword.Visible = false;
            enterPasswordBox.Visible = false;
            confirmPassword.Visible = false;
            confirmPasswordBox.Visible = false;
            
            promptLabel.Visible = false;
        }

        private void uniButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(!ValidateData.EmailAvailability(enterMail.Text))
                {
                    promptLabel.Text = "Email does not exists!";
                    promptLabel.Visible = true;
                    return;
                }

                if (uniButton.Text == "Send Code")
                {
                    FileOperations.FileLogs(uniButton.Text);
                    code = GenerateVerificationCode();
                    codes.Add(code);
                    Console.WriteLine(code);
                    uniButton.Text = "Verify Code";
                    codeVerification.Visible = true;
                    enterVerificationCode.Visible = true;
                    promptLabel.Visible = false;
                    return;
                }

                if(uniButton.Text == "Verify Code")
                {
                    FileOperations.FileLogs(uniButton.Text+ ": Before entering code");
                    try
                    {
                        int enteredCode = int.Parse(enterVerificationCode.Text);
                        if (codes.Contains(enteredCode))
                        {
                            FileOperations.FileLogs(uniButton.Text+" :After entering code");
                            promptLabel.Text = "Code verified successfully!";
                            promptLabel.Visible = true;
                            enterPassword.Visible = true;
                            enterPasswordBox.Visible = true;
                            confirmPassword.Visible = true;
                            confirmPasswordBox.Visible = true;

                            enterPasswordBox.Focus();

                            uniButton.Text = "Reset Password";
                        }
                        else
                        {
                            promptLabel.Text = "Incorrect verification code.";
                            promptLabel.Visible = true;
                            enterVerificationCode.Clear();
                        }
                    }
                    catch (FormatException)
                    {
                        promptLabel.Text = "Invalid verification code format!";
                        promptLabel.Visible = true;
                    }
                }

                if (uniButton.Text == "Reset Password")
                {
                    FileOperations.FileLogs(uniButton.Text+": Before entering password");
                    if (!ValidateData.EmptyFieldChecks(enterPasswordBox))
                    {
                        if ((!ValidateData.PassMatch(enterPasswordBox.Text, confirmPasswordBox.Text)))
                        {
                            FileOperations.FileLogs(uniButton.Text+": After entring Incorrect password");
                            promptLabel.Text = "Passwords do not match!";
                            promptLabel.Visible = true;
                            return;
                        }


                        if (FileOperations.PasswordReset(enterMail.Text, enterPasswordBox.Text))
                        {
                            FileOperations.FileLogs(uniButton.Text + ": After entring password");
                            MessageBox.Show("Password Reset Successfully!", "Success", MessageBoxButtons.OK);
                            this.Hide();
                            Login login = new Login();
                            login.StartPosition = FormStartPosition.CenterScreen;
                            login.MaximizeBox = false;
                            login.Show();
                        }
                        else
                        {
                            promptLabel.Text = "Password reset failed.";
                            promptLabel.Visible = true;
                        }
                    }
                    else
                    {
                        promptLabel.Text = "Enter Password";
                        promptLabel.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int GenerateVerificationCode()
        {
            return 100000 + random.Next(900000);
        }
    }
}
