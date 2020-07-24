namespace OutlookTemplate
{
    partial class Configurations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurations));
            this.EmployeeCodeLabel = new System.Windows.Forms.Label();
            this.EmployeeCode = new System.Windows.Forms.TextBox();
            this.ToLabel = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.TextBox();
            this.CC = new System.Windows.Forms.TextBox();
            this.CCLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeCodeLabel
            // 
            this.EmployeeCodeLabel.AutoSize = true;
            this.EmployeeCodeLabel.Location = new System.Drawing.Point(33, 19);
            this.EmployeeCodeLabel.Name = "EmployeeCodeLabel";
            this.EmployeeCodeLabel.Size = new System.Drawing.Size(81, 13);
            this.EmployeeCodeLabel.TabIndex = 0;
            this.EmployeeCodeLabel.Text = "Employee Code";
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.Location = new System.Drawing.Point(133, 19);
            this.EmployeeCode.Name = "EmployeeCode";
            this.EmployeeCode.Size = new System.Drawing.Size(380, 20);
            this.EmployeeCode.TabIndex = 1;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(93, 52);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(20, 13);
            this.ToLabel.TabIndex = 2;
            this.ToLabel.Text = "To";
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(133, 49);
            this.To.Multiline = true;
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(380, 53);
            this.To.TabIndex = 3;
            // 
            // CC
            // 
            this.CC.Location = new System.Drawing.Point(133, 112);
            this.CC.Multiline = true;
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(380, 56);
            this.CC.TabIndex = 4;
            // 
            // CCLabel
            // 
            this.CCLabel.AutoSize = true;
            this.CCLabel.Location = new System.Drawing.Point(92, 115);
            this.CCLabel.Name = "CCLabel";
            this.CCLabel.Size = new System.Drawing.Size(21, 13);
            this.CCLabel.TabIndex = 5;
            this.CCLabel.Text = "CC";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(372, 179);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(141, 23);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "Update Configuration";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Configurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 222);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CCLabel);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.To);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.EmployeeCode);
            this.Controls.Add(this.EmployeeCodeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Configurations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeCodeLabel;
        private System.Windows.Forms.TextBox EmployeeCode;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.TextBox CC;
        private System.Windows.Forms.Label CCLabel;
        private System.Windows.Forms.Button UpdateButton;
    }
}