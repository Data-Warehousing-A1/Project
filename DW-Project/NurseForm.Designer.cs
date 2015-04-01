namespace DW_Project
{
    partial class NurseForm
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
            this.selectBut = new System.Windows.Forms.Button();
            this.enterBut = new System.Windows.Forms.Button();
            this.disrepinfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.startrangeLabel = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.endRangeLabel = new System.Windows.Forms.Label();
            this.allCheck = new System.Windows.Forms.CheckBox();
            this.reportList = new System.Windows.Forms.ListBox();
            this.disrepinfoTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBut
            // 
            this.backBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBut.Location = new System.Drawing.Point(599, 477);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(80, 30);
            this.backBut.TabIndex = 9;
            this.backBut.Text = "Back";
            this.backBut.UseVisualStyleBackColor = true;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // selectBut
            // 
            this.selectBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBut.Location = new System.Drawing.Point(834, 386);
            this.selectBut.Name = "selectBut";
            this.selectBut.Size = new System.Drawing.Size(80, 30);
            this.selectBut.TabIndex = 8;
            this.selectBut.Text = "Select";
            this.selectBut.UseVisualStyleBackColor = true;
            this.selectBut.Click += new System.EventHandler(this.selectBut_Click);
            // 
            // enterBut
            // 
            this.enterBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBut.Location = new System.Drawing.Point(332, 386);
            this.enterBut.Name = "enterBut";
            this.enterBut.Size = new System.Drawing.Size(80, 30);
            this.enterBut.TabIndex = 7;
            this.enterBut.Text = "Enter";
            this.enterBut.UseVisualStyleBackColor = true;
            this.enterBut.Click += new System.EventHandler(this.enterBut_Click);
            // 
            // disrepinfoTable
            // 
            this.disrepinfoTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.disrepinfoTable.ColumnCount = 2;
            this.disrepinfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.84404F));
            this.disrepinfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.15596F));
            this.disrepinfoTable.Controls.Add(this.startDate, 0, 1);
            this.disrepinfoTable.Controls.Add(this.startrangeLabel, 0, 0);
            this.disrepinfoTable.Controls.Add(this.endDate, 0, 1);
            this.disrepinfoTable.Controls.Add(this.endRangeLabel, 1, 0);
            this.disrepinfoTable.Location = new System.Drawing.Point(64, 56);
            this.disrepinfoTable.Name = "disrepinfoTable";
            this.disrepinfoTable.RowCount = 2;
            this.disrepinfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.disrepinfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.disrepinfoTable.Size = new System.Drawing.Size(587, 66);
            this.disrepinfoTable.TabIndex = 5;
            // 
            // startDate
            // 
            this.startDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Location = new System.Drawing.Point(14, 34);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(281, 26);
            this.startDate.TabIndex = 3;
            // 
            // startrangeLabel
            // 
            this.startrangeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startrangeLabel.AutoSize = true;
            this.startrangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startrangeLabel.Location = new System.Drawing.Point(97, 3);
            this.startrangeLabel.Name = "startrangeLabel";
            this.startrangeLabel.Size = new System.Drawing.Size(116, 22);
            this.startrangeLabel.TabIndex = 0;
            this.startrangeLabel.Text = "Start Range: ";
            // 
            // endDate
            // 
            this.endDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Location = new System.Drawing.Point(317, 34);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(262, 26);
            this.endDate.TabIndex = 1;
            // 
            // endRangeLabel
            // 
            this.endRangeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endRangeLabel.AutoSize = true;
            this.endRangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endRangeLabel.Location = new System.Drawing.Point(393, 3);
            this.endRangeLabel.Name = "endRangeLabel";
            this.endRangeLabel.Size = new System.Drawing.Size(110, 22);
            this.endRangeLabel.TabIndex = 2;
            this.endRangeLabel.Text = "End Range: ";
            // 
            // allCheck
            // 
            this.allCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allCheck.AutoSize = true;
            this.allCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCheck.Location = new System.Drawing.Point(64, 128);
            this.allCheck.Name = "allCheck";
            this.allCheck.Size = new System.Drawing.Size(89, 24);
            this.allCheck.TabIndex = 10;
            this.allCheck.Text = "Show All";
            this.allCheck.UseVisualStyleBackColor = true;
            // 
            // reportList
            // 
            this.reportList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportList.FormattingEnabled = true;
            this.reportList.ItemHeight = 15;
            this.reportList.Items.AddRange(new object[] {
            "Date, Unit, County, top symtom, top cause",
            "test, test, test, test, test"});
            this.reportList.Location = new System.Drawing.Point(766, 56);
            this.reportList.Name = "reportList";
            this.reportList.Size = new System.Drawing.Size(250, 289);
            this.reportList.TabIndex = 11;
            // 
            // NurseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 568);
            this.Controls.Add(this.reportList);
            this.Controls.Add(this.allCheck);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.selectBut);
            this.Controls.Add(this.enterBut);
            this.Controls.Add(this.disrepinfoTable);
            this.Name = "NurseForm";
            this.Text = "NurseForm";
            this.disrepinfoTable.ResumeLayout(false);
            this.disrepinfoTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.Button selectBut;
        private System.Windows.Forms.Button enterBut;
        private System.Windows.Forms.TableLayoutPanel disrepinfoTable;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label startrangeLabel;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label endRangeLabel;
        private System.Windows.Forms.CheckBox allCheck;
        private System.Windows.Forms.ListBox reportList;
    }
}