using System;
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
    public partial class NurseForm : Form
    {
        SqlConnection conn;
        SqlDataReader read;
        public NurseForm()
        {
            InitializeComponent();
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.CustomFormat = "MM/dd/yyy";
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.CustomFormat = "MM/dd/yyy";
            startDate.Value = DateTime.Today.AddDays(-7);
            endDate.Value = DateTime.Today;
            //TODO: fill nurseCombo and phyCombo with nurse and phy numbers
        }



        private void enterBut_Click(object sender, EventArgs e)
        {
            reportList.Items.Clear();
            //Grab times
            String st = startDate.Value.ToString("yyyy/MM/dd");
            String ed = endDate.Value.ToString("yyyy/MM/dd");
            System.Diagnostics.Debug.WriteLine(st + " " + ed);
            try
            {
                conn = Factory.getNewDBConnection();
                //create/use sql/stored prc to get possible dispatch reports
                //might want to sort by oldest?
                if (!allCheck.Checked)
                {
                    //do procedure that does check if NurseNum=NULL
                    SqlCommand cmd = new SqlCommand("exec [dbo].[get_records] '" + st + "', '" + ed + "', 0", conn);
                    conn.Open();
                    read = cmd.ExecuteReader();
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            reportList.Items.Add(read[0] + ", " + read[1] + ", " + read[2] + ", " + read[3]);
                        }
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("No rows found.");
                    }
                    read.Close();
                }
                else
                {
                    //do procedure that gets all
                    SqlCommand cmd = new SqlCommand("exec [dbo].[get_records] '" + st + "', '" + ed + "', 1", conn);
                    conn.Open();
                    read = cmd.ExecuteReader();
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            reportList.Items.Add(read[0] + ", " + read[1] + ", " + read[2] + ", " + read[3]);
                        }
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("No rows found.");
                    }
                    read.Close();
                }
            }
            catch (SqlException er)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + er + "\nThere was an error connecting to the DB");
            }
            finally
            {
                conn.Close();
            }
        }

        private void selectBut_Click(object sender, EventArgs e)
        {
            //Grab selected
            String report = reportList.SelectedItem.ToString();
            //Grab nurse and phys nums
            String nurse = nurseCombo.SelectedItem.ToString();
            String phys = phyCombo.SelectedItem.ToString();
            //TODO: check if numbers and correct/possible

            //TODO: Create/use sql insert statement/stored proc to add NurseNum and PhyNum to dispatcher_report table

            //TODO: remove handled from list/display success prompt (maby reselect all?)

            //TODO: error checking
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new StartScreenForm().ShowDialog();
            this.Close();
        }

        private void reportList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected = reportList.GetItemText(reportList.SelectedItem);
            String[] split = selected.Split(',');
            //split[0]=date, split[1]=county, split[2]=unit, split[3]=age
            //remove space a start of string
            split[1] = split[1].Remove(0, 1);
            split[2] = split[2].Remove(0, 1);
            //converts date to necessary fomat (might not be needed)
            DateTime hold = Convert.ToDateTime(split[0]);
            split[0] = hold.ToString("yyyy/MM/dd HH:mm:ss.fff");
            causeText.Text = String.Empty;
            //populate causeText with causes stored proc
            try
            {
                conn = Factory.getNewDBConnection();
                SqlCommand cmd = new SqlCommand("exec [dbo].[get_cause_list] '" + split[0] + "', '" + split[2] + "', '"+split[1]+"', "+split[3], conn);
                conn.Open();
                read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    read.Read();
                    causeText.Text = read[0]+"";
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("No rows found.");
                }
                read.Close();

                symtomText.Text = String.Empty;
                //populate symtomText with sym stored proc
                cmd = new SqlCommand("exec [dbo].[get_symptom_list] '" + split[0] + "', '" + split[2] + "', '" + split[1] + "', " + split[3], conn);
                read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    read.Read();
                    symtomText.Text = read[0] + "";
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("No rows found.");
                }
                read.Close();
            }
            catch (SqlException er)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + er + "\nThere was an error connecting to the DB");
            }
            finally
            {
                conn.Close();
            }
        }
        //creates view form
        private void viewButt_Click(object sender, EventArgs e)
        {
            String selected = reportList.GetItemText(reportList.SelectedItem);
            String[] split = selected.Split(',');
            split[1] = split[1].Remove(0, 1);
            split[2] = split[2].Remove(0, 1);
            //converts date to necessary fomat (might not be needed)
            DateTime hold = Convert.ToDateTime(split[0]);
            split[0] = hold.ToString("yyyy/MM/dd HH:mm:ss.fff");
            //pass date, unit, name, age
            new viewForm(split[0],split[2],split[1],split[3]).ShowDialog();
        }


    }
}
