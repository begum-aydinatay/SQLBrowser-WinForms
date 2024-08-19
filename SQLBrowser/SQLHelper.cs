using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQLBrowser
{
    public class SQLHelper
    {
        public SqlConnection Connection { get; private set; }
        public SqlCommand Command { get; private set; }

        public SQLHelper(string connectionString)
        {
            this.Connection = new SqlConnection(connectionString);
            this.Command = this.Connection.CreateCommand();
        }

        // This method is used to get the list of data (potentially a column) from the database with the assigned query
        public List<string> GetDataList()
        {
            List<string> results = new List<string>();

            this.Connection.Open();

            SqlDataReader reader = this.Command.ExecuteReader();

            while (reader.Read())
            {
                string value = reader.GetString(0);
                results.Add(value);
            }

            reader.Close();
            reader.Dispose();

            this.Connection.Close();

            return results;
        }

        // This method is used to get the table from the database formed from the assigned query
        public DataTable GetDataTable()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(this.Command);
            adapter.Fill(dt);

            return dt;
        }
    }
}
