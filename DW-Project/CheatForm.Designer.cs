namespace DW_Project
{
    partial class CheatForm
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
            this.cheatText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cheatText
            // 
            this.cheatText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cheatText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatText.Location = new System.Drawing.Point(0, -1);
            this.cheatText.Name = "cheatText";
            this.cheatText.ReadOnly = true;
            this.cheatText.Size = new System.Drawing.Size(449, 260);
            this.cheatText.TabIndex = 0;
            this.cheatText.Text = "";
            // 
            // CheatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 262);
            this.Controls.Add(this.cheatText);
            this.Name = "CheatForm";
            this.Text = "Table Names";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox cheatText;
    }
}