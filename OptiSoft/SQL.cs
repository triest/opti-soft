using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OptiSoft
{


    class SQL
    {
        public static object DBSQLServerUtils { get; private set; }

        public SqlConnection con;
        //To Handle connection related activities
        private void connection()
        {
            string constr = "Data Source=MACHINE-VOIV7EH\\SQLEXPRESS; Initial Catalog = OptiSoft; Persist Security Info = False;Integrated Security=True;";
            con = new SqlConnection(constr);
        }

        public void GetDBConnection()
        {
            connection();
        }

        public void GetAllData()
        {
       
            try
            {

                connection();
                con.Open();
                SqlCommand command = new SqlCommand("select_all", con);
                command.CommandType = CommandType.StoredProcedure;

                // execute the command
                SqlDataReader rdr = null;
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(
                   rdr["description"]
                 );
                }
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
    }
}
