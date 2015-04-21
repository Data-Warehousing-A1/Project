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
    public partial class NameQuery : Form
    {
        public string name { get; set; }
        public NameQuery()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(out string result)
        {
            DialogResult dialogResult = base.ShowDialog();

            result = name;
            return dialogResult;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Error. Name field is blank");
            }
            else
            {
                name = nameTextBox.Text;
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            name = "";
            this.Close();
        }
    }
}
