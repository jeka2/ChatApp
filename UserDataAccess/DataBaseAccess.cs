using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace UserDataAccess
{
    public class DataBaseAccess
    {
        private NpgsqlConnection conn;
        private string connstring = String.Format("Server={0};Port={1}, " +
            "User Id={2};Password={3};Database={4};", "localhost", "5432", "postgres",
            "MYPASS", "chatapp");
        private DataTable dt;
        private NpgsqlCommand comm;
        private string sql = null;

        public List<string> MakeRequest()
        {
            try
            {
                /*conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = "select * from get_users()";
                comm = new NpgsqlCommand(sql, conn);

                dt = new DataTable();
                dt.Load(comm.ExecuteReader());
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(comm);
                adapter.Fill(dt);

                List<string> names = new List<string>();
                foreach(DataRow row in dt.Rows)
                {
                    names.Add(row["name"].ToString());
                }
                return names;
                */
                return new List<string>() { "hi", "hello" };
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
               
            }
            return null;
        }
        
    }
}
