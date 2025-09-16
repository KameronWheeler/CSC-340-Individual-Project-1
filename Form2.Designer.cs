namespace Individual_Project
{
    partial class SchedulerPanel
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
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.patientLabel = new System.Windows.Forms.Label();
            this.apptHistoryLabel = new System.Windows.Forms.Label();
            this.AppointmentHistoryListBox = new System.Windows.Forms.ListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Location = new System.Drawing.Point(140, 36);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(174, 22);
            this.patientNameTextBox.TabIndex = 0;
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Location = new System.Drawing.Point(40, 39);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(94, 16);
            this.patientLabel.TabIndex = 1;
            this.patientLabel.Text = "Patient Name: ";
            // 
            // apptHistoryLabel
            // 
            this.apptHistoryLabel.AutoSize = true;
            this.apptHistoryLabel.Location = new System.Drawing.Point(363, 39);
            this.apptHistoryLabel.Name = "apptHistoryLabel";
            this.apptHistoryLabel.Size = new System.Drawing.Size(127, 16);
            this.apptHistoryLabel.TabIndex = 2;
            this.apptHistoryLabel.Text = "Appointment History";
            // 
            // AppointmentHistoryListBox
            // 
            this.AppointmentHistoryListBox.FormattingEnabled = true;
            this.AppointmentHistoryListBox.ItemHeight = 16;
            this.AppointmentHistoryListBox.Location = new System.Drawing.Point(335, 86);
            this.AppointmentHistoryListBox.Name = "AppointmentHistoryListBox";
            this.AppointmentHistoryListBox.Size = new System.Drawing.Size(373, 340);
            this.AppointmentHistoryListBox.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(140, 86);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.Location = new System.Drawing.Point(140, 130);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(75, 23);
            this.ScheduleButton.TabIndex = 5;
            this.ScheduleButton.Text = "Schedule";
            this.ScheduleButton.UseVisualStyleBackColor = true;
            // 
            // SchedulerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScheduleButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AppointmentHistoryListBox);
            this.Controls.Add(this.apptHistoryLabel);
            this.Controls.Add(this.patientLabel);
            this.Controls.Add(this.patientNameTextBox);
            this.Name = "SchedulerPanel";
            this.Text = "Appointment Schedule System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.Label apptHistoryLabel;
        private System.Windows.Forms.ListBox AppointmentHistoryListBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ScheduleButton;
    }
}