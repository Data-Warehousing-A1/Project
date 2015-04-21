using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DW_Project
{
    public partial class DispatcherForm : Form
    {
        public DispatcherForm()
        {
            InitializeComponent();
        }

        private void DispatcherForm_Load(object sender, EventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Open CSV File";
            //should fliter for files with the name or extention csv
            fDialog.Filter = "CSV Foles|*.csv";
            //sets initial directory to start browser at
            fDialog.InitialDirectory = @"C:\";
            fDialog.CheckFileExists = true;
            fDialog.CheckPathExists = true;
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                //needs testing
                //InsetFile name into DTS file
                String fullpath=Path.GetFullPath("../../../sql/Building out the Datawarehouse/run_file_import_var.bat");
                String dtspath = Path.GetFullPath("../../../sql/Building out the Datawarehouse/import_with_password.dtsx");
                String file = File.ReadAllText(fullpath);
                file = file.Replace("##path##", fDialog.FileName.ToString());
                file = file.Replace("##DTSPATH##", dtspath);
                File.WriteAllText(fullpath, file);
                //Run DTS file
                try
                {
                    System.Diagnostics.ProcessStartInfo processInfo;
                    System.Diagnostics.Process process;
                    processInfo = new System.Diagnostics.ProcessStartInfo(fullpath);
                    processInfo.CreateNoWindow = false;
                    processInfo.UseShellExecute = false;
                    // *** Redirect the output ***
                    processInfo.RedirectStandardError = true;
                    processInfo.RedirectStandardOutput = true;
                    process = System.Diagnostics.Process.Start(processInfo);
                    process.WaitForExit(5000);
                    MessageBox.Show("Added");
                }
                catch (Win32Exception winer)
                {
                    MessageBox.Show("Error in .bat file run " + winer.ErrorCode);
                }
                finally
                {
                    //Clean DTS file
                    file = File.ReadAllText(fullpath);
                    file = file.Replace(fDialog.FileName.ToString(), "##path##");
                    file = file.Replace(dtspath, "##DTSPATH##");
                    File.WriteAllText(fullpath, file);
                }

                
                
                //TODO: prompt user success or fail
            }

        }

        private void backBut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new StartScreenForm().ShowDialog();
            this.Close();
        }

    }
}
