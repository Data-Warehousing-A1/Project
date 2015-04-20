using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace DW_Project
{
    public partial class ResultForm : Form
    {
        public ResultForm(DataGridView SQLGridView)
        {
            InitializeComponent();
            BarChart.Series.Clear();
            if (SQLGridView.Columns.Count == 2)
            {
                BarChart.Series.Add("Series");
                BarChart.ChartAreas[0].AxisX.Interval = 1;
                BarChart.ChartAreas[0].AxisX.Title = SQLGridView.Columns[0].Name;
                BarChart.ChartAreas[0].AxisY.Title = SQLGridView.Columns[1].Name;
                for (int i = 0; i < SQLGridView.Rows.Count; i++)
                {
                    BarChart.Series[0].Points.AddXY(SQLGridView.Rows[i].Cells[0].Value, SQLGridView.Rows[i].Cells[1].Value);
                }
            }
            if (SQLGridView.Columns.Count == 3)
            {
                BarChart.ChartAreas[0].AxisX.Title = SQLGridView.Columns[0].Name;
                BarChart.ChartAreas[0].AxisY.Title = SQLGridView.Columns[1].Name;
                for (int i = 0; i < SQLGridView.Rows.Count; i++)
                {
                    if (BarChart.Series.IndexOf(SQLGridView.Rows[i].Cells[2].Value.ToString()) == -1)
                    {
                        var s = new Series(SQLGridView.Rows[i].Cells[2].Value.ToString());
                        s.ChartType = SeriesChartType.Line;
                        BarChart.Series.Add(s);
                    }
                    BarChart.Series[SQLGridView.Rows[i].Cells[2].Value.ToString()].Points.AddXY(SQLGridView.Rows[i].Cells[0].Value, SQLGridView.Rows[i].Cells[1].Value);
                }
            }
        }
    }
}
