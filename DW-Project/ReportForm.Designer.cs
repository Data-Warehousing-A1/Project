namespace DW_Project
{
    partial class ReportForm
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
            this.SQLTextBox = new System.Windows.Forms.TextBox();
            this.ExecuteSQLButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SQLTextBox
            // 
            this.SQLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQLTextBox.Location = new System.Drawing.Point(39, 189);
            this.SQLTextBox.Multiline = true;
            this.SQLTextBox.Name = "SQLTextBox";
            this.SQLTextBox.Size = new System.Drawing.Size(522, 118);
            this.SQLTextBox.TabIndex = 0;
            // 
            // ExecuteSQLButton
            // 
            this.ExecuteSQLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteSQLButton.Location = new System.Drawing.Point(448, 160);
            this.ExecuteSQLButton.Name = "ExecuteSQLButton";
            this.ExecuteSQLButton.Size = new System.Drawing.Size(113, 23);
            this.ExecuteSQLButton.TabIndex = 2;
            this.ExecuteSQLButton.Text = "Execute";
            this.ExecuteSQLButton.UseVisualStyleBackColor = true;
            this.ExecuteSQLButton.Click += new System.EventHandler(this.ExecuteSQLButtonClick);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 346);
            this.Controls.Add(this.ExecuteSQLButton);
            this.Controls.Add(this.SQLTextBox);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SQLTextBox;
        private System.Windows.Forms.Button ExecuteSQLButton;
    }
}