using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentAutomation
{
   public class SqlHelper
    {
        public SqlConnection Con { get; set; }
        public string ConString { get; set; }
        public SqlCommand Command { get; set; }


        public SqlHelper()
        {
            ConString = @"Data Source=WISSEN\SQLEXPRESS; Initial Catalog=DuesManagement; Trusted_connection=true; User ID=Section1";
            Con = new SqlConnection(ConString);
            Command = new SqlCommand();
        }
        public DataTable GetData(string Query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(Query,ConString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public void ExecuteQuery(string Query)
        {          
            Command.Connection = Con;
            Command.CommandText = Query;
            Con.Open();
            Command.ExecuteNonQuery();
            Con.Close();
            Con.Dispose();

        }
        public void ExecuteProcedure(string ProcName,params SqlParameter[] prms)
        {
            Command.Connection = Con;
            Command.CommandText = ProcName;
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddRange(prms);
            Con.Open();
            Command.ExecuteNonQuery();
            Con.Close();
            Con.Dispose();
        } 
    }
}
