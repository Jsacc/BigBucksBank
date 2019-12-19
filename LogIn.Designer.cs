namespace Big_Bucks_Bank_Atm
{
    partial class LogIn
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
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.TextBox();
            this.UserPin = new System.Windows.Forms.TextBox();
            this.btnBox = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.logInBTN = new System.Windows.Forms.Button();
            this.pWord = new System.Windows.Forms.Label();
            this.uName = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.GroupBox();
            this.btnBox.SuspendLayout();
            this.inputBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompanyName
            // 
            this.CompanyName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyName.CausesValidation = false;
            this.CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName.Location = new System.Drawing.Point(132, 53);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.ShortcutsEnabled = false;
            this.CompanyName.Size = new System.Drawing.Size(173, 15);
            this.CompanyName.TabIndex = 0;
            this.CompanyName.TabStop = false;
            this.CompanyName.Text = "Big Bucks Bank";
            this.CompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserID
            // 
            this.UserID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.Location = new System.Drawing.Point(0, 42);
            this.UserID.MaxLength = 8;
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(333, 22);
            this.UserID.TabIndex = 1;
            // 
            // UserPin
            // 
            this.UserPin.AcceptsTab = true;
            this.UserPin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserPin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPin.Location = new System.Drawing.Point(0, 85);
            this.UserPin.MaxLength = 4;
            this.UserPin.Name = "UserPin";
            this.UserPin.Size = new System.Drawing.Size(333, 22);
            this.UserPin.TabIndex = 2;
            this.UserPin.UseSystemPasswordChar = true;
            // 
            // btnBox
            // 
            this.btnBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBox.AutoSize = true;
            this.btnBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBox.CausesValidation = false;
            this.btnBox.Controls.Add(this.cancelBtn);
            this.btnBox.Controls.Add(this.logInBTN);
            this.btnBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox.Location = new System.Drawing.Point(132, 196);
            this.btnBox.Name = "btnBox";
            this.btnBox.Size = new System.Drawing.Size(200, 61);
            this.btnBox.TabIndex = 0;
            this.btnBox.TabStop = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(111, 19);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(83, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // logInBTN
            // 
            this.logInBTN.Location = new System.Drawing.Point(6, 19);
            this.logInBTN.Name = "logInBTN";
            this.logInBTN.Size = new System.Drawing.Size(83, 23);
            this.logInBTN.TabIndex = 0;
            this.logInBTN.UseVisualStyleBackColor = true;
            this.logInBTN.Click += new System.EventHandler(this.logInBTN_Click);
            // 
            // pWord
            // 
            this.pWord.AutoSize = true;
            this.pWord.Location = new System.Drawing.Point(6, 69);
            this.pWord.Name = "pWord";
            this.pWord.Size = new System.Drawing.Size(56, 13);
            this.pWord.TabIndex = 3;
            this.pWord.Text = "Password:";
            // 
            // uName
            // 
            this.uName.AutoSize = true;
            this.uName.Location = new System.Drawing.Point(8, 26);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(58, 13);
            this.uName.TabIndex = 4;
            this.uName.Text = "Username:";
            // 
            // inputBox
            // 
            this.inputBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputBox.AutoSize = true;
            this.inputBox.Controls.Add(this.UserPin);
            this.inputBox.Controls.Add(this.pWord);
            this.inputBox.Controls.Add(this.uName);
            this.inputBox.Controls.Add(this.UserID);
            this.inputBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputBox.Location = new System.Drawing.Point(54, 74);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(333, 135);
            this.inputBox.TabIndex = 5;
            this.inputBox.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 269);
            this.ControlBox = false;
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.btnBox);
            this.Controls.Add(this.CompanyName);
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.btnBox.ResumeLayout(false);
            this.inputBox.ResumeLayout(false);
            this.inputBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CompanyName;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.TextBox UserPin;
        private System.Windows.Forms.GroupBox btnBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button logInBTN;
        private System.Windows.Forms.Label pWord;
        private System.Windows.Forms.Label uName;
        private System.Windows.Forms.GroupBox inputBox;
    }
}

