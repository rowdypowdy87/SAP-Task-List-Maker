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
        public int                  SelectedMeasure;
        public DataGridViewCell     CurrentCell;

        /// <summary>
        /// Contructor method
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            ImportExportManager = new ImportExport(this);
            MeasurementManager  = new MeasController(this);

            // Pass controller to measurement tree
            MeasPointsTree.SetControllers(this, MeasurementManager);

            SelectedMeasure = -1;
        }

        /// <summary>
        /// Set status progress on Main Window
        /// </summary>
        /// <param name="StatusText">Status text</param>
        /// <param name="Prog">Progress amount</param>
        public void SetStatusProgress(string StatusText, int Prog)
        {
            if(Prog <= 0) 
                StatusProgressBar.Visible = false;
            else
            { 
                StatusProgressBar.Visible   = true;
                StatusProgressBar.Value     = Prog;
            }

            StatusTextLabel.Text    = StatusText;
        }

        private static void DrawStringOutlined(Graphics g, string Text, Font TextFont, Color TextColor, Color OutlineColor, int X, int Y, int OutlineDepth)
        {
            // Draw outline
            TextRenderer.DrawText(g, Text, TextFont, new Point(X - OutlineDepth, Y - OutlineDepth), OutlineColor);
            TextRenderer.DrawText(g, Text, TextFont, new Point(X - OutlineDepth, Y + OutlineDepth), OutlineColor);
            TextRenderer.DrawText(g, Text, TextFont, new Point(X + OutlineDepth, Y - OutlineDepth), OutlineColor);
            TextRenderer.DrawText(g, Text, TextFont, new Point(X + OutlineDepth, Y + OutlineDepth), OutlineColor);
            // Draw text
            TextRenderer.DrawText(g, Text, TextFont, new Point(X, Y), TextColor);
        }

        /// <summary>
        /// Updates currently selected measurement in measurement tree view
        /// </summary>
        private void MeasUpdateButton_Click(object sender, EventArgs e)
        {
            if (SelectedMeasure > 0)
            { 
                MobilityMeasurement MeasureToChange = MeasurementManager.GetExistingMeasurement(SelectedMeasure);

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

                try {
                    MeasPointsTree.Nodes[1].Nodes[SelectedMeasure].Text = $"[{MeasureToChange.Number}] - {MeasureToChange.Description}";
                } catch { };

                MeasurementManager.SetExistingMeasurement(MeasureToChange, SelectedMeasure);
                
                MeasPointsTree.Refresh();
            }
        }

        /// <summary>
        /// Import CEL
        /// </summary>
        private void ImportCELMenuBtn_Click(object sender, EventArgs e)
        {
            InputCEL GetCEL = new InputCEL(this);

            GetCEL.Show();
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

        private void ImportMeasBtn_Click(object sender, EventArgs e)
        {
            switch (MeasurementManager.LoadMeasurements("11338714"))
            {
                case SAPERROR.SAP_NOT_CONNECTED: MsgBoxs.MsgBox_Error("Please ensure SAP is running to continue"); break;
            }

            ImportExportManager.ImportFromSAP();
        }
    }
}
