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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("EXISTING MEASUREMENTS");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("MEASUREMENT TO CREATE");
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromSapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importMEasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelEditableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelSAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelEditableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excelSAPDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.MainStatus = new System.Windows.Forms.StatusStrip();
            this.StatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusTextLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainSplitLayout = new System.Windows.Forms.SplitContainer();
            this.MeasurementsLayout = new System.Windows.Forms.TableLayoutPanel();
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
            this.MeasUpdateButton = new System.Windows.Forms.Button();
            this.MeasPointsTree = new SAP_Task_List_Maker.MyTree();
            this.DataTabs = new System.Windows.Forms.TabControl();
            this.HeaderTab = new System.Windows.Forms.TabPage();
            this.HeaderTabLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DGVHeader = new SAP_Task_List_Maker.Tasklist();
            this.HGroupCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HCounterCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HPlanningPlantCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HWorkCenterCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HPlannerGroupCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HMaintStratergyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderInputsGB = new System.Windows.Forms.GroupBox();
            this.HeaderInputsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TasklistGroupLBL = new System.Windows.Forms.Label();
            this.TasklistGroupTB = new System.Windows.Forms.TextBox();
            this.TasklistCounterLBL = new System.Windows.Forms.Label();
            this.TasklistCounterTB = new System.Windows.Forms.TextBox();
            this.TemplateEquipmentLBL = new System.Windows.Forms.Label();
            this.TemplateEquipmentTB = new System.Windows.Forms.TextBox();
            this.BodyTab = new System.Windows.Forms.TabPage();
            this.DGVBody = new SAP_Task_List_Maker.Tasklist();
            this.BOperationNumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSubOperationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOperationDescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BLongTextCol = new SAP_Task_List_Maker.LongTextColumn();
            this.BTotalWorkCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUnitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTechniciansCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BMeasurementsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.HeaderInputsGB.SuspendLayout();
            this.HeaderInputsLayout.SuspendLayout();
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
            this.MainMenu.Padding = new System.Windows.Forms.Padding(7, 1, 0, 1);
            this.MainMenu.Size = new System.Drawing.Size(1583, 26);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromSapToolStripMenuItem,
            this.importMEasToolStripMenuItem,
            this.exportToToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importFromSapToolStripMenuItem
            // 
            this.importFromSapToolStripMenuItem.Name = "importFromSapToolStripMenuItem";
            this.importFromSapToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.importFromSapToolStripMenuItem.Text = "Import From Sap";
            this.importFromSapToolStripMenuItem.Click += new System.EventHandler(this.importFromSapToolStripMenuItem_Click);
            // 
            // importMEasToolStripMenuItem
            // 
            this.importMEasToolStripMenuItem.Name = "importMEasToolStripMenuItem";
            this.importMEasToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.importMEasToolStripMenuItem.Text = "Import MEas";
            this.importMEasToolStripMenuItem.Click += new System.EventHandler(this.importMEasToolStripMenuItem_Click);
            // 
            // exportToToolStripMenuItem
            // 
            this.exportToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelEditableToolStripMenuItem,
            this.excelSAPToolStripMenuItem});
            this.exportToToolStripMenuItem.Name = "exportToToolStripMenuItem";
            this.exportToToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.exportToToolStripMenuItem.Text = "Export";
            // 
            // excelEditableToolStripMenuItem
            // 
            this.excelEditableToolStripMenuItem.Name = "excelEditableToolStripMenuItem";
            this.excelEditableToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.excelEditableToolStripMenuItem.Text = "Excel (Editable)";
            // 
            // excelSAPToolStripMenuItem
            // 
            this.excelSAPToolStripMenuItem.Name = "excelSAPToolStripMenuItem";
            this.excelSAPToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.excelSAPToolStripMenuItem.Text = "Excel (SAP Data File)";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelEditableToolStripMenuItem1,
            this.excelSAPDataFileToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // excelEditableToolStripMenuItem1
            // 
            this.excelEditableToolStripMenuItem1.Name = "excelEditableToolStripMenuItem1";
            this.excelEditableToolStripMenuItem1.Size = new System.Drawing.Size(229, 26);
            this.excelEditableToolStripMenuItem1.Text = "Excel (Editable)";
            // 
            // excelSAPDataFileToolStripMenuItem
            // 
            this.excelSAPDataFileToolStripMenuItem.Name = "excelSAPDataFileToolStripMenuItem";
            this.excelSAPDataFileToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.excelSAPDataFileToolStripMenuItem.Text = "Excel (SAP Data File)";
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainToolStrip.Location = new System.Drawing.Point(0, 26);
            this.MainToolStrip.MinimumSize = new System.Drawing.Size(0, 50);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(1583, 50);
            this.MainToolStrip.TabIndex = 2;
            this.MainToolStrip.Text = "Tool Strip";
            // 
            // MainStatus
            // 
            this.MainStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusProgressBar,
            this.StatusTextLabel});
            this.MainStatus.Location = new System.Drawing.Point(0, 1057);
            this.MainStatus.Name = "MainStatus";
            this.MainStatus.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.MainStatus.Size = new System.Drawing.Size(1583, 30);
            this.MainStatus.TabIndex = 3;
            this.MainStatus.Text = "statusStrip1";
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.Size = new System.Drawing.Size(100, 22);
            // 
            // StatusTextLabel
            // 
            this.StatusTextLabel.Name = "StatusTextLabel";
            this.StatusTextLabel.Size = new System.Drawing.Size(151, 24);
            this.StatusTextLabel.Text = "toolStripStatusLabel1";
            // 
            // MainSplitLayout
            // 
            this.MainSplitLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitLayout.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainSplitLayout.Location = new System.Drawing.Point(0, 76);
            this.MainSplitLayout.Name = "MainSplitLayout";
            // 
            // MainSplitLayout.Panel1
            // 
            this.MainSplitLayout.Panel1.Controls.Add(this.MeasurementsLayout);
            // 
            // MainSplitLayout.Panel2
            // 
            this.MainSplitLayout.Panel2.Controls.Add(this.DataTabs);
            this.MainSplitLayout.Size = new System.Drawing.Size(1583, 981);
            this.MainSplitLayout.SplitterDistance = 433;
            this.MainSplitLayout.TabIndex = 4;
            // 
            // MeasurementsLayout
            // 
            this.MeasurementsLayout.AutoScroll = true;
            this.MeasurementsLayout.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.MeasurementsLayout.AutoScrollMinSize = new System.Drawing.Size(200, 200);
            this.MeasurementsLayout.ColumnCount = 1;
            this.MeasurementsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MeasurementsLayout.Controls.Add(this.MeasPointDetailGroupBox, 0, 1);
            this.MeasurementsLayout.Controls.Add(this.MeasPointsTree, 0, 0);
            this.MeasurementsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasurementsLayout.Location = new System.Drawing.Point(0, 0);
            this.MeasurementsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MeasurementsLayout.Name = "MeasurementsLayout";
            this.MeasurementsLayout.RowCount = 2;
            this.MeasurementsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.MeasurementsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.MeasurementsLayout.Size = new System.Drawing.Size(433, 981);
            this.MeasurementsLayout.TabIndex = 1;
            // 
            // MeasPointDetailGroupBox
            // 
            this.MeasPointDetailGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.MeasPointDetailGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasPointDetailGroupBox.Location = new System.Drawing.Point(1, 569);
            this.MeasPointDetailGroupBox.Margin = new System.Windows.Forms.Padding(1);
            this.MeasPointDetailGroupBox.Name = "MeasPointDetailGroupBox";
            this.MeasPointDetailGroupBox.Size = new System.Drawing.Size(431, 411);
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
            this.tableLayoutPanel1.Controls.Add(this.MeasUpdateButton, 0, 11);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(425, 385);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MPPositionTextBox
            // 
            this.MPPositionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPPositionTextBox.Location = new System.Drawing.Point(145, 36);
            this.MPPositionTextBox.Name = "MPPositionTextBox";
            this.MPPositionTextBox.Size = new System.Drawing.Size(277, 27);
            this.MPPositionTextBox.TabIndex = 2;
            // 
            // MPDescLabel
            // 
            this.MPDescLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MPDescLabel.AutoSize = true;
            this.MPDescLabel.Location = new System.Drawing.Point(54, 6);
            this.MPDescLabel.Name = "MPDescLabel";
            this.MPDescLabel.Size = new System.Drawing.Size(85, 20);
            this.MPDescLabel.TabIndex = 0;
            this.MPDescLabel.Text = "Description";
            // 
            // MPPositionLabel
            // 
            this.MPPositionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MPPositionLabel.AutoSize = true;
            this.MPPositionLabel.Location = new System.Drawing.Point(78, 39);
            this.MPPositionLabel.Name = "MPPositionLabel";
            this.MPPositionLabel.Size = new System.Drawing.Size(61, 20);
            this.MPPositionLabel.TabIndex = 0;
            this.MPPositionLabel.Text = "Position";
            // 
            // MPDescriptionTextBox
            // 
            this.MPDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPDescriptionTextBox.Location = new System.Drawing.Point(145, 3);
            this.MPDescriptionTextBox.Name = "MPDescriptionTextBox";
            this.MPDescriptionTextBox.Size = new System.Drawing.Size(277, 27);
            this.MPDescriptionTextBox.TabIndex = 1;
            // 
            // MPCharNameLabel
            // 
            this.MPCharNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MPCharNameLabel.AutoSize = true;
            this.MPCharNameLabel.Location = new System.Drawing.Point(41, 73);
            this.MPCharNameLabel.Name = "MPCharNameLabel";
            this.MPCharNameLabel.Size = new System.Drawing.Size(98, 20);
            this.MPCharNameLabel.TabIndex = 0;
            this.MPCharNameLabel.Text = "Characteristic";
            // 
            // MPCharNameComboBox
            // 
            this.MPCharNameComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPCharNameComboBox.FormattingEnabled = true;
            this.MPCharNameComboBox.Location = new System.Drawing.Point(145, 69);
            this.MPCharNameComboBox.Name = "MPCharNameComboBox";
            this.MPCharNameComboBox.Size = new System.Drawing.Size(277, 28);
            this.MPCharNameComboBox.TabIndex = 3;
            // 
            // MPDecimalPlaceLabel
            // 
            this.MPDecimalPlaceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MPDecimalPlaceLabel.AutoSize = true;
            this.MPDecimalPlaceLabel.Location = new System.Drawing.Point(75, 106);
            this.MPDecimalPlaceLabel.Name = "MPDecimalPlaceLabel";
            this.MPDecimalPlaceLabel.Size = new System.Drawing.Size(64, 20);
            this.MPDecimalPlaceLabel.TabIndex = 0;
            this.MPDecimalPlaceLabel.Text = "Decimal";
            // 
            // MPDecimalTextBox
            // 
            this.MPDecimalTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPDecimalTextBox.Location = new System.Drawing.Point(145, 103);
            this.MPDecimalTextBox.Name = "MPDecimalTextBox";
            this.MPDecimalTextBox.Size = new System.Drawing.Size(277, 27);
            this.MPDecimalTextBox.TabIndex = 5;
            // 
            // MPCodeGroupLabel
            // 
            this.MPCodeGroupLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MPCodeGroupLabel.AutoSize = true;
            this.MPCodeGroupLabel.Location = new System.Drawing.Point(50, 140);
            this.MPCodeGroupLabel.Name = "MPCodeGroupLabel";
            this.MPCodeGroupLabel.Size = new System.Drawing.Size(89, 20);
            this.MPCodeGroupLabel.TabIndex = 0;
            this.MPCodeGroupLabel.Text = "Code Group";
            // 
            // MPCodeGroupComboBox
            // 
            this.MPCodeGroupComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPCodeGroupComboBox.FormattingEnabled = true;
            this.MPCodeGroupComboBox.Location = new System.Drawing.Point(145, 136);
            this.MPCodeGroupComboBox.Name = "MPCodeGroupComboBox";
            this.MPCodeGroupComboBox.Size = new System.Drawing.Size(277, 28);
            this.MPCodeGroupComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lower Limit";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Upper Limit";
            // 
            // MPLowerLimitTextBox
            // 
            this.MPLowerLimitTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPLowerLimitTextBox.Location = new System.Drawing.Point(145, 170);
            this.MPLowerLimitTextBox.Name = "MPLowerLimitTextBox";
            this.MPLowerLimitTextBox.Size = new System.Drawing.Size(277, 27);
            this.MPLowerLimitTextBox.TabIndex = 8;
            // 
            // MPUpperLimitTextBox
            // 
            this.MPUpperLimitTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPUpperLimitTextBox.Location = new System.Drawing.Point(145, 203);
            this.MPUpperLimitTextBox.Name = "MPUpperLimitTextBox";
            this.MPUpperLimitTextBox.Size = new System.Drawing.Size(277, 27);
            this.MPUpperLimitTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Target Value";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Target Text";
            // 
            // MPTargetValueTextBox
            // 
            this.MPTargetValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPTargetValueTextBox.Location = new System.Drawing.Point(145, 236);
            this.MPTargetValueTextBox.Name = "MPTargetValueTextBox";
            this.MPTargetValueTextBox.Size = new System.Drawing.Size(277, 27);
            this.MPTargetValueTextBox.TabIndex = 10;
            // 
            // MPTargetTextTextBox
            // 
            this.MPTargetTextTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPTargetTextTextBox.Location = new System.Drawing.Point(145, 269);
            this.MPTargetTextTextBox.Name = "MPTargetTextTextBox";
            this.MPTargetTextTextBox.Size = new System.Drawing.Size(277, 27);
            this.MPTargetTextTextBox.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(145, 302);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(179, 24);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Value Code Sufficient?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(35, 302);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 24);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Is Counter?";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // MeasUpdateButton
            // 
            this.MeasUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.MeasUpdateButton, 2);
            this.MeasUpdateButton.Location = new System.Drawing.Point(3, 332);
            this.MeasUpdateButton.Name = "MeasUpdateButton";
            this.MeasUpdateButton.Size = new System.Drawing.Size(419, 50);
            this.MeasUpdateButton.TabIndex = 13;
            this.MeasUpdateButton.Text = "Update Selected";
            this.MeasUpdateButton.UseVisualStyleBackColor = true;
            this.MeasUpdateButton.Click += new System.EventHandler(this.MeasUpdateButton_Click);
            // 
            // MeasPointsTree
            // 
            this.MeasPointsTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MeasPointsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasPointsTree.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.MeasPointsTree.Location = new System.Drawing.Point(3, 3);
            this.MeasPointsTree.Name = "MeasPointsTree";
            treeNode1.Name = "ExistingMeasRoot";
            treeNode1.NodeFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode1.Text = "EXISTING MEASUREMENTS";
            treeNode2.Name = "NewMeasRoot";
            treeNode2.NodeFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode2.Text = "MEASUREMENT TO CREATE";
            this.MeasPointsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.MeasPointsTree.Size = new System.Drawing.Size(427, 562);
            this.MeasPointsTree.TabIndex = 2;
            // 
            // DataTabs
            // 
            this.DataTabs.Controls.Add(this.HeaderTab);
            this.DataTabs.Controls.Add(this.BodyTab);
            this.DataTabs.Controls.Add(this.ComponentsTab);
            this.DataTabs.Controls.Add(this.PRTTab);
            this.DataTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTabs.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DataTabs.Location = new System.Drawing.Point(0, 0);
            this.DataTabs.Margin = new System.Windows.Forms.Padding(0);
            this.DataTabs.Name = "DataTabs";
            this.DataTabs.SelectedIndex = 0;
            this.DataTabs.Size = new System.Drawing.Size(1146, 981);
            this.DataTabs.TabIndex = 0;
            // 
            // HeaderTab
            // 
            this.HeaderTab.Controls.Add(this.HeaderTabLayout);
            this.HeaderTab.Location = new System.Drawing.Point(4, 29);
            this.HeaderTab.Name = "HeaderTab";
            this.HeaderTab.Padding = new System.Windows.Forms.Padding(3);
            this.HeaderTab.Size = new System.Drawing.Size(1138, 948);
            this.HeaderTab.TabIndex = 0;
            this.HeaderTab.Text = "TASKLIST HEADER";
            this.HeaderTab.UseVisualStyleBackColor = true;
            // 
            // HeaderTabLayout
            // 
            this.HeaderTabLayout.ColumnCount = 1;
            this.HeaderTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderTabLayout.Controls.Add(this.DGVHeader, 0, 1);
            this.HeaderTabLayout.Controls.Add(this.HeaderInputsGB, 0, 0);
            this.HeaderTabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderTabLayout.Location = new System.Drawing.Point(3, 3);
            this.HeaderTabLayout.Name = "HeaderTabLayout";
            this.HeaderTabLayout.RowCount = 2;
            this.HeaderTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.12676F));
            this.HeaderTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.87324F));
            this.HeaderTabLayout.Size = new System.Drawing.Size(1132, 942);
            this.HeaderTabLayout.TabIndex = 0;
            // 
            // DGVHeader
            // 
            this.DGVHeader.AllowUserToAddRows = false;
            this.DGVHeader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HGroupCol,
            this.HCounterCol,
            this.HDescriptionCol,
            this.HPlanningPlantCol,
            this.HWorkCenterCol,
            this.HPlannerGroupCol,
            this.HMaintStratergyCol});
            this.DGVHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVHeader.GridColor = System.Drawing.Color.LightGray;
            this.DGVHeader.Location = new System.Drawing.Point(3, 107);
            this.DGVHeader.Name = "DGVHeader";
            this.DGVHeader.RowHeadersVisible = false;
            this.DGVHeader.RowHeadersWidth = 51;
            this.DGVHeader.RowTemplate.Height = 29;
            this.DGVHeader.Size = new System.Drawing.Size(1126, 832);
            this.DGVHeader.TabIndex = 0;
            // 
            // HGroupCol
            // 
            this.HGroupCol.HeaderText = "TASKLIST GROUP";
            this.HGroupCol.MinimumWidth = 6;
            this.HGroupCol.Name = "HGroupCol";
            // 
            // HCounterCol
            // 
            this.HCounterCol.HeaderText = "TASKLIST COUNTER";
            this.HCounterCol.MinimumWidth = 6;
            this.HCounterCol.Name = "HCounterCol";
            // 
            // HDescriptionCol
            // 
            this.HDescriptionCol.HeaderText = "TASKLIST DESCRIPTION";
            this.HDescriptionCol.MinimumWidth = 6;
            this.HDescriptionCol.Name = "HDescriptionCol";
            // 
            // HPlanningPlantCol
            // 
            this.HPlanningPlantCol.HeaderText = "PLANNING PLANT";
            this.HPlanningPlantCol.MinimumWidth = 6;
            this.HPlanningPlantCol.Name = "HPlanningPlantCol";
            // 
            // HWorkCenterCol
            // 
            this.HWorkCenterCol.HeaderText = "WORK CENTER";
            this.HWorkCenterCol.MinimumWidth = 6;
            this.HWorkCenterCol.Name = "HWorkCenterCol";
            // 
            // HPlannerGroupCol
            // 
            this.HPlannerGroupCol.HeaderText = "PLANNER GROUP";
            this.HPlannerGroupCol.MinimumWidth = 6;
            this.HPlannerGroupCol.Name = "HPlannerGroupCol";
            // 
            // HMaintStratergyCol
            // 
            this.HMaintStratergyCol.HeaderText = "MAINTENANCE STRATEGY";
            this.HMaintStratergyCol.MinimumWidth = 6;
            this.HMaintStratergyCol.Name = "HMaintStratergyCol";
            // 
            // HeaderInputsGB
            // 
            this.HeaderInputsGB.Controls.Add(this.HeaderInputsLayout);
            this.HeaderInputsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderInputsGB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderInputsGB.Location = new System.Drawing.Point(3, 3);
            this.HeaderInputsGB.Name = "HeaderInputsGB";
            this.HeaderInputsGB.Padding = new System.Windows.Forms.Padding(1);
            this.HeaderInputsGB.Size = new System.Drawing.Size(1126, 98);
            this.HeaderInputsGB.TabIndex = 1;
            this.HeaderInputsGB.TabStop = false;
            this.HeaderInputsGB.Text = "TASKLIST INFORMATION";
            // 
            // HeaderInputsLayout
            // 
            this.HeaderInputsLayout.ColumnCount = 6;
            this.HeaderInputsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.HeaderInputsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.HeaderInputsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.HeaderInputsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.HeaderInputsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.HeaderInputsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 303F));
            this.HeaderInputsLayout.Controls.Add(this.TasklistGroupLBL, 0, 0);
            this.HeaderInputsLayout.Controls.Add(this.TasklistGroupTB, 1, 0);
            this.HeaderInputsLayout.Controls.Add(this.TasklistCounterLBL, 2, 0);
            this.HeaderInputsLayout.Controls.Add(this.TasklistCounterTB, 3, 0);
            this.HeaderInputsLayout.Controls.Add(this.TemplateEquipmentLBL, 4, 0);
            this.HeaderInputsLayout.Controls.Add(this.TemplateEquipmentTB, 5, 0);
            this.HeaderInputsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderInputsLayout.Location = new System.Drawing.Point(1, 21);
            this.HeaderInputsLayout.Margin = new System.Windows.Forms.Padding(1);
            this.HeaderInputsLayout.Name = "HeaderInputsLayout";
            this.HeaderInputsLayout.RowCount = 1;
            this.HeaderInputsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderInputsLayout.Size = new System.Drawing.Size(1124, 76);
            this.HeaderInputsLayout.TabIndex = 0;
            // 
            // TasklistGroupLBL
            // 
            this.TasklistGroupLBL.AutoSize = true;
            this.TasklistGroupLBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasklistGroupLBL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TasklistGroupLBL.Location = new System.Drawing.Point(3, 0);
            this.TasklistGroupLBL.Name = "TasklistGroupLBL";
            this.TasklistGroupLBL.Size = new System.Drawing.Size(135, 76);
            this.TasklistGroupLBL.TabIndex = 0;
            this.TasklistGroupLBL.Text = "TASKLIST GROUP:";
            this.TasklistGroupLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TasklistGroupTB
            // 
            this.TasklistGroupTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TasklistGroupTB.Location = new System.Drawing.Point(144, 24);
            this.TasklistGroupTB.Name = "TasklistGroupTB";
            this.TasklistGroupTB.Size = new System.Drawing.Size(125, 27);
            this.TasklistGroupTB.TabIndex = 1;
            // 
            // TasklistCounterLBL
            // 
            this.TasklistCounterLBL.AutoSize = true;
            this.TasklistCounterLBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasklistCounterLBL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TasklistCounterLBL.Location = new System.Drawing.Point(281, 0);
            this.TasklistCounterLBL.Name = "TasklistCounterLBL";
            this.TasklistCounterLBL.Size = new System.Drawing.Size(165, 76);
            this.TasklistCounterLBL.TabIndex = 2;
            this.TasklistCounterLBL.Text = "TASKLIST COUNTER:";
            this.TasklistCounterLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TasklistCounterTB
            // 
            this.TasklistCounterTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TasklistCounterTB.Location = new System.Drawing.Point(452, 24);
            this.TasklistCounterTB.Name = "TasklistCounterTB";
            this.TasklistCounterTB.Size = new System.Drawing.Size(125, 27);
            this.TasklistCounterTB.TabIndex = 3;
            // 
            // TemplateEquipmentLBL
            // 
            this.TemplateEquipmentLBL.AutoSize = true;
            this.TemplateEquipmentLBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemplateEquipmentLBL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TemplateEquipmentLBL.Location = new System.Drawing.Point(613, 0);
            this.TemplateEquipmentLBL.Name = "TemplateEquipmentLBL";
            this.TemplateEquipmentLBL.Size = new System.Drawing.Size(205, 76);
            this.TemplateEquipmentLBL.TabIndex = 4;
            this.TemplateEquipmentLBL.Text = "TEMPLATE EQUIPMENT NUMBER:";
            this.TemplateEquipmentLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TemplateEquipmentTB
            // 
            this.TemplateEquipmentTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TemplateEquipmentTB.Location = new System.Drawing.Point(824, 24);
            this.TemplateEquipmentTB.Name = "TemplateEquipmentTB";
            this.TemplateEquipmentTB.Size = new System.Drawing.Size(189, 27);
            this.TemplateEquipmentTB.TabIndex = 5;
            // 
            // BodyTab
            // 
            this.BodyTab.Controls.Add(this.DGVBody);
            this.BodyTab.Location = new System.Drawing.Point(4, 29);
            this.BodyTab.Name = "BodyTab";
            this.BodyTab.Padding = new System.Windows.Forms.Padding(3);
            this.BodyTab.Size = new System.Drawing.Size(1138, 948);
            this.BodyTab.TabIndex = 1;
            this.BodyTab.Text = "TASKLIST BODY";
            this.BodyTab.UseVisualStyleBackColor = true;
            // 
            // DGVBody
            // 
            this.DGVBody.AllowUserToAddRows = false;
            this.DGVBody.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBody.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBody.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BOperationNumberCol,
            this.BSubOperationNumber,
            this.BOperationDescriptionCol,
            this.BLongTextCol,
            this.BTotalWorkCol,
            this.BUnitCol,
            this.BTechniciansCol,
            this.BMeasurementsCol});
            this.DGVBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVBody.Location = new System.Drawing.Point(3, 3);
            this.DGVBody.Name = "DGVBody";
            this.DGVBody.RowHeadersWidth = 51;
            this.DGVBody.RowTemplate.Height = 29;
            this.DGVBody.Size = new System.Drawing.Size(1132, 942);
            this.DGVBody.TabIndex = 0;
            // 
            // BOperationNumberCol
            // 
            this.BOperationNumberCol.FillWeight = 10F;
            this.BOperationNumberCol.HeaderText = "OPERATION";
            this.BOperationNumberCol.MinimumWidth = 6;
            this.BOperationNumberCol.Name = "BOperationNumberCol";
            // 
            // BSubOperationNumber
            // 
            this.BSubOperationNumber.FillWeight = 10F;
            this.BSubOperationNumber.HeaderText = "SUB-OPERATION";
            this.BSubOperationNumber.MinimumWidth = 6;
            this.BSubOperationNumber.Name = "BSubOperationNumber";
            // 
            // BOperationDescriptionCol
            // 
            this.BOperationDescriptionCol.FillWeight = 15F;
            this.BOperationDescriptionCol.HeaderText = "OPERATION DESCRIPTION";
            this.BOperationDescriptionCol.MinimumWidth = 6;
            this.BOperationDescriptionCol.Name = "BOperationDescriptionCol";
            // 
            // BLongTextCol
            // 
            this.BLongTextCol.FillWeight = 30F;
            this.BLongTextCol.HeaderText = "LONG TEXT";
            this.BLongTextCol.MinimumWidth = 6;
            this.BLongTextCol.Name = "BLongTextCol";
            // 
            // BTotalWorkCol
            // 
            this.BTotalWorkCol.FillWeight = 5F;
            this.BTotalWorkCol.HeaderText = "WORK";
            this.BTotalWorkCol.MinimumWidth = 6;
            this.BTotalWorkCol.Name = "BTotalWorkCol";
            this.BTotalWorkCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BTotalWorkCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BUnitCol
            // 
            this.BUnitCol.FillWeight = 5F;
            this.BUnitCol.HeaderText = "UNIT";
            this.BUnitCol.MinimumWidth = 6;
            this.BUnitCol.Name = "BUnitCol";
            this.BUnitCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BUnitCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BTechniciansCol
            // 
            this.BTechniciansCol.FillWeight = 5F;
            this.BTechniciansCol.HeaderText = "PEOPLE";
            this.BTechniciansCol.MinimumWidth = 6;
            this.BTechniciansCol.Name = "BTechniciansCol";
            // 
            // BMeasurementsCol
            // 
            this.BMeasurementsCol.FillWeight = 15F;
            this.BMeasurementsCol.HeaderText = "MEASUREMENT POINTS";
            this.BMeasurementsCol.MinimumWidth = 6;
            this.BMeasurementsCol.Name = "BMeasurementsCol";
            // 
            // ComponentsTab
            // 
            this.ComponentsTab.Location = new System.Drawing.Point(4, 29);
            this.ComponentsTab.Name = "ComponentsTab";
            this.ComponentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ComponentsTab.Size = new System.Drawing.Size(1138, 948);
            this.ComponentsTab.TabIndex = 2;
            this.ComponentsTab.Text = "TASKLIST COMPONENTS";
            this.ComponentsTab.UseVisualStyleBackColor = true;
            // 
            // PRTTab
            // 
            this.PRTTab.Location = new System.Drawing.Point(4, 29);
            this.PRTTab.Name = "PRTTab";
            this.PRTTab.Padding = new System.Windows.Forms.Padding(3);
            this.PRTTab.Size = new System.Drawing.Size(1138, 948);
            this.PRTTab.TabIndex = 3;
            this.PRTTab.Text = "DOCUMENT ATTACHMENTS (PRTs)";
            this.PRTTab.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 1087);
            this.Controls.Add(this.MainSplitLayout);
            this.Controls.Add(this.MainStatus);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.MainMenu;
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
            this.HeaderInputsGB.ResumeLayout(false);
            this.HeaderInputsLayout.ResumeLayout(false);
            this.HeaderInputsLayout.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem importFromSapToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel HeaderTabLayout;
        private System.Windows.Forms.TabPage ComponentsTab;
        private System.Windows.Forms.TabPage PRTTab;
        private System.Windows.Forms.ToolStripMenuItem importMEasToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel MeasurementsLayout;
        private System.Windows.Forms.GroupBox MeasPointDetailGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label MPDescLabel;
        private System.Windows.Forms.Label MPPositionLabel;
        private System.Windows.Forms.Label MPCharNameLabel;
        private System.Windows.Forms.Label MPDecimalPlaceLabel;
        private System.Windows.Forms.Label MPCodeGroupLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem exportToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelEditableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelSAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelEditableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excelSAPDataFileToolStripMenuItem;
        public SAP_Task_List_Maker.MyTree MeasPointsTree;
        public Tasklist DGVHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn HGroupCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HCounterCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDescriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HPlanningPlantCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HWorkCenterCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HPlannerGroupCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HMaintStratergyCol;
        private System.Windows.Forms.GroupBox HeaderInputsGB;
        private System.Windows.Forms.TableLayoutPanel HeaderInputsLayout;
        private System.Windows.Forms.Label TasklistGroupLBL;
        private System.Windows.Forms.TextBox TasklistGroupTB;
        private System.Windows.Forms.Label TasklistCounterLBL;
        private System.Windows.Forms.TextBox TasklistCounterTB;
        private System.Windows.Forms.Label TemplateEquipmentLBL;
        private System.Windows.Forms.TextBox TemplateEquipmentTB;
        public System.Windows.Forms.TextBox MPPositionTextBox;
        public System.Windows.Forms.TextBox MPDescriptionTextBox;
        public System.Windows.Forms.ComboBox MPCharNameComboBox;
        public System.Windows.Forms.TextBox MPDecimalTextBox;
        public System.Windows.Forms.ComboBox MPCodeGroupComboBox;
        public System.Windows.Forms.TextBox MPLowerLimitTextBox;
        public System.Windows.Forms.TextBox MPUpperLimitTextBox;
        public System.Windows.Forms.TextBox MPTargetValueTextBox;
        public System.Windows.Forms.TextBox MPTargetTextTextBox;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.Button MeasUpdateButton;
        public Tasklist DGVBody;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOperationNumberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BSubOperationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOperationDescriptionCol;
        private LongTextColumn BLongTextCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BTotalWorkCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUnitCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BTechniciansCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BMeasurementsCol;
    }
}
