using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class UserHome : Form
    {
        public string Email;
        public UserHome(TextBox email)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            Email = email.Text;
        }

        private void MyAccountBtn_Click(object sender, EventArgs e)
        {
            FileOperations.FileLogs(MyAccountBtn.Text);
            this.Hide();
            MyAccount myAccount = new MyAccount(Email);
            myAccount.Show();
        }

        private void CreateNewEntryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Project.HealthDataLogger_CSharp.healthDataRecordForm hdr = new healthDataRecordForm();
        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            this.FormClosing += UserHome_FormClosing;
        }

        private void UserHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to Exit Application!",
                "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // This condition is to prevent closing form if user selects 'No'
            if (res == DialogResult.No) 
            {
                // This statement is responsible for terminating the window
                e.Cancel = true;
            }
        }
    }
}
