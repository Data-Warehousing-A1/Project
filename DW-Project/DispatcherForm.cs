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
                MessageBox.Show(fDialog.FileName.ToString());
                String fullpath=Path.GetFullPath("../../../sql/Building out the Datawarehouse/run_file_import.bat");
                String file = File.ReadAllText(fullpath);
                file = file.Replace("##path##", fDialog.FileName.ToString());
                File.WriteAllText(fullpath, file);
                //TODO: Run DTS file
                try
                {
                    int exitCode;
                    System.Diagnostics.ProcessStartInfo processInfo;
                    System.Diagnostics.Process process;

                    processInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c"+fullpath);
                    processInfo.CreateNoWindow = true;
                    processInfo.UseShellExecute = false;
                    // *** Redirect the output ***
                    processInfo.RedirectStandardError = true;
                    processInfo.RedirectStandardOutput = true;

                    process = System.Diagnostics.Process.Start(processInfo);
                    process.WaitForExit();

                    // *** Read the streams ***
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    exitCode = process.ExitCode;

                    Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
                    Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
                    Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");
                    process.Close();
                    //System.Diagnostics.Process.Start("../../../sql/Building out the Datawarehouse/run_file_import.bat");
                }
                catch (Win32Exception winer)
                {
                    System.Diagnostics.Debug.WriteLine("Error in .bat file run");
                    System.Diagnostics.Debug.WriteLine(winer.ErrorCode);
                }
                //Clean DTS file
                file = File.ReadAllText(fullpath);
                file = file.Replace(fDialog.FileName.ToString(), "##path##");
                File.WriteAllText(fullpath, file);
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
