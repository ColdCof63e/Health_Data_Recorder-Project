using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Project.Validators;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void forgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            FileOperations.FileLogs(forgotPassword.Text);
            Forgot_Password frgtPass = new Forgot_Password();
            frgtPass.StartPosition = FormStartPosition.CenterScreen;
            frgtPass.MaximizeBox = false;
            frgtPass.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            FileOperations.FileLogs(loginBtn.Text);
            try
            {
                
                if(ValidateData.IsValidCredentials(emailBox.Text, passwordBox.Text))
                {
                    this.Hide();
                    UserHome usrHome = new UserHome();
                    usrHome.StartPosition = FormStartPosition.CenterScreen;
                    usrHome.WindowState = FormWindowState.Maximized;
                    usrHome.Show();
                }
                else
                {
                    promptLabel.Text = "Invalid Email or Password!";
                    promptLabel.Visible = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FileOperations.FileLogs(linkLabel1.Text);
            this.Hide();
            signUp accCreate = new signUp();
            accCreate.StartPosition = FormStartPosition.CenterScreen;
            accCreate.MaximizeBox = false;
            accCreate.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormClosing += Login_FormClosing;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new NotImplementedException();
            DialogResult result = MessageBox.Show("Do you want to Cancel Login?",
                "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}