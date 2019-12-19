namespace Big_Bucks_Bank_Atm
{
    partial class withDrawalForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.okayBtn = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.accountNumBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Withdrawal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.okayBtn);
            this.panel1.Controls.Add(this.amountBox);
            this.panel1.Controls.Add(this.accountNumBox);
            this.panel1.Controls.Add(this.amountLabel);
            this.panel1.Controls.Add(this.accountLabel);
            this.panel1.Location = new System.Drawing.Point(79, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 161);
            this.panel1.TabIndex = 1;
            // 
            // okayBtn
            // 
            this.okayBtn.Location = new System.Drawing.Point(96, 119);
            this.okayBtn.Name = "okayBtn";
            this.okayBtn.Size = new System.Drawing.Size(75, 23);
            this.okayBtn.TabIndex = 4;
            this.okayBtn.Text = "&Okay";
            this.okayBtn.UseVisualStyleBackColor = true;
            this.okayBtn.Click += new System.EventHandler(this.okayBtn_Click);
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(21, 93);
            this.amountBox.MaxLength = 8;
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(224, 20);
            this.amountBox.TabIndex = 3;
            // 
            // accountNumBox
            // 
            this.accountNumBox.Location = new System.Drawing.Point(21, 46);
            this.accountNumBox.MaxLength = 8;
            this.accountNumBox.Name = "accountNumBox";
            this.accountNumBox.Size = new System.Drawing.Size(224, 20);
            this.accountNumBox.TabIndex = 2;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(18, 76);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(46, 13);
            this.amountLabel.TabIndex = 1;
            this.amountLabel.Text = "Amount:";
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(18, 30);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(90, 13);
            this.accountLabel.TabIndex = 0;
            this.accountLabel.Text = "Account Number:";
            // 
            // withDrawalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 261);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "withDrawalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.TextBox accountNumBox;
        private System.Windows.Forms.Button okayBtn;
    }
}