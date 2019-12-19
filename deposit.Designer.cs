namespace Big_Bucks_Bank_Atm
{
    partial class deposit
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
            this.ok = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.accountNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ok);
            this.panel1.Controls.Add(this.amountBox);
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Controls.Add(this.labelAccount);
            this.panel1.Controls.Add(this.accountNum);
            this.panel1.Location = new System.Drawing.Point(87, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 169);
            this.panel1.TabIndex = 0;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(93, 125);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 4;
            this.ok.Text = "&Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(58, 84);
            this.amountBox.MaxLength = 8;
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(152, 20);
            this.amountBox.TabIndex = 3;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(58, 67);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(85, 13);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Deposit Amount:";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(58, 21);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(90, 13);
            this.labelAccount.TabIndex = 1;
            this.labelAccount.Text = "Account Number:";
            // 
            // accountNum
            // 
            this.accountNum.Location = new System.Drawing.Point(58, 40);
            this.accountNum.MaxLength = 8;
            this.accountNum.Name = "accountNum";
            this.accountNum.Size = new System.Drawing.Size(152, 20);
            this.accountNum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Deposit";
            // 
            // deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 261);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.TextBox accountNum;
        private System.Windows.Forms.Label label1;
    }
}