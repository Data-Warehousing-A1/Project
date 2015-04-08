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
    public partial class PhysicianForm : Form
    {
        //TODO: view dispatch report
        public PhysicianForm()
        {
            InitializeComponent();
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new StartScreenForm().ShowDialog();
            this.Close();
        }

        private void attachBut_Click(object sender, EventArgs e)
        {
            //TODO: grab selected dispatch report info

            //TODO: grab note

            //TODO: use sql/storedproc to add not to the dispatch report

            //remove/refresh dispatch list
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
            //TODO: pass dispach report info to view
            new viewForm("phy").ShowDialog();
            this.Close();
        }
    }
}
