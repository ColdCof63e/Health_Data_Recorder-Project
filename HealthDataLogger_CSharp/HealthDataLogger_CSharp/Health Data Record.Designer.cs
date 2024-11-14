
namespace HealthDataLogger_CSharp
{
    partial class healthDataRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(healthDataRecordForm));
            TreeNode treeNode85 = new TreeNode("Blood Glucose");
            TreeNode treeNode86 = new TreeNode("Leucocyte Count");
            TreeNode treeNode87 = new TreeNode("Erythrocyte Count");
            TreeNode treeNode88 = new TreeNode("Blood Oxygen");
            TreeNode treeNode89 = new TreeNode("Blood Pressure");
            TreeNode treeNode90 = new TreeNode("Body Temperature");
            TreeNode treeNode91 = new TreeNode("Blood Metrics", new TreeNode[] { treeNode85, treeNode86, treeNode87, treeNode88, treeNode89, treeNode90 });
            TreeNode treeNode92 = new TreeNode("Heart Rate");
            TreeNode treeNode93 = new TreeNode("Cholesterol Level");
            TreeNode treeNode94 = new TreeNode("Coronary Artery Calcium");
            TreeNode treeNode95 = new TreeNode("Heart Metrics", new TreeNode[] { treeNode92, treeNode93, treeNode94 });
            TreeNode treeNode96 = new TreeNode("Respiratory Rate");
            TreeNode treeNode97 = new TreeNode("Vital Capacity");
            TreeNode treeNode98 = new TreeNode("Respiratory Metrics", new TreeNode[] { treeNode96, treeNode97 });
            healthDataRecordMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutUSToolStripMenuItem = new ToolStripMenuItem();
            healthDRPictureBox = new PictureBox();
            healthMetricsListGroupBox = new GroupBox();
            healthMetricsTreeView = new TreeView();
            basicPersonalInfoGroupBox = new GroupBox();
            hdrWeightTextBox = new TextBox();
            hdrBloodTypeTextBox = new TextBox();
            hdrGenderTextBox = new TextBox();
            hdrHeightTextBox = new TextBox();
            hdrAgeTextBox = new TextBox();
            hdrPatientNameTextBox = new TextBox();
            hdrWeightLabel = new Label();
            hdrBloodTypeLabel = new Label();
            hdrGenderLabel = new Label();
            hdrHeightLabel = new Label();
            hdrAgeLabel = new Label();
            hdrPatientNameLabel = new Label();
            selectedHDPGroupBox = new GroupBox();
            hdrBackButton = new Button();
            healthDataDeleteButton = new Button();
            healthDataSaveButton = new Button();
            healthDataModfiyButton = new Button();
            healthDataNameWithValue = new TextBox();
            healthDataRecordMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)healthDRPictureBox).BeginInit();
            healthMetricsListGroupBox.SuspendLayout();
            basicPersonalInfoGroupBox.SuspendLayout();
            selectedHDPGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // healthDataRecordMenuStrip
            // 
            healthDataRecordMenuStrip.ImageScalingSize = new Size(24, 24);
            healthDataRecordMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem, aboutUSToolStripMenuItem });
            healthDataRecordMenuStrip.Location = new Point(0, 0);
            healthDataRecordMenuStrip.Name = "healthDataRecordMenuStrip";
            healthDataRecordMenuStrip.Size = new Size(1087, 33);
            healthDataRecordMenuStrip.TabIndex = 0;
            healthDataRecordMenuStrip.Text = "menuStrip1";
            healthDataRecordMenuStrip.ItemClicked += healthDataRecordMenuStrip_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUSToolStripMenuItem
            // 
            aboutUSToolStripMenuItem.Name = "aboutUSToolStripMenuItem";
            aboutUSToolStripMenuItem.Size = new Size(105, 29);
            aboutUSToolStripMenuItem.Text = "About US";
            // 
            // healthDRPictureBox
            // 
            healthDRPictureBox.Image = (Image)resources.GetObject("healthDRPictureBox.Image");
            healthDRPictureBox.Location = new Point(27, 36);
            healthDRPictureBox.Name = "healthDRPictureBox";
            healthDRPictureBox.Size = new Size(218, 178);
            healthDRPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            healthDRPictureBox.TabIndex = 1;
            healthDRPictureBox.TabStop = false;
            healthDRPictureBox.Click += healthDRPictureBox_Click;
            // 
            // healthMetricsListGroupBox
            // 
            healthMetricsListGroupBox.Controls.Add(healthMetricsTreeView);
            healthMetricsListGroupBox.Location = new Point(12, 220);
            healthMetricsListGroupBox.Name = "healthMetricsListGroupBox";
            healthMetricsListGroupBox.Size = new Size(253, 443);
            healthMetricsListGroupBox.TabIndex = 2;
            healthMetricsListGroupBox.TabStop = false;
            healthMetricsListGroupBox.Text = "Health Metrics List";
            healthMetricsListGroupBox.Enter += healthMetricsListGroupBox_Enter;
            // 
            // healthMetricsTreeView
            // 
            healthMetricsTreeView.Location = new Point(15, 30);
            healthMetricsTreeView.Name = "healthMetricsTreeView";
            treeNode85.Name = "bloodGlucoseNode";
            treeNode85.Text = "Blood Glucose";
            treeNode86.Name = "leucocyteCountNode";
            treeNode86.Text = "Leucocyte Count";
            treeNode87.Name = "erythrocyteCountNode";
            treeNode87.Text = "Erythrocyte Count";
            treeNode88.Name = "bloodOxygenNode";
            treeNode88.Text = "Blood Oxygen";
            treeNode89.Name = "bloodPressureNode";
            treeNode89.Text = "Blood Pressure";
            treeNode90.Name = "bodyTemperatureNode";
            treeNode90.Text = "Body Temperature";
            treeNode91.Name = "bloodMetricsNode";
            treeNode91.Text = "Blood Metrics";
            treeNode92.Name = "heartRateNode";
            treeNode92.Text = "Heart Rate";
            treeNode93.Name = "cholesterolLevelNode";
            treeNode93.Text = "Cholesterol Level";
            treeNode94.Name = "coronaryArteryCalciumNode";
            treeNode94.Text = "Coronary Artery Calcium";
            treeNode95.Name = "heartMetricsNode";
            treeNode95.Text = "Heart Metrics";
            treeNode96.Name = "respiratoryRateNode";
            treeNode96.Text = "Respiratory Rate";
            treeNode97.Name = "vitalCapacityNode";
            treeNode97.Text = "Vital Capacity";
            treeNode98.Name = "respiratoryMetricsNode";
            treeNode98.Text = "Respiratory Metrics";
            healthMetricsTreeView.Nodes.AddRange(new TreeNode[] { treeNode91, treeNode95, treeNode98 });
            healthMetricsTreeView.Size = new Size(220, 407);
            healthMetricsTreeView.TabIndex = 0;
            healthMetricsTreeView.AfterSelect += healthMetricsTreeView_AfterSelect;
            // 
            // basicPersonalInfoGroupBox
            // 
            basicPersonalInfoGroupBox.Controls.Add(hdrWeightTextBox);
            basicPersonalInfoGroupBox.Controls.Add(hdrBloodTypeTextBox);
            basicPersonalInfoGroupBox.Controls.Add(hdrGenderTextBox);
            basicPersonalInfoGroupBox.Controls.Add(hdrHeightTextBox);
            basicPersonalInfoGroupBox.Controls.Add(hdrAgeTextBox);
            basicPersonalInfoGroupBox.Controls.Add(hdrPatientNameTextBox);
            basicPersonalInfoGroupBox.Controls.Add(hdrWeightLabel);
            basicPersonalInfoGroupBox.Controls.Add(hdrBloodTypeLabel);
            basicPersonalInfoGroupBox.Controls.Add(hdrGenderLabel);
            basicPersonalInfoGroupBox.Controls.Add(hdrHeightLabel);
            basicPersonalInfoGroupBox.Controls.Add(hdrAgeLabel);
            basicPersonalInfoGroupBox.Controls.Add(hdrPatientNameLabel);
            basicPersonalInfoGroupBox.Location = new Point(263, 36);
            basicPersonalInfoGroupBox.Name = "basicPersonalInfoGroupBox";
            basicPersonalInfoGroupBox.Size = new Size(812, 178);
            basicPersonalInfoGroupBox.TabIndex = 3;
            basicPersonalInfoGroupBox.TabStop = false;
            basicPersonalInfoGroupBox.Text = "Basic Personal Info";
            basicPersonalInfoGroupBox.Enter += basicPersonalInfoGroupBox_Enter;
            // 
            // hdrWeightTextBox
            // 
            hdrWeightTextBox.Location = new Point(585, 127);
            hdrWeightTextBox.Name = "hdrWeightTextBox";
            hdrWeightTextBox.Size = new Size(150, 31);
            hdrWeightTextBox.TabIndex = 11;
            hdrWeightTextBox.TextChanged += hdrWeightTextBox_TextChanged;
            // 
            // hdrBloodTypeTextBox
            // 
            hdrBloodTypeTextBox.Location = new Point(585, 78);
            hdrBloodTypeTextBox.Name = "hdrBloodTypeTextBox";
            hdrBloodTypeTextBox.Size = new Size(150, 31);
            hdrBloodTypeTextBox.TabIndex = 10;
            hdrBloodTypeTextBox.TextChanged += hdrBloodTypeTextBox_TextChanged;
            // 
            // hdrGenderTextBox
            // 
            hdrGenderTextBox.Location = new Point(585, 33);
            hdrGenderTextBox.Name = "hdrGenderTextBox";
            hdrGenderTextBox.Size = new Size(150, 31);
            hdrGenderTextBox.TabIndex = 9;
            hdrGenderTextBox.TextChanged += hdrGenderTextBox_TextChanged;
            // 
            // hdrHeightTextBox
            // 
            hdrHeightTextBox.Location = new Point(185, 127);
            hdrHeightTextBox.Name = "hdrHeightTextBox";
            hdrHeightTextBox.Size = new Size(150, 31);
            hdrHeightTextBox.TabIndex = 8;
            hdrHeightTextBox.TextChanged += hdrHeightTextBox_TextChanged;
            // 
            // hdrAgeTextBox
            // 
            hdrAgeTextBox.Location = new Point(185, 78);
            hdrAgeTextBox.Name = "hdrAgeTextBox";
            hdrAgeTextBox.Size = new Size(150, 31);
            hdrAgeTextBox.TabIndex = 7;
            hdrAgeTextBox.TextChanged += hdrAgeTextBox_TextChanged;
            // 
            // hdrPatientNameTextBox
            // 
            hdrPatientNameTextBox.Location = new Point(185, 33);
            hdrPatientNameTextBox.Name = "hdrPatientNameTextBox";
            hdrPatientNameTextBox.Size = new Size(150, 31);
            hdrPatientNameTextBox.TabIndex = 6;
            hdrPatientNameTextBox.TextChanged += hdrPatientNameTextBox_TextChanged;
            // 
            // hdrWeightLabel
            // 
            hdrWeightLabel.AutoSize = true;
            hdrWeightLabel.Location = new Point(423, 130);
            hdrWeightLabel.Name = "hdrWeightLabel";
            hdrWeightLabel.Size = new Size(68, 25);
            hdrWeightLabel.TabIndex = 5;
            hdrWeightLabel.Text = "Weight";
            hdrWeightLabel.Click += hdrWeightLabel_Click;
            // 
            // hdrBloodTypeLabel
            // 
            hdrBloodTypeLabel.AutoSize = true;
            hdrBloodTypeLabel.Location = new Point(423, 81);
            hdrBloodTypeLabel.Name = "hdrBloodTypeLabel";
            hdrBloodTypeLabel.Size = new Size(101, 25);
            hdrBloodTypeLabel.TabIndex = 4;
            hdrBloodTypeLabel.Text = "Blood Type";
            hdrBloodTypeLabel.Click += hdrBloodTypeLabel_Click;
            // 
            // hdrGenderLabel
            // 
            hdrGenderLabel.AutoSize = true;
            hdrGenderLabel.Location = new Point(423, 36);
            hdrGenderLabel.Name = "hdrGenderLabel";
            hdrGenderLabel.Size = new Size(69, 25);
            hdrGenderLabel.TabIndex = 3;
            hdrGenderLabel.Text = "Gender";
            hdrGenderLabel.Click += hdrGenderLabel_Click;
            // 
            // hdrHeightLabel
            // 
            hdrHeightLabel.AutoSize = true;
            hdrHeightLabel.Location = new Point(25, 130);
            hdrHeightLabel.Name = "hdrHeightLabel";
            hdrHeightLabel.Size = new Size(65, 25);
            hdrHeightLabel.TabIndex = 2;
            hdrHeightLabel.Text = "Height";
            hdrHeightLabel.Click += hdrHeightLabel_Click;
            // 
            // hdrAgeLabel
            // 
            hdrAgeLabel.AutoSize = true;
            hdrAgeLabel.Location = new Point(25, 81);
            hdrAgeLabel.Name = "hdrAgeLabel";
            hdrAgeLabel.Size = new Size(44, 25);
            hdrAgeLabel.TabIndex = 1;
            hdrAgeLabel.Text = "Age";
            hdrAgeLabel.Click += hdrAgeLabel_Click;
            // 
            // hdrPatientNameLabel
            // 
            hdrPatientNameLabel.AutoSize = true;
            hdrPatientNameLabel.Location = new Point(25, 36);
            hdrPatientNameLabel.Name = "hdrPatientNameLabel";
            hdrPatientNameLabel.Size = new Size(117, 25);
            hdrPatientNameLabel.TabIndex = 0;
            hdrPatientNameLabel.Text = "Patient Name";
            hdrPatientNameLabel.Click += hdrPatientNameLabel_Click;
            // 
            // selectedHDPGroupBox
            // 
            selectedHDPGroupBox.Controls.Add(hdrBackButton);
            selectedHDPGroupBox.Controls.Add(healthDataDeleteButton);
            selectedHDPGroupBox.Controls.Add(healthDataSaveButton);
            selectedHDPGroupBox.Controls.Add(healthDataModfiyButton);
            selectedHDPGroupBox.Controls.Add(healthDataNameWithValue);
            selectedHDPGroupBox.Location = new Point(271, 220);
            selectedHDPGroupBox.Name = "selectedHDPGroupBox";
            selectedHDPGroupBox.Size = new Size(804, 437);
            selectedHDPGroupBox.TabIndex = 4;
            selectedHDPGroupBox.TabStop = false;
            selectedHDPGroupBox.Text = "Selected Health Data Presenting";
            selectedHDPGroupBox.Enter += selectedHDPGroupBox_Enter;
            // 
            // hdrBackButton
            // 
            hdrBackButton.Location = new Point(673, 364);
            hdrBackButton.Name = "hdrBackButton";
            hdrBackButton.Size = new Size(112, 34);
            hdrBackButton.TabIndex = 4;
            hdrBackButton.Text = "Back";
            hdrBackButton.UseVisualStyleBackColor = true;
            hdrBackButton.Click += hdrBackButton_Click;
            // 
            // healthDataDeleteButton
            // 
            healthDataDeleteButton.Location = new Point(453, 364);
            healthDataDeleteButton.Name = "healthDataDeleteButton";
            healthDataDeleteButton.Size = new Size(112, 34);
            healthDataDeleteButton.TabIndex = 3;
            healthDataDeleteButton.Text = "Delete";
            healthDataDeleteButton.UseVisualStyleBackColor = true;
            healthDataDeleteButton.Click += healthDataDeleteButton_Click;
            // 
            // healthDataSaveButton
            // 
            healthDataSaveButton.Location = new Point(234, 364);
            healthDataSaveButton.Name = "healthDataSaveButton";
            healthDataSaveButton.Size = new Size(112, 34);
            healthDataSaveButton.TabIndex = 2;
            healthDataSaveButton.Text = "Save";
            healthDataSaveButton.UseVisualStyleBackColor = true;
            healthDataSaveButton.Click += healthDataSaveButton_Click;
            // 
            // healthDataModfiyButton
            // 
            healthDataModfiyButton.Location = new Point(18, 364);
            healthDataModfiyButton.Name = "healthDataModfiyButton";
            healthDataModfiyButton.Size = new Size(112, 34);
            healthDataModfiyButton.TabIndex = 1;
            healthDataModfiyButton.Text = "Modify";
            healthDataModfiyButton.UseVisualStyleBackColor = true;
            healthDataModfiyButton.Click += healthDataModfiyButton_Click;
            // 
            // healthDataNameWithValue
            // 
            healthDataNameWithValue.Location = new Point(18, 62);
            healthDataNameWithValue.Multiline = true;
            healthDataNameWithValue.Name = "healthDataNameWithValue";
            healthDataNameWithValue.Size = new Size(767, 269);
            healthDataNameWithValue.TabIndex = 0;
            healthDataNameWithValue.TextChanged += healthDataNameWithValue_TextChanged;
            // 
            // healthDataRecordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 675);
            Controls.Add(selectedHDPGroupBox);
            Controls.Add(basicPersonalInfoGroupBox);
            Controls.Add(healthMetricsListGroupBox);
            Controls.Add(healthDRPictureBox);
            Controls.Add(healthDataRecordMenuStrip);
            MainMenuStrip = healthDataRecordMenuStrip;
            Name = "healthDataRecordForm";
            Text = "Health Data Record";
            //Load += healthDataRecordForm_Load;
            healthDataRecordMenuStrip.ResumeLayout(false);
            healthDataRecordMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)healthDRPictureBox).EndInit();
            healthMetricsListGroupBox.ResumeLayout(false);
            basicPersonalInfoGroupBox.ResumeLayout(false);
            basicPersonalInfoGroupBox.PerformLayout();
            selectedHDPGroupBox.ResumeLayout(false);
            selectedHDPGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        //private void healthDataRecordForm_Load(object sender, EventArgs e)
        //{
        //    LoadPatientData("12345", healthDataManager);
        //}

        #endregion

        private MenuStrip healthDataRecordMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutUSToolStripMenuItem;
        private PictureBox healthDRPictureBox;
        private GroupBox healthMetricsListGroupBox;
        private GroupBox basicPersonalInfoGroupBox;
        private GroupBox selectedHDPGroupBox;
        private TreeView healthMetricsTreeView;
        private TextBox healthDataNameWithValue;
        private Button healthDataDeleteButton;
        private Button healthDataSaveButton;
        private Button healthDataModfiyButton;
        private Label hdrWeightLabel;
        private Label hdrBloodTypeLabel;
        private Label hdrGenderLabel;
        private Label hdrHeightLabel;
        private Label hdrAgeLabel;
        private Label hdrPatientNameLabel;
        private TextBox hdrWeightTextBox;
        private TextBox hdrBloodTypeTextBox;
        private TextBox hdrGenderTextBox;
        private TextBox hdrHeightTextBox;
        private TextBox hdrAgeTextBox;
        private TextBox hdrPatientNameTextBox;
        private Button hdrBackButton;
    }
}