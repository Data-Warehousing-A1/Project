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
            this.SQLGridView = new System.Windows.Forms.DataGridView();
            this.ShowGraphButton = new System.Windows.Forms.Button();
            this.cheatButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SQLGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SQLTextBox
            // 
            this.SQLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQLTextBox.Location = new System.Drawing.Point(39, 353);
            this.SQLTextBox.Multiline = true;
            this.SQLTextBox.Name = "SQLTextBox";
            this.SQLTextBox.Size = new System.Drawing.Size(572, 118);
            this.SQLTextBox.TabIndex = 0;
            // 
            // ExecuteSQLButton
            // 
            this.ExecuteSQLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteSQLButton.Location = new System.Drawing.Point(498, 324);
            this.ExecuteSQLButton.Name = "ExecuteSQLButton";
            this.ExecuteSQLButton.Size = new System.Drawing.Size(113, 23);
            this.ExecuteSQLButton.TabIndex = 2;
            this.ExecuteSQLButton.Text = "Execute";
            this.ExecuteSQLButton.UseVisualStyleBackColor = true;
            this.ExecuteSQLButton.Click += new System.EventHandler(this.ExecuteSQLButtonClick);
            // 
            // SQLGridView
            // 
            this.SQLGridView.AllowUserToAddRows = false;
            this.SQLGridView.AllowUserToDeleteRows = false;
            this.SQLGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQLGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SQLGridView.Location = new System.Drawing.Point(39, 12);
            this.SQLGridView.Name = "SQLGridView";
            this.SQLGridView.ReadOnly = true;
            this.SQLGridView.Size = new System.Drawing.Size(572, 306);
            this.SQLGridView.TabIndex = 3;
            // 
            // ShowGraphButton
            // 
            this.ShowGraphButton.Location = new System.Drawing.Point(375, 324);
            this.ShowGraphButton.Name = "ShowGraphButton";
            this.ShowGraphButton.Size = new System.Drawing.Size(117, 23);
            this.ShowGraphButton.TabIndex = 4;
            this.ShowGraphButton.Text = "ShowGraph";
            this.ShowGraphButton.UseVisualStyleBackColor = true;
            this.ShowGraphButton.Click += new System.EventHandler(this.ShowGraphButton_Click);
            // 
            // cheatButton
            // 
            this.cheatButton.Location = new System.Drawing.Point(252, 324);
            this.cheatButton.Name = "cheatButton";
            this.cheatButton.Size = new System.Drawing.Size(117, 23);
            this.cheatButton.TabIndex = 5;
            this.cheatButton.Text = "Cheat Sheet";
            this.cheatButton.UseVisualStyleBackColor = true;
            this.cheatButton.Click += new System.EventHandler(this.cheatButton_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 510);
            this.Controls.Add(this.cheatButton);
            this.Controls.Add(this.ShowGraphButton);
            this.Controls.Add(this.SQLGridView);
            this.Controls.Add(this.ExecuteSQLButton);
            this.Controls.Add(this.SQLTextBox);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.SQLGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SQLTextBox;
        private System.Windows.Forms.Button ExecuteSQLButton;
        private System.Windows.Forms.DataGridView SQLGridView;
        private System.Windows.Forms.Button ShowGraphButton;
        private System.Windows.Forms.Button cheatButton;
    }
}