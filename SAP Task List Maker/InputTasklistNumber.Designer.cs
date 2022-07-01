namespace SAP_Task_List_Maker
{
    partial class InputTasklistNumber
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
            this.TasklistGroup = new System.Windows.Forms.TextBox();
            this.TasklistCounter = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.CounterLabel = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TasklistGroup
            // 
            this.TasklistGroup.Location = new System.Drawing.Point(137, 19);
            this.TasklistGroup.Name = "TasklistGroup";
            this.TasklistGroup.Size = new System.Drawing.Size(244, 27);
            this.TasklistGroup.TabIndex = 0;
            // 
            // TasklistCounter
            // 
            this.TasklistCounter.Location = new System.Drawing.Point(137, 50);
            this.TasklistCounter.Name = "TasklistCounter";
            this.TasklistCounter.Size = new System.Drawing.Size(244, 27);
            this.TasklistCounter.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(401, 19);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(274, 27);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(21, 22);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(110, 20);
            this.GroupLabel.TabIndex = 3;
            this.GroupLabel.Text = "Task List Group:";
            // 
            // CounterLabel
            // 
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Location = new System.Drawing.Point(10, 53);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(121, 20);
            this.CounterLabel.TabIndex = 3;
            this.CounterLabel.Text = "Task List Counter:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(401, 50);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(274, 27);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // InputTasklistNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 90);
            this.Controls.Add(this.CounterLabel);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.TasklistCounter);
            this.Controls.Add(this.TasklistGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputTasklistNumber";
            this.Text = "Please enter Task List details:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TasklistGroup;
        public System.Windows.Forms.TextBox TasklistCounter;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Label CounterLabel;
        private System.Windows.Forms.Button CancelBtn;
    }
}