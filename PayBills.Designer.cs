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
            this.payButton = new System.Windows.Forms.Button();
            this.OpenBillsCheckbox = new System.Windows.Forms.CheckedListBox();
            this.Amount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentHistoryButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.historyView = new System.Windows.Forms.ListBox();
            this.MenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open Bills";
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(44, 342);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(186, 58);
            this.payButton.TabIndex = 2;
            this.payButton.Text = "Pay Selected Bill(s)";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenBillsCheckbox
            // 
            this.OpenBillsCheckbox.FormattingEnabled = true;
            this.OpenBillsCheckbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OpenBillsCheckbox.Location = new System.Drawing.Point(44, 53);
            this.OpenBillsCheckbox.Name = "OpenBillsCheckbox";
            this.OpenBillsCheckbox.Size = new System.Drawing.Size(186, 225);
            this.OpenBillsCheckbox.TabIndex = 3;
            this.OpenBillsCheckbox.ThreeDCheckBoxes = true;
            this.OpenBillsCheckbox.SelectedIndexChanged += new System.EventHandler(this.OpenBillsCheckbox_SelectedIndexChanged);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(178, 34);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(52, 16);
            this.Amount.TabIndex = 4;
            this.Amount.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // paymentHistoryButton
            // 
            this.paymentHistoryButton.Location = new System.Drawing.Point(293, 284);
            this.paymentHistoryButton.Name = "paymentHistoryButton";
            this.paymentHistoryButton.Size = new System.Drawing.Size(183, 58);
            this.paymentHistoryButton.TabIndex = 6;
            this.paymentHistoryButton.Text = "View Payment History";
            this.paymentHistoryButton.UseVisualStyleBackColor = true;
            this.paymentHistoryButton.Click += new System.EventHandler(this.paymentHistoryButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total: ";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(112, 304);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 25);
            this.totalLabel.TabIndex = 10;
            // 
            // historyView
            // 
            this.historyView.FormattingEnabled = true;
            this.historyView.ItemHeight = 16;
            this.historyView.Location = new System.Drawing.Point(293, 50);
            this.historyView.Name = "historyView";
            this.historyView.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.historyView.Size = new System.Drawing.Size(183, 228);
            this.historyView.TabIndex = 11;
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(293, 342);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(183, 58);
            this.MenuButton.TabIndex = 12;
            this.MenuButton.Text = "Main Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // PayBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 412);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.historyView);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paymentHistoryButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.OpenBillsCheckbox);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.label1);
            this.Name = "PayBills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayBills";
            this.Load += new System.EventHandler(this.PayBills_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.CheckedListBox OpenBillsCheckbox;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button paymentHistoryButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.ListBox historyView;
        private System.Windows.Forms.Button MenuButton;
    }
}