using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SAP_Task_List_Maker
{
    public partial class MainWindow : Form
    {
        // Global variables
        public ImportExport         ImportExportManager;
        public MeasController       MeasurementManager;
        public ExcelDataTables      DataTableManager;
        public int                  SelectedMeasure;
        public DataGridViewCell     CurrentCell;

        // Checks
        public bool                 TasklistData = false;
        public bool                 CELData      = false;
        public bool                 EQData       = false;



        /// <summary>
        /// Contructor method
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            ImportExportManager = new(this);
            MeasurementManager  = new(this);
            DataTableManager    = new();

            // Pass controller to measurement tree
            MeasPointsTree.SetControllers(this, MeasurementManager);

            SelectedMeasure = -1;

            SetStatusProgress("", 0);
        }

        /// <summary>
        /// Set status progress on Main Window
        /// </summary>
        /// <param name="StatusText">Status text</param>
        /// <param name="Prog">Progress amount</param>
        public void SetStatusProgress(string StatusText, int Prog)
        {
            if (Prog <= 0) 
                StatusProgressBar.Visible = false;
            else
            { 
                StatusProgressBar.Visible   = true;
                StatusProgressBar.Value     = Prog;
            }
            StatusTextLabel.Text = StatusText; 
        }

        /// <summary>
        /// Updates currently selected measurement in measurement tree view
        /// </summary>
        private void MeasUpdateButton_Click(object sender, EventArgs e)
        {
            if (SelectedMeasure > 0)
            { 
                MobilityMeasurement MeasureToChange = MeasurementManager.GetMeasurement(SelectedMeasure);

                MeasureToChange.Description     = MPDescriptionTextBox.Text;
                MeasureToChange.Position        = MPPositionTextBox.Text;
                MeasureToChange.CharCode        = MPCharNameComboBox.Text;
                MeasureToChange.CodeGroup       = MPCodeGroupComboBox.Text;
                MeasureToChange.Decimals        = MPDecimalTextBox.Text;
                MeasureToChange.UpperLimit      = MPUpperLimitTextBox.Text;
                MeasureToChange.LowerLimit      = MPLowerLimitTextBox.Text;
                MeasureToChange.TargetText      = MPTargetTextTextBox.Text;
                MeasureToChange.TargetValue     = MPTargetValueTextBox.Text;
                MeasureToChange.UpdateMethod    = MEAS_UPDATE.UPDATE;

                MeasurementManager.SetMeasurement(MeasureToChange, SelectedMeasure);
                
                MeasPointsTree.Refresh();
            }
        }

        /// <summary>
        /// Loading form event
        /// </summary>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Create the CEL table style
            DataGridViewCellStyle CELStyle = new()
            {
                Font                = new("Calibri", 9.0f, FontStyle.Regular),
                SelectionForeColor  = Color.FromArgb(55,86,35),
                SelectionBackColor  = Color.FromArgb(198, 224, 180),
                ForeColor           = Color.FromArgb(55, 86, 35),
                BackColor           = Color.FromArgb(198,224,180),
                WrapMode            = DataGridViewTriState.True,
                Alignment           = DataGridViewContentAlignment.MiddleCenter
            };

            // Set to CEL table
            DGVCEL.Columns[2].DefaultCellStyle = CELStyle;

            DGVBody.SetParent(this);
        }

        /// Drag drop event
        private void DGVBody_DragDrop(object sender, DragEventArgs e)
        {
            if (CurrentCell.GetType() == typeof(MeaspointCol))
            {
                Debug.Print("Dropped event trigger");

                if (e.Data.GetDataPresent(typeof(int)))
                {
                    MeaspointCell cell = (MeaspointCell)CurrentCell;

                    // Get data
                    int ToAdd = (int)e.Data.GetData(typeof(int));

                    if (ToAdd > -1)
                    { 
                        // Drop data
                        cell.Attached.Add(ToAdd);
                        Debug.Print("Dropped in cell");

                        // Clear data
                        e.Data.SetData(-1);
                    }
                }
            }
        }

        private void DGVBody_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void DGVBody_DragOver(object sender, DragEventArgs e)
        {
            // Find where mouse is pointing
            Point grvScreenLocation = DGVBody.PointToScreen(DGVBody.Location);

            // Check for cell hit
            DataGridView.HitTestInfo hit = DGVBody.HitTest(MousePosition.X - grvScreenLocation.X + DGVBody.Left,
                                                           MousePosition.Y - grvScreenLocation.Y + DGVBody.Top);

            Debug.Print($"{hit.ColumnIndex} - {hit.RowIndex}");

            if (hit.ColumnIndex > 6 & hit.RowIndex >= 0)
                CurrentCell = DGVBody.Rows[hit.RowIndex].Cells[hit.ColumnIndex];
        }

        /// <summary>
        /// Exit application
        /// </summary>
        private void ExitMenuBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void NewProjectTSBTN_Click(object sender, EventArgs e)
        {
            if (MsgBoxs.MsgBox_Question("Are you sure you want to start a new project?") == DialogResult.Yes)
            {
                DGVBody.Rows.Clear();
                DGVHeader.Rows.Clear();
                DGVCEL.Rows.Clear();
                DGVPRT.Rows.Clear();
                DGVComponents.Rows.Clear();
                MeasPointsTree.Nodes[0].Nodes.Clear();

                MPDescriptionTextBox.Text   = "";
                MPPositionTextBox.Text      = "";
                MPCharNameComboBox.Text     = "";
                MPCodeGroupComboBox.Text    = "";
                MPDecimalTextBox.Text       = "";
                MPUpperLimitTextBox.Text    = "";
                MPLowerLimitTextBox.Text    = "";
                MPTargetTextTextBox.Text    = "";
                MPTargetValueTextBox.Text   = "";

                TasklistData    = false;
                CELData         = false;
                EQData          = false;

            }
        }

        private void SaveTSBTN_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Clear measure update TBs on tree leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MeasureTree_Leave(object sender, EventArgs e)
        {
            if (MeasPointsTree.SelectedNode == null)
            {
                MPDescriptionTextBox.Text = "";
                MPPositionTextBox.Text = "";
                MPCharNameComboBox.Text = "";
                MPCodeGroupComboBox.Text = "";
                MPDecimalTextBox.Text = "";
                MPUpperLimitTextBox.Text = "";
                MPLowerLimitTextBox.Text = "";
                MPTargetTextTextBox.Text = "";
                MPTargetValueTextBox.Text = "";
            }
        }

        private void ImportExcelTSBTN_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Imports tasklist from SAP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportTasklistSAPBtn_Click(object sender, EventArgs e)
        {
            if (TasklistData)
            {
                MsgBoxs.MsgBox_Error("Tasklist already imported, please clear tasklist to continue");
                return;
            }

            ImportExportManager.ImportFromSAP();

            // Cannot add more
            TasklistData = true;
        }

        /// <summary>
        /// Import CEL
        /// </summary>
        private void ImportCELMenuBtn_Click(object sender, EventArgs e)
        {
            if (CELData)
                DGVCEL.Rows.Clear();

            InputCEL GetCEL = new InputCEL(this);

            GetCEL.Show();
        }

        /// <summary>
        /// Toolbar button for equipment import
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportEqBTN_Click(object sender, EventArgs e)
        {
            ImportCELMenuBtn_Click(sender, e);
        }

        private void equipmentOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
             string EqNumber = Microsoft.VisualBasic.Interaction.InputBox("Please enter the template equipment number");

             if (EqNumber == "")
                return;

            // Load measurements
            switch (MeasurementManager.LoadMeasurements(EqNumber))
            {
                case SAPERROR.SAP_NOT_CONNECTED: MsgBoxs.MsgBox_Error("Please ensure SAP is running to continue"); break;
                case SAPERROR.NONE:              EQData = true; break;
            }
        }

        /// <summary>
        /// Import tasklsit from SAP - menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fromSAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportTasklistSAPBtn_Click(sender, e);
        }

        /// <summary>
        /// Imports tasklist, CEL & Equipment in one go
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputEverythingBtn_Click(object sender, EventArgs e)
        {
            InputAll BringFullTasklist = new InputAll(this);

            BringFullTasklist.ShowDialog();
        }

        /// <summary>
        /// Set creation mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreationModeCHK_CheckedChanged(object sender, EventArgs e)
        {
            if(CreationModeCHK.Checked)
            {
                DGVBody.AllowUserToAddRows              = true;
                DGVPRT.AllowUserToAddRows               = true;
                DGVComponents.AllowUserToAddRows        = true;
                DGVCEL.AllowUserToAddRows               = true;
                DGVHeader.AllowUserToAddRows            = true;
            }
            else
            {
                DGVBody.AllowUserToAddRows              = false;
                DGVPRT.AllowUserToAddRows               = false;
                DGVComponents.AllowUserToAddRows        = false;
                DGVCEL.AllowUserToAddRows               = false;
                DGVHeader.AllowUserToAddRows            = false;
            }
        }
    }
}
