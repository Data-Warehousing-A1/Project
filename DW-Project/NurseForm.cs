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
        //TODO: view dispatch report (optional?)
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
            /*try
            {
                conn = Factory.getNewDBConnection();
                
                SqlCommand cmd = new SqlCommand("getNurse", conn);
                cmd.CommandType=CommandType.StoredProcedure;
                conn.Open();
                read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        nurseCombo.Items.Add(read[0]+" "+read[1]);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                read.Close();
                cmd = new SqlCommand("getPhy", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        phyCombo.Items.Add(read[0] + " " + read[1]);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                read.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error: " + e+"\nThere was an error connecting to the DB");
            }
            finally
            {
                conn.Close();
            }*/
        }

        

        private void enterBut_Click(object sender, EventArgs e)
        {
            reportList.Items.Clear();
            //Grab times
            String st = startDate.Value.ToString("yyyy/MM/dd");
            String ed = endDate.Value.ToString("yyyy/MM/dd");
            System.Diagnostics.Debug.WriteLine(st + " " + ed);
            //TODO: create/use sql/stored prc to get possible dispatch reports (might want to remove already handled reports?)
            if (!allCheck.Checked)
            {
                //do procedure that does not check if NurseNum=NULL
                try
                {
                    conn = Factory.getNewDBConnection();
                    /*SqlCommand cmd = new SqlCommand("getDispatch", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter prm = new SqlParameter();
                    prm.ParameterName = "@start_date";
                    prm.SqlDbType = SqlDbType.DateTime;
                    prm.Direction = ParameterDirection.Input;
                    prm.Value = startDate.Value;
                    cmd.Parameters.Add(prm);
                    prm = new SqlParameter();
                    prm.ParameterName = "@end_date";
                    prm.SqlDbType = SqlDbType.DateTime;
                    prm.Direction = ParameterDirection.Input;
                    prm.Value = endDate.Value;
                    cmd.Parameters.Add(prm);
                    conn.Open();
                    read = cmd.ExecuteReader();
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            reportList.Items.Add(read[0] + ", " + read[1]+", "+read[2]+", "+read[3]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                    read.Close();
                    */
                    
                    SqlCommand cmd = new SqlCommand("exec [dbo].[hours_2_cause] '"+st+"', '"+ed+"', null", conn);
                    conn.Open();
                    read = cmd.ExecuteReader();
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            //System.Diagnostics.Debug.WriteLine(read[0]+" "+ read[1]+" "+ read[2]);
                            reportList.Items.Add(read[0] + " time, " + read[1] + ", " + read[2]);
                            
                        }
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
            else
            {
                //do procedure that gets all
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
            String[] split=selected.Split(',',' ');
            //date=split[0]+split[1] or split[2]? unit=split
            System.Diagnostics.Debug.WriteLine("Index Changed "+selected);
            causeText.Text = String.Empty;
            causeText.Text = split[0] + split[1]+split[3]+split[5];
            //TODO: populate causeText with causes stored proc
            /*try
            {
                conn = Factory.getNewDBConnection();
                SqlCommand cmd = new SqlCommand("exec [dbo].[get_cause_list] '" + st + "', '" + ed + "', null", conn);
            }
            catch (SqlException er)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + er + "\nThere was an error connecting to the DB");
            }
            finally
            {
                conn.Close();
            }*/
            symtomText.Text = String.Empty;
            //TODO: populate symtomText with sym stored proc
        }
        //creates view form
        private void viewButt_Click(object sender, EventArgs e)
        {
            String selected = reportList.GetItemText(reportList.SelectedItem);
            String[] split = selected.Split(',', ' ');
            //pass date, unit, name, age
            new viewForm().ShowDialog();
        }

        
    }
}
