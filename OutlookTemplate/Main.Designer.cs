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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            this.SettingsButton = new System.Windows.Forms.Button();
            this.CCLabel = new System.Windows.Forms.Label();
            this.CC = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.TextBox();
            this.ToLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeCodeLabel
            // 
            this.EmployeeCodeLabel.AutoSize = true;
            this.EmployeeCodeLabel.Location = new System.Drawing.Point(14, 106);
            this.EmployeeCodeLabel.Name = "EmployeeCodeLabel";
            this.EmployeeCodeLabel.Size = new System.Drawing.Size(81, 13);
            this.EmployeeCodeLabel.TabIndex = 0;
            this.EmployeeCodeLabel.Text = "Employee Code";
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.Enabled = false;
            this.EmployeeCode.Location = new System.Drawing.Point(114, 106);
            this.EmployeeCode.Name = "EmployeeCode";
            this.EmployeeCode.Size = new System.Drawing.Size(408, 20);
            this.EmployeeCode.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(114, 138);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(408, 20);
            this.Date.TabIndex = 3;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(65, 138);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date";
            // 
            // TimeIn
            // 
            this.TimeIn.Location = new System.Drawing.Point(111, 171);
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.Size = new System.Drawing.Size(200, 20);
            this.TimeIn.TabIndex = 5;
            // 
            // TimeOut
            // 
            this.TimeOut.Location = new System.Drawing.Point(322, 171);
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.Size = new System.Drawing.Size(200, 20);
            this.TimeOut.TabIndex = 6;
            // 
            // TimeEntriesLabel
            // 
            this.TimeEntriesLabel.AutoSize = true;
            this.TimeEntriesLabel.Location = new System.Drawing.Point(30, 171);
            this.TimeEntriesLabel.Name = "TimeEntriesLabel";
            this.TimeEntriesLabel.Size = new System.Drawing.Size(65, 13);
            this.TimeEntriesLabel.TabIndex = 4;
            this.TimeEntriesLabel.Text = "Time Entries";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(60, 202);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(35, 13);
            this.HoursLabel.TabIndex = 7;
            this.HoursLabel.Text = "Hours";
            // 
            // OutlookButton
            // 
            this.OutlookButton.Location = new System.Drawing.Point(413, 234);
            this.OutlookButton.Name = "OutlookButton";
            this.OutlookButton.Size = new System.Drawing.Size(109, 23);
            this.OutlookButton.TabIndex = 9;
            this.OutlookButton.Text = "Open Outlook";
            this.OutlookButton.UseVisualStyleBackColor = true;
            this.OutlookButton.Click += new System.EventHandler(this.OutlookButton_Click);
            // 
            // Hours
            // 
            this.Hours.Location = new System.Drawing.Point(111, 202);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(411, 20);
            this.Hours.TabIndex = 8;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(413, 13);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SettingsButton.Size = new System.Drawing.Size(109, 23);
            this.SettingsButton.TabIndex = 10;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // CCLabel
            // 
            this.CCLabel.AutoSize = true;
            this.CCLabel.Location = new System.Drawing.Point(74, 76);
            this.CCLabel.Name = "CCLabel";
            this.CCLabel.Size = new System.Drawing.Size(21, 13);
            this.CCLabel.TabIndex = 11;
            this.CCLabel.Text = "CC";
            // 
            // CC
            // 
            this.CC.Enabled = false;
            this.CC.Location = new System.Drawing.Point(114, 76);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(408, 20);
            this.CC.TabIndex = 12;
            // 
            // To
            // 
            this.To.Enabled = false;
            this.To.Location = new System.Drawing.Point(114, 46);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(408, 20);
            this.To.TabIndex = 14;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(75, 46);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(20, 13);
            this.ToLabel.TabIndex = 13;
            this.ToLabel.Text = "To";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 270);
            this.Controls.Add(this.To);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.CCLabel);
            this.Controls.Add(this.SettingsButton);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label CCLabel;
        private System.Windows.Forms.TextBox CC;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.Label ToLabel;
    }
}

