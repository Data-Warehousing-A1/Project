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
using System.IO;


namespace DW_Project
{
    public partial class ReportForm : Form
    {

        private List<SavedProc> savedProcs = new List<SavedProc>();
        private const string serializationFile = "SavedProcs.bin";

        public ReportForm()
        {
            InitializeComponent();
            ShowGraphButton.Enabled = false;
            
            if(File.Exists(serializationFile))
            {
                using (Stream stream = File.Open(serializationFile, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    savedProcs = (List<SavedProc>)bformatter.Deserialize(stream);
                }
                if (savedProcs.Count != 0)
                {
                    foreach (SavedProc it in savedProcs)
                    {
                        QueryComboBox.Items.Add(it);
                    }
                }
            }
            else
            {
                SaveProcFile();
            }
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
                    SQLGridView.Rows.Clear();
                    SQLGridView.ColumnCount = reader.FieldCount;
                    if (reader.Read())
                    {
                        if (reader.FieldCount == 2 || reader.FieldCount == 3)
                        {
                            double unused;
                            if(double.TryParse(reader.GetValue(1).ToString(), out unused)){
                                ShowGraphButton.Enabled = true;
                            }
                            else{
                                ShowGraphButton.Enabled = false;
                            }
                        }
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            SQLGridView.Columns[i].Name = reader.GetName(i);
                        }
                    }

                    do
                    {
                        var arr = new Object[reader.FieldCount];
                        reader.GetValues(arr);
                        SQLGridView.Rows.Add(arr);
                    } while (reader.Read());
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

        private void ShowGraphButton_Click(object sender, EventArgs e)
        {
            var theGraph = new ResultForm(SQLGridView);
            theGraph.Show();
        }

        private void QueryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLTextBox.Clear();
            //should be a reference to a member of the "savedProc" list
            var proc = (SavedProc)QueryComboBox.SelectedItem;
            SQLTextBox.Text = proc.proc;
        }

        private void SaveQueryButton_Click(object sender, EventArgs e)
        {
            string name;
            var getNameForm = new NameQuery();
            getNameForm.ShowDialog(out name);
            if (name != "")
            {
                var newSavedProc = new SavedProc(name, SQLTextBox.Text);
                savedProcs.Add(newSavedProc);
                QueryComboBox.Items.Add(newSavedProc);
                SaveProcFile();
            }
        }

        private void DeleteQueryButton_Click(object sender, EventArgs e)
        {
            if (QueryComboBox.Items.Count != 0)
            {
                var proc = (SavedProc)QueryComboBox.SelectedItem;
                int idx = QueryComboBox.SelectedIndex;
                QueryComboBox.Items.RemoveAt(idx);
                savedProcs.RemoveAt(idx);
                SaveProcFile();
            }
            else
            {
                MessageBox.Show("Error: Nothing to remove");
            }
        }

        private void SaveQueryEditButton_Click(object sender, EventArgs e)
        {
            if (QueryComboBox.Items.Count != 0)
            {
                var proc = (SavedProc)QueryComboBox.SelectedItem;
                proc.proc = SQLTextBox.Text;
                SaveProcFile();
            }
            else
            {
                MessageBox.Show("Error: Nothing to save edit to");
            }
        }

        private void SaveProcFile()
        {
            using(Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                bformatter.Serialize(stream, savedProcs);
            }
        }

        private void TableNamesButton_Click(object sender, EventArgs e)
        {
            var cheat = new CheatForm();
            cheat.Show();
        }
    }
}
