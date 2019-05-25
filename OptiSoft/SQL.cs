using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace OptiSoft
{


    class SQL
    {
        public static object DBSQLServerUtils { get; private set; }

        public SqlConnection con;


        //To Handle connection related activities
        public void connection()
        {
            string constr = "Data Source=MACHINE-VOIV7EH\\SQLEXPRESS; Initial Catalog = OptiSoft; Persist Security Info = False;Integrated Security=True;";
            con = new SqlConnection(constr);
        }

        public void GetDBConnection()
        {
            connection();
        }



        //call store procedure for insert date in Documents table
        public void InsertData(string date, string description, int status, string number)
        {
            if (date != null && description != null && status != null && number != null)
            {
                connection();
                con.Open();
                SqlCommand command = new SqlCommand("InsertDate", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@date", date);
                command.Parameters.Add("@description", description);
                command.Parameters.Add("@status", status);
                command.Parameters.Add("@number", number);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("error");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public void UpdateDate(int id, string date, string description, int status, string number)
        {
            if (date != null && description != null && status != null && number != null && id != null)
            {
                connection();
                con.Open();
                SqlCommand command = new SqlCommand("update_document", con);
                command.CommandType = CommandType.StoredProcedure;
                Console.WriteLine(id);
                Console.WriteLine(date);
                Console.WriteLine(description);
                Console.WriteLine(status);
                Console.WriteLine(number);
                command.Parameters.Add("@id", id);
                command.Parameters.Add("@date", date);
                command.Parameters.Add("@description", description);
                command.Parameters.Add("@status", status-1);
                command.Parameters.Add("@doc_number", number);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    con.Close();
                }
            }

        }

        public void GetStatusList()
        {
            connection();
            con.Open();
        }


        public DataTable GetAllData()
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
                DataTable dt = new DataTable();
                dt.Columns.Add("Номер");
                dt.Columns.Add("Дата");
                dt.Columns.Add("Статус");
                while (rdr.Read())
                {
                    dt.Rows.Add(rdr["id"], rdr["date"], rdr["status_id"]);
                }
                return dt;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public Record SelectSingle(int id)
        {

            try
            {
                connection();
                con.Open();
                SqlCommand command = new SqlCommand("select_single", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", id);
                SqlDataReader rdr = null;
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    //dt.Rows.Add(rdr["id"], rdr["date"], rdr["status_id"]);
                    Record record = new Record();
                    String temp = rdr["id"].ToString();
                    record.id = Int32.Parse(temp);
                    record.date = rdr["date"].ToString();
                    record.description = rdr["description"].ToString();
                    temp = rdr["status"].ToString();
                    record.status = Int32.Parse(temp);
                    record.doc_number = rdr["doc_number"].ToString();
                    return record;
                }

            }
            finally
            {

            }
            return null;
        }

        public string[]  getStatusList()
        {
            try
            {
                connection();
                con.Open();
                SqlCommand command = new SqlCommand("get_status_list", con);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = null;
                rdr = command.ExecuteReader();
                //array of status
                //Dictionary<int, String> array = new Dictionary<int, string>();
                
                List<string> temp=new List<string>();
                int i = 0;
                
                while (rdr.Read())
                {
                    //  array.Add(i, rdr["name"].ToString());
                    // i++;
                    // array.Add(rdr["name"].ToString());
                    //array[i]=rdr["status"].ToString();
                    //i=i+1;
                    //temp.add(rdr["status"].ToString());
                    temp.Add(rdr["status"].ToString());
                }
                string[] array = temp.ToArray();

                return array;

            }
            finally
            {
               
            }
            return null;
        }
    }
}
