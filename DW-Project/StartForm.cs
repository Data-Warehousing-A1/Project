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
    public partial class StartScreenForm : Form
    {
        SqlConnection conn;
        SqlDataReader read;
        public StartScreenForm()
        {
            InitializeComponent();
        }

        private void SwitchToNewForm(Form window)
        {
            this.Visible = false;
            window.ShowDialog();
            this.Close();
        }

        private void SelectionCommon()
        {
            switch (AccountComboBox.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Error. You need to select an account type first.");
                    break;
                case 0:
                    if (Login(userText.Text, passText.Text, 3))
                        SwitchToNewForm(new DispatcherForm());
                    else
                        MessageBox.Show("Bad Login");
                    break;
                case 1:
                    if (Login(userText.Text, passText.Text, 1))
                        SwitchToNewForm(new PhysicianForm(userText.Text));
                    else
                        MessageBox.Show("Bad Login");
                    break;
                case 2:
                    if (Login(userText.Text, passText.Text, 0))
                        SwitchToNewForm(new ReportForm());
                    else
                        MessageBox.Show("Bad Login");
                    break;
                case 3:
                    if (Login(userText.Text, passText.Text, 2))
                        SwitchToNewForm(new NurseForm());
                    else
                        MessageBox.Show("Bad Login");
                    break;
            }
        }

        private void AccountConfirmationButton_Click(object sender, EventArgs e)
        {
            SelectionCommon();
        }

        private void HelloWorldButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private Boolean Login(String userid, String pass, int type)
        {
            try
            {
                conn = Factory.getNewDBConnection();
                SqlCommand cmd = new SqlCommand("exec [dbo].[get_login] "+userid+", "+type, conn);
                conn.Open();
                read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    read.Read();
                    if (pass.Equals(read[0]))
                        return true;
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
                read.Close();
            }
            catch (SqlException er)
            {
                MessageBox.Show("There was an error connecting to the DB. Make sure you are connected to the school's network");
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void userText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectionCommon();
            }
        }

        private void passText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectionCommon();
            }
        }
    }
}
