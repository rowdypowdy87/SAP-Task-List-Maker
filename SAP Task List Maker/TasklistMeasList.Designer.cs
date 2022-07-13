namespace SAP_Task_List_Maker
{
    partial class TasklistMeasList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MeasurementsLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MeasurementsLB
            // 
            this.MeasurementsLB.FormattingEnabled = true;
            this.MeasurementsLB.ItemHeight = 20;
            this.MeasurementsLB.Location = new System.Drawing.Point(12, 53);
            this.MeasurementsLB.Name = "MeasurementsLB";
            this.MeasurementsLB.Size = new System.Drawing.Size(408, 424);
            this.MeasurementsLB.TabIndex = 0;
            // 
            // TasklistMeasList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 572);
            this.Controls.Add(this.MeasurementsLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TasklistMeasList";
            this.Text = "TasklistMeasList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MeasurementsLB;
    }
}