using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DW_Project
{
    public partial class NurseForm : Form
    {
        //TODO: view dispatch report (optional?)
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
            /* result=getNurse();
             * while(row=result.getresult()){
             *      nurseCombo.Items.Add(row[0]+" "+row[1]);
             *      }
             *  result=getPhy();
             *  while(row=result.getresult()){
             *      phyCombo.Items.Add(row[0]+" "+row[1]);
             *      }
             */
        }

        

        private void enterBut_Click(object sender, EventArgs e)
        {
            //Grab times
            String st = startDate.ToString();
            String ed = endDate.ToString();
            
            //TODO: create/use sql/stored prc to get possible dispatch reports (might want to remove already handled reports?)
            if (allCheck.Checked)
            {
                //do procedure that does not check if NurseNum=NULL
            }
            else
            {
                //do procedure that checks if NurseNum=NULL
            }
            //Empty reportList
            reportList.Items.Clear();
            //TODO: Add results from sql to reportList
            
            //reportList.Items.Add("");
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
            causeText.Text = String.Empty;
            //TODO: populate causeText with causes stored proc

            symtomText.Text = String.Empty;
            //TODO: populate symtomText with sym stored proc
        }

        private void viewButt_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new viewForm("nur").ShowDialog();
            this.Close();
        }

        
    }
}
