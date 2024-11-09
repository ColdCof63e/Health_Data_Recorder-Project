namespace Project
{
    partial class UserHome
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopCenterCellTable = new System.Windows.Forms.TableLayoutPanel();
            this.CreateNewEntryBtn = new System.Windows.Forms.Button();
            this.ModifyEntryBtn = new System.Windows.Forms.Button();
            this.BottomCenterCellTable = new System.Windows.Forms.TableLayoutPanel();
            this.AlertBtn = new System.Windows.Forms.Button();
            this.BottomLeftCellTable = new System.Windows.Forms.TableLayoutPanel();
            this.MyHomeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MyAccountBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.mainTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopCenterCellTable.SuspendLayout();
            this.BottomCenterCellTable.SuspendLayout();
            this.BottomLeftCellTable.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "&Logout";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewEntryToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // createNewEntryToolStripMenuItem
            // 
            this.createNewEntryToolStripMenuItem.Name = "createNewEntryToolStripMenuItem";
            this.createNewEntryToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.createNewEntryToolStripMenuItem.Text = "Create &New Entry";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutUsToolStripMenuItem.Text = "&About Us";
            // 
            // mainTable
            // 
            this.mainTable.AutoSize = true;
            this.mainTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainTable.ColumnCount = 3;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTable.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.mainTable.Controls.Add(this.chart1, 0, 0);
            this.mainTable.Controls.Add(this.pictureBox1, 1, 1);
            this.mainTable.Controls.Add(this.TopCenterCellTable, 1, 0);
            this.mainTable.Controls.Add(this.BottomCenterCellTable, 1, 2);
            this.mainTable.Controls.Add(this.BottomLeftCellTable, 0, 2);
            this.mainTable.Controls.Add(this.tableLayoutPanel2, 2, 2);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 24);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 3;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTable.Size = new System.Drawing.Size(800, 426);
            this.mainTable.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(535, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 136);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(93, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(93, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(260, 136);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TopCenterCellTable
            // 
            this.TopCenterCellTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopCenterCellTable.ColumnCount = 3;
            this.TopCenterCellTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TopCenterCellTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TopCenterCellTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TopCenterCellTable.Controls.Add(this.CreateNewEntryBtn, 0, 1);
            this.TopCenterCellTable.Controls.Add(this.ModifyEntryBtn, 2, 1);
            this.TopCenterCellTable.Location = new System.Drawing.Point(269, 3);
            this.TopCenterCellTable.Name = "TopCenterCellTable";
            this.TopCenterCellTable.RowCount = 3;
            this.TopCenterCellTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TopCenterCellTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TopCenterCellTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TopCenterCellTable.Size = new System.Drawing.Size(260, 136);
            this.TopCenterCellTable.TabIndex = 2;
            // 
            // CreateNewEntryBtn
            // 
            this.CreateNewEntryBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CreateNewEntryBtn.Location = new System.Drawing.Point(8, 56);
            this.CreateNewEntryBtn.Name = "CreateNewEntryBtn";
            this.CreateNewEntryBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateNewEntryBtn.TabIndex = 0;
            this.CreateNewEntryBtn.Text = "Create &New Entry";
            this.CreateNewEntryBtn.UseVisualStyleBackColor = true;
            this.CreateNewEntryBtn.Click += new System.EventHandler(this.CreateNewEntryBtn_Click);
            // 
            // ModifyEntryBtn
            // 
            this.ModifyEntryBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ModifyEntryBtn.Location = new System.Drawing.Point(175, 56);
            this.ModifyEntryBtn.Name = "ModifyEntryBtn";
            this.ModifyEntryBtn.Size = new System.Drawing.Size(75, 23);
            this.ModifyEntryBtn.TabIndex = 1;
            this.ModifyEntryBtn.Text = "&Modify";
            this.ModifyEntryBtn.UseVisualStyleBackColor = true;
            // 
            // BottomCenterCellTable
            // 
            this.BottomCenterCellTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomCenterCellTable.ColumnCount = 3;
            this.BottomCenterCellTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomCenterCellTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomCenterCellTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomCenterCellTable.Controls.Add(this.AlertBtn, 1, 0);
            this.BottomCenterCellTable.Location = new System.Drawing.Point(269, 287);
            this.BottomCenterCellTable.Name = "BottomCenterCellTable";
            this.BottomCenterCellTable.RowCount = 3;
            this.BottomCenterCellTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomCenterCellTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomCenterCellTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomCenterCellTable.Size = new System.Drawing.Size(260, 136);
            this.BottomCenterCellTable.TabIndex = 3;
            // 
            // AlertBtn
            // 
            this.AlertBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AlertBtn.Location = new System.Drawing.Point(91, 3);
            this.AlertBtn.Name = "AlertBtn";
            this.AlertBtn.Size = new System.Drawing.Size(75, 23);
            this.AlertBtn.TabIndex = 0;
            this.AlertBtn.Text = "Aler&t";
            this.AlertBtn.UseVisualStyleBackColor = true;
            // 
            // BottomLeftCellTable
            // 
            this.BottomLeftCellTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomLeftCellTable.ColumnCount = 3;
            this.BottomLeftCellTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomLeftCellTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomLeftCellTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomLeftCellTable.Controls.Add(this.MyHomeLabel, 1, 1);
            this.BottomLeftCellTable.Location = new System.Drawing.Point(3, 287);
            this.BottomLeftCellTable.Name = "BottomLeftCellTable";
            this.BottomLeftCellTable.RowCount = 3;
            this.BottomLeftCellTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomLeftCellTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomLeftCellTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomLeftCellTable.Size = new System.Drawing.Size(260, 136);
            this.BottomLeftCellTable.TabIndex = 4;
            // 
            // MyHomeLabel
            // 
            this.MyHomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MyHomeLabel.AutoSize = true;
            this.MyHomeLabel.Location = new System.Drawing.Point(103, 61);
            this.MyHomeLabel.Name = "MyHomeLabel";
            this.MyHomeLabel.Size = new System.Drawing.Size(52, 13);
            this.MyHomeLabel.TabIndex = 0;
            this.MyHomeLabel.Text = "My Home";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.MyAccountBtn, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(535, 287);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(262, 136);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // MyAccountBtn
            // 
            this.MyAccountBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MyAccountBtn.Location = new System.Drawing.Point(93, 56);
            this.MyAccountBtn.Name = "MyAccountBtn";
            this.MyAccountBtn.Size = new System.Drawing.Size(75, 23);
            this.MyAccountBtn.TabIndex = 0;
            this.MyAccountBtn.Text = "My Account";
            this.MyAccountBtn.UseVisualStyleBackColor = true;
            this.MyAccountBtn.Click += new System.EventHandler(this.MyAccountBtn_Click);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserHome";
            this.Text = "User_Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainTable.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopCenterCellTable.ResumeLayout(false);
            this.BottomCenterCellTable.ResumeLayout(false);
            this.BottomLeftCellTable.ResumeLayout(false);
            this.BottomLeftCellTable.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel TopCenterCellTable;
        private System.Windows.Forms.Button CreateNewEntryBtn;
        private System.Windows.Forms.Button ModifyEntryBtn;
        private System.Windows.Forms.TableLayoutPanel BottomCenterCellTable;
        private System.Windows.Forms.Button AlertBtn;
        private System.Windows.Forms.TableLayoutPanel BottomLeftCellTable;
        private System.Windows.Forms.Label MyHomeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button MyAccountBtn;
    }
}