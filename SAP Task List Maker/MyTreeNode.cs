using System.Drawing;
using System.Windows.Forms;

namespace SAP_Task_List_Maker
{
    public class MyTreeView : TreeView
    {
        public MyTreeView()
        {
            //ItemHeight = 40;
        }

        /*protected override void OnDrawNode(DrawTreeNodeEventArgs e)
        {
            // Draw the background and node text for a selected node.
            e.DrawDefault = false;
            Rectangle eNodeBounds = NodeBounds(e.Node);
            if (eNodeBounds.X == 0 && eNodeBounds.Y == 0) return;

            e.Graphics.FillRectangle(SystemBrushes.Window, e.Node.Bounds); // clear any remains from system

            // Draw the background of the selected node. The NodeBounds method makes the highlight rectangle large enough for the text.
            e.Graphics.FillRectangle(((e.State & TreeNodeStates.Selected) != 0) ? SystemBrushes.Highlight : SystemBrushes.HighlightText ,eNodeBounds);

            // Draw the node text using  the node font. If the node font has not been set, use the TreeView font.
            e.Graphics.DrawString(e.Node.Text, e.Node.NodeFont ?? e.Node.TreeView?.Font ?? Font,
                                    ((e.State & TreeNodeStates.Selected) != 0) ? SystemBrushes.Window : SystemBrushes.WindowText, eNodeBounds);

            // If the node has focus, draw the focus rectangle.
            if ((e.State & TreeNodeStates.Focused) != 0) 
            {
                using (Pen focusPen = new Pen(Color.Black))
                {
                    focusPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    e.Graphics.DrawRectangle(focusPen, new Rectangle(eNodeBounds.Location, Rectangle.Inflate(eNodeBounds, -1, -1).Size));
                }
            }
        }*/

        // Returns the bounds of the specified node label, Possibly multi line.
        private Rectangle NodeBounds(TreeNode node)
        {
            if (node?.TreeView != null && node?.Text != null) 
            {
                // Retrieve a Graphics object from the TreeView handle and use it to calculate the display size of the text.
                using (Graphics g = node.TreeView.CreateGraphics())
                {
                    SizeF textSize = g.MeasureString(node.Text, node.NodeFont ?? node.TreeView.Font);
                    return Rectangle.Ceiling(new RectangleF(PointF.Add(node.Bounds.Location, new SizeF(0, (node.TreeView.ItemHeight - textSize.Height) / 2)), textSize)); //Centre Y
                }
            } else return node?.Bounds ?? new Rectangle(); //FallBack to the normal node bounds, and to empty 0,0.
        }
    }
}
