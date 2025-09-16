namespace Individual_Project
{
    partial class UserMedicineRequest
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.TextBox();
            this.DrName = new System.Windows.Forms.TextBox();
            this.RxName = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.drNameLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.purpose = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(10, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 260);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prescriptions:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(278, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Request Medicine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(278, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Return Home";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.date.Location = new System.Drawing.Point(384, 125);
            this.date.Margin = new System.Windows.Forms.Padding(4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(209, 22);
            this.date.TabIndex = 17;
            // 
            // DrName
            // 
            this.DrName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DrName.Location = new System.Drawing.Point(384, 95);
            this.DrName.Margin = new System.Windows.Forms.Padding(4);
            this.DrName.Name = "DrName";
            this.DrName.Size = new System.Drawing.Size(209, 22);
            this.DrName.TabIndex = 16;
            // 
            // RxName
            // 
            this.RxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RxName.Location = new System.Drawing.Point(384, 65);
            this.RxName.Margin = new System.Windows.Forms.Padding(4);
            this.RxName.Name = "RxName";
            this.RxName.Size = new System.Drawing.Size(209, 22);
            this.RxName.TabIndex = 15;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(334, 128);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(42, 16);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Date: ";
            // 
            // drNameLabel
            // 
            this.drNameLabel.AutoSize = true;
            this.drNameLabel.Location = new System.Drawing.Point(252, 98);
            this.drNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drNameLabel.Name = "drNameLabel";
            this.drNameLabel.Size = new System.Drawing.Size(124, 16);
            this.drNameLabel.TabIndex = 12;
            this.drNameLabel.Text = "Prescribing Doctor: ";
            this.drNameLabel.Click += new System.EventHandler(this.drNameLabel_Click);
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Location = new System.Drawing.Point(252, 68);
            this.patientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(124, 16);
            this.patientNameLabel.TabIndex = 11;
            this.patientNameLabel.Text = "Prescription Name: ";
            // 
            // purpose
            // 
            this.purpose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.purpose.Location = new System.Drawing.Point(384, 155);
            this.purpose.Margin = new System.Windows.Forms.Padding(4);
            this.purpose.Name = "purpose";
            this.purpose.Size = new System.Drawing.Size(209, 22);
            this.purpose.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Purpose: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.purpose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.DrName);
            this.panel1.Controls.Add(this.RxName);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.drNameLabel);
            this.panel1.Controls.Add(this.patientNameLabel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(4, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 349);
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Request another medicine?";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(51, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 42);
            this.button3.TabIndex = 22;
            this.button3.Text = "Another request";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(166, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 42);
            this.button4.TabIndex = 23;
            this.button4.Text = "Return home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(139, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 161);
            this.panel2.TabIndex = 24;
            // 
            // UserMedicineRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UserMedicineRequest";
            this.Text = "UserMedicineRequest";
            this.Load += new System.EventHandler(this.UserMedicineRequest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox DrName;
        private System.Windows.Forms.TextBox RxName;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label drNameLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.TextBox purpose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
    }
}