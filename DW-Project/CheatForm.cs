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
    public partial class CheatForm : Form
    {
        SqlConnection conn;
        SqlDataReader read;
        public CheatForm()
        {
            InitializeComponent();
            try
            {
                conn = Factory.getNewDBConnection();
                SqlCommand cmd = new SqlCommand("SELECT 'dbo.' + table_name FROM information_schema.tables where table_schema = 'dbo'", conn);
                conn.Open();
                read = cmd.ExecuteReader();
                String output = "";
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        output+=(read[0]+", ");
                    }
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("No rows found.");
                }
                cheatText.Text = output;
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
    }
}
