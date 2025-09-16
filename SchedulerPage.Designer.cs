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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AppointmentHistoryListBox = new System.Windows.Forms.ListBox();
            this.apptHistoryLabel = new System.Windows.Forms.Label();
            this.patientLabel = new System.Windows.Forms.Label();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Patient results: ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(64, 203);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 212);
            this.listBox1.TabIndex = 14;
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.Location = new System.Drawing.Point(161, 128);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(75, 23);
            this.ScheduleButton.TabIndex = 13;
            this.ScheduleButton.Text = "Schedule";
            this.ScheduleButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(161, 84);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // AppointmentHistoryListBox
            // 
            this.AppointmentHistoryListBox.FormattingEnabled = true;
            this.AppointmentHistoryListBox.ItemHeight = 16;
            this.AppointmentHistoryListBox.Location = new System.Drawing.Point(356, 84);
            this.AppointmentHistoryListBox.Name = "AppointmentHistoryListBox";
            this.AppointmentHistoryListBox.Size = new System.Drawing.Size(373, 340);
            this.AppointmentHistoryListBox.TabIndex = 11;
            // 
            // apptHistoryLabel
            // 
            this.apptHistoryLabel.AutoSize = true;
            this.apptHistoryLabel.Location = new System.Drawing.Point(353, 56);
            this.apptHistoryLabel.Name = "apptHistoryLabel";
            this.apptHistoryLabel.Size = new System.Drawing.Size(127, 16);
            this.apptHistoryLabel.TabIndex = 10;
            this.apptHistoryLabel.Text = "Appointment History";
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Location = new System.Drawing.Point(61, 37);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(94, 16);
            this.patientLabel.TabIndex = 9;
            this.patientLabel.Text = "Patient Name: ";
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Location = new System.Drawing.Point(161, 34);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(174, 22);
            this.patientNameTextBox.TabIndex = 8;
            // 
            // SchedulerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ScheduleButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AppointmentHistoryListBox);
            this.Controls.Add(this.apptHistoryLabel);
            this.Controls.Add(this.patientLabel);
            this.Controls.Add(this.patientNameTextBox);
            this.Name = "SchedulerPage";
            this.Text = "SchedulerPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox AppointmentHistoryListBox;
        private System.Windows.Forms.Label apptHistoryLabel;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.TextBox patientNameTextBox;
    }
}