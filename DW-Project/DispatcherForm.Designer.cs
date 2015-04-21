namespace DW_Project
{
    partial class DispatcherForm
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
            this.browseBut = new System.Windows.Forms.Button();
            this.browseLabel = new System.Windows.Forms.Label();
            this.backBut = new System.Windows.Forms.Button();
            this.SDKLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browseBut
            // 
            this.browseBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browseBut.Location = new System.Drawing.Point(203, 243);
            this.browseBut.Name = "browseBut";
            this.browseBut.Size = new System.Drawing.Size(131, 43);
            this.browseBut.TabIndex = 0;
            this.browseBut.Text = "Browse";
            this.browseBut.UseVisualStyleBackColor = true;
            this.browseBut.Click += new System.EventHandler(this.browse_Click);
            // 
            // browseLabel
            // 
            this.browseLabel.AutoSize = true;
            this.browseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseLabel.Location = new System.Drawing.Point(259, 187);
            this.browseLabel.Name = "browseLabel";
            this.browseLabel.Size = new System.Drawing.Size(203, 22);
            this.browseLabel.TabIndex = 1;
            this.browseLabel.Text = "Enter the .csv file to add";
            this.browseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backBut
            // 
            this.backBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBut.Location = new System.Drawing.Point(377, 243);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(131, 43);
            this.backBut.TabIndex = 2;
            this.backBut.Text = "Back";
            this.backBut.UseVisualStyleBackColor = true;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // SDKLabel
            // 
            this.SDKLabel.AutoSize = true;
            this.SDKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDKLabel.Location = new System.Drawing.Point(29, 396);
            this.SDKLabel.Name = "SDKLabel";
            this.SDKLabel.Size = new System.Drawing.Size(692, 22);
            this.SDKLabel.TabIndex = 3;
            this.SDKLabel.Text = "Please make sure you have sql server and the necessary SDK tools to run a .DTS fi" +
    "le";
            this.SDKLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DispatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 427);
            this.Controls.Add(this.SDKLabel);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.browseLabel);
            this.Controls.Add(this.browseBut);
            this.Name = "DispatcherForm";
            this.Text = "Dispatcher";
            this.Load += new System.EventHandler(this.DispatcherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseBut;
        private System.Windows.Forms.Label browseLabel;
        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.Label SDKLabel;

    }
}