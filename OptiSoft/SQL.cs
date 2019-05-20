using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=MACHINE-VOIV7EH\\SQLEXPRESS; Initial Catalog = geolog; Persist Security Info = False;Integrated Security=True;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            Console.Write("connect");
            cnn.Close();
        }
    }
}
