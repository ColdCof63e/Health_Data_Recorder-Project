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
        public UserHome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void MyAccountBtn_Click(object sender, EventArgs e)
        {
            FileOperations.FileLogs(MyAccountBtn.Text);
            this.Hide();
            MyAccount myAccount = new MyAccount();
            myAccount.Show();
        }

        private void CreateNewEntryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Project.HealthDataLogger_CSharp.healthDataRecordForm hdr = new healthDataRecordForm();
        }
    }
}
