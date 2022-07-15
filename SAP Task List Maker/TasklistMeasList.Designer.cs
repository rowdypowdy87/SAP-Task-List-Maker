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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasklistMeasList));
            this.MeasurementsLB = new System.Windows.Forms.ListBox();
            this.MeasUpBTN = new System.Windows.Forms.Button();
            this.MeasDownBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.OkayBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MeasurementsLB
            // 
            this.MeasurementsLB.FormattingEnabled = true;
            this.MeasurementsLB.ItemHeight = 20;
            this.MeasurementsLB.Location = new System.Drawing.Point(12, 52);
            this.MeasurementsLB.Name = "MeasurementsLB";
            this.MeasurementsLB.Size = new System.Drawing.Size(408, 384);
            this.MeasurementsLB.TabIndex = 0;
            // 
            // MeasUpBTN
            // 
            this.MeasUpBTN.Image = ((System.Drawing.Image)(resources.GetObject("MeasUpBTN.Image")));
            this.MeasUpBTN.Location = new System.Drawing.Point(12, 12);
            this.MeasUpBTN.Name = "MeasUpBTN";
            this.MeasUpBTN.Size = new System.Drawing.Size(33, 34);
            this.MeasUpBTN.TabIndex = 1;
            this.MeasUpBTN.UseVisualStyleBackColor = true;
            this.MeasUpBTN.Click += new System.EventHandler(this.MeasUpBTN_Click);
            // 
            // MeasDownBTN
            // 
            this.MeasDownBTN.Image = ((System.Drawing.Image)(resources.GetObject("MeasDownBTN.Image")));
            this.MeasDownBTN.Location = new System.Drawing.Point(51, 12);
            this.MeasDownBTN.Name = "MeasDownBTN";
            this.MeasDownBTN.Size = new System.Drawing.Size(33, 34);
            this.MeasDownBTN.TabIndex = 1;
            this.MeasDownBTN.UseVisualStyleBackColor = true;
            this.MeasDownBTN.Click += new System.EventHandler(this.MeasDownBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBTN.Image")));
            this.DeleteBTN.Location = new System.Drawing.Point(90, 12);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(33, 34);
            this.DeleteBTN.TabIndex = 1;
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // OkayBTN
            // 
            this.OkayBTN.Location = new System.Drawing.Point(12, 442);
            this.OkayBTN.Name = "OkayBTN";
            this.OkayBTN.Size = new System.Drawing.Size(408, 61);
            this.OkayBTN.TabIndex = 2;
            this.OkayBTN.Text = "OKAY";
            this.OkayBTN.UseVisualStyleBackColor = true;
            // 
            // TasklistMeasList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 512);
            this.Controls.Add(this.OkayBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.MeasDownBTN);
            this.Controls.Add(this.MeasUpBTN);
            this.Controls.Add(this.MeasurementsLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TasklistMeasList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Update Operation Measurement List";
            this.Load += new System.EventHandler(this.TasklistMeasList_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button MeasUpBTN;
        private System.Windows.Forms.Button MeasDownBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button OkayBTN;
        public System.Windows.Forms.ListBox MeasurementsLB;
    }
}