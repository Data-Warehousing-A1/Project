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
    public partial class StartScreenForm : Form
    {
        public StartScreenForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SwitchToNewForm(Form window)
        {
            this.Visible = false;
            window.ShowDialog();
            this.Close();
        }

        private void AccountConfirmationButton_Click(object sender, EventArgs e)
        {
            switch (AccountComboBox.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Error. You need to select an account type first.");
                    break;
                case 0:
                    SwitchToNewForm(new DispatcherForm());
                    break;
                case 1:
                    SwitchToNewForm(new PhysicianForm());
                    break;
                case 2:
                    SwitchToNewForm(new ReportForm());
                    break;
            }
        }

        private void HelloWorldButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
