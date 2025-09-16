namespace Individual_Project
{
    partial class DoctorMedicineRequest
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
            this.requestList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rejectButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.RxPurpose = new System.Windows.Forms.TextBox();
            this.datePrescribed = new System.Windows.Forms.TextBox();
            this.MedicationName = new System.Windows.Forms.TextBox();
            this.patientName = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.medicationLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.numRefills = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // requestList
            // 
            this.requestList.FormattingEnabled = true;
            this.requestList.ItemHeight = 16;
            this.requestList.Location = new System.Drawing.Point(12, 97);
            this.requestList.Name = "requestList";
            this.requestList.Size = new System.Drawing.Size(248, 292);
            this.requestList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Requests:";
            // 
            // rejectButton
            // 
            this.rejectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rejectButton.Location = new System.Drawing.Point(464, 312);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(119, 37);
            this.rejectButton.TabIndex = 23;
            this.rejectButton.Text = "Reject";
            this.rejectButton.UseVisualStyleBackColor = false;
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.acceptButton.Location = new System.Drawing.Point(288, 312);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(119, 37);
            this.acceptButton.TabIndex = 22;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = false;
            // 
            // RxPurpose
            // 
            this.RxPurpose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RxPurpose.Location = new System.Drawing.Point(399, 204);
            this.RxPurpose.Margin = new System.Windows.Forms.Padding(4);
            this.RxPurpose.Name = "RxPurpose";
            this.RxPurpose.Size = new System.Drawing.Size(209, 22);
            this.RxPurpose.TabIndex = 21;
            // 
            // datePrescribed
            // 
            this.datePrescribed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.datePrescribed.Location = new System.Drawing.Point(399, 174);
            this.datePrescribed.Margin = new System.Windows.Forms.Padding(4);
            this.datePrescribed.Name = "datePrescribed";
            this.datePrescribed.Size = new System.Drawing.Size(209, 22);
            this.datePrescribed.TabIndex = 20;
            // 
            // MedicationName
            // 
            this.MedicationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MedicationName.Location = new System.Drawing.Point(399, 144);
            this.MedicationName.Margin = new System.Windows.Forms.Padding(4);
            this.MedicationName.Name = "MedicationName";
            this.MedicationName.Size = new System.Drawing.Size(209, 22);
            this.MedicationName.TabIndex = 19;
            // 
            // patientName
            // 
            this.patientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.patientName.Location = new System.Drawing.Point(399, 114);
            this.patientName.Margin = new System.Windows.Forms.Padding(4);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(209, 22);
            this.patientName.TabIndex = 18;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(327, 207);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(64, 16);
            this.timeLabel.TabIndex = 17;
            this.timeLabel.Text = "Purpose: ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(281, 177);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(110, 16);
            this.dateLabel.TabIndex = 16;
            this.dateLabel.Text = "Date prescribed: ";
            // 
            // medicationLabel
            // 
            this.medicationLabel.AutoSize = true;
            this.medicationLabel.Location = new System.Drawing.Point(272, 147);
            this.medicationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medicationLabel.Name = "medicationLabel";
            this.medicationLabel.Size = new System.Drawing.Size(119, 16);
            this.medicationLabel.TabIndex = 15;
            this.medicationLabel.Text = "Medication Name: ";
            this.medicationLabel.Click += new System.EventHandler(this.drNameLabel_Click);
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Location = new System.Drawing.Point(285, 117);
            this.patientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(91, 16);
            this.patientNameLabel.TabIndex = 14;
            this.patientNameLabel.Text = "Patient Name:";
            // 
            // numRefills
            // 
            this.numRefills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.numRefills.Location = new System.Drawing.Point(399, 234);
            this.numRefills.Margin = new System.Windows.Forms.Padding(4);
            this.numRefills.Name = "numRefills";
            this.numRefills.Size = new System.Drawing.Size(209, 22);
            this.numRefills.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Number of refills";
            // 
            // DoctorMedicineRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numRefills);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.RxPurpose);
            this.Controls.Add(this.datePrescribed);
            this.Controls.Add(this.MedicationName);
            this.Controls.Add(this.patientName);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.medicationLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requestList);
            this.Name = "DoctorMedicineRequest";
            this.Text = "DoctorMedicineRequest";
            this.Load += new System.EventHandler(this.DoctorMedicineRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox requestList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox RxPurpose;
        private System.Windows.Forms.TextBox datePrescribed;
        private System.Windows.Forms.TextBox MedicationName;
        private System.Windows.Forms.TextBox patientName;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label medicationLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.TextBox numRefills;
        private System.Windows.Forms.Label label2;
    }
}