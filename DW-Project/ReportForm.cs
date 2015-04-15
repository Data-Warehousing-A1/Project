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
using System.Data.SqlClient;


namespace DW_Project
{
    public partial class ReportForm : Form
    {

        public ReportForm()
        {
            InitializeComponent();            
        }

        private void ExecuteSQLButtonClick(object sender, EventArgs e)
        {
            var connection = Factory.getNewDBConnection();

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("w/e");
            }
            finally
            {
                connection.Close();
            }
            try
            {
                connection.Open();
                var command = new SqlCommand(SQLTextBox.Text, connection);
                var reader = command.ExecuteReader();
                try
                {
                    var readerRows = new ArrayList();
                    String[] colsNames = null;
                    if (reader.Read())
                    {
                        colsNames = new String[reader.FieldCount];
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            colsNames[i] = reader.GetName(i);
                        }
                    }

                    do
                    {
                        var arr = new Object[reader.FieldCount];
                        reader.GetValues(arr);
                        readerRows.Add(arr);
                    } while (reader.Read());
                    var resultForm = new ResultForm(readerRows, colsNames);
                    resultForm.Show();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
                finally
                {
                    reader.Close();
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
