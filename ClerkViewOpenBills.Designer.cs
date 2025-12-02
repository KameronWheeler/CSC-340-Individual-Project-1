namespace Individual_Project
{
    partial class ClerkViewOpenBills
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
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.amountDueBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.appointmentDateBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.patientNameBox = new System.Windows.Forms.TextBox();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.requestList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.MainMenuButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuButton.Location = new System.Drawing.Point(288, 288);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(295, 37);
            this.MainMenuButton.TabIndex = 70;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click_2);
            // 
            // amountDueBox
            // 
            this.amountDueBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.amountDueBox.Location = new System.Drawing.Point(399, 125);
            this.amountDueBox.Margin = new System.Windows.Forms.Padding(4);
            this.amountDueBox.Name = "amountDueBox";
            this.amountDueBox.Size = new System.Drawing.Size(209, 22);
            this.amountDueBox.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "Amount Due:";
            // 
            // appointmentDateBox
            // 
            this.appointmentDateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.appointmentDateBox.Location = new System.Drawing.Point(399, 95);
            this.appointmentDateBox.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentDateBox.Name = "appointmentDateBox";
            this.appointmentDateBox.Size = new System.Drawing.Size(209, 22);
            this.appointmentDateBox.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Date:";
            // 
            // patientNameBox
            // 
            this.patientNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.patientNameBox.Location = new System.Drawing.Point(399, 65);
            this.patientNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.patientNameBox.Name = "patientNameBox";
            this.patientNameBox.Size = new System.Drawing.Size(209, 22);
            this.patientNameBox.TabIndex = 63;
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Location = new System.Drawing.Point(285, 68);
            this.patientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(91, 16);
            this.patientNameLabel.TabIndex = 62;
            this.patientNameLabel.Text = "Patient Name:";
            // 
            // requestList
            // 
            this.requestList.FormattingEnabled = true;
            this.requestList.ItemHeight = 16;
            this.requestList.Location = new System.Drawing.Point(12, 48);
            this.requestList.Name = "requestList";
            this.requestList.Size = new System.Drawing.Size(248, 292);
            this.requestList.TabIndex = 60;
            this.requestList.SelectedIndexChanged += new System.EventHandler(this.requestList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Open Bills";
            // 
            // ClerkViewOpenBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.amountDueBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.appointmentDateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patientNameBox);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.requestList);
            this.Name = "ClerkViewOpenBills";
            this.Text = "ClerkViewOpenBills";
            this.Load += new System.EventHandler(this.ClerkViewOpenBills_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.TextBox amountDueBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox appointmentDateBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patientNameBox;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.ListBox requestList;
        private System.Windows.Forms.Label label1;
    }
}