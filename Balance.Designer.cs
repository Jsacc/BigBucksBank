namespace Big_Bucks_Bank_Atm
{
    partial class Balance
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
            this.button1 = new System.Windows.Forms.Button();
            this.savingsBal = new System.Windows.Forms.Button();
            this.checkingBal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.savingsBal);
            this.panel1.Controls.Add(this.checkingBal);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 127);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // savingsBal
            // 
            this.savingsBal.Location = new System.Drawing.Point(18, 55);
            this.savingsBal.Name = "savingsBal";
            this.savingsBal.Size = new System.Drawing.Size(75, 23);
            this.savingsBal.TabIndex = 1;
            this.savingsBal.Text = "&Savings";
            this.savingsBal.UseVisualStyleBackColor = true;
            this.savingsBal.Click += new System.EventHandler(this.savingsBal_Click);
            // 
            // checkingBal
            // 
            this.checkingBal.Location = new System.Drawing.Point(18, 26);
            this.checkingBal.Name = "checkingBal";
            this.checkingBal.Size = new System.Drawing.Size(75, 23);
            this.checkingBal.TabIndex = 0;
            this.checkingBal.Text = "&Checking";
            this.checkingBal.UseVisualStyleBackColor = true;
            this.checkingBal.Click += new System.EventHandler(this.checkingBal_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 151);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button savingsBal;
        private System.Windows.Forms.Button checkingBal;
        private System.Windows.Forms.Button button1;
    }
}