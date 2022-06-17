using System;
using System.Drawing;
using System.Windows.Forms;

namespace SAP_Task_List_Maker
{
    public partial class MainWindow : Form
    {
        // Global variables
        public ImportExport   ImportExportManager;
        public MeasController MeasurementManager;
        public int            SelectedMeasure;

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

        private void importFromSapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportExportManager.ImportFromSAP();
        }

        private void importMEasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (MeasurementManager.LoadMeasurements("11338714"))
            {
                case SAPERROR.SAP_NOT_CONNECTED: MsgBoxs.MsgBox_Error("Please ensure SAP is running to continue"); break;
            }
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
    }
}
