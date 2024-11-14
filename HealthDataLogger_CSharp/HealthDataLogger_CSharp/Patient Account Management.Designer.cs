namespace HealthDataLogger_CSharp
{
    partial class patientAccountManagementForm
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
            TreeNode treeNode1 = new TreeNode("Patient Health Data Management");
            TreeNode treeNode2 = new TreeNode("Patient Account Management");
            TreeNode treeNode3 = new TreeNode("My Account");
            userAccManMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            userAccManTreeView = new TreeView();
            userAccManGroupBox = new GroupBox();
            pAMResetButton = new Button();
            pAMSearchButton = new Button();
            pAMRegionComboBox = new ComboBox();
            pAMDateTimePicker = new DateTimePicker();
            pAMUNIDTextBox = new TextBox();
            pAMRegionLabel = new Label();
            pAMDateLabel = new Label();
            patientAccManUNIDLabel = new Label();
            patientAccManResultingTextBox = new TextBox();
            patAccManPIDLabel = new Label();
            patAccManUNLabel = new Label();
            patAccManACTlabel = new Label();
            patAccManRoleLabel = new Label();
            patAccManAUTLabel = new Label();
            patAccManSatusLabel = new Label();
            patAccManOperationLabel = new Label();
            patAccManResultingViewButton = new Button();
            userAccManMenuStrip.SuspendLayout();
            userAccManGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // userAccManMenuStrip
            // 
            userAccManMenuStrip.ImageScalingSize = new Size(24, 24);
            userAccManMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem, aboutUsToolStripMenuItem });
            userAccManMenuStrip.Location = new Point(0, 0);
            userAccManMenuStrip.Name = "userAccManMenuStrip";
            userAccManMenuStrip.Size = new Size(1100, 33);
            userAccManMenuStrip.TabIndex = 0;
            userAccManMenuStrip.Text = "menuStrip1";
            userAccManMenuStrip.ItemClicked += userAccManMenuStrip_ItemClicked;
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
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(103, 29);
            aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // userAccManTreeView
            // 
            userAccManTreeView.ItemHeight = 50;
            userAccManTreeView.Location = new Point(0, 36);
            userAccManTreeView.Name = "userAccManTreeView";
            treeNode1.Name = "patientHDManNode";
            treeNode1.Text = "Patient Health Data Management";
            treeNode2.Name = "patientAccManNode";
            treeNode2.Text = "Patient Account Management";
            treeNode3.Name = "technicianMyAccNode";
            treeNode3.Text = "My Account";
            userAccManTreeView.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            userAccManTreeView.Size = new Size(308, 533);
            userAccManTreeView.TabIndex = 1;
            userAccManTreeView.AfterSelect += userAccManTreeView_AfterSelect;
            // 
            // userAccManGroupBox
            // 
            userAccManGroupBox.Controls.Add(pAMResetButton);
            userAccManGroupBox.Controls.Add(pAMSearchButton);
            userAccManGroupBox.Controls.Add(pAMRegionComboBox);
            userAccManGroupBox.Controls.Add(pAMDateTimePicker);
            userAccManGroupBox.Controls.Add(pAMUNIDTextBox);
            userAccManGroupBox.Controls.Add(pAMRegionLabel);
            userAccManGroupBox.Controls.Add(pAMDateLabel);
            userAccManGroupBox.Controls.Add(patientAccManUNIDLabel);
            userAccManGroupBox.Location = new Point(314, 36);
            userAccManGroupBox.Name = "userAccManGroupBox";
            userAccManGroupBox.Size = new Size(774, 209);
            userAccManGroupBox.TabIndex = 2;
            userAccManGroupBox.TabStop = false;
            userAccManGroupBox.Text = "Filter";
            userAccManGroupBox.Enter += userAccManGroupBox_Enter;
            // 
            // pAMResetButton
            // 
            pAMResetButton.Location = new Point(656, 146);
            pAMResetButton.Name = "pAMResetButton";
            pAMResetButton.Size = new Size(112, 34);
            pAMResetButton.TabIndex = 7;
            pAMResetButton.Text = "Reset";
            pAMResetButton.UseVisualStyleBackColor = true;
            pAMResetButton.Click += pAMResetButton_Click;
            // 
            // pAMSearchButton
            // 
            pAMSearchButton.Location = new Point(516, 146);
            pAMSearchButton.Name = "pAMSearchButton";
            pAMSearchButton.Size = new Size(112, 34);
            pAMSearchButton.TabIndex = 6;
            pAMSearchButton.Text = "Search";
            pAMSearchButton.UseVisualStyleBackColor = true;
            pAMSearchButton.Click += pAMSearchButton_Click;
            // 
            // pAMRegionComboBox
            // 
            pAMRegionComboBox.FormattingEnabled = true;
            pAMRegionComboBox.Items.AddRange(new object[] { "Ontario", "Quebec", "Nova Scotia", "New Brunswick", "Manitoba", "British Columbia", "Prince Edward Island", "Saskatchewan", "Alberta", "Newfoundland and Labrador" });
            pAMRegionComboBox.Location = new Point(191, 143);
            pAMRegionComboBox.Name = "pAMRegionComboBox";
            pAMRegionComboBox.Size = new Size(182, 33);
            pAMRegionComboBox.TabIndex = 5;
            pAMRegionComboBox.SelectedIndexChanged += pAMRegionComboBox_SelectedIndexChanged;
            // 
            // pAMDateTimePicker
            // 
            pAMDateTimePicker.Location = new Point(191, 92);
            pAMDateTimePicker.Name = "pAMDateTimePicker";
            pAMDateTimePicker.Size = new Size(300, 31);
            pAMDateTimePicker.TabIndex = 4;
            pAMDateTimePicker.ValueChanged += pAMDateTimePicker_ValueChanged;
            // 
            // pAMUNIDTextBox
            // 
            pAMUNIDTextBox.Location = new Point(191, 39);
            pAMUNIDTextBox.Name = "pAMUNIDTextBox";
            pAMUNIDTextBox.Size = new Size(150, 31);
            pAMUNIDTextBox.TabIndex = 3;
            pAMUNIDTextBox.TextChanged += pAMUNIDTextBox_TextChanged;
            // 
            // pAMRegionLabel
            // 
            pAMRegionLabel.AutoSize = true;
            pAMRegionLabel.Location = new Point(6, 146);
            pAMRegionLabel.Name = "pAMRegionLabel";
            pAMRegionLabel.Size = new Size(67, 25);
            pAMRegionLabel.TabIndex = 2;
            pAMRegionLabel.Text = "Region";
            pAMRegionLabel.Click += pAMRegionLabel_Click;
            // 
            // pAMDateLabel
            // 
            pAMDateLabel.AutoSize = true;
            pAMDateLabel.Location = new Point(6, 97);
            pAMDateLabel.Name = "pAMDateLabel";
            pAMDateLabel.Size = new Size(49, 25);
            pAMDateLabel.TabIndex = 1;
            pAMDateLabel.Text = "Date";
            pAMDateLabel.Click += pAMDateLabel_Click;
            // 
            // patientAccManUNIDLabel
            // 
            patientAccManUNIDLabel.AutoSize = true;
            patientAccManUNIDLabel.Location = new Point(6, 42);
            patientAccManUNIDLabel.Name = "patientAccManUNIDLabel";
            patientAccManUNIDLabel.Size = new Size(144, 25);
            patientAccManUNIDLabel.TabIndex = 0;
            patientAccManUNIDLabel.Text = "User Name or ID";
            patientAccManUNIDLabel.Click += patientAccManUNIDLabel_Click;
            // 
            // patientAccManResultingTextBox
            // 
            patientAccManResultingTextBox.Location = new Point(320, 304);
            patientAccManResultingTextBox.Multiline = true;
            patientAccManResultingTextBox.Name = "patientAccManResultingTextBox";
            patientAccManResultingTextBox.Size = new Size(663, 265);
            patientAccManResultingTextBox.TabIndex = 3;
            patientAccManResultingTextBox.TextChanged += patientAccManResultingTextBox_TextChanged;
            // 
            // patAccManPIDLabel
            // 
            patAccManPIDLabel.AutoSize = true;
            patAccManPIDLabel.BackColor = SystemColors.Highlight;
            patAccManPIDLabel.Location = new Point(314, 265);
            patAccManPIDLabel.Name = "patAccManPIDLabel";
            patAccManPIDLabel.Size = new Size(88, 25);
            patAccManPIDLabel.TabIndex = 4;
            patAccManPIDLabel.Text = "Patient ID";
            patAccManPIDLabel.Click += patAccManPIDLabel_Click;
            // 
            // patAccManUNLabel
            // 
            patAccManUNLabel.AutoSize = true;
            patAccManUNLabel.BackColor = SystemColors.Highlight;
            patAccManUNLabel.Location = new Point(418, 265);
            patAccManUNLabel.Name = "patAccManUNLabel";
            patAccManUNLabel.Size = new Size(99, 25);
            patAccManUNLabel.TabIndex = 5;
            patAccManUNLabel.Text = "User Name";
            patAccManUNLabel.Click += patAccManUNLabel_Click;
            // 
            // patAccManACTlabel
            // 
            patAccManACTlabel.AutoSize = true;
            patAccManACTlabel.BackColor = SystemColors.Highlight;
            patAccManACTlabel.Location = new Point(589, 265);
            patAccManACTlabel.Name = "patAccManACTlabel";
            patAccManACTlabel.Size = new Size(149, 25);
            patAccManACTlabel.TabIndex = 6;
            patAccManACTlabel.Text = "Acc Created Time";
            patAccManACTlabel.Click += patAccManACTlabel_Click;
            // 
            // patAccManRoleLabel
            // 
            patAccManRoleLabel.AutoSize = true;
            patAccManRoleLabel.BackColor = SystemColors.Highlight;
            patAccManRoleLabel.Location = new Point(523, 265);
            patAccManRoleLabel.Name = "patAccManRoleLabel";
            patAccManRoleLabel.Size = new Size(46, 25);
            patAccManRoleLabel.TabIndex = 7;
            patAccManRoleLabel.Text = "Role";
            patAccManRoleLabel.Click += patAccManRoleLabel_Click;
            // 
            // patAccManAUTLabel
            // 
            patAccManAUTLabel.AutoSize = true;
            patAccManAUTLabel.BackColor = SystemColors.Highlight;
            patAccManAUTLabel.Location = new Point(744, 265);
            patAccManAUTLabel.Name = "patAccManAUTLabel";
            patAccManAUTLabel.Size = new Size(157, 25);
            patAccManAUTLabel.TabIndex = 8;
            patAccManAUTLabel.Text = "Acc Updated Time";
            patAccManAUTLabel.Click += patAccManAUTLabel_Click;
            // 
            // patAccManSatusLabel
            // 
            patAccManSatusLabel.AutoSize = true;
            patAccManSatusLabel.BackColor = SystemColors.Highlight;
            patAccManSatusLabel.Location = new Point(923, 265);
            patAccManSatusLabel.Name = "patAccManSatusLabel";
            patAccManSatusLabel.Size = new Size(60, 25);
            patAccManSatusLabel.TabIndex = 9;
            patAccManSatusLabel.Text = "Status";
            patAccManSatusLabel.Click += patAccManSatusLabel_Click;
            // 
            // patAccManOperationLabel
            // 
            patAccManOperationLabel.AutoSize = true;
            patAccManOperationLabel.BackColor = SystemColors.AppWorkspace;
            patAccManOperationLabel.Location = new Point(996, 265);
            patAccManOperationLabel.Name = "patAccManOperationLabel";
            patAccManOperationLabel.Size = new Size(92, 25);
            patAccManOperationLabel.TabIndex = 10;
            patAccManOperationLabel.Text = "Operation";
            patAccManOperationLabel.Click += patAccManOperationLabel_Click;
            // 
            // patAccManResultingViewButton
            // 
            patAccManResultingViewButton.Location = new Point(999, 313);
            patAccManResultingViewButton.Name = "patAccManResultingViewButton";
            patAccManResultingViewButton.Size = new Size(89, 34);
            patAccManResultingViewButton.TabIndex = 11;
            patAccManResultingViewButton.Text = "View";
            patAccManResultingViewButton.UseVisualStyleBackColor = true;
            patAccManResultingViewButton.Click += patAccManResultingViewButton_Click;
            // 
            // patientAccountManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 581);
            Controls.Add(patAccManResultingViewButton);
            Controls.Add(patAccManOperationLabel);
            Controls.Add(patAccManSatusLabel);
            Controls.Add(patAccManAUTLabel);
            Controls.Add(patAccManRoleLabel);
            Controls.Add(patAccManACTlabel);
            Controls.Add(patAccManUNLabel);
            Controls.Add(patAccManPIDLabel);
            Controls.Add(patientAccManResultingTextBox);
            Controls.Add(userAccManGroupBox);
            Controls.Add(userAccManTreeView);
            Controls.Add(userAccManMenuStrip);
            MainMenuStrip = userAccManMenuStrip;
            Name = "patientAccountManagementForm";
            Text = "Patient Account Management";
            Load += patientAccountManagementForm_Load;
            userAccManMenuStrip.ResumeLayout(false);
            userAccManMenuStrip.PerformLayout();
            userAccManGroupBox.ResumeLayout(false);
            userAccManGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip userAccManMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private TreeView userAccManTreeView;
        private GroupBox userAccManGroupBox;
        private Label pAMRegionLabel;
        private Label pAMDateLabel;
        private Label patientAccManUNIDLabel;
        private DateTimePicker pAMDateTimePicker;
        private TextBox pAMUNIDTextBox;
        private ComboBox pAMRegionComboBox;
        private Button pAMResetButton;
        private Button pAMSearchButton;
        private TextBox patientAccManResultingTextBox;
        private Label patAccManPIDLabel;
        private Label patAccManUNLabel;
        private Label patAccManACTlabel;
        private Label patAccManRoleLabel;
        private Label patAccManAUTLabel;
        private Label patAccManSatusLabel;
        private Label patAccManOperationLabel;
        private Button patAccManResultingViewButton;
    }
}