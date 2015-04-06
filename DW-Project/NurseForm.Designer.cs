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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseForm));
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
            this.physLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.phyCombo = new System.Windows.Forms.ComboBox();
            this.nurseCombo = new System.Windows.Forms.ComboBox();
            this.disrepinfoTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBut
            // 
            resources.ApplyResources(this.backBut, "backBut");
            this.backBut.Name = "backBut";
            this.backBut.UseVisualStyleBackColor = true;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // selectBut
            // 
            resources.ApplyResources(this.selectBut, "selectBut");
            this.selectBut.Name = "selectBut";
            this.selectBut.UseVisualStyleBackColor = true;
            this.selectBut.Click += new System.EventHandler(this.selectBut_Click);
            // 
            // enterBut
            // 
            resources.ApplyResources(this.enterBut, "enterBut");
            this.enterBut.Name = "enterBut";
            this.enterBut.UseVisualStyleBackColor = true;
            this.enterBut.Click += new System.EventHandler(this.enterBut_Click);
            // 
            // disrepinfoTable
            // 
            this.disrepinfoTable.AllowDrop = true;
            resources.ApplyResources(this.disrepinfoTable, "disrepinfoTable");
            this.disrepinfoTable.Controls.Add(this.startDate, 0, 1);
            this.disrepinfoTable.Controls.Add(this.startrangeLabel, 0, 0);
            this.disrepinfoTable.Controls.Add(this.endDate, 0, 1);
            this.disrepinfoTable.Controls.Add(this.endRangeLabel, 1, 0);
            this.disrepinfoTable.Name = "disrepinfoTable";
            // 
            // startDate
            // 
            resources.ApplyResources(this.startDate, "startDate");
            this.startDate.Name = "startDate";
            // 
            // startrangeLabel
            // 
            resources.ApplyResources(this.startrangeLabel, "startrangeLabel");
            this.startrangeLabel.Name = "startrangeLabel";
            // 
            // endDate
            // 
            resources.ApplyResources(this.endDate, "endDate");
            this.endDate.Name = "endDate";
            // 
            // endRangeLabel
            // 
            resources.ApplyResources(this.endRangeLabel, "endRangeLabel");
            this.endRangeLabel.Name = "endRangeLabel";
            // 
            // allCheck
            // 
            resources.ApplyResources(this.allCheck, "allCheck");
            this.allCheck.Name = "allCheck";
            this.allCheck.UseVisualStyleBackColor = true;
            // 
            // reportList
            // 
            resources.ApplyResources(this.reportList, "reportList");
            this.reportList.FormattingEnabled = true;
            this.reportList.Items.AddRange(new object[] {
            resources.GetString("reportList.Items")});
            this.reportList.Name = "reportList";
            // 
            // physLabel
            // 
            resources.ApplyResources(this.physLabel, "physLabel");
            this.physLabel.Name = "physLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.physLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.phyCombo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nurseCombo, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // phyCombo
            // 
            resources.ApplyResources(this.phyCombo, "phyCombo");
            this.phyCombo.FormattingEnabled = true;
            this.phyCombo.Name = "phyCombo";
            // 
            // nurseCombo
            // 
            resources.ApplyResources(this.nurseCombo, "nurseCombo");
            this.nurseCombo.FormattingEnabled = true;
            this.nurseCombo.Name = "nurseCombo";
            // 
            // NurseForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.reportList);
            this.Controls.Add(this.allCheck);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.selectBut);
            this.Controls.Add(this.enterBut);
            this.Controls.Add(this.disrepinfoTable);
            this.Name = "NurseForm";
            this.disrepinfoTable.ResumeLayout(false);
            this.disrepinfoTable.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label physLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox phyCombo;
        private System.Windows.Forms.ComboBox nurseCombo;
    }
}