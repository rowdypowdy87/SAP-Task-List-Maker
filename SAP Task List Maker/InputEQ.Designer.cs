namespace SAP_Task_List_Maker
{
    partial class InputEQ
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
            this.EQListCB = new System.Windows.Forms.ComboBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EQListCB
            // 
            this.EQListCB.FormattingEnabled = true;
            this.EQListCB.Location = new System.Drawing.Point(23, 21);
            this.EQListCB.Name = "EQListCB";
            this.EQListCB.Size = new System.Drawing.Size(275, 28);
            this.EQListCB.TabIndex = 0;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(23, 64);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(275, 48);
            this.ImportButton.TabIndex = 1;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(23, 118);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(275, 48);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // InputEQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 188);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.EQListCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputEQ";
            this.Text = "Select Template Equipment";
            this.Load += new System.EventHandler(this.InputEQ_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox EQListCB;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button CancelBtn;
    }
}