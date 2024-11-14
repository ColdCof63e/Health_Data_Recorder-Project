using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthDataLogger_CSharp
{
    public partial class patientAccountManagementForm : Form
    {
        //sample data for demo purposes
        private List<PatientAccount> patientAccounts = new List<PatientAccount>
        {
            new PatientAccount {PatientID = "12345", UserName = "Yipeng", Role = "Patient", CreatedTime = DateTime.Now.AddMonths(-1), UpdatedTime = DateTime.Now, Status = "Active", Region = "Ontario"},
            new PatientAccount {PatientID = "67890", UserName = "Narendra", Role = "Patient", CreatedTime = DateTime.Now.AddMonths(-2), UpdatedTime = DateTime.Now.AddMonths(-1), Status = "Inactive", Region = "Alberta"}

        };
        public patientAccountManagementForm()
        {
            InitializeComponent();
        }

        private void patientAccountManagementForm_Load(object sender, EventArgs e)
        {
            //I already have regions in combo box
            //pAMRegionComboBox.Items.AddRange(new string[] { "North", "East", "South", "West" });

        }

        private void userAccManMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void userAccManTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //switch (e.Node.Text)
            //{
            //    case "Patient Health Data Management":
            //        technicianHomeForm techHome = new technicianHomeForm();
            //        techHome.Show();
            //        this.Hide();
            //        break;
            //    case "My Account":
            //        MessageBox.Show("My Account functionality will be implemented later.");
            //        break;
            //}
        }

        private void userAccManGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void patientAccManUNIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void pAMUNIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pAMDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void pAMDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pAMRegionLabel_Click(object sender, EventArgs e)
        {

        }

        private void pAMRegionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pAMSearchButton_Click(object sender, EventArgs e)
        {
            string userNameOrId = pAMUNIDTextBox.Text;
            DateTime selectedDate = pAMDateTimePicker.Value;
            string selectedRegion = pAMRegionComboBox.SelectedItem?.ToString();

            //filter accounts based on search criteria
            var filteredAccounts = patientAccounts.Where(acc =>
                (string.IsNullOrEmpty(userNameOrId) || acc.UserName.Contains(userNameOrId) || acc.PatientID.Contains(userNameOrId)) &&
                (!selectedDate.Equals(DateTime.Now) || acc.CreatedTime.Date == selectedDate.Date) &&
                (string.IsNullOrEmpty(selectedRegion) || acc.Region == selectedRegion)
            ).ToList();

            //display filtered accounts
            DisplaySearchResults(filteredAccounts);
        }

        private void DisplaySearchResults(List<PatientAccount> accounts) {
            patientAccManResultingTextBox.Clear();
            if (accounts.Count == 0)
            {
                patientAccManResultingTextBox.AppendText("No results found.\n");
            }
            else
            {
                foreach (var account in accounts)
                {
                    patientAccManResultingTextBox.AppendText(
                        $"ID: {account.PatientID}, User: {account.UserName}, Role: {account.Role}, Created: {account.CreatedTime.ToShortDateString()}, Updated: {account.UpdatedTime.ToShortDateString()}, Status: {account.Status}\n");
                }
            }
        }

        private void pAMResetButton_Click(object sender, EventArgs e)
        {
            pAMUNIDTextBox.Clear();
            pAMDateTimePicker.Value = DateTime.Now;
            pAMRegionComboBox.SelectedIndex = -1;
            patientAccManResultingTextBox.Clear() ;
        }

        private void patAccManPIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void patAccManUNLabel_Click(object sender, EventArgs e)
        {

        }

        private void patAccManRoleLabel_Click(object sender, EventArgs e)
        {

        }

        private void patAccManACTlabel_Click(object sender, EventArgs e)
        {

        }

        private void patAccManAUTLabel_Click(object sender, EventArgs e)
        {

        }

        private void patAccManSatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void patAccManOperationLabel_Click(object sender, EventArgs e)
        {

        }

        private void patAccManResultingViewButton_Click(object sender, EventArgs e)
        {
            // Assume user selects an account ID to view
            if (patientAccManResultingTextBox.SelectedText.Length > 0)
            {
                // Implement code to open Patient Account details here
                string selectedPatientID = ExtractSelectedPatientID();
                OpenPatientAccountDetails(selectedPatientID);
            }
            else
            {
                MessageBox.Show("Please select a record to view.");
            }

        }

        // Helper method to extract Patient ID from the selected text in the TextBox
        private string ExtractSelectedPatientID()
        {
            // Example logic to parse out the Patient ID from the selected text
            string selectedText = patientAccManResultingTextBox.SelectedText;
            var tokens = selectedText.Split(',');
            var idToken = tokens.FirstOrDefault(t => t.Contains("ID:"));
            return idToken?.Split(':')[1].Trim();
        }

        // Opens the Patient Account details form
        private void OpenPatientAccountDetails(string patientID)
        {
            MessageBox.Show($"Opening details for Patient ID: {patientID}");
            // For future, here we can instantiate the PatientAccountDetails form
            // PatientAccountDetailsForm detailsForm = new PatientAccountDetailsForm(patientID);
            // detailsForm.ShowDialog();
        }

        private void patientAccManResultingTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    // Sample PatientAccount class for demonstration
    public class PatientAccount
    {
        public string PatientID { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string Status { get; set; }
        public string Region { get; set; }
    }
}
