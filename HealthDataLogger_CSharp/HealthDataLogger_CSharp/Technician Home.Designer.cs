
namespace HealthDataLogger_CSharp
{
    partial class technicianHomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Patient Health Data Management");
            TreeNode treeNode2 = new TreeNode("Patient Account Management");
            TreeNode treeNode3 = new TreeNode("My Account");
            thMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            techHomeTreeView = new TreeView();
            techHomeGroupBox = new GroupBox();
            techHomeResetButton = new Button();
            techHomeSearchButton = new Button();
            techHomeGenderComboBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            userNameOrIDTextBox = new TextBox();
            techHomeGenderLabel = new Label();
            techHomeDateLabel = new Label();
            gbUserNameLabel = new Label();
            thRecordIDLabel = new Label();
            thPatientIDLabel = new Label();
            thUserNameLabel = new Label();
            thECTLabel = new Label();
            thEUTLabel = new Label();
            thOperationLabel = new Label();
            thSearchingResultTextBox = new TextBox();
            thResultViewButton = new Button();
            thMenuStrip.SuspendLayout();
            techHomeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // thMenuStrip
            // 
            thMenuStrip.ImageScalingSize = new Size(24, 24);
            thMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem, aboutUsToolStripMenuItem });
            thMenuStrip.Location = new Point(0, 0);
            thMenuStrip.Name = "thMenuStrip";
            thMenuStrip.Size = new Size(1112, 33);
            thMenuStrip.TabIndex = 0;
            thMenuStrip.Text = "menuStrip1";
            thMenuStrip.ItemClicked += thMenuStrip_ItemClicked;
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
            // techHomeTreeView
            // 
            techHomeTreeView.ItemHeight = 50;
            techHomeTreeView.Location = new Point(0, 36);
            techHomeTreeView.Name = "techHomeTreeView";
            treeNode1.Name = "patientHDManNode";
            treeNode1.Text = "Patient Health Data Management";
            treeNode2.Name = "patientAccManNode";
            treeNode2.Text = "Patient Account Management";
            treeNode3.Name = "myAccountNode";
            treeNode3.Text = "My Account";
            techHomeTreeView.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            techHomeTreeView.Size = new Size(298, 557);
            techHomeTreeView.TabIndex = 1;
            techHomeTreeView.AfterSelect += techHomeTreeView_AfterSelect;
            // 
            // techHomeGroupBox
            // 
            techHomeGroupBox.Controls.Add(techHomeResetButton);
            techHomeGroupBox.Controls.Add(techHomeSearchButton);
            techHomeGroupBox.Controls.Add(techHomeGenderComboBox);
            techHomeGroupBox.Controls.Add(dateTimePicker1);
            techHomeGroupBox.Controls.Add(userNameOrIDTextBox);
            techHomeGroupBox.Controls.Add(techHomeGenderLabel);
            techHomeGroupBox.Controls.Add(techHomeDateLabel);
            techHomeGroupBox.Controls.Add(gbUserNameLabel);
            techHomeGroupBox.Location = new Point(304, 36);
            techHomeGroupBox.Name = "techHomeGroupBox";
            techHomeGroupBox.Size = new Size(794, 203);
            techHomeGroupBox.TabIndex = 2;
            techHomeGroupBox.TabStop = false;
            techHomeGroupBox.Text = "Filter";
            // 
            // techHomeResetButton
            // 
            techHomeResetButton.Location = new Point(676, 141);
            techHomeResetButton.Name = "techHomeResetButton";
            techHomeResetButton.Size = new Size(112, 34);
            techHomeResetButton.TabIndex = 7;
            techHomeResetButton.Text = "Reset";
            techHomeResetButton.UseVisualStyleBackColor = true;
            techHomeResetButton.Click += techHomeResetButton_Click;
            // 
            // techHomeSearchButton
            // 
            techHomeSearchButton.Location = new Point(527, 141);
            techHomeSearchButton.Name = "techHomeSearchButton";
            techHomeSearchButton.Size = new Size(112, 34);
            techHomeSearchButton.TabIndex = 6;
            techHomeSearchButton.Text = "Search";
            techHomeSearchButton.UseVisualStyleBackColor = true;
            techHomeSearchButton.Click += techHomeSearchButton_Click;
            // 
            // techHomeGenderComboBox
            // 
            techHomeGenderComboBox.FormattingEnabled = true;
            techHomeGenderComboBox.Items.AddRange(new object[] { "Male", "Female", "Others" });
            techHomeGenderComboBox.Location = new Point(192, 141);
            techHomeGenderComboBox.Name = "techHomeGenderComboBox";
            techHomeGenderComboBox.Size = new Size(182, 33);
            techHomeGenderComboBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(192, 88);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // userNameOrIDTextBox
            // 
            userNameOrIDTextBox.Location = new Point(192, 37);
            userNameOrIDTextBox.Name = "userNameOrIDTextBox";
            userNameOrIDTextBox.Size = new Size(197, 31);
            userNameOrIDTextBox.TabIndex = 3;
            // 
            // techHomeGenderLabel
            // 
            techHomeGenderLabel.AutoSize = true;
            techHomeGenderLabel.Location = new Point(6, 144);
            techHomeGenderLabel.Name = "techHomeGenderLabel";
            techHomeGenderLabel.Size = new Size(69, 25);
            techHomeGenderLabel.TabIndex = 2;
            techHomeGenderLabel.Text = "Gender";
            // 
            // techHomeDateLabel
            // 
            techHomeDateLabel.AutoSize = true;
            techHomeDateLabel.Location = new Point(6, 93);
            techHomeDateLabel.Name = "techHomeDateLabel";
            techHomeDateLabel.Size = new Size(49, 25);
            techHomeDateLabel.TabIndex = 1;
            techHomeDateLabel.Text = "Date";
            // 
            // gbUserNameLabel
            // 
            gbUserNameLabel.AutoSize = true;
            gbUserNameLabel.Location = new Point(6, 40);
            gbUserNameLabel.Name = "gbUserNameLabel";
            gbUserNameLabel.Size = new Size(144, 25);
            gbUserNameLabel.TabIndex = 0;
            gbUserNameLabel.Text = "User Name or ID";
            // 
            // thRecordIDLabel
            // 
            thRecordIDLabel.AutoSize = true;
            thRecordIDLabel.BackColor = SystemColors.Highlight;
            thRecordIDLabel.Location = new Point(304, 261);
            thRecordIDLabel.Name = "thRecordIDLabel";
            thRecordIDLabel.Size = new Size(90, 25);
            thRecordIDLabel.TabIndex = 3;
            thRecordIDLabel.Text = "Record ID";
            // 
            // thPatientIDLabel
            // 
            thPatientIDLabel.AutoSize = true;
            thPatientIDLabel.BackColor = SystemColors.Highlight;
            thPatientIDLabel.Location = new Point(414, 261);
            thPatientIDLabel.Name = "thPatientIDLabel";
            thPatientIDLabel.Size = new Size(88, 25);
            thPatientIDLabel.TabIndex = 4;
            thPatientIDLabel.Text = "Patient ID";
            // 
            // thUserNameLabel
            // 
            thUserNameLabel.AutoSize = true;
            thUserNameLabel.BackColor = SystemColors.Highlight;
            thUserNameLabel.Location = new Point(532, 261);
            thUserNameLabel.Name = "thUserNameLabel";
            thUserNameLabel.Size = new Size(99, 25);
            thUserNameLabel.TabIndex = 5;
            thUserNameLabel.Text = "User Name";
            // 
            // thECTLabel
            // 
            thECTLabel.AutoSize = true;
            thECTLabel.BackColor = SystemColors.Highlight;
            thECTLabel.Location = new Point(651, 261);
            thECTLabel.Name = "thECTLabel";
            thECTLabel.Size = new Size(161, 25);
            thECTLabel.TabIndex = 6;
            thECTLabel.Text = "Entry Created Time";
            thECTLabel.Click += thECTLabel_Click;
            // 
            // thEUTLabel
            // 
            thEUTLabel.AutoSize = true;
            thEUTLabel.BackColor = SystemColors.Highlight;
            thEUTLabel.Location = new Point(818, 261);
            thEUTLabel.Name = "thEUTLabel";
            thEUTLabel.Size = new Size(169, 25);
            thEUTLabel.TabIndex = 7;
            thEUTLabel.Text = "Entry Updated Time";
            // 
            // thOperationLabel
            // 
            thOperationLabel.AutoSize = true;
            thOperationLabel.BackColor = SystemColors.AppWorkspace;
            thOperationLabel.Location = new Point(1006, 261);
            thOperationLabel.Name = "thOperationLabel";
            thOperationLabel.Size = new Size(92, 25);
            thOperationLabel.TabIndex = 8;
            thOperationLabel.Text = "Operation";
            thOperationLabel.Click += label6_Click;
            // 
            // thSearchingResultTextBox
            // 
            thSearchingResultTextBox.Location = new Point(310, 302);
            thSearchingResultTextBox.Multiline = true;
            thSearchingResultTextBox.Name = "thSearchingResultTextBox";
            thSearchingResultTextBox.Size = new Size(677, 291);
            thSearchingResultTextBox.TabIndex = 9;
            // 
            // thResultViewButton
            // 
            thResultViewButton.Location = new Point(999, 312);
            thResultViewButton.Name = "thResultViewButton";
            thResultViewButton.Size = new Size(99, 34);
            thResultViewButton.TabIndex = 10;
            thResultViewButton.Text = "View";
            thResultViewButton.UseVisualStyleBackColor = true;
            thResultViewButton.Click += thResultViewButton_Click;
            // 
            // technicianHomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 617);
            Controls.Add(thResultViewButton);
            Controls.Add(thSearchingResultTextBox);
            Controls.Add(thOperationLabel);
            Controls.Add(thEUTLabel);
            Controls.Add(thECTLabel);
            Controls.Add(thUserNameLabel);
            Controls.Add(thPatientIDLabel);
            Controls.Add(thRecordIDLabel);
            Controls.Add(techHomeGroupBox);
            Controls.Add(techHomeTreeView);
            Controls.Add(thMenuStrip);
            MainMenuStrip = thMenuStrip;
            Name = "technicianHomeForm";
            Text = "Technician Home";
            Load += technicianHomeForm_Load;
            thMenuStrip.ResumeLayout(false);
            thMenuStrip.PerformLayout();
            techHomeGroupBox.ResumeLayout(false);
            techHomeGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void thECTLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip thMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private TreeView techHomeTreeView;
        private GroupBox techHomeGroupBox;
        private Button techHomeResetButton;
        private Button techHomeSearchButton;
        private ComboBox techHomeGenderComboBox;
        private DateTimePicker dateTimePicker1;
        private TextBox userNameOrIDTextBox;
        private Label techHomeGenderLabel;
        private Label techHomeDateLabel;
        private Label gbUserNameLabel;
        private Label thRecordIDLabel;
        private Label thPatientIDLabel;
        private Label thUserNameLabel;
        private Label thECTLabel;
        private Label thEUTLabel;
        private Label thOperationLabel;
        private TextBox thSearchingResultTextBox;
        private Button thResultViewButton;
    }
}
