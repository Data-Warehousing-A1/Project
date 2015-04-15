namespace DW_Project
{
    partial class ResultForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DataTab = new System.Windows.Forms.TabPage();
            this.GraphTab = new System.Windows.Forms.TabPage();
            this.SQLGridView = new System.Windows.Forms.DataGridView();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.DataTab.SuspendLayout();
            this.GraphTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQLGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.DataTab);
            this.tabControl1.Controls.Add(this.GraphTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // DataTab
            // 
            this.DataTab.Controls.Add(this.SQLGridView);
            this.DataTab.Location = new System.Drawing.Point(4, 22);
            this.DataTab.Name = "DataTab";
            this.DataTab.Padding = new System.Windows.Forms.Padding(3);
            this.DataTab.Size = new System.Drawing.Size(644, 424);
            this.DataTab.TabIndex = 0;
            this.DataTab.Text = "Data";
            this.DataTab.UseVisualStyleBackColor = true;
            // 
            // GraphTab
            // 
            this.GraphTab.Controls.Add(this.BarChart);
            this.GraphTab.Location = new System.Drawing.Point(4, 22);
            this.GraphTab.Name = "GraphTab";
            this.GraphTab.Padding = new System.Windows.Forms.Padding(3);
            this.GraphTab.Size = new System.Drawing.Size(644, 424);
            this.GraphTab.TabIndex = 1;
            this.GraphTab.Text = "Graph";
            this.GraphTab.UseVisualStyleBackColor = true;
            // 
            // SQLGridView
            // 
            this.SQLGridView.AllowUserToAddRows = false;
            this.SQLGridView.AllowUserToDeleteRows = false;
            this.SQLGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQLGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SQLGridView.Location = new System.Drawing.Point(6, 6);
            this.SQLGridView.Name = "SQLGridView";
            this.SQLGridView.ReadOnly = true;
            this.SQLGridView.Size = new System.Drawing.Size(632, 412);
            this.SQLGridView.TabIndex = 2;
            // 
            // BarChart
            // 
            chartArea1.Name = "ChartArea1";
            this.BarChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BarChart.Legends.Add(legend1);
            this.BarChart.Location = new System.Drawing.Point(6, 6);
            this.BarChart.Name = "BarChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.BarChart.Series.Add(series1);
            this.BarChart.Size = new System.Drawing.Size(632, 412);
            this.BarChart.TabIndex = 0;
            this.BarChart.Text = "chart1";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 474);
            this.Controls.Add(this.tabControl1);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.tabControl1.ResumeLayout(false);
            this.DataTab.ResumeLayout(false);
            this.GraphTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SQLGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DataTab;
        private System.Windows.Forms.TabPage GraphTab;
        private System.Windows.Forms.DataGridView SQLGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
    }
}