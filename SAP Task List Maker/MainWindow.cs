﻿using System;
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

        /// <summary>
        /// Update measurement point data on click
        /// </summary>
        private void MeasTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }

        /// <summary>
        /// Draw node text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MeasTree_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            // Variables
            Font TextFont       = new Font("Segoe UI", 9.0f, FontStyle.Regular);
            Image EditIcon      = Properties.Resources.Updated;
            Color Fore          = e.Node.ForeColor;
            Color Border        = Color.Black;
            Color Normal        = Color.White;
            Color Change        = Color.LimeGreen;

            // Set renderer to high quality
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw focus rectangles
            if (e.Node == e.Node.TreeView.SelectedNode)
            {
                Fore = SystemColors.HighlightText;

                e.Graphics.FillRectangle(new SolidBrush(Color.LightBlue), e.Bounds);
                ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds, Fore, Color.LightBlue);
            }
            else
                e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);

            if (e.Node.Level > 0)
            {
                MobilityMeasurement MeasureToDisplay = MeasurementManager.GetExistingMeasurement(e.Node.Index);

                if (MeasureToDisplay.UpdateMethod == MEAS_UPDATE.UPDATE)
                { 
                    TextRenderer.DrawText(e.Graphics, e.Node.Text, TextFont, new Point(e.Node.Bounds.X, e.Node.Bounds.Y), Color.Black);

                    e.Graphics.DrawImage(EditIcon, new Point(e.Node.Bounds.X - 15, e.Node.Bounds.Y + 2));
                }
                else
                    TextRenderer.DrawText(e.Graphics, e.Node.Text, TextFont, new Point(e.Node.Bounds.X, e.Node.Bounds.Y), Color.Black);

            }
            else
                TextRenderer.DrawText(e.Graphics, e.Node.Text, TextFont, new Point(e.Node.Bounds.X, e.Node.Bounds.Y), Color.Black);
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

        private void MeasTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level > 0)
            {
                MobilityMeasurement MeasureToDisplay = MeasurementManager.GetExistingMeasurement(e.Node.Index);

                MPDescriptionTextBox.Text           = MeasureToDisplay.Description;
                MPPositionTextBox.Text              = MeasureToDisplay.Position;
                MPCharNameComboBox.Text             = MeasureToDisplay.CharCode;
                MPCodeGroupComboBox.Text            = MeasureToDisplay.CodeGroup;
                MPDecimalTextBox.Text               = MeasureToDisplay.Decimals;
                MPUpperLimitTextBox.Text            = MeasureToDisplay.UpperLimit;
                MPLowerLimitTextBox.Text            = MeasureToDisplay.LowerLimit;
                MPTargetTextTextBox.Text            = MeasureToDisplay.TargetText;
                MPTargetValueTextBox.Text           = MeasureToDisplay.TargetValue;

                // Tell the app what node we have selected
                SelectedMeasure                     = e.Node.Index;
            }
        }
    }
}
