using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SLNSSCEB_for_PC
{
    class DatabaseConnection
    {
        public string connectionString = "Data Source=DESKTOP-9PI6981;Initial Catalog=SLNSSCEB;Integrated Security=True";

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9PI6981;Initial Catalog=SLNSSCEB;Integrated Security=True");

        public void command(string command)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(command, con);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                //Sql commend Executed
            }
            else
            {
                //Sql Command not Executed
            }
            con.Close();
        }
    }
}
