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
            this.SuspendLayout();
            // 
            // AccountComboBox
            // 
            this.AccountComboBox.FormattingEnabled = true;
            this.AccountComboBox.Items.AddRange(new object[] {
            "Dispatcher",
            "Physician",
            "Report"});
            this.AccountComboBox.Location = new System.Drawing.Point(198, 222);
            this.AccountComboBox.Name = "AccountComboBox";
            this.AccountComboBox.Size = new System.Drawing.Size(121, 21);
            this.AccountComboBox.TabIndex = 0;
            // 
            // AccountTypeLabel
            // 
            this.AccountTypeLabel.AutoSize = true;
            this.AccountTypeLabel.Location = new System.Drawing.Point(195, 206);
            this.AccountTypeLabel.Name = "AccountTypeLabel";
            this.AccountTypeLabel.Size = new System.Drawing.Size(74, 13);
            this.AccountTypeLabel.TabIndex = 1;
            this.AccountTypeLabel.Text = "Account Type";
            // 
            // AccountConfirmationButton
            // 
            this.AccountConfirmationButton.Location = new System.Drawing.Point(198, 249);
            this.AccountConfirmationButton.Name = "AccountConfirmationButton";
            this.AccountConfirmationButton.Size = new System.Drawing.Size(121, 23);
            this.AccountConfirmationButton.TabIndex = 2;
            this.AccountConfirmationButton.Text = "Log In";
            this.AccountConfirmationButton.UseVisualStyleBackColor = true;
            this.AccountConfirmationButton.Click += new System.EventHandler(this.AccountConfirmationButton_Click);
            // 
            // StartScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 452);
            this.Controls.Add(this.AccountConfirmationButton);
            this.Controls.Add(this.AccountTypeLabel);
            this.Controls.Add(this.AccountComboBox);
            this.Name = "StartScreenForm";
            this.Text = "StartScreen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AccountComboBox;
        private System.Windows.Forms.Label AccountTypeLabel;
        private System.Windows.Forms.Button AccountConfirmationButton;

    }
}

