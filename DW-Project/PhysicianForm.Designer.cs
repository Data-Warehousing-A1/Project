namespace DW_Project
{
    partial class PhysicianForm
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
            this.backBut = new System.Windows.Forms.Button();
            this.attachBut = new System.Windows.Forms.Button();
            this.noteBox = new System.Windows.Forms.RichTextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.reportList = new System.Windows.Forms.ListBox();
            this.causeLabel = new System.Windows.Forms.Label();
            this.causeText = new System.Windows.Forms.TextBox();
            this.symtomLabel = new System.Windows.Forms.Label();
            this.symtomText = new System.Windows.Forms.TextBox();
            this.viewButt = new System.Windows.Forms.Button();
            this.allCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // backBut
            // 
            this.backBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backBut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backBut.Location = new System.Drawing.Point(730, 431);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(80, 30);
            this.backBut.TabIndex = 13;
            this.backBut.Text = "Back";
            this.backBut.UseVisualStyleBackColor = true;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // attachBut
            // 
            this.attachBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attachBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.attachBut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.attachBut.Location = new System.Drawing.Point(73, 431);
            this.attachBut.Name = "attachBut";
            this.attachBut.Size = new System.Drawing.Size(80, 30);
            this.attachBut.TabIndex = 14;
            this.attachBut.Text = "Attach";
            this.attachBut.UseVisualStyleBackColor = true;
            this.attachBut.Click += new System.EventHandler(this.attachBut_Click);
            // 
            // noteBox
            // 
            this.noteBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteBox.Location = new System.Drawing.Point(490, 60);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(562, 343);
            this.noteBox.TabIndex = 15;
            this.noteBox.Text = "";
            // 
            // noteLabel
            // 
            this.noteLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(699, 21);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(138, 22);
            this.noteLabel.TabIndex = 16;
            this.noteLabel.Text = "Type Note Here";
            // 
            // reportList
            // 
            this.reportList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.reportList.FormattingEnabled = true;
            this.reportList.ItemHeight = 15;
            this.reportList.Location = new System.Drawing.Point(23, 60);
            this.reportList.Name = "reportList";
            this.reportList.Size = new System.Drawing.Size(410, 199);
            this.reportList.TabIndex = 17;
            this.reportList.SelectedIndexChanged += new System.EventHandler(this.reportList_SelectedIndexChanged);
            // 
            // causeLabel
            // 
            this.causeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.causeLabel.AutoSize = true;
            this.causeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.causeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.causeLabel.Location = new System.Drawing.Point(182, 352);
            this.causeLabel.Name = "causeLabel";
            this.causeLabel.Size = new System.Drawing.Size(71, 22);
            this.causeLabel.TabIndex = 21;
            this.causeLabel.Text = "Causes";
            // 
            // causeText
            // 
            this.causeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.causeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.causeText.Location = new System.Drawing.Point(23, 377);
            this.causeText.Name = "causeText";
            this.causeText.Size = new System.Drawing.Size(416, 26);
            this.causeText.TabIndex = 20;
            // 
            // symtomLabel
            // 
            this.symtomLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.symtomLabel.AutoSize = true;
            this.symtomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.symtomLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.symtomLabel.Location = new System.Drawing.Point(179, 298);
            this.symtomLabel.Name = "symtomLabel";
            this.symtomLabel.Size = new System.Drawing.Size(93, 22);
            this.symtomLabel.TabIndex = 19;
            this.symtomLabel.Text = "Symptoms";
            // 
            // symtomText
            // 
            this.symtomText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.symtomText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.symtomText.Location = new System.Drawing.Point(23, 323);
            this.symtomText.Name = "symtomText";
            this.symtomText.Size = new System.Drawing.Size(413, 26);
            this.symtomText.TabIndex = 18;
            // 
            // viewButt
            // 
            this.viewButt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.viewButt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viewButt.Location = new System.Drawing.Point(271, 431);
            this.viewButt.Name = "viewButt";
            this.viewButt.Size = new System.Drawing.Size(80, 30);
            this.viewButt.TabIndex = 22;
            this.viewButt.Text = "View";
            this.viewButt.UseVisualStyleBackColor = true;
            this.viewButt.Click += new System.EventHandler(this.viewButt_Click);
            // 
            // allCheck
            // 
            this.allCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allCheck.AutoSize = true;
            this.allCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.allCheck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.allCheck.Location = new System.Drawing.Point(23, 265);
            this.allCheck.Name = "allCheck";
            this.allCheck.Size = new System.Drawing.Size(89, 24);
            this.allCheck.TabIndex = 23;
            this.allCheck.Text = "Show All";
            this.allCheck.UseVisualStyleBackColor = true;
            this.allCheck.CheckedChanged += new System.EventHandler(this.allCheck_CheckedChanged);
            // 
            // PhysicianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 521);
            this.Controls.Add(this.allCheck);
            this.Controls.Add(this.viewButt);
            this.Controls.Add(this.causeLabel);
            this.Controls.Add(this.causeText);
            this.Controls.Add(this.symtomLabel);
            this.Controls.Add(this.symtomText);
            this.Controls.Add(this.reportList);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.attachBut);
            this.Controls.Add(this.backBut);
            this.Name = "PhysicianForm";
            this.Text = "PhysicianForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.Button attachBut;
        private System.Windows.Forms.RichTextBox noteBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.ListBox reportList;
        private System.Windows.Forms.Label causeLabel;
        private System.Windows.Forms.TextBox causeText;
        private System.Windows.Forms.Label symtomLabel;
        private System.Windows.Forms.TextBox symtomText;
        private System.Windows.Forms.Button viewButt;
        private System.Windows.Forms.CheckBox allCheck;

    }
}