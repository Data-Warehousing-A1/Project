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
        }

        

        private void enterBut_Click(object sender, EventArgs e)
        {
            //TODO: Grab info from disrepinfoTable

            //TODO: create/use sql/stored prc to get possible dispatch reports (might want to remove already handled reports?)

            //TODO: Empty reportList

            //TODO: Add results from sql to reportList

        }

        private void selectBut_Click(object sender, EventArgs e)
        {
            //TODO: Grab each checke box one by one

            //TODO: Create/use sql insert statement/stored proc to add to dispatchreport_Physician table

            //TODO: remove handled from list/display success prompt

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
