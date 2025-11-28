namespace Individual_Project
{
    partial class SchedulerPage
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label apptHistoryLabel;
            System.Windows.Forms.Label patientLabel;
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.ApproveButton = new System.Windows.Forms.Button();
            this.DenyButton = new System.Windows.Forms.Button();
            this.apptDetails = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            apptHistoryLabel = new System.Windows.Forms.Label();
            patientLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(61, 147);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(143, 16);
            label1.TabIndex = 15;
            label1.Text = "Appointment requests: ";
            // 
            // apptHistoryLabel
            // 
            apptHistoryLabel.AutoSize = true;
            apptHistoryLabel.Location = new System.Drawing.Point(353, 69);
            apptHistoryLabel.Name = "apptHistoryLabel";
            apptHistoryLabel.Size = new System.Drawing.Size(130, 16);
            apptHistoryLabel.TabIndex = 10;
            apptHistoryLabel.Text = "Appointment Details:";
            // 
            // patientLabel
            // 
            patientLabel.AutoSize = true;
            patientLabel.Location = new System.Drawing.Point(61, 37);
            patientLabel.Name = "patientLabel";
            patientLabel.Size = new System.Drawing.Size(94, 16);
            patientLabel.TabIndex = 9;
            patientLabel.Text = "Patient Name: ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(64, 179);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 212);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(161, 62);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(174, 23);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Location = new System.Drawing.Point(161, 34);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(174, 22);
            this.patientNameTextBox.TabIndex = 8;
            // 
            // ApproveButton
            // 
            this.ApproveButton.Location = new System.Drawing.Point(64, 106);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(131, 23);
            this.ApproveButton.TabIndex = 16;
            this.ApproveButton.Text = "Approve";
            this.ApproveButton.UseVisualStyleBackColor = true;
            this.ApproveButton.Click += new System.EventHandler(this.ApproveButton_Click);
            // 
            // DenyButton
            // 
            this.DenyButton.Location = new System.Drawing.Point(201, 106);
            this.DenyButton.Name = "DenyButton";
            this.DenyButton.Size = new System.Drawing.Size(134, 23);
            this.DenyButton.TabIndex = 17;
            this.DenyButton.Text = "Reject";
            this.DenyButton.UseVisualStyleBackColor = true;
            this.DenyButton.Click += new System.EventHandler(this.DenyButton_Click);
            // 
            // apptDetails
            // 
            this.apptDetails.BackColor = System.Drawing.SystemColors.Window;
            this.apptDetails.Location = new System.Drawing.Point(356, 110);
            this.apptDetails.Multiline = true;
            this.apptDetails.Name = "apptDetails";
            this.apptDetails.ReadOnly = true;
            this.apptDetails.Size = new System.Drawing.Size(373, 340);
            this.apptDetails.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 53);
            this.button1.TabIndex = 19;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SchedulerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.apptDetails);
            this.Controls.Add(this.DenyButton);
            this.Controls.Add(this.ApproveButton);
            this.Controls.Add(label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(apptHistoryLabel);
            this.Controls.Add(patientLabel);
            this.Controls.Add(this.patientNameTextBox);
            this.Name = "SchedulerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchedulerPage";
            this.Load += new System.EventHandler(this.SchedulerPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.Button ApproveButton;
        private System.Windows.Forms.Button DenyButton;
        private System.Windows.Forms.TextBox apptDetails;
        private System.Windows.Forms.Button button1;
    }
}