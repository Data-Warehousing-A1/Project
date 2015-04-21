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
    public partial class viewForm : Form
    {
        SqlDataReader read;
        SqlConnection conn;
        public viewForm(String date, String unit, String county, String age)
        {
            InitializeComponent();
            //populate fields with info from dispatch report
            
            try
            {
                conn = Factory.getNewDBConnection();
                SqlCommand cmd = new SqlCommand("exec [dbo].[get_view] '" + date + "', '" + unit + "', '" + county + "', " + age, conn);
                conn.Open();
                read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    read.Read();
                    dateText.Text = read[0]+"";
                    countyText.Text = read[1]+"";
                    unitText.Text = read[2] + "";
                    ageText.Text = read[3] + "";
                    typeText.Text = read[4] + "";
                    pedText.Text = read[5] + "";
                    sexText.Text = read[6] + "";
                    catText.Text = read[7] + "";
                    descriptionText.Text = read[8] + "";
                    ccText.Text = read[9] + "";
                    bp1sText.Text = read[10] + "";
                    bp1dText.Text = read[11] + "";
                    bp2sText.Text = read[12] + "";
                    bp2dText.Text = read[13] + "";
                    pulse1Text.Text = read[14] + "";
                    pulse2Text.Text = read[15] + "";
                    resp1Text.Text = read[16] + "";
                    resp2Text.Text = read[17] + "";
                    ox1Text.Text = read[18] + "";
                    ox2Text.Text = read[19] + "";
                    bgl1Text.Text = read[20] + "";
                    bgl2Text.Text = read[21] + "";
                    if ((read[22] + "").Equals("0") || (read[22] + "").Equals(""))
                        locCheck.Checked=false;
                    else locCheck.Checked=true;
                    gcsText.Text = read[23] + "";
                    if ((read[24] + "").Equals("0") || (read[24] + "").Equals(""))
                        taCheck.Checked=false;
                    else taCheck.Checked=true;
                    if ((read[25] + "").Equals("0") || (read[25] + "").Equals(""))
                        saCheck.Checked=false;
                    else saCheck.Checked=true;
                    if ((read[26] + "").Equals("0") || (read[26] + "").Equals(""))
                        stemiCheck.Checked=false;
                    else stemiCheck.Checked=true;
                    deptText.Text = read[27] + "";
                    if ((read[28] + "").Equals("0") || (read[28] + "").Equals(""))
                        resusCheck.Checked=false;
                    else resusCheck.Checked=true;
                    etaText.Text = read[29] + "";
                    levelText.Text = read[30] + "";
                    if((read[31]+"").Equals("0")||(read[31]+"").Equals(""))
                        mpsCheck.Checked=false;
                    else mpsCheck.Checked=true;
                    disText.Text = read[32] + "";
                    physText.Text = read[33] + "";
                    nurseText.Text = read[34] + "";
                    noteText.Text = read[35] + "";
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
                read.Close();
            }
            catch (SqlException er)
            {
                MessageBox.Show("Error: " + er + "\nThere was an error connecting to the DB. Make sure you are connected to the school's network");
            }
            finally
            {
                conn.Close();
            }
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }
    }
}
