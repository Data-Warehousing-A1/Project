using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DW_Project
{
    class Factory
    {
        public static SqlConnection getNewDBConnection()
        {
            return new SqlConnection("Data Source=LYRA;Initial Catalog=cap4774sp15dwa1;User ID=cap4774sp15dwa1;Password=hovertrack");
        }
    }
}
