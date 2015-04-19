namespace DW_Project
{
    partial class StartScreenForm
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
            this.AccountComboBox = new System.Windows.Forms.ComboBox();
            this.AccountTypeLabel = new System.Windows.Forms.Label();
            this.AccountConfirmationButton = new System.Windows.Forms.Button();
            this.userText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AccountComboBox
            // 
            this.AccountComboBox.FormattingEnabled = true;
            this.AccountComboBox.Items.AddRange(new object[] {
            "Dispatcher",
            "Physician",
            "Report",
            "Nurse"});
            this.AccountComboBox.Location = new System.Drawing.Point(45, 53);
            this.AccountComboBox.Name = "AccountComboBox";
            this.AccountComboBox.Size = new System.Drawing.Size(121, 21);
            this.AccountComboBox.TabIndex = 0;
            // 
            // AccountTypeLabel
            // 
            this.AccountTypeLabel.AutoSize = true;
            this.AccountTypeLabel.Location = new System.Drawing.Point(42, 37);
            this.AccountTypeLabel.Name = "AccountTypeLabel";
            this.AccountTypeLabel.Size = new System.Drawing.Size(74, 13);
            this.AccountTypeLabel.TabIndex = 1;
            this.AccountTypeLabel.Text = "Account Type";
            // 
            // AccountConfirmationButton
            // 
            this.AccountConfirmationButton.Location = new System.Drawing.Point(45, 177);
            this.AccountConfirmationButton.Name = "AccountConfirmationButton";
            this.AccountConfirmationButton.Size = new System.Drawing.Size(121, 23);
            this.AccountConfirmationButton.TabIndex = 2;
            this.AccountConfirmationButton.Text = "Log In";
            this.AccountConfirmationButton.UseVisualStyleBackColor = true;
            this.AccountConfirmationButton.Click += new System.EventHandler(this.AccountConfirmationButton_Click);
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(45, 99);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(121, 20);
            this.userText.TabIndex = 3;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(45, 146);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(121, 20);
            this.passText.TabIndex = 4;
            this.passText.UseSystemPasswordChar = true;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(45, 80);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(49, 13);
            this.UsernameLabel.TabIndex = 5;
            this.UsernameLabel.Text = "Usernum";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(45, 126);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password";
            // 
            // StartScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 247);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.AccountConfirmationButton);
            this.Controls.Add(this.AccountTypeLabel);
            this.Controls.Add(this.AccountComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(233, 285);
            this.MinimumSize = new System.Drawing.Size(233, 285);
            this.Name = "StartScreenForm";
            this.Text = "StartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AccountComboBox;
        private System.Windows.Forms.Label AccountTypeLabel;
        private System.Windows.Forms.Button AccountConfirmationButton;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;

    }
}

