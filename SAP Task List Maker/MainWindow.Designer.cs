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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("EQUIPMENT NOT LOADED");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.FindMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplaceMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportCELMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.tasklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tasklistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tasklistToFilesxlsxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewProjectTSBTN = new System.Windows.Forms.ToolStripButton();
            this.OpenTSBTN = new System.Windows.Forms.ToolStripButton();
            this.SaveTSBTN = new System.Windows.Forms.ToolStripButton();
            this.UGLLogoLBL = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ImportExcelTSBTN = new System.Windows.Forms.ToolStripButton();
            this.ExportExcelTSBTN = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ImportEQBTN = new System.Windows.Forms.ToolStripButton();
            this.ImportCELBTN = new System.Windows.Forms.ToolStripButton();
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
            this.MeasPointsTree = new SAP_Task_List_Maker.MeasureTree();
            this.DataTabs = new System.Windows.Forms.TabControl();
            this.HeaderTab = new System.Windows.Forms.TabPage();
            this.DGVHeader = new SAP_Task_List_Maker.Tasklist();
            this.HGroupCol = new SAP_Task_List_Maker.TasklistColumn();
            this.HCounterCol = new SAP_Task_List_Maker.TasklistColumn();
            this.HDescriptionCol = new SAP_Task_List_Maker.TasklistColumn();
            this.HPlanningPlantCol = new SAP_Task_List_Maker.TasklistColumn();
            this.HWorkCenterCol = new SAP_Task_List_Maker.TasklistColumn();
            this.HPlannerGroupCol = new SAP_Task_List_Maker.TasklistColumn();
            this.HMaintStratergyCol = new SAP_Task_List_Maker.TasklistColumn();
            this.BodyTab = new System.Windows.Forms.TabPage();
            this.DGVBody = new SAP_Task_List_Maker.Tasklist();
            this.BOperationNumberCol = new SAP_Task_List_Maker.MeaspointCol();
            this.BSubOperationNumber = new SAP_Task_List_Maker.TasklistColumn();
            this.BOperationDescriptionCol = new SAP_Task_List_Maker.TasklistColumn();
            this.BLongTextCol = new SAP_Task_List_Maker.TasklistLongTextColumn();
            this.BTotalWorkCol = new SAP_Task_List_Maker.TasklistColumn();
            this.BUnitCol = new SAP_Task_List_Maker.TasklistColumn();
            this.BTechniciansCol = new SAP_Task_List_Maker.TasklistColumn();
            this.BMeasurementsCol = new SAP_Task_List_Maker.MeaspointCol();
            this.ComponentsTab = new System.Windows.Forms.TabPage();
            this.DGVComponents = new SAP_Task_List_Maker.Tasklist();
            this.CMatNumberCol = new SAP_Task_List_Maker.TasklistColumn();
            this.CMatDescCol = new SAP_Task_List_Maker.TasklistColumn();
            this.CMatQuantityCol = new SAP_Task_List_Maker.TasklistColumn();
            this.CUnitCol = new SAP_Task_List_Maker.TasklistLongTextColumn();
            this.PRTTab = new System.Windows.Forms.TabPage();
            this.DGVPRT = new SAP_Task_List_Maker.Tasklist();
            this.DocOperationCol = new SAP_Task_List_Maker.TasklistColumn();
            this.DocNumberCol = new SAP_Task_List_Maker.TasklistColumn();
            this.DocDescriptionCol = new SAP_Task_List_Maker.TasklistColumn();
            this.CELTab = new System.Windows.Forms.TabPage();
            this.DGVCEL = new SAP_Task_List_Maker.Tasklist();
            this.CMeasPositionCol = new SAP_Task_List_Maker.TasklistColumn();
            this.CMeasDescCol = new SAP_Task_List_Maker.TasklistColumn();
            this.CSortOrderCol = new SAP_Task_List_Maker.TasklistColumn();
            this.MainMenu.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.DGVHeader)).BeginInit();
            this.BodyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBody)).BeginInit();
            this.ComponentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVComponents)).BeginInit();
            this.PRTTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPRT)).BeginInit();
            this.CELTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCEL)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.ImportMenu,
            this.ExportMenu,
            this.ControlMenu});
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
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoMenuBtn,
            this.RedoMenuBtn,
            this.FindMenuBtn,
            this.ReplaceMenuBtn});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // UndoMenuBtn
            // 
            this.UndoMenuBtn.Name = "UndoMenuBtn";
            this.UndoMenuBtn.Size = new System.Drawing.Size(184, 26);
            this.UndoMenuBtn.Text = "Undo (Ctrl+Z)";
            // 
            // RedoMenuBtn
            // 
            this.RedoMenuBtn.Name = "RedoMenuBtn";
            this.RedoMenuBtn.Size = new System.Drawing.Size(184, 26);
            this.RedoMenuBtn.Text = "Redo (Ctrl+Y)";
            // 
            // FindMenuBtn
            // 
            this.FindMenuBtn.Name = "FindMenuBtn";
            this.FindMenuBtn.Size = new System.Drawing.Size(184, 26);
            this.FindMenuBtn.Text = "Find";
            // 
            // ReplaceMenuBtn
            // 
            this.ReplaceMenuBtn.Name = "ReplaceMenuBtn";
            this.ReplaceMenuBtn.Size = new System.Drawing.Size(184, 26);
            this.ReplaceMenuBtn.Text = "Replace";
            // 
            // ImportMenu
            // 
            this.ImportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportCELMenuBtn,
            this.tasklistToolStripMenuItem});
            this.ImportMenu.Name = "ImportMenu";
            this.ImportMenu.Size = new System.Drawing.Size(68, 24);
            this.ImportMenu.Text = "Import";
            // 
            // ImportCELMenuBtn
            // 
            this.ImportCELMenuBtn.Name = "ImportCELMenuBtn";
            this.ImportCELMenuBtn.Size = new System.Drawing.Size(138, 26);
            this.ImportCELMenuBtn.Text = "CEL";
            this.ImportCELMenuBtn.Click += new System.EventHandler(this.ImportCELMenuBtn_Click);
            // 
            // tasklistToolStripMenuItem
            // 
            this.tasklistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromFilesToolStripMenuItem,
            this.fromSAPToolStripMenuItem});
            this.tasklistToolStripMenuItem.Name = "tasklistToolStripMenuItem";
            this.tasklistToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.tasklistToolStripMenuItem.Text = "Tasklist";
            // 
            // fromFilesToolStripMenuItem
            // 
            this.fromFilesToolStripMenuItem.Name = "fromFilesToolStripMenuItem";
            this.fromFilesToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.fromFilesToolStripMenuItem.Text = "From files";
            // 
            // fromSAPToolStripMenuItem
            // 
            this.fromSAPToolStripMenuItem.Name = "fromSAPToolStripMenuItem";
            this.fromSAPToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.fromSAPToolStripMenuItem.Text = "From SAP";
            // 
            // ExportMenu
            // 
            this.ExportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasklistToolStripMenuItem1,
            this.tasklistToFilesxlsxToolStripMenuItem});
            this.ExportMenu.Name = "ExportMenu";
            this.ExportMenu.Size = new System.Drawing.Size(66, 24);
            this.ExportMenu.Text = "Export";
            // 
            // tasklistToolStripMenuItem1
            // 
            this.tasklistToolStripMenuItem1.Name = "tasklistToolStripMenuItem1";
            this.tasklistToolStripMenuItem1.Size = new System.Drawing.Size(232, 26);
            this.tasklistToolStripMenuItem1.Text = "Tasklist To SAP";
            // 
            // tasklistToFilesxlsxToolStripMenuItem
            // 
            this.tasklistToFilesxlsxToolStripMenuItem.Name = "tasklistToFilesxlsxToolStripMenuItem";
            this.tasklistToFilesxlsxToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.tasklistToFilesxlsxToolStripMenuItem.Text = "Tasklist To Files (.xlsx)";
            // 
            // ControlMenu
            // 
            this.ControlMenu.Name = "ControlMenu";
            this.ControlMenu.Size = new System.Drawing.Size(72, 24);
            this.ControlMenu.Text = "Control";
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewProjectTSBTN,
            this.OpenTSBTN,
            this.SaveTSBTN,
            this.UGLLogoLBL,
            this.toolStripSeparator1,
            this.ImportExcelTSBTN,
            this.ExportExcelTSBTN,
            this.toolStripSeparator2,
            this.ImportEQBTN,
            this.ImportCELBTN});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 26);
            this.MainToolStrip.MinimumSize = new System.Drawing.Size(0, 80);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(1583, 80);
            this.MainToolStrip.TabIndex = 2;
            this.MainToolStrip.Text = "Tool Strip";
            // 
            // NewProjectTSBTN
            // 
            this.NewProjectTSBTN.Image = ((System.Drawing.Image)(resources.GetObject("NewProjectTSBTN.Image")));
            this.NewProjectTSBTN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewProjectTSBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewProjectTSBTN.Name = "NewProjectTSBTN";
            this.NewProjectTSBTN.Size = new System.Drawing.Size(49, 77);
            this.NewProjectTSBTN.Text = "New";
            this.NewProjectTSBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewProjectTSBTN.ToolTipText = "Start New Project";
            this.NewProjectTSBTN.Click += new System.EventHandler(this.NewProjectTSBTN_Click);
            // 
            // OpenTSBTN
            // 
            this.OpenTSBTN.Image = ((System.Drawing.Image)(resources.GetObject("OpenTSBTN.Image")));
            this.OpenTSBTN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OpenTSBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenTSBTN.Name = "OpenTSBTN";
            this.OpenTSBTN.Size = new System.Drawing.Size(49, 77);
            this.OpenTSBTN.Text = "Open";
            this.OpenTSBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenTSBTN.ToolTipText = "Open Tasklist Maker File (*.tmf)";
            // 
            // SaveTSBTN
            // 
            this.SaveTSBTN.Image = ((System.Drawing.Image)(resources.GetObject("SaveTSBTN.Image")));
            this.SaveTSBTN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SaveTSBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveTSBTN.Name = "SaveTSBTN";
            this.SaveTSBTN.Size = new System.Drawing.Size(49, 77);
            this.SaveTSBTN.Text = "Save";
            this.SaveTSBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SaveTSBTN.ToolTipText = "Save Tasklist Maker File (*.tmf)";
            this.SaveTSBTN.Click += new System.EventHandler(this.SaveTSBTN_Click);
            // 
            // UGLLogoLBL
            // 
            this.UGLLogoLBL.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UGLLogoLBL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UGLLogoLBL.Image = ((System.Drawing.Image)(resources.GetObject("UGLLogoLBL.Image")));
            this.UGLLogoLBL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UGLLogoLBL.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.UGLLogoLBL.Name = "UGLLogoLBL";
            this.UGLLogoLBL.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.UGLLogoLBL.Size = new System.Drawing.Size(234, 80);
            this.UGLLogoLBL.Text = "toolStripLabel1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 80);
            // 
            // ImportExcelTSBTN
            // 
            this.ImportExcelTSBTN.Image = ((System.Drawing.Image)(resources.GetObject("ImportExcelTSBTN.Image")));
            this.ImportExcelTSBTN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ImportExcelTSBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImportExcelTSBTN.Name = "ImportExcelTSBTN";
            this.ImportExcelTSBTN.Size = new System.Drawing.Size(58, 77);
            this.ImportExcelTSBTN.Text = "Import";
            this.ImportExcelTSBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ImportExcelTSBTN.ToolTipText = "Import from Excel Files (*.xlsx)";
            this.ImportExcelTSBTN.Click += new System.EventHandler(this.ImportExcelTSBTN_Click);
            // 
            // ExportExcelTSBTN
            // 
            this.ExportExcelTSBTN.Image = ((System.Drawing.Image)(resources.GetObject("ExportExcelTSBTN.Image")));
            this.ExportExcelTSBTN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ExportExcelTSBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportExcelTSBTN.Name = "ExportExcelTSBTN";
            this.ExportExcelTSBTN.Size = new System.Drawing.Size(57, 77);
            this.ExportExcelTSBTN.Text = "Export";
            this.ExportExcelTSBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExportExcelTSBTN.ToolTipText = "Export to Excel Files (*.xlsx)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 80);
            // 
            // ImportEQBTN
            // 
            this.ImportEQBTN.Image = ((System.Drawing.Image)(resources.GetObject("ImportEQBTN.Image")));
            this.ImportEQBTN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ImportEQBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImportEQBTN.Name = "ImportEQBTN";
            this.ImportEQBTN.Size = new System.Drawing.Size(56, 77);
            this.ImportEQBTN.Text = "Export";
            this.ImportEQBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ImportEQBTN.ToolTipText = "Import Equipment";
            this.ImportEQBTN.Click += new System.EventHandler(this.ImportEqBTN_Click);
            // 
            // ImportCELBTN
            // 
            this.ImportCELBTN.Image = ((System.Drawing.Image)(resources.GetObject("ImportCELBTN.Image")));
            this.ImportCELBTN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ImportCELBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImportCELBTN.Name = "ImportCELBTN";
            this.ImportCELBTN.Size = new System.Drawing.Size(56, 77);
            this.ImportCELBTN.Text = "Export";
            this.ImportCELBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ImportCELBTN.ToolTipText = "Import CEL";
            this.ImportCELBTN.Click += new System.EventHandler(this.ImportCELBtn_Click_1);
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
            this.MainSplitLayout.Location = new System.Drawing.Point(0, 106);
            this.MainSplitLayout.Name = "MainSplitLayout";
            // 
            // MainSplitLayout.Panel1
            // 
            this.MainSplitLayout.Panel1.Controls.Add(this.MeasurementsLayout);
            // 
            // MainSplitLayout.Panel2
            // 
            this.MainSplitLayout.Panel2.Controls.Add(this.DataTabs);
            this.MainSplitLayout.Size = new System.Drawing.Size(1583, 951);
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
            this.MeasurementsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.09779F));
            this.MeasurementsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.90221F));
            this.MeasurementsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MeasurementsLayout.Size = new System.Drawing.Size(433, 951);
            this.MeasurementsLayout.TabIndex = 1;
            // 
            // MeasPointDetailGroupBox
            // 
            this.MeasPointDetailGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.MeasPointDetailGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasPointDetailGroupBox.Location = new System.Drawing.Point(1, 544);
            this.MeasPointDetailGroupBox.Margin = new System.Windows.Forms.Padding(1);
            this.MeasPointDetailGroupBox.Name = "MeasPointDetailGroupBox";
            this.MeasPointDetailGroupBox.Size = new System.Drawing.Size(431, 406);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(425, 380);
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
            this.tableLayoutPanel1.SetColumnSpan(this.MeasUpdateButton, 2);
            this.MeasUpdateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasUpdateButton.Location = new System.Drawing.Point(3, 332);
            this.MeasUpdateButton.Name = "MeasUpdateButton";
            this.MeasUpdateButton.Size = new System.Drawing.Size(419, 45);
            this.MeasUpdateButton.TabIndex = 13;
            this.MeasUpdateButton.Text = "Update Selected";
            this.MeasUpdateButton.UseVisualStyleBackColor = true;
            this.MeasUpdateButton.Click += new System.EventHandler(this.MeasUpdateButton_Click);
            // 
            // MeasPointsTree
            // 
            this.MeasPointsTree.AllowDrop = true;
            this.MeasPointsTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MeasPointsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasPointsTree.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.MeasPointsTree.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MeasPointsTree.Location = new System.Drawing.Point(3, 3);
            this.MeasPointsTree.Name = "MeasPointsTree";
            treeNode1.Name = "ExistingMeasRoot";
            treeNode1.NodeFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode1.Text = "EQUIPMENT NOT LOADED";
            this.MeasPointsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.MeasPointsTree.Size = new System.Drawing.Size(427, 537);
            this.MeasPointsTree.TabIndex = 2;
            this.MeasPointsTree.Leave += new System.EventHandler(this.MeasureTree_Leave);
            // 
            // DataTabs
            // 
            this.DataTabs.Controls.Add(this.HeaderTab);
            this.DataTabs.Controls.Add(this.BodyTab);
            this.DataTabs.Controls.Add(this.ComponentsTab);
            this.DataTabs.Controls.Add(this.PRTTab);
            this.DataTabs.Controls.Add(this.CELTab);
            this.DataTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTabs.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataTabs.Location = new System.Drawing.Point(0, 0);
            this.DataTabs.Margin = new System.Windows.Forms.Padding(0);
            this.DataTabs.Name = "DataTabs";
            this.DataTabs.SelectedIndex = 0;
            this.DataTabs.Size = new System.Drawing.Size(1146, 951);
            this.DataTabs.TabIndex = 0;
            // 
            // HeaderTab
            // 
            this.HeaderTab.Controls.Add(this.DGVHeader);
            this.HeaderTab.Location = new System.Drawing.Point(4, 27);
            this.HeaderTab.Name = "HeaderTab";
            this.HeaderTab.Padding = new System.Windows.Forms.Padding(3);
            this.HeaderTab.Size = new System.Drawing.Size(1138, 920);
            this.HeaderTab.TabIndex = 0;
            this.HeaderTab.Text = "HEADER";
            this.HeaderTab.UseVisualStyleBackColor = true;
            // 
            // DGVHeader
            // 
            this.DGVHeader.AllowDrop = true;
            this.DGVHeader.AllowUserToAddRows = false;
            this.DGVHeader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVHeader.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVHeader.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HGroupCol,
            this.HCounterCol,
            this.HDescriptionCol,
            this.HPlanningPlantCol,
            this.HWorkCenterCol,
            this.HPlannerGroupCol,
            this.HMaintStratergyCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVHeader.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVHeader.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVHeader.GridColor = System.Drawing.Color.LightGray;
            this.DGVHeader.Location = new System.Drawing.Point(3, 3);
            this.DGVHeader.Name = "DGVHeader";
            this.DGVHeader.RowHeadersVisible = false;
            this.DGVHeader.RowHeadersWidth = 51;
            this.DGVHeader.RowTemplate.Height = 29;
            this.DGVHeader.Size = new System.Drawing.Size(1132, 914);
            this.DGVHeader.TabIndex = 0;
            // 
            // HGroupCol
            // 
            this.HGroupCol.HeaderText = "TASKLIST GROUP";
            this.HGroupCol.MinimumWidth = 6;
            this.HGroupCol.Name = "HGroupCol";
            this.HGroupCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HGroupCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HCounterCol
            // 
            this.HCounterCol.HeaderText = "TASKLIST COUNTER";
            this.HCounterCol.MinimumWidth = 6;
            this.HCounterCol.Name = "HCounterCol";
            this.HCounterCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HCounterCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HDescriptionCol
            // 
            this.HDescriptionCol.HeaderText = "TASKLIST DESCRIPTION";
            this.HDescriptionCol.MinimumWidth = 6;
            this.HDescriptionCol.Name = "HDescriptionCol";
            this.HDescriptionCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HDescriptionCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HPlanningPlantCol
            // 
            this.HPlanningPlantCol.HeaderText = "PLANNING PLANT";
            this.HPlanningPlantCol.MinimumWidth = 6;
            this.HPlanningPlantCol.Name = "HPlanningPlantCol";
            this.HPlanningPlantCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HPlanningPlantCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HWorkCenterCol
            // 
            this.HWorkCenterCol.HeaderText = "WORK CENTER";
            this.HWorkCenterCol.MinimumWidth = 6;
            this.HWorkCenterCol.Name = "HWorkCenterCol";
            this.HWorkCenterCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HWorkCenterCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HPlannerGroupCol
            // 
            this.HPlannerGroupCol.HeaderText = "PLANNER GROUP";
            this.HPlannerGroupCol.MinimumWidth = 6;
            this.HPlannerGroupCol.Name = "HPlannerGroupCol";
            this.HPlannerGroupCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HPlannerGroupCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HMaintStratergyCol
            // 
            this.HMaintStratergyCol.HeaderText = "MAINTENANCE STRATEGY";
            this.HMaintStratergyCol.MinimumWidth = 6;
            this.HMaintStratergyCol.Name = "HMaintStratergyCol";
            this.HMaintStratergyCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HMaintStratergyCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BodyTab
            // 
            this.BodyTab.Controls.Add(this.DGVBody);
            this.BodyTab.Location = new System.Drawing.Point(4, 27);
            this.BodyTab.Name = "BodyTab";
            this.BodyTab.Padding = new System.Windows.Forms.Padding(3);
            this.BodyTab.Size = new System.Drawing.Size(1138, 920);
            this.BodyTab.TabIndex = 1;
            this.BodyTab.Text = "BODY";
            this.BodyTab.UseVisualStyleBackColor = true;
            // 
            // DGVBody
            // 
            this.DGVBody.AllowDrop = true;
            this.DGVBody.AllowUserToAddRows = false;
            this.DGVBody.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBody.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBody.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBody.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVBody.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVBody.Location = new System.Drawing.Point(3, 3);
            this.DGVBody.Name = "DGVBody";
            this.DGVBody.RowHeadersWidth = 51;
            this.DGVBody.RowTemplate.Height = 29;
            this.DGVBody.Size = new System.Drawing.Size(1132, 914);
            this.DGVBody.TabIndex = 0;
            this.DGVBody.DragDrop += new System.Windows.Forms.DragEventHandler(this.DGVBody_DragDrop);
            this.DGVBody.DragEnter += new System.Windows.Forms.DragEventHandler(this.DGVBody_DragEnter);
            this.DGVBody.DragOver += new System.Windows.Forms.DragEventHandler(this.DGVBody_DragOver);
            // 
            // BOperationNumberCol
            // 
            this.BOperationNumberCol.FillWeight = 10F;
            this.BOperationNumberCol.HeaderText = "OPERATION";
            this.BOperationNumberCol.MinimumWidth = 6;
            this.BOperationNumberCol.Name = "BOperationNumberCol";
            this.BOperationNumberCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BOperationNumberCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BSubOperationNumber
            // 
            this.BSubOperationNumber.FillWeight = 10F;
            this.BSubOperationNumber.HeaderText = "SUB-OPERATION";
            this.BSubOperationNumber.MinimumWidth = 6;
            this.BSubOperationNumber.Name = "BSubOperationNumber";
            this.BSubOperationNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BSubOperationNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BOperationDescriptionCol
            // 
            this.BOperationDescriptionCol.FillWeight = 15F;
            this.BOperationDescriptionCol.HeaderText = "OPERATION DESCRIPTION";
            this.BOperationDescriptionCol.MinimumWidth = 6;
            this.BOperationDescriptionCol.Name = "BOperationDescriptionCol";
            this.BOperationDescriptionCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BOperationDescriptionCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // 
            // BUnitCol
            // 
            this.BUnitCol.FillWeight = 5F;
            this.BUnitCol.HeaderText = "UNIT";
            this.BUnitCol.MinimumWidth = 6;
            this.BUnitCol.Name = "BUnitCol";
            this.BUnitCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BTechniciansCol
            // 
            this.BTechniciansCol.FillWeight = 5F;
            this.BTechniciansCol.HeaderText = "PEOPLE";
            this.BTechniciansCol.MinimumWidth = 6;
            this.BTechniciansCol.Name = "BTechniciansCol";
            this.BTechniciansCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BTechniciansCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BMeasurementsCol
            // 
            this.BMeasurementsCol.FillWeight = 15F;
            this.BMeasurementsCol.HeaderText = "MEASUREMENT POINTS";
            this.BMeasurementsCol.MinimumWidth = 6;
            this.BMeasurementsCol.Name = "BMeasurementsCol";
            this.BMeasurementsCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BMeasurementsCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ComponentsTab
            // 
            this.ComponentsTab.Controls.Add(this.DGVComponents);
            this.ComponentsTab.Location = new System.Drawing.Point(4, 27);
            this.ComponentsTab.Name = "ComponentsTab";
            this.ComponentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ComponentsTab.Size = new System.Drawing.Size(1138, 920);
            this.ComponentsTab.TabIndex = 2;
            this.ComponentsTab.Text = "COMPONENTS";
            this.ComponentsTab.UseVisualStyleBackColor = true;
            // 
            // DGVComponents
            // 
            this.DGVComponents.AllowDrop = true;
            this.DGVComponents.AllowUserToAddRows = false;
            this.DGVComponents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVComponents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVComponents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVComponents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVComponents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CMatNumberCol,
            this.CMatDescCol,
            this.CMatQuantityCol,
            this.CUnitCol});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVComponents.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVComponents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVComponents.Location = new System.Drawing.Point(3, 3);
            this.DGVComponents.Name = "DGVComponents";
            this.DGVComponents.RowHeadersWidth = 51;
            this.DGVComponents.RowTemplate.Height = 29;
            this.DGVComponents.Size = new System.Drawing.Size(1132, 914);
            this.DGVComponents.TabIndex = 1;
            // 
            // CMatNumberCol
            // 
            this.CMatNumberCol.FillWeight = 40F;
            this.CMatNumberCol.HeaderText = "MATERIAL NUMBER";
            this.CMatNumberCol.MinimumWidth = 6;
            this.CMatNumberCol.Name = "CMatNumberCol";
            this.CMatNumberCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CMatNumberCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CMatDescCol
            // 
            this.CMatDescCol.FillWeight = 40F;
            this.CMatDescCol.HeaderText = "MATERIAL DESCRIPTION";
            this.CMatDescCol.MinimumWidth = 6;
            this.CMatDescCol.Name = "CMatDescCol";
            this.CMatDescCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CMatDescCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CMatQuantityCol
            // 
            this.CMatQuantityCol.FillWeight = 10F;
            this.CMatQuantityCol.HeaderText = "MATERIAL QUANTITY";
            this.CMatQuantityCol.MinimumWidth = 6;
            this.CMatQuantityCol.Name = "CMatQuantityCol";
            this.CMatQuantityCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CMatQuantityCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CUnitCol
            // 
            this.CUnitCol.FillWeight = 10F;
            this.CUnitCol.HeaderText = "UNIT";
            this.CUnitCol.MinimumWidth = 6;
            this.CUnitCol.Name = "CUnitCol";
            // 
            // PRTTab
            // 
            this.PRTTab.Controls.Add(this.DGVPRT);
            this.PRTTab.Location = new System.Drawing.Point(4, 27);
            this.PRTTab.Name = "PRTTab";
            this.PRTTab.Padding = new System.Windows.Forms.Padding(3);
            this.PRTTab.Size = new System.Drawing.Size(1138, 920);
            this.PRTTab.TabIndex = 3;
            this.PRTTab.Text = "DOCUMENT ATTACHMENTS (PRTs)";
            this.PRTTab.UseVisualStyleBackColor = true;
            // 
            // DGVPRT
            // 
            this.DGVPRT.AllowDrop = true;
            this.DGVPRT.AllowUserToAddRows = false;
            this.DGVPRT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPRT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVPRT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPRT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVPRT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPRT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocOperationCol,
            this.DocNumberCol,
            this.DocDescriptionCol});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPRT.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGVPRT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPRT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVPRT.Location = new System.Drawing.Point(3, 3);
            this.DGVPRT.Name = "DGVPRT";
            this.DGVPRT.RowHeadersWidth = 51;
            this.DGVPRT.RowTemplate.Height = 29;
            this.DGVPRT.Size = new System.Drawing.Size(1132, 914);
            this.DGVPRT.TabIndex = 2;
            // 
            // DocOperationCol
            // 
            this.DocOperationCol.FillWeight = 20F;
            this.DocOperationCol.HeaderText = "DOCUMENT OPERATION";
            this.DocOperationCol.MinimumWidth = 6;
            this.DocOperationCol.Name = "DocOperationCol";
            this.DocOperationCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DocOperationCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DocNumberCol
            // 
            this.DocNumberCol.FillWeight = 40F;
            this.DocNumberCol.HeaderText = "DOCUMENT NUMBER";
            this.DocNumberCol.MinimumWidth = 6;
            this.DocNumberCol.Name = "DocNumberCol";
            this.DocNumberCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DocNumberCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DocDescriptionCol
            // 
            this.DocDescriptionCol.FillWeight = 40F;
            this.DocDescriptionCol.HeaderText = "DOCUMENT DESCRIPTION";
            this.DocDescriptionCol.MinimumWidth = 6;
            this.DocDescriptionCol.Name = "DocDescriptionCol";
            this.DocDescriptionCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DocDescriptionCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CELTab
            // 
            this.CELTab.Controls.Add(this.DGVCEL);
            this.CELTab.Location = new System.Drawing.Point(4, 27);
            this.CELTab.Name = "CELTab";
            this.CELTab.Padding = new System.Windows.Forms.Padding(3);
            this.CELTab.Size = new System.Drawing.Size(1138, 920);
            this.CELTab.TabIndex = 4;
            this.CELTab.Text = "CEL";
            this.CELTab.UseVisualStyleBackColor = true;
            // 
            // DGVCEL
            // 
            this.DGVCEL.AllowDrop = true;
            this.DGVCEL.AllowUserToAddRows = false;
            this.DGVCEL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCEL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVCEL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCEL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGVCEL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCEL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CMeasPositionCol,
            this.CMeasDescCol,
            this.CSortOrderCol});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCEL.DefaultCellStyle = dataGridViewCellStyle10;
            this.DGVCEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCEL.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVCEL.Location = new System.Drawing.Point(3, 3);
            this.DGVCEL.Name = "DGVCEL";
            this.DGVCEL.RowHeadersWidth = 51;
            this.DGVCEL.RowTemplate.Height = 29;
            this.DGVCEL.Size = new System.Drawing.Size(1132, 914);
            this.DGVCEL.TabIndex = 0;
            // 
            // CMeasPositionCol
            // 
            this.CMeasPositionCol.FillWeight = 40F;
            this.CMeasPositionCol.HeaderText = "MEASUREMENT POSITION";
            this.CMeasPositionCol.MinimumWidth = 6;
            this.CMeasPositionCol.Name = "CMeasPositionCol";
            this.CMeasPositionCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CMeasPositionCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CMeasDescCol
            // 
            this.CMeasDescCol.FillWeight = 40F;
            this.CMeasDescCol.HeaderText = "MEASUREMENT DESCRIPTION";
            this.CMeasDescCol.MinimumWidth = 6;
            this.CMeasDescCol.Name = "CMeasDescCol";
            this.CMeasDescCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CMeasDescCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CSortOrderCol
            // 
            this.CSortOrderCol.FillWeight = 20F;
            this.CSortOrderCol.HeaderText = "SORT ORDER";
            this.CSortOrderCol.MinimumWidth = 6;
            this.CSortOrderCol.Name = "CSortOrderCol";
            this.CSortOrderCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CSortOrderCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainWindow";
            this.Text = "SAP Tasklist Maker";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.DGVHeader)).EndInit();
            this.BodyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBody)).EndInit();
            this.ComponentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVComponents)).EndInit();
            this.PRTTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPRT)).EndInit();
            this.CELTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCEL)).EndInit();
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
        private System.Windows.Forms.TabPage ComponentsTab;
        private System.Windows.Forms.TabPage PRTTab;
        private System.Windows.Forms.TableLayoutPanel MeasurementsLayout;
        public SAP_Task_List_Maker.MeasureTree MeasPointsTree;
        public Tasklist DGVBody;
        private System.Windows.Forms.TabPage CELTab;
        public Tasklist DGVHeader;
        private System.Windows.Forms.ToolStripMenuItem ImportMenu;
        private System.Windows.Forms.ToolStripMenuItem ImportCELMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem ExportMenu;
        public Tasklist DGVCEL;
        private TasklistColumn HGroupCol;
        private TasklistColumn HCounterCol;
        private TasklistColumn HDescriptionCol;
        private TasklistColumn HPlanningPlantCol;
        private TasklistColumn HWorkCenterCol;
        private TasklistColumn HPlannerGroupCol;
        private TasklistColumn HMaintStratergyCol;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem RedoMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem FindMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem ReplaceMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem tasklistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromSAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasklistToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tasklistToFilesxlsxToolStripMenuItem;
        public Tasklist DGVComponents;
        private TasklistColumn CMatNumberCol;
        private TasklistColumn CMatDescCol;
        private TasklistColumn CMatQuantityCol;
        private TasklistLongTextColumn CUnitCol;
        public Tasklist DGVPRT;
        private TasklistColumn DocOperationCol;
        private TasklistColumn DocNumberCol;
        private TasklistColumn DocDescriptionCol;
        private MeaspointCol BOperationNumberCol;
        private TasklistColumn BSubOperationNumber;
        private TasklistColumn BOperationDescriptionCol;
        private TasklistLongTextColumn BLongTextCol;
        private TasklistColumn BTotalWorkCol;
        private TasklistColumn BUnitCol;
        private TasklistColumn BTechniciansCol;
        private MeaspointCol BMeasurementsCol;
        private TasklistColumn CMeasPositionCol;
        private TasklistColumn CMeasDescCol;
        private TasklistColumn CSortOrderCol;
        private System.Windows.Forms.ToolStripButton SaveTSBTN;
        private System.Windows.Forms.ToolStripLabel UGLLogoLBL;
        private System.Windows.Forms.ToolStripButton OpenTSBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ImportExcelTSBTN;
        private System.Windows.Forms.ToolStripButton NewProjectTSBTN;
        private System.Windows.Forms.ToolStripButton ImportCELBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox MeasPointDetailGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TextBox MPPositionTextBox;
        private System.Windows.Forms.Label MPDescLabel;
        private System.Windows.Forms.Label MPPositionLabel;
        public System.Windows.Forms.TextBox MPDescriptionTextBox;
        private System.Windows.Forms.Label MPCharNameLabel;
        public System.Windows.Forms.ComboBox MPCharNameComboBox;
        private System.Windows.Forms.Label MPDecimalPlaceLabel;
        public System.Windows.Forms.TextBox MPDecimalTextBox;
        private System.Windows.Forms.Label MPCodeGroupLabel;
        public System.Windows.Forms.ComboBox MPCodeGroupComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox MPLowerLimitTextBox;
        public System.Windows.Forms.TextBox MPUpperLimitTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox MPTargetValueTextBox;
        public System.Windows.Forms.TextBox MPTargetTextTextBox;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.Button MeasUpdateButton;
        private System.Windows.Forms.ToolStripMenuItem ControlMenu;
        private System.Windows.Forms.ToolStripButton ExportExcelTSBTN;
        private System.Windows.Forms.ToolStripButton ImportEQBTN;
        public System.Windows.Forms.ToolStripStatusLabel StatusTextLabel;
    }
}
