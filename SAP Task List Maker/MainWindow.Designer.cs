namespace SAP_Task_List_Maker
{
    partial class MainWindow
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Existing Measurements");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("New Measurements");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromSapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importMEasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.MainStatus = new System.Windows.Forms.StatusStrip();
            this.StatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusTextLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainSplitLayout = new System.Windows.Forms.SplitContainer();
            this.MeasurementsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MeasPointsTree = new SAP_Task_List_Maker.MyTreeView();
            this.MeasPointDetailGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MPPositionTextBox = new System.Windows.Forms.TextBox();
            this.MPDescLabel = new System.Windows.Forms.Label();
            this.MPPositionLabel = new System.Windows.Forms.Label();
            this.MPDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.MPCharNameLabel = new System.Windows.Forms.Label();
            this.MPCharNameComboBox = new System.Windows.Forms.ComboBox();
            this.MPDecimalPlaceLabel = new System.Windows.Forms.Label();
            this.MPDecimalTextBox = new System.Windows.Forms.TextBox();
            this.MPCodeGroupLabel = new System.Windows.Forms.Label();
            this.MPCodeGroupComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MPLowerLimitTextBox = new System.Windows.Forms.TextBox();
            this.MPUpperLimitTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MPTargetValueTextBox = new System.Windows.Forms.TextBox();
            this.MPTargetTextTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.DataTabs = new System.Windows.Forms.TabControl();
            this.HeaderTab = new System.Windows.Forms.TabPage();
            this.HeaderTabLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DGVHeader = new System.Windows.Forms.DataGridView();
            this.GroupCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CounterCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskListDescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlantCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkCenterCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaintStratCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BodyTab = new System.Windows.Forms.TabPage();
            this.DGVBody = new System.Windows.Forms.DataGridView();
            this.OperationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubOperationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LongTextCol = new SAP_Task_List_Maker.LongTextColumn();
            this.WorkCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabourHourUnitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfPersonCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentsTab = new System.Windows.Forms.TabPage();
            this.PRTTab = new System.Windows.Forms.TabPage();
            this.MainMenu.SuspendLayout();
            this.MainStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitLayout)).BeginInit();
            this.MainSplitLayout.Panel1.SuspendLayout();
            this.MainSplitLayout.Panel2.SuspendLayout();
            this.MainSplitLayout.SuspendLayout();
            this.MeasurementsLayout.SuspendLayout();
            this.MeasPointDetailGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.DataTabs.SuspendLayout();
            this.HeaderTab.SuspendLayout();
            this.HeaderTabLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHeader)).BeginInit();
            this.BodyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBody)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(1978, 33);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromSapToolStripMenuItem,
            this.importMEasToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importFromSapToolStripMenuItem
            // 
            this.importFromSapToolStripMenuItem.Name = "importFromSapToolStripMenuItem";
            this.importFromSapToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.importFromSapToolStripMenuItem.Text = "Import From Sap";
            this.importFromSapToolStripMenuItem.Click += new System.EventHandler(this.importFromSapToolStripMenuItem_Click);
            // 
            // importMEasToolStripMenuItem
            // 
            this.importMEasToolStripMenuItem.Name = "importMEasToolStripMenuItem";
            this.importMEasToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.importMEasToolStripMenuItem.Text = "Import MEas";
            this.importMEasToolStripMenuItem.Click += new System.EventHandler(this.importMEasToolStripMenuItem_Click);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainToolStrip.Location = new System.Drawing.Point(0, 33);
            this.MainToolStrip.MinimumSize = new System.Drawing.Size(0, 62);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(1978, 62);
            this.MainToolStrip.TabIndex = 2;
            this.MainToolStrip.Text = "Tool Strip";
            // 
            // MainStatus
            // 
            this.MainStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusProgressBar,
            this.StatusTextLabel});
            this.MainStatus.Location = new System.Drawing.Point(0, 1222);
            this.MainStatus.Name = "MainStatus";
            this.MainStatus.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.MainStatus.Size = new System.Drawing.Size(1978, 32);
            this.MainStatus.TabIndex = 3;
            this.MainStatus.Text = "statusStrip1";
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.Size = new System.Drawing.Size(125, 24);
            // 
            // StatusTextLabel
            // 
            this.StatusTextLabel.Name = "StatusTextLabel";
            this.StatusTextLabel.Size = new System.Drawing.Size(179, 25);
            this.StatusTextLabel.Text = "toolStripStatusLabel1";
            // 
            // MainSplitLayout
            // 
            this.MainSplitLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitLayout.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainSplitLayout.Location = new System.Drawing.Point(0, 95);
            this.MainSplitLayout.Margin = new System.Windows.Forms.Padding(4);
            this.MainSplitLayout.Name = "MainSplitLayout";
            // 
            // MainSplitLayout.Panel1
            // 
            this.MainSplitLayout.Panel1.Controls.Add(this.MeasurementsLayout);
            // 
            // MainSplitLayout.Panel2
            // 
            this.MainSplitLayout.Panel2.Controls.Add(this.DataTabs);
            this.MainSplitLayout.Size = new System.Drawing.Size(1978, 1127);
            this.MainSplitLayout.SplitterDistance = 433;
            this.MainSplitLayout.SplitterWidth = 5;
            this.MainSplitLayout.TabIndex = 4;
            // 
            // MeasurementsLayout
            // 
            this.MeasurementsLayout.AutoScroll = true;
            this.MeasurementsLayout.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.MeasurementsLayout.AutoScrollMinSize = new System.Drawing.Size(200, 200);
            this.MeasurementsLayout.ColumnCount = 1;
            this.MeasurementsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MeasurementsLayout.Controls.Add(this.MeasPointsTree, 0, 0);
            this.MeasurementsLayout.Controls.Add(this.MeasPointDetailGroupBox, 0, 1);
            this.MeasurementsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasurementsLayout.Location = new System.Drawing.Point(0, 0);
            this.MeasurementsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MeasurementsLayout.Name = "MeasurementsLayout";
            this.MeasurementsLayout.RowCount = 2;
            this.MeasurementsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MeasurementsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MeasurementsLayout.Size = new System.Drawing.Size(433, 1127);
            this.MeasurementsLayout.TabIndex = 1;
            // 
            // MeasPointsTree
            // 
            this.MeasPointsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasPointsTree.Location = new System.Drawing.Point(1, 1);
            this.MeasPointsTree.Margin = new System.Windows.Forms.Padding(1);
            this.MeasPointsTree.Name = "MeasPointsTree";
            treeNode1.Name = "ExistingMeasNode";
            treeNode1.Text = "Existing Measurements";
            treeNode2.Name = "NewMeasNode";
            treeNode2.Text = "New Measurements";
            this.MeasPointsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.MeasPointsTree.Size = new System.Drawing.Size(431, 674);
            this.MeasPointsTree.TabIndex = 0;
            this.MeasPointsTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MeasTree_NodeMouseClick);
            // 
            // MeasPointDetailGroupBox
            // 
            this.MeasPointDetailGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.MeasPointDetailGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasPointDetailGroupBox.Location = new System.Drawing.Point(1, 677);
            this.MeasPointDetailGroupBox.Margin = new System.Windows.Forms.Padding(1);
            this.MeasPointDetailGroupBox.Name = "MeasPointDetailGroupBox";
            this.MeasPointDetailGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.MeasPointDetailGroupBox.Size = new System.Drawing.Size(431, 449);
            this.MeasPointDetailGroupBox.TabIndex = 1;
            this.MeasPointDetailGroupBox.TabStop = false;
            this.MeasPointDetailGroupBox.Text = "Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.5443F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.4557F));
            this.tableLayoutPanel1.Controls.Add(this.MPPositionTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.MPDescLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MPPositionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MPDescriptionTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MPCharNameLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.MPCharNameComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.MPDecimalPlaceLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.MPDecimalTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.MPCodeGroupLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.MPCodeGroupComboBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.MPLowerLimitTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.MPUpperLimitTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.MPTargetValueTextBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.MPTargetTextTextBox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.checkBox2, 0, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(423, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // MPPositionTextBox
            // 
            this.MPPositionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPPositionTextBox.Location = new System.Drawing.Point(145, 43);
            this.MPPositionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MPPositionTextBox.Name = "MPPositionTextBox";
            this.MPPositionTextBox.Size = new System.Drawing.Size(274, 31);
            this.MPPositionTextBox.TabIndex = 2;
            // 
            // MPDescLabel
            // 
            this.MPDescLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MPDescLabel.AutoSize = true;
            this.MPDescLabel.Location = new System.Drawing.Point(35, 7);
            this.MPDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MPDescLabel.Name = "MPDescLabel";
            this.MPDescLabel.Size = new System.Drawing.Size(102, 25);
            this.MPDescLabel.TabIndex = 0;
            this.MPDescLabel.Text = "Description";
            // 
            // MPPositionLabel
            // 
            this.MPPositionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MPPositionLabel.AutoSize = true;
            this.MPPositionLabel.Location = new System.Drawing.Point(62, 46);
            this.MPPositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MPPositionLabel.Name = "MPPositionLabel";
            this.MPPositionLabel.Size = new System.Drawing.Size(75, 25);
            this.MPPositionLabel.TabIndex = 0;
            this.MPPositionLabel.Text = "Position";
            // 
            // MPDescriptionTextBox
            // 
            this.MPDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPDescriptionTextBox.Location = new System.Drawing.Point(145, 4);
            this.MPDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MPDescriptionTextBox.Name = "MPDescriptionTextBox";
            this.MPDescriptionTextBox.Size = new System.Drawing.Size(274, 31);
            this.MPDescriptionTextBox.TabIndex = 1;
            // 
            // MPCharNameLabel
            // 
            this.MPCharNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MPCharNameLabel.AutoSize = true;
            this.MPCharNameLabel.Location = new System.Drawing.Point(21, 86);
            this.MPCharNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MPCharNameLabel.Name = "MPCharNameLabel";
            this.MPCharNameLabel.Size = new System.Drawing.Size(116, 25);
            this.MPCharNameLabel.TabIndex = 0;
            this.MPCharNameLabel.Text = "Characteristic";
            // 
            // MPCharNameComboBox
            // 
            this.MPCharNameComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPCharNameComboBox.FormattingEnabled = true;
            this.MPCharNameComboBox.Location = new System.Drawing.Point(145, 82);
            this.MPCharNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.MPCharNameComboBox.Name = "MPCharNameComboBox";
            this.MPCharNameComboBox.Size = new System.Drawing.Size(274, 33);
            this.MPCharNameComboBox.TabIndex = 3;
            // 
            // MPDecimalPlaceLabel
            // 
            this.MPDecimalPlaceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MPDecimalPlaceLabel.AutoSize = true;
            this.MPDecimalPlaceLabel.Location = new System.Drawing.Point(62, 126);
            this.MPDecimalPlaceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MPDecimalPlaceLabel.Name = "MPDecimalPlaceLabel";
            this.MPDecimalPlaceLabel.Size = new System.Drawing.Size(75, 25);
            this.MPDecimalPlaceLabel.TabIndex = 0;
            this.MPDecimalPlaceLabel.Text = "Decimal";
            // 
            // MPDecimalTextBox
            // 
            this.MPDecimalTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPDecimalTextBox.Location = new System.Drawing.Point(145, 123);
            this.MPDecimalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MPDecimalTextBox.Name = "MPDecimalTextBox";
            this.MPDecimalTextBox.Size = new System.Drawing.Size(274, 31);
            this.MPDecimalTextBox.TabIndex = 5;
            // 
            // MPCodeGroupLabel
            // 
            this.MPCodeGroupLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MPCodeGroupLabel.AutoSize = true;
            this.MPCodeGroupLabel.Location = new System.Drawing.Point(28, 166);
            this.MPCodeGroupLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MPCodeGroupLabel.Name = "MPCodeGroupLabel";
            this.MPCodeGroupLabel.Size = new System.Drawing.Size(109, 25);
            this.MPCodeGroupLabel.TabIndex = 0;
            this.MPCodeGroupLabel.Text = "Code Group";
            // 
            // MPCodeGroupComboBox
            // 
            this.MPCodeGroupComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPCodeGroupComboBox.FormattingEnabled = true;
            this.MPCodeGroupComboBox.Location = new System.Drawing.Point(145, 162);
            this.MPCodeGroupComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.MPCodeGroupComboBox.Name = "MPCodeGroupComboBox";
            this.MPCodeGroupComboBox.Size = new System.Drawing.Size(274, 33);
            this.MPCodeGroupComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lower Limit";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Upper Limit";
            // 
            // MPLowerLimitTextBox
            // 
            this.MPLowerLimitTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPLowerLimitTextBox.Location = new System.Drawing.Point(145, 203);
            this.MPLowerLimitTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MPLowerLimitTextBox.Name = "MPLowerLimitTextBox";
            this.MPLowerLimitTextBox.Size = new System.Drawing.Size(274, 31);
            this.MPLowerLimitTextBox.TabIndex = 8;
            // 
            // MPUpperLimitTextBox
            // 
            this.MPUpperLimitTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPUpperLimitTextBox.Location = new System.Drawing.Point(145, 242);
            this.MPUpperLimitTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MPUpperLimitTextBox.Name = "MPUpperLimitTextBox";
            this.MPUpperLimitTextBox.Size = new System.Drawing.Size(274, 31);
            this.MPUpperLimitTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Target Value";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Target Text";
            // 
            // MPTargetValueTextBox
            // 
            this.MPTargetValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPTargetValueTextBox.Location = new System.Drawing.Point(145, 281);
            this.MPTargetValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MPTargetValueTextBox.Name = "MPTargetValueTextBox";
            this.MPTargetValueTextBox.Size = new System.Drawing.Size(274, 31);
            this.MPTargetValueTextBox.TabIndex = 10;
            // 
            // MPTargetTextTextBox
            // 
            this.MPTargetTextTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPTargetTextTextBox.Location = new System.Drawing.Point(145, 320);
            this.MPTargetTextTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MPTargetTextTextBox.Name = "MPTargetTextTextBox";
            this.MPTargetTextTextBox.Size = new System.Drawing.Size(274, 31);
            this.MPTargetTextTextBox.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(145, 359);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(213, 29);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Value Code Sufficient?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 359);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(127, 29);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Is Counter?";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // DataTabs
            // 
            this.DataTabs.Controls.Add(this.HeaderTab);
            this.DataTabs.Controls.Add(this.BodyTab);
            this.DataTabs.Controls.Add(this.ComponentsTab);
            this.DataTabs.Controls.Add(this.PRTTab);
            this.DataTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTabs.Location = new System.Drawing.Point(0, 0);
            this.DataTabs.Margin = new System.Windows.Forms.Padding(0);
            this.DataTabs.Name = "DataTabs";
            this.DataTabs.SelectedIndex = 0;
            this.DataTabs.Size = new System.Drawing.Size(1540, 1127);
            this.DataTabs.TabIndex = 0;
            // 
            // HeaderTab
            // 
            this.HeaderTab.Controls.Add(this.HeaderTabLayout);
            this.HeaderTab.Location = new System.Drawing.Point(4, 34);
            this.HeaderTab.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderTab.Name = "HeaderTab";
            this.HeaderTab.Padding = new System.Windows.Forms.Padding(4);
            this.HeaderTab.Size = new System.Drawing.Size(1532, 1089);
            this.HeaderTab.TabIndex = 0;
            this.HeaderTab.Text = "Header";
            this.HeaderTab.UseVisualStyleBackColor = true;
            // 
            // HeaderTabLayout
            // 
            this.HeaderTabLayout.ColumnCount = 1;
            this.HeaderTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderTabLayout.Controls.Add(this.DGVHeader, 0, 1);
            this.HeaderTabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderTabLayout.Location = new System.Drawing.Point(4, 4);
            this.HeaderTabLayout.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderTabLayout.Name = "HeaderTabLayout";
            this.HeaderTabLayout.RowCount = 2;
            this.HeaderTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.12676F));
            this.HeaderTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.87324F));
            this.HeaderTabLayout.Size = new System.Drawing.Size(1524, 1081);
            this.HeaderTabLayout.TabIndex = 0;
            // 
            // DGVHeader
            // 
            this.DGVHeader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVHeader.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupCol,
            this.CounterCol,
            this.TaskListDescriptionCol,
            this.PlantCol,
            this.WorkCenterCol,
            this.MaintStratCol});
            this.DGVHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVHeader.Location = new System.Drawing.Point(0, 120);
            this.DGVHeader.Margin = new System.Windows.Forms.Padding(0);
            this.DGVHeader.Name = "DGVHeader";
            this.DGVHeader.RowHeadersVisible = false;
            this.DGVHeader.RowHeadersWidth = 51;
            this.DGVHeader.RowTemplate.Height = 29;
            this.DGVHeader.Size = new System.Drawing.Size(1524, 961);
            this.DGVHeader.TabIndex = 1;
            // 
            // GroupCol
            // 
            dataGridViewCellStyle1.Format = "0000";
            dataGridViewCellStyle1.NullValue = null;
            this.GroupCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.GroupCol.HeaderText = "Group";
            this.GroupCol.MinimumWidth = 80;
            this.GroupCol.Name = "GroupCol";
            // 
            // CounterCol
            // 
            this.CounterCol.HeaderText = "Counter";
            this.CounterCol.MinimumWidth = 80;
            this.CounterCol.Name = "CounterCol";
            // 
            // TaskListDescriptionCol
            // 
            this.TaskListDescriptionCol.HeaderText = "Description";
            this.TaskListDescriptionCol.MinimumWidth = 250;
            this.TaskListDescriptionCol.Name = "TaskListDescriptionCol";
            // 
            // PlantCol
            // 
            this.PlantCol.HeaderText = "Plant";
            this.PlantCol.MinimumWidth = 70;
            this.PlantCol.Name = "PlantCol";
            this.PlantCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // WorkCenterCol
            // 
            this.WorkCenterCol.HeaderText = "Work Center";
            this.WorkCenterCol.MinimumWidth = 6;
            this.WorkCenterCol.Name = "WorkCenterCol";
            this.WorkCenterCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkCenterCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MaintStratCol
            // 
            this.MaintStratCol.HeaderText = "Maintenance Strategy";
            this.MaintStratCol.MinimumWidth = 6;
            this.MaintStratCol.Name = "MaintStratCol";
            // 
            // BodyTab
            // 
            this.BodyTab.Controls.Add(this.DGVBody);
            this.BodyTab.Location = new System.Drawing.Point(4, 34);
            this.BodyTab.Margin = new System.Windows.Forms.Padding(4);
            this.BodyTab.Name = "BodyTab";
            this.BodyTab.Padding = new System.Windows.Forms.Padding(4);
            this.BodyTab.Size = new System.Drawing.Size(1532, 1089);
            this.BodyTab.TabIndex = 1;
            this.BodyTab.Text = "Body";
            this.BodyTab.UseVisualStyleBackColor = true;
            // 
            // DGVBody
            // 
            this.DGVBody.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBody.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVBody.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBody.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBody.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OperationCol,
            this.SubOperationCol,
            this.DescriptionCol,
            this.LongTextCol,
            this.WorkCol,
            this.LabourHourUnitCol,
            this.NumOfPersonCol});
            this.DGVBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVBody.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVBody.Location = new System.Drawing.Point(4, 4);
            this.DGVBody.Margin = new System.Windows.Forms.Padding(4);
            this.DGVBody.Name = "DGVBody";
            this.DGVBody.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVBody.RowHeadersWidth = 25;
            this.DGVBody.RowTemplate.Height = 29;
            this.DGVBody.Size = new System.Drawing.Size(1524, 1081);
            this.DGVBody.TabIndex = 0;
            this.DGVBody.MouseEnter += new System.EventHandler(this.BodyDGV_MouseEnter);
            // 
            // OperationCol
            // 
            dataGridViewCellStyle3.Format = "0000";
            dataGridViewCellStyle3.NullValue = null;
            this.OperationCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.OperationCol.FillWeight = 10F;
            this.OperationCol.HeaderText = "Operation";
            this.OperationCol.MinimumWidth = 10;
            this.OperationCol.Name = "OperationCol";
            // 
            // SubOperationCol
            // 
            this.SubOperationCol.FillWeight = 10F;
            this.SubOperationCol.HeaderText = "Sub Operation";
            this.SubOperationCol.MinimumWidth = 10;
            this.SubOperationCol.Name = "SubOperationCol";
            // 
            // DescriptionCol
            // 
            this.DescriptionCol.FillWeight = 20F;
            this.DescriptionCol.HeaderText = "Description";
            this.DescriptionCol.MinimumWidth = 100;
            this.DescriptionCol.Name = "DescriptionCol";
            // 
            // LongTextCol
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LongTextCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.LongTextCol.FillWeight = 70F;
            this.LongTextCol.HeaderText = "Long Text";
            this.LongTextCol.MinimumWidth = 300;
            this.LongTextCol.Name = "LongTextCol";
            this.LongTextCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LongTextCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.LongTextCol.ToolTipText = "Long Text for Operation";
            // 
            // WorkCol
            // 
            this.WorkCol.FillWeight = 5F;
            this.WorkCol.HeaderText = "Labour Hours";
            this.WorkCol.MinimumWidth = 10;
            this.WorkCol.Name = "WorkCol";
            this.WorkCol.ToolTipText = "Hours required for Operation";
            // 
            // LabourHourUnitCol
            // 
            this.LabourHourUnitCol.FillWeight = 10F;
            this.LabourHourUnitCol.HeaderText = "Labour Hour Unit";
            this.LabourHourUnitCol.MinimumWidth = 10;
            this.LabourHourUnitCol.Name = "LabourHourUnitCol";
            // 
            // NumOfPersonCol
            // 
            this.NumOfPersonCol.FillWeight = 10F;
            this.NumOfPersonCol.HeaderText = "Number of Person";
            this.NumOfPersonCol.MinimumWidth = 10;
            this.NumOfPersonCol.Name = "NumOfPersonCol";
            // 
            // ComponentsTab
            // 
            this.ComponentsTab.Location = new System.Drawing.Point(4, 34);
            this.ComponentsTab.Margin = new System.Windows.Forms.Padding(4);
            this.ComponentsTab.Name = "ComponentsTab";
            this.ComponentsTab.Padding = new System.Windows.Forms.Padding(4);
            this.ComponentsTab.Size = new System.Drawing.Size(1532, 1089);
            this.ComponentsTab.TabIndex = 2;
            this.ComponentsTab.Text = "Components";
            this.ComponentsTab.UseVisualStyleBackColor = true;
            // 
            // PRTTab
            // 
            this.PRTTab.Location = new System.Drawing.Point(4, 34);
            this.PRTTab.Margin = new System.Windows.Forms.Padding(4);
            this.PRTTab.Name = "PRTTab";
            this.PRTTab.Padding = new System.Windows.Forms.Padding(4);
            this.PRTTab.Size = new System.Drawing.Size(1532, 1089);
            this.PRTTab.TabIndex = 3;
            this.PRTTab.Text = "PRT";
            this.PRTTab.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1978, 1254);
            this.Controls.Add(this.MainSplitLayout);
            this.Controls.Add(this.MainStatus);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainStatus.ResumeLayout(false);
            this.MainStatus.PerformLayout();
            this.MainSplitLayout.Panel1.ResumeLayout(false);
            this.MainSplitLayout.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitLayout)).EndInit();
            this.MainSplitLayout.ResumeLayout(false);
            this.MeasurementsLayout.ResumeLayout(false);
            this.MeasPointDetailGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.DataTabs.ResumeLayout(false);
            this.HeaderTab.ResumeLayout(false);
            this.HeaderTabLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVHeader)).EndInit();
            this.BodyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.StatusStrip MainStatus;
        private System.Windows.Forms.SplitContainer MainSplitLayout;
        private System.Windows.Forms.TabControl DataTabs;
        private System.Windows.Forms.TabPage HeaderTab;
        private System.Windows.Forms.TabPage BodyTab;
        private System.Windows.Forms.ToolStripProgressBar StatusProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusTextLabel;
        public System.Windows.Forms.DataGridView DGVBody;
        private System.Windows.Forms.ToolStripMenuItem importFromSapToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel HeaderTabLayout;
        private System.Windows.Forms.TabPage ComponentsTab;
        private System.Windows.Forms.TabPage PRTTab;
        public System.Windows.Forms.DataGridView DGVHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CounterCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskListDescriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlantCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkCenterCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaintStratCol;
        private System.Windows.Forms.ToolStripMenuItem importMEasToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel MeasurementsLayout;
        public MyTreeView MeasPointsTree;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubOperationCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionCol;
        private LongTextColumn LongTextCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabourHourUnitCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOfPersonCol;
        private System.Windows.Forms.GroupBox MeasPointDetailGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox MPPositionTextBox;
        private System.Windows.Forms.Label MPDescLabel;
        private System.Windows.Forms.Label MPPositionLabel;
        private System.Windows.Forms.TextBox MPDescriptionTextBox;
        private System.Windows.Forms.Label MPCharNameLabel;
        private System.Windows.Forms.ComboBox MPCharNameComboBox;
        private System.Windows.Forms.Label MPDecimalPlaceLabel;
        private System.Windows.Forms.TextBox MPDecimalTextBox;
        private System.Windows.Forms.Label MPCodeGroupLabel;
        private System.Windows.Forms.ComboBox MPCodeGroupComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MPLowerLimitTextBox;
        private System.Windows.Forms.TextBox MPUpperLimitTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MPTargetValueTextBox;
        private System.Windows.Forms.TextBox MPTargetTextTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}
