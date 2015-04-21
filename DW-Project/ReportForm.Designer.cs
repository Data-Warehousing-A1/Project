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
            this.QueryComboBox = new System.Windows.Forms.ComboBox();
            this.SaveNewQueryButton = new System.Windows.Forms.Button();
            this.DeleteQueryButton = new System.Windows.Forms.Button();
            this.SaveQueryEditButton = new System.Windows.Forms.Button();
            this.TableNamesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SQLGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SQLTextBox
            // 
            this.SQLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQLTextBox.Location = new System.Drawing.Point(39, 408);
            this.SQLTextBox.Multiline = true;
            this.SQLTextBox.Name = "SQLTextBox";
            this.SQLTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SQLTextBox.Size = new System.Drawing.Size(816, 118);
            this.SQLTextBox.TabIndex = 0;
            // 
            // ExecuteSQLButton
            // 
            this.ExecuteSQLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteSQLButton.Location = new System.Drawing.Point(755, 379);
            this.ExecuteSQLButton.Name = "ExecuteSQLButton";
            this.ExecuteSQLButton.Size = new System.Drawing.Size(100, 23);
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
            this.SQLGridView.Size = new System.Drawing.Size(816, 361);
            this.SQLGridView.TabIndex = 3;
            // 
            // ShowGraphButton
            // 
            this.ShowGraphButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowGraphButton.Location = new System.Drawing.Point(649, 379);
            this.ShowGraphButton.Name = "ShowGraphButton";
            this.ShowGraphButton.Size = new System.Drawing.Size(100, 23);
            this.ShowGraphButton.TabIndex = 4;
            this.ShowGraphButton.Text = "Show Graph";
            this.ShowGraphButton.UseVisualStyleBackColor = true;
            this.ShowGraphButton.Click += new System.EventHandler(this.ShowGraphButton_Click);
            // 
            // QueryComboBox
            // 
            this.QueryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryComboBox.FormattingEnabled = true;
            this.QueryComboBox.Location = new System.Drawing.Point(39, 381);
            this.QueryComboBox.Name = "QueryComboBox";
            this.QueryComboBox.Size = new System.Drawing.Size(182, 21);
            this.QueryComboBox.TabIndex = 5;
            this.QueryComboBox.Text = "Select a Query";
            this.QueryComboBox.SelectedIndexChanged += new System.EventHandler(this.QueryComboBox_SelectedIndexChanged);
            // 
            // SaveNewQueryButton
            // 
            this.SaveNewQueryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveNewQueryButton.Location = new System.Drawing.Point(543, 379);
            this.SaveNewQueryButton.Name = "SaveNewQueryButton";
            this.SaveNewQueryButton.Size = new System.Drawing.Size(100, 23);
            this.SaveNewQueryButton.TabIndex = 6;
            this.SaveNewQueryButton.Text = "Save New Query";
            this.SaveNewQueryButton.UseVisualStyleBackColor = true;
            this.SaveNewQueryButton.Click += new System.EventHandler(this.SaveQueryButton_Click);
            // 
            // DeleteQueryButton
            // 
            this.DeleteQueryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteQueryButton.Location = new System.Drawing.Point(331, 379);
            this.DeleteQueryButton.Name = "DeleteQueryButton";
            this.DeleteQueryButton.Size = new System.Drawing.Size(100, 23);
            this.DeleteQueryButton.TabIndex = 7;
            this.DeleteQueryButton.Text = "Delete Query";
            this.DeleteQueryButton.UseVisualStyleBackColor = true;
            this.DeleteQueryButton.Click += new System.EventHandler(this.DeleteQueryButton_Click);
            // 
            // SaveQueryEditButton
            // 
            this.SaveQueryEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveQueryEditButton.Location = new System.Drawing.Point(437, 379);
            this.SaveQueryEditButton.Name = "SaveQueryEditButton";
            this.SaveQueryEditButton.Size = new System.Drawing.Size(100, 23);
            this.SaveQueryEditButton.TabIndex = 8;
            this.SaveQueryEditButton.Text = "Save Query Edit";
            this.SaveQueryEditButton.UseVisualStyleBackColor = true;
            this.SaveQueryEditButton.Click += new System.EventHandler(this.SaveQueryEditButton_Click);
            // 
            // TableNamesButton
            // 
            this.TableNamesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableNamesButton.Location = new System.Drawing.Point(225, 379);
            this.TableNamesButton.Name = "TableNamesButton";
            this.TableNamesButton.Size = new System.Drawing.Size(100, 23);
            this.TableNamesButton.TabIndex = 9;
            this.TableNamesButton.Text = "Table Names";
            this.TableNamesButton.UseVisualStyleBackColor = true;
            this.TableNamesButton.Click += new System.EventHandler(this.TableNamesButton_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 565);
            this.Controls.Add(this.TableNamesButton);
            this.Controls.Add(this.SaveQueryEditButton);
            this.Controls.Add(this.DeleteQueryButton);
            this.Controls.Add(this.SaveNewQueryButton);
            this.Controls.Add(this.QueryComboBox);
            this.Controls.Add(this.ShowGraphButton);
            this.Controls.Add(this.SQLGridView);
            this.Controls.Add(this.ExecuteSQLButton);
            this.Controls.Add(this.SQLTextBox);
            this.MinimumSize = new System.Drawing.Size(918, 370);
            this.Name = "ReportForm";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.SQLGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SQLTextBox;
        private System.Windows.Forms.Button ExecuteSQLButton;
        private System.Windows.Forms.DataGridView SQLGridView;
        private System.Windows.Forms.Button ShowGraphButton;
        private System.Windows.Forms.ComboBox QueryComboBox;
        private System.Windows.Forms.Button SaveNewQueryButton;
        private System.Windows.Forms.Button DeleteQueryButton;
        private System.Windows.Forms.Button SaveQueryEditButton;
        private System.Windows.Forms.Button TableNamesButton;
    }
}