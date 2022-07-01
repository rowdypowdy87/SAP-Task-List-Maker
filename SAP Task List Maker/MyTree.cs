using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAP_Task_List_Maker
{
    public class MyTree : TreeView
    {
        // Global variables
        public MainWindow       WinParent;
        public MeasController   MeasurementManager;
        public bool TrapData;

        public MyTree()
        {
            // Add node mouse click event
            NodeMouseClick  += new TreeNodeMouseClickEventHandler(MeasTree_NodeMouseClick);
            ItemDrag        += new ItemDragEventHandler(MeasTree_ItemDrag);
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

        }
        

        /// <summary>
        /// Set parents
        /// </summary>
        /// <param name="WPar">MainWindow</param>
        /// <param name="MCon">Measurement Controller</param>
        public void SetControllers(MainWindow WPar, MeasController MCon)
        {
            WinParent           = WPar;
            MeasurementManager  = MCon;
        }

        /// <summary>
        /// Stop tooltips
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.Style |= 0x80;  // Turn on TVS_NOTOOLTIPS 
                return parms;
            }
        }

        /// <summary>
        /// Item drag events
        /// </summary>
        public void MeasTree_ItemDrag(object sender, ItemDragEventArgs e)
        {

            if(SelectedNode != null)
            { 
                if(SelectedNode.Level > 0)
                { 
                    Debug.Print("Drag data set");
                    DoDragDrop(SelectedNode.Index, DragDropEffects.Copy);
                }
            }
        }

        /// <summary>
        /// Updates the main window info boxes based off selection
        /// </summary>
        private void MeasTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Nodes below root
            if (e.Node.Level > 0)
            {

                MobilityMeasurement MeasureToDisplay    = MeasurementManager.GetExistingMeasurement(e.Node.Index);

                WinParent.MPDescriptionTextBox.Text     = MeasureToDisplay.Description;
                WinParent.MPPositionTextBox.Text        = MeasureToDisplay.Position;
                WinParent.MPCharNameComboBox.Text       = MeasureToDisplay.CharCode;
                WinParent.MPCodeGroupComboBox.Text      = MeasureToDisplay.CodeGroup;
                WinParent.MPDecimalTextBox.Text         = MeasureToDisplay.Decimals;
                WinParent.MPUpperLimitTextBox.Text      = MeasureToDisplay.UpperLimit;
                WinParent.MPLowerLimitTextBox.Text      = MeasureToDisplay.LowerLimit;
                WinParent.MPTargetTextTextBox.Text      = MeasureToDisplay.TargetText;
                WinParent.MPTargetValueTextBox.Text     = MeasureToDisplay.TargetValue;

                // Tell the app what node we have selected
                WinParent.SelectedMeasure               = e.Node.Index;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics Gfx = e.Graphics;
            Pen Lines    = new Pen(Color.LightSlateGray) { DashPattern = new float[] { 1, 4, 8, 12 } };

            foreach (TreeNode n in Nodes)
            {
                DrawNodes(e, n);

                if (n.IsExpanded)
                {
                    foreach (TreeNode n2 in n.Nodes)
                    {
                        int X, Y, W, H;

                        X = n2.Bounds.X;
                        Y = n2.Bounds.Y;
                        W = n2.Bounds.Width;
                        H = n2.Bounds.Height;    

                        // Draw lines
                        if (n2.Index == 0)
                        {
                            Gfx.DrawLine(Lines, new Point(X + AutoScrollOffset.X - 5, Y + AutoScrollOffset.Y + (H / 2)),
                                                new Point(X + AutoScrollOffset.X - 5, Y + AutoScrollOffset.Y + H - 2));
                            Gfx.DrawLine(Lines, new Point(X + AutoScrollOffset.X - 4, Y + AutoScrollOffset.Y + (H / 2)),
                                                new Point(X + AutoScrollOffset.X - 1, Y + AutoScrollOffset.Y + (H / 2)));

                            // Draw line to root node
                            Gfx.DrawLine(Lines, new Point(X + AutoScrollOffset.X - 4, Y + AutoScrollOffset.Y + (H / 2)),
                                                new Point(X + AutoScrollOffset.X - 20, Y + AutoScrollOffset.Y));
                        }

                        // End child node
                        if (n2.Index == SelectedNode.Nodes.Count - 1)
                        {
                            Gfx.DrawLine(Lines, 
                                         X + AutoScrollOffset.X - 5, 
                                         Y + AutoScrollOffset.Y + 2,
                                         X + AutoScrollOffset.X - 5, 
                                         Y + AutoScrollOffset.Y + (H / 2));

                            Gfx.DrawLine(Lines,
                                         X + AutoScrollOffset.X - 4, 
                                         Y + AutoScrollOffset.Y + (H / 2),
                                         X + AutoScrollOffset.X - 1, 
                                         Y + AutoScrollOffset.Y + (H / 2));
                        }

                        // Middle child nodes
                        if (n2.Index > 0 && n2.Index < SelectedNode.Nodes.Count - 1)
                        {
                            Gfx.DrawLine(Lines, new Point(X + AutoScrollOffset.X - 5, Y + AutoScrollOffset.Y + 2),
                                                new Point(X + AutoScrollOffset.X - 5, Y + AutoScrollOffset.Y + H - 2));
                            Gfx.DrawLine(Lines, new Point(X + AutoScrollOffset.X - 4, Y + AutoScrollOffset.Y + (H / 2)),
                                                new Point(X + AutoScrollOffset.X - 1, Y + AutoScrollOffset.Y + (H / 2)));
                        }

                        // Draw the nodes
                        DrawNodes(e, n2);
                    }
                }
            }
        }

        /// <summary>
        /// Override draw node event
        /// </summary>
        private void DrawNodes(PaintEventArgs e, TreeNode CurNode)
        {
            // Variables
            Font        TextFont        = new Font("Calibri", 9.0f, FontStyle.Regular);
            Font        RootFont        = new Font("Calibri", 10.0f, FontStyle.Bold);
            Image       EditIcon        = Properties.Resources.Updated;
            Color       Fore            = CurNode.ForeColor;
            Color       Border          = Color.Black;
            Color       Normal          = Color.White;
            Color       Change          = Color.LimeGreen;
            Rectangle   Bounds          = CurNode.Bounds;
            Rectangle   SBounds         = CurNode.Bounds;
            Graphics    Gfx             = e.Graphics;
            int         X, Y, W, H;

            // Separate node bounds
            X = Bounds.X + 5;
            Y = Bounds.Y;
            W = Bounds.Width;
            H = Bounds.Height;

            // Inflate the bounds so it fits
            if (CurNode.Level == 0)
            {
                // Selection bounds
                SBounds.Width = (int)Gfx.MeasureString(CurNode.Text, RootFont).Width - 15;
                SBounds.Height = (int)Gfx.MeasureString(CurNode.Text, RootFont).Height - 2;
                SBounds.X += 15;
                SBounds.Y += 2;
            }
            else
            {
                // Selection bounds
                SBounds.Width   = (int)Gfx.MeasureString(CurNode.Text, TextFont).Width - 5;
                SBounds.Height  = (int)Gfx.MeasureString(CurNode.Text, TextFont).Height - 2;
                SBounds.X += 5;
                SBounds.Y += 2;
            }

            // Set renderer to high quality
            Gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw focus rectangles
            if (CurNode == CurNode.TreeView.SelectedNode)
            {
                // Get current forecolor
                Fore = SystemColors.HighlightText;
                // Draw blue internal rect
                Gfx.FillRectangle(new SolidBrush(Color.LightBlue), SBounds);
                // Draw focus rectangle
                ControlPaint.DrawFocusRectangle(Gfx, SBounds, Fore, Color.LightBlue);
            }
            else
                // Fill nothing
                Gfx.FillRectangle(SystemBrushes.Window, SBounds);

            // Child level
            if (CurNode.Level > 0)
            {
                // Get measurement data
                MobilityMeasurement MeasureToDisplay = MeasurementManager.GetExistingMeasurement(CurNode.Index);

                // Draw text
                TextRenderer.DrawText(Gfx, CurNode.Text, TextFont, new Point(X, Y), Color.Black);

                // Draw icon for change notification
                if (MeasureToDisplay.UpdateMethod == MEAS_UPDATE.UPDATE)
                    Gfx.DrawImage(EditIcon, new Point(X - 15, Y + 2)); 
            }
            // Draw root node text
            else
            { 
                // Draw the icons
                switch (CurNode.Index)
                {
                    case 0:
                        // Draw the expand sign
                        if (CurNode.Nodes.Count > 0 && !CurNode.IsExpanded)
                            Gfx.DrawImage(Properties.Resources.Expand,   new Point(X - 2, Y + (H/2) - (Properties.Resources.Expand.Height/2) + 1));
                        else if (CurNode.Nodes.Count > 0 && CurNode.IsExpanded)
                            Gfx.DrawImage(Properties.Resources.DeExpand, new Point(X - 2, Y + (H/2) - (Properties.Resources.Expand.Height/2) + 1));

                        Gfx.DrawImage(Properties.Resources.ExistingMeas, new Point(X - 20, Y + 2));
                        
                        break;

                    case 1:
                        Gfx.DrawImage(Properties.Resources.NewMeas, new Point(X - 20, Y + 2));
                        break;
                }

                // Draw root text
                TextRenderer.DrawText(Gfx, CurNode.Text, RootFont, new Point(X + 10, Y + 2), Color.Black);

                // Draw lines
                //Gfx.DrawLine(new Pen(Color.Red), new Point(X - 5,Y + W), new Point(X - 5,Y + W + 10));
            }
        }
    }
}
