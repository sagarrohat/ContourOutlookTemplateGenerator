namespace OutlookTemplate
{
    partial class Main
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
            this.EmployeeCodeLabel = new System.Windows.Forms.Label();
            this.EmployeeCode = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeIn = new System.Windows.Forms.DateTimePicker();
            this.TimeOut = new System.Windows.Forms.DateTimePicker();
            this.TimeEntriesLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.OutlookButton = new System.Windows.Forms.Button();
            this.Hours = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeCodeLabel
            // 
            this.EmployeeCodeLabel.AutoSize = true;
            this.EmployeeCodeLabel.Location = new System.Drawing.Point(9, 24);
            this.EmployeeCodeLabel.Name = "EmployeeCodeLabel";
            this.EmployeeCodeLabel.Size = new System.Drawing.Size(81, 13);
            this.EmployeeCodeLabel.TabIndex = 0;
            this.EmployeeCodeLabel.Text = "Employee Code";
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.Enabled = false;
            this.EmployeeCode.Location = new System.Drawing.Point(108, 24);
            this.EmployeeCode.Name = "EmployeeCode";
            this.EmployeeCode.Size = new System.Drawing.Size(408, 20);
            this.EmployeeCode.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(108, 60);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(408, 20);
            this.Date.TabIndex = 3;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(60, 60);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Date";
            // 
            // TimeIn
            // 
            this.TimeIn.Location = new System.Drawing.Point(105, 102);
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.Size = new System.Drawing.Size(200, 20);
            this.TimeIn.TabIndex = 5;
            // 
            // TimeOut
            // 
            this.TimeOut.Location = new System.Drawing.Point(316, 102);
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.Size = new System.Drawing.Size(200, 20);
            this.TimeOut.TabIndex = 6;
            // 
            // TimeEntriesLabel
            // 
            this.TimeEntriesLabel.AutoSize = true;
            this.TimeEntriesLabel.Location = new System.Drawing.Point(25, 102);
            this.TimeEntriesLabel.Name = "TimeEntriesLabel";
            this.TimeEntriesLabel.Size = new System.Drawing.Size(65, 13);
            this.TimeEntriesLabel.TabIndex = 7;
            this.TimeEntriesLabel.Text = "Time Entries";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(54, 140);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(35, 13);
            this.HoursLabel.TabIndex = 9;
            this.HoursLabel.Text = "Hours";
            // 
            // OutlookButton
            // 
            this.OutlookButton.Location = new System.Drawing.Point(407, 172);
            this.OutlookButton.Name = "OutlookButton";
            this.OutlookButton.Size = new System.Drawing.Size(109, 23);
            this.OutlookButton.TabIndex = 10;
            this.OutlookButton.Text = "Open Outlook";
            this.OutlookButton.UseVisualStyleBackColor = true;
            this.OutlookButton.Click += new System.EventHandler(this.OutlookButton_Click);
            // 
            // Hours
            // 
            this.Hours.Location = new System.Drawing.Point(105, 140);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(411, 20);
            this.Hours.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 222);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.OutlookButton);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.TimeEntriesLabel);
            this.Controls.Add(this.TimeOut);
            this.Controls.Add(this.TimeIn);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.EmployeeCode);
            this.Controls.Add(this.EmployeeCodeLabel);
            this.Name = "Main";
            this.Text = "Outlook Email Generator";
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeCodeLabel;
        private System.Windows.Forms.TextBox EmployeeCode;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker TimeIn;
        private System.Windows.Forms.DateTimePicker TimeOut;
        private System.Windows.Forms.Label TimeEntriesLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Button OutlookButton;
        private System.Windows.Forms.NumericUpDown Hours;
    }
}

