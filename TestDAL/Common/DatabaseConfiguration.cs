using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TestDAL.Common
{
    public class DatabaseConfiguration
    {
        public static string rmsDesktopConnectionString = ConfigurationManager.ConnectionStrings["RMSDESKTOPCONNECTIONSTRING"].ConnectionString;


        public static DataSet GetDataSetUsingQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(rmsDesktopConnectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.CommandTimeout = 130;
                    command.CommandType = CommandType.Text;



                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet dataset = new DataSet();
                        adapter.Fill(dataset);
                        return dataset;
                    }
                }
            }
        }
    }
}
