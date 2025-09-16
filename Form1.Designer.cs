namespace Individual_Project
{
    partial class Form1
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
            this.requestsListBox = new System.Windows.Forms.ListBox();
            this.requestsLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.drNameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // requestsListBox
            // 
            this.requestsListBox.FormattingEnabled = true;
            this.requestsListBox.ItemHeight = 16;
            this.requestsListBox.Location = new System.Drawing.Point(51, 94);
            this.requestsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.requestsListBox.Name = "requestsListBox";
            this.requestsListBox.Size = new System.Drawing.Size(285, 324);
            this.requestsListBox.TabIndex = 0;
            // 
            // requestsLabel
            // 
            this.requestsLabel.AutoSize = true;
            this.requestsLabel.Location = new System.Drawing.Point(47, 50);
            this.requestsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requestsLabel.Name = "requestsLabel";
            this.requestsLabel.Size = new System.Drawing.Size(143, 16);
            this.requestsLabel.TabIndex = 1;
            this.requestsLabel.Text = "Appointment Requests";
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Location = new System.Drawing.Point(376, 97);
            this.patientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(91, 16);
            this.patientNameLabel.TabIndex = 3;
            this.patientNameLabel.Text = "Patient Name:";
            // 
            // drNameLabel
            // 
            this.drNameLabel.AutoSize = true;
            this.drNameLabel.Location = new System.Drawing.Point(376, 127);
            this.drNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drNameLabel.Name = "drNameLabel";
            this.drNameLabel.Size = new System.Drawing.Size(67, 16);
            this.drNameLabel.TabIndex = 4;
            this.drNameLabel.Text = "Dr Name: ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(376, 157);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(42, 16);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "Date: ";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(376, 187);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(44, 16);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Time: ";
            this.timeLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(465, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox2.Location = new System.Drawing.Point(465, 124);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox3.Location = new System.Drawing.Point(465, 154);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox4.Location = new System.Drawing.Point(465, 184);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 22);
            this.textBox4.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(723, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(296, 324);
            this.listBox1.TabIndex = 11;
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.acceptButton.Location = new System.Drawing.Point(379, 292);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(119, 37);
            this.acceptButton.TabIndex = 12;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = false;
            // 
            // rejectButton
            // 
            this.rejectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rejectButton.Location = new System.Drawing.Point(555, 292);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(119, 37);
            this.rejectButton.TabIndex = 13;
            this.rejectButton.Text = "Reject";
            this.rejectButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.drNameLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.requestsLabel);
            this.Controls.Add(this.requestsListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox requestsListBox;
        private System.Windows.Forms.Label requestsLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label drNameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button rejectButton;
    }
}