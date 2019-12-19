namespace Big_Bucks_Bank_Atm
{
    partial class Transfer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.amountTo = new System.Windows.Forms.TextBox();
            this.okayBtn = new System.Windows.Forms.Button();
            this.transferAmount = new System.Windows.Forms.TextBox();
            this.amountFrom = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.amountTo);
            this.panel1.Controls.Add(this.okayBtn);
            this.panel1.Controls.Add(this.transferAmount);
            this.panel1.Controls.Add(this.amountFrom);
            this.panel1.Controls.Add(this.amountLabel);
            this.panel1.Controls.Add(this.accountLabel);
            this.panel1.Location = new System.Drawing.Point(76, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 188);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Account Number To:";
            // 
            // amountTo
            // 
            this.amountTo.Location = new System.Drawing.Point(32, 79);
            this.amountTo.MaxLength = 8;
            this.amountTo.Name = "amountTo";
            this.amountTo.Size = new System.Drawing.Size(223, 20);
            this.amountTo.TabIndex = 1;
            // 
            // okayBtn
            // 
            this.okayBtn.Location = new System.Drawing.Point(107, 145);
            this.okayBtn.Name = "okayBtn";
            this.okayBtn.Size = new System.Drawing.Size(75, 23);
            this.okayBtn.TabIndex = 4;
            this.okayBtn.Text = "&Okay";
            this.okayBtn.UseVisualStyleBackColor = true;
            this.okayBtn.Click += new System.EventHandler(this.okayBtn_Click);
            // 
            // transferAmount
            // 
            this.transferAmount.Location = new System.Drawing.Point(32, 119);
            this.transferAmount.Name = "transferAmount";
            this.transferAmount.Size = new System.Drawing.Size(224, 20);
            this.transferAmount.TabIndex = 3;
            // 
            // amountFrom
            // 
            this.amountFrom.Location = new System.Drawing.Point(31, 40);
            this.amountFrom.MaxLength = 8;
            this.amountFrom.Name = "amountFrom";
            this.amountFrom.Size = new System.Drawing.Size(224, 20);
            this.amountFrom.TabIndex = 2;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(29, 102);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(46, 13);
            this.amountLabel.TabIndex = 1;
            this.amountLabel.Text = "Amount:";
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(28, 24);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(113, 13);
            this.accountLabel.TabIndex = 0;
            this.accountLabel.Text = "Account Number from:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transfer";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 261);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountTo;
        private System.Windows.Forms.Button okayBtn;
        private System.Windows.Forms.TextBox transferAmount;
        private System.Windows.Forms.TextBox amountFrom;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label label1;
    }
}