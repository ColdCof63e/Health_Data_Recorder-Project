using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
            promptLabel.Visible = false;
        }

        private void signUpBtn1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Clicked");
            string email = eMailBox.Text;
            string password1 = enterPassword.Text;
            string password2 = confirmPassword.Text;
            string name = nameBox.Text;
            string tech = techCheckBox.Checked.ToString();

            if (!ValidateData.EmailRegex(email)) 
            {
                promptLabel.Text = "Invalid Email!";
                promptLabel.Visible = true;
                return;
            }

            if (ValidateData.EmailAvailability(email))
            {
                promptLabel.Text = "Email exists!";
                promptLabel.Visible = true;
                return;
            }

            if (!ValidateData.PassMatch(password1, password2))
            {
                promptLabel.Text = "Password Fails to Match!";
                promptLabel.Visible = true;
                return;
            }

            FileOperations.WriteToAFile(email,password1, name, tech);

            MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK);
            this.Hide();
            Login login = new Login();
            login.Visible = true;
            login.StartPosition = FormStartPosition.CenterParent;
            login.MaximizeBox = false;
            login.Show();
        }

        private void signUp_Load(object sender, EventArgs e)
        {
            this.FormClosing += signUp_FormClosing;
        }

        private void signUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Cancel Account Creation?",
                            "Discard Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
