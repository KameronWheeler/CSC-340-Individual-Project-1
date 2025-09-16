namespace Individual_Project
{
    partial class PayBills
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
            this.button1 = new System.Windows.Forms.Button();
            this.OpenBillsCheckbox = new System.Windows.Forms.CheckedListBox();
            this.Amount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open Bills";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pay Selected Bill(s)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OpenBillsCheckbox
            // 
            this.OpenBillsCheckbox.FormattingEnabled = true;
            this.OpenBillsCheckbox.Items.AddRange(new object[] {
            "09/12/2025\t$500",
            "07/20/2025\t$300"});
            this.OpenBillsCheckbox.Location = new System.Drawing.Point(64, 112);
            this.OpenBillsCheckbox.Name = "OpenBillsCheckbox";
            this.OpenBillsCheckbox.Size = new System.Drawing.Size(158, 293);
            this.OpenBillsCheckbox.TabIndex = 3;
            this.OpenBillsCheckbox.ThreeDCheckBoxes = true;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(170, 93);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(52, 16);
            this.Amount.TabIndex = 4;
            this.Amount.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(524, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 58);
            this.button2.TabIndex = 6;
            this.button2.Text = "View Payment History";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(557, 112);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(183, 218);
            this.listView1.TabIndex = 7;
            this.listView1.TileSize = new System.Drawing.Size(1, 1);
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // PayBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.OpenBillsCheckbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "PayBills";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox OpenBillsCheckbox;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
    }
}