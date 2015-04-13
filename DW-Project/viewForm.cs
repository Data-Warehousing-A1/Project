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
    public partial class viewForm : Form
    {
        public viewForm()
        {
            InitializeComponent();
            disDate.Format = DateTimePickerFormat.Custom;
            disDate.CustomFormat = "MM/dd/yyy HHmm";
            //TODO: populate fields with info from dispatch report
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }
    }
}
