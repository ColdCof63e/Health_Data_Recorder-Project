using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthDataLogger_CSharp
{
    public partial class healthDataRecordForm : Form
    {
        private Dictionary<string, string> healthMetricsData;
        public healthDataRecordForm()
        {
            InitializeComponent();
            LoadHealthMetricsData();
            DisplayBasicPeronalInfo();
        }

        private void healthDataRecordForm_Load(object sender, EventArgs e)
        {
            //load any additional data if necessary
            //LoadHealthMetricsData();
        }

        private void LoadHealthMetricsData()
        {   //The Main reason that I can not keep the health metrics changes is that I have to save the health data modfication in the ArrayList
            //
            // Sample data for demonstration purposes
            healthMetricsData = new Dictionary<string, string>
            {
                { "Blood Glucose", "130 mg/dL" },
                { "Leucocyte Count", "4.5 K/uL" },
                { "Erythrocyte Count", "6.0 M/uL" },
                { "Blood Oxygen", "95%" },
                { "Blood Pressure", "130/70 mmHg" },
                { "Body Temperature", "88.6°F" },
                { "Heart Rate", "82 bpm" },
                { "Cholesterol Level", "190 mg/dL" },
                { "Coronary Artery Calcium", "280 Agatston units" },
                { "Respiratory Rate", "15 breaths/min" },
                { "Vital Capacity", "4900 mL" }
            };
        }

        //private void PopulateHealthMetricsTreeView()
        //{
        //    healthMetricsTreeView.Nodes.Clear();
        //    TreeNode bloodMetricsNode = new TreeNode("Blood Metrics");
        //    foreach (var metric in healthMetricsData.Keys)
        //    {
        //        bloodMetricsNode.Nodes.Add(new TreeNode(metric));
        //    }
        //    healthMetricsTreeView.Nodes.Add(bloodMetricsNode);
        //}

        private void DisplayBasicPeronalInfo()
        {
            // Placeholder values for personal information
            hdrPatientNameTextBox.Text = "Yipeng";
            hdrAgeTextBox.Text = "80";
            hdrHeightTextBox.Text = "190 cm";
            hdrGenderTextBox.Text = "Male";
            hdrBloodTypeTextBox.Text = "O+";
            hdrWeightTextBox.Text = "80 kg";
        }

        private void healthDataRecordMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void healthDRPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void basicPersonalInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void hdrPatientNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void hdrPatientNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hdrAgeLabel_Click(object sender, EventArgs e)
        {

        }

        private void hdrAgeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hdrHeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void hdrHeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hdrGenderLabel_Click(object sender, EventArgs e)
        {

        }

        private void hdrGenderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hdrBloodTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void hdrBloodTypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hdrWeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void hdrWeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void healthMetricsListGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void healthMetricsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //check if a leaf node (individual metric) is selected
            if (e.Node != null && e.Node.Parent != null)
            {
                string selectedMetric = e.Node.Text;
                
                //display the metric's value if it exists in the dictionary
                if (healthMetricsData.ContainsKey(selectedMetric))
                {
                    healthDataNameWithValue.Text = healthMetricsData[selectedMetric];
                    healthDataNameWithValue.ReadOnly = true; //make it read only by default
                }
                else
                {
                    healthDataNameWithValue.Text = "";
                }
            }

        }

        private void selectedHDPGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void healthDataNameWithValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void healthDataModfiyButton_Click(object sender, EventArgs e)
        {
            if (healthMetricsTreeView.SelectedNode != null && healthMetricsTreeView.SelectedNode.Parent != null)
            {
                healthDataNameWithValue.ReadOnly = false;
                MessageBox.Show("You can modify the selected health metric value now.");
            }
            else
            {
                MessageBox.Show("Please select a health metric to modify.");
            }
        }

        private void healthDataSaveButton_Click(object sender, EventArgs e)
        {
            if (healthMetricsTreeView.SelectedNode != null && healthMetricsTreeView.SelectedNode.Parent != null)
            {
                string selectedMetric = healthMetricsTreeView.SelectedNode.Text;
                string newValue = healthDataNameWithValue.Text;

                // Perform validation
                if (ValidateHealthMetric(selectedMetric, newValue))
                {
                    // Update the dictionary with the new value if valid
                    healthMetricsData[selectedMetric] = newValue;
                    healthDataNameWithValue.ReadOnly = true;
                    MessageBox.Show("Health metric updated successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a health metric to save changes.");
            }
        }

        private bool ValidateHealthMetric(string metric, string value) {
            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show("Value cannot be empty.");
                return false;
            }

            switch (metric)
            {
                case "Blood Glucose":
                    if (int.TryParse(value.Replace(" mg/dL", ""), out int glucose) && glucose >= 60 && glucose <= 190)
                        return true;
                    else
                        MessageBox.Show("Blood Glucose must be a number between 60 and 190 mg/dL.");
                    break;

                case "Blood Pressure":
                    if (Regex.IsMatch(value, @"^\d{2,3}/\d{2,3} mmHg$"))
                        return true;
                    else
                        MessageBox.Show("Blood Pressure must be in the format '130/70 mmHg'.");
                    break;

                case "Heart Rate":
                    if (int.TryParse(value.Replace(" bpm", ""), out int heartRate) && heartRate >= 50 && heartRate <= 190)
                        return true;
                    else
                        MessageBox.Show("Heart Rate must be a number between 50 and 190 bpm.");
                    break;

                case "Body Temperature":
                    if (double.TryParse(value.Replace("°F", ""), out double temp) && temp >= 80 && temp <= 110)
                        return true;
                    else
                        MessageBox.Show("Body Temperature must be between 80°F and 110°F.");
                    break;

                case "Respiratory Rate":
                    if (int.TryParse(value.Replace(" breaths/min", ""), out int respRate) && respRate >= 8 && respRate <= 30)
                        return true;
                    else
                        MessageBox.Show("Respiratory Rate must be between 8 and 30 breaths/min.");
                    break;

                case "Cholesterol Level":
                    if (int.TryParse(value.Replace(" mg/dL", ""), out int cholesterol) && cholesterol >= 80 && cholesterol <= 320)
                        return true;
                    else
                        MessageBox.Show("Cholesterol Level must be between 80 and 320 mg/dL.");
                    break;

                case "Blood Oxygen":
                    if (int.TryParse(value.Replace("%", ""), out int oxygen) && oxygen >= 70 && oxygen <= 100)
                        return true;
                    else
                        MessageBox.Show("Blood Oxygen must be between 70% and 100%.");
                    break;

                default:
                    MessageBox.Show("No specific validation for this metric.");
                    return true;
            }

            return false;
        }

        private void healthDataDeleteButton_Click(object sender, EventArgs e)
        {
            if (healthMetricsTreeView.SelectedNode != null && healthMetricsTreeView.SelectedNode.Parent != null)
            {
                string selectedMetric = healthMetricsTreeView.SelectedNode.Text;

                // Remove the metric from the dictionary
                healthMetricsData.Remove(selectedMetric);
                healthDataNameWithValue.Clear(); // Clear display after deletion
                MessageBox.Show("Health metric deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a health metric to delete.");
            }
        }

        private void hdrBackButton_Click(object sender, EventArgs e)
        {
            // Close this form and navigate back such as back to Technician Home
            this.Close();
        }
    }
}
