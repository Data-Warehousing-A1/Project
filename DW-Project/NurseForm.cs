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
        public NurseForm()
        {
            InitializeComponent();
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.CustomFormat = "MM/dd/yyy HHmm";
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.CustomFormat = "MM/dd/yyy HHmm";
            //TODO: fill nurseCombo and phyCombo with nurse and phy numbers
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
            //TODO: Grab nurse and phys nums
            
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

        
    }
}
