using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAP_Task_List_Maker
{
    public partial class MainWindow : Form
    {
        // Global variables
        public ImportExport   ImportExportManager;
        public MeasController MeasurementManager;
        

        /// <summary>
        /// Contructor method
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            ImportExportManager = new(this);
            MeasurementManager  = new(this);
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
            MeasurementManager.LoadMeasurements("11338714");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Update measurement point data on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MeasTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if(e.Node.Text[..1] == "[")
            {
                MobilityMeasurement MeasureToDisplay = MeasurementManager.GetExistingMeasurement(e.Node.Index);

                MPDescriptionTextBox.Text   = MeasureToDisplay.Description;
                MPPositionTextBox.Text      = MeasureToDisplay.Position;
                MPCharNameComboBox.Text     = MeasureToDisplay.CharCode;
                MPCodeGroupComboBox.Text    = MeasureToDisplay.CodeGroup;
                MPDecimalTextBox.Text       = MeasureToDisplay.Decimals;
                MPUpperLimitTextBox.Text    = MeasureToDisplay.UpperLimit;
                MPLowerLimitTextBox.Text    = MeasureToDisplay.LowerLimit; 
                MPTargetTextTextBox.Text    = MeasureToDisplay.TargetText;
                MPTargetValueTextBox.Text   = MeasureToDisplay.TargetValue;
            }
        }

        /// <summary>
        /// Turn off the annoynig tooltips for every cell
        /// </summary>
        private void BodyDGV_MouseEnter(object sender, EventArgs e)
        {
            DGVBody.ShowCellToolTips = false;
        }
    }
}
