using HealthDataLogger_CSharp.Models;

namespace HealthDataLogger_CSharp
{
    public partial class technicianHomeForm : Form
    {
        private List<PatientRecord> patientRecords;
        private HealthDataManager healthDataManager;
        public technicianHomeForm()
        {
            InitializeComponent();
            InitializeMockData();
            healthDataManager = new HealthDataManager();
        }
        

        private void technicianHomeForm_Load(object sender, EventArgs e)
        {
            techHomeTreeView.SelectedNode = techHomeTreeView.Nodes[0];

        }

        private void InitializeMockData()
        {
            patientRecords = new List<PatientRecord>
            {
                new PatientRecord() {RecordID = 1, PatientID = 12345, UserName = "Yipeng", CreatedTime = DateTime.Now.AddDays(-10), UpdatedTime = DateTime.Now.AddDays(-1), Gender = "Male"},
                new PatientRecord() {RecordID = 2, PatientID = 21356, UserName = "Emma", CreatedTime = DateTime.Now.AddDays(-8), UpdatedTime = DateTime.Now.AddDays(-2), Gender = "Female" }
            };
        }

        private void techHomeTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Patient Account Management":
                    patientAccountManagementForm patientAccountForm = new patientAccountManagementForm();
                    patientAccountForm.Show();
                    this.Hide();
                    break;
                case "My Account":
                    MessageBox.Show("My Account functionality will be implemented later.");
                    break;
            }
        }

        private void techHomeSearchButton_Click(object sender, EventArgs e)
        {
            string userNameOrId = userNameOrIDTextBox.Text.Trim();
            DateTime selectedDate = dateTimePicker1.Value;
            string gender = techHomeGenderComboBox.SelectedItem?.ToString();

            var filteredRecords = patientRecords.Where(record =>
                (string.IsNullOrEmpty(userNameOrId) || record.UserName.Contains(userNameOrId) || record.PatientID.ToString() == userNameOrId) &&
                (gender == null || record.Gender == gender) &&
                record.CreatedTime.Date <= selectedDate.Date).ToList();

            thSearchingResultTextBox.Clear();
            foreach (var record in filteredRecords)
            {
                thSearchingResultTextBox.AppendText($"Record ID: {record.RecordID}, Patient ID: {record.PatientID}, User: {record.UserName}, Created: {record.CreatedTime}, Updated: {record.UpdatedTime}{Environment.NewLine}");
            }

            if (filteredRecords.Count == 0)
            {
                thSearchingResultTextBox.AppendText("No records found.");
            }

        }

        private void techHomeResetButton_Click(object sender, EventArgs e)
        {
            userNameOrIDTextBox.Clear();
            techHomeGenderComboBox.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            thSearchingResultTextBox.Clear();
        }

        private void thResultViewButton_Click(object sender, EventArgs e)
        {
            string patientId = "12345"; // ???????????ID
            healthDataRecordForm healthDataRecord = new healthDataRecordForm(healthDataManager, patientId);
            healthDataRecord.ShowDialog(); // ?? ShowDialog ??????
        }

        private void thMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

    public class PatientRecord
    {
        public int RecordID { get; set; }
        public int PatientID { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string Gender { get; set; }
    }
}
