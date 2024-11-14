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
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            this.FormClosing += MyAccount_FormClosing;
        }

        private void MyAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Changes will Discarded",
                "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No)
            {
                // To prevent closing form if user selects 'No'
                e.Cancel = true;
            }
        }
    }
}
