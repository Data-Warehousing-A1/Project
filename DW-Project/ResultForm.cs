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

namespace DW_Project
{
    public partial class ResultForm : Form
    {
        public ResultForm(ArrayList rows, String[] colNames)
        {
            InitializeComponent();
            SQLGridView.ColumnCount = colNames.Length;
            for (int i = 0; i < colNames.Length; i++)
            {
                SQLGridView.Columns[i].Name = colNames[i];
            }
            for (int i = 0; i < rows.Count; i++)
            {
                SQLGridView.Rows.Add((Object[])rows[i]);
            }
            BarChart.Series.Clear();
            if (colNames.Length == 2)
            {
                BarChart.Series.Add("Series");
                for (int i = 0; i < rows.Count; i++)
                {
                    BarChart.Series[0].Points.AddXY(((Object[])rows[i])[1], ((Object[])rows[i])[0]);
                }
            }
            if (colNames.Length == 3)
            {
                
                for (int i = 0; i < rows.Count; i++)
                {
                    if (BarChart.Series.IndexOf((String)((Object[])rows[i])[1]) == -1)
                    {
                        var s = new Series((String)((Object[])rows[i])[1]);
                        s.ChartType = SeriesChartType.Line;
                        BarChart.Series.Add(s);
                    }
                    BarChart.Series[(String)((Object[])rows[i])[1]].Points.AddXY(DateTime.Parse((String)((Object[])rows[i])[2]), ((Object[])rows[i])[0]);
                }
            }
        }
    }
}
