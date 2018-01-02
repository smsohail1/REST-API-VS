using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEntity;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OracleClient;

namespace TestDAL
{
    public class TestDAL
    {
        public List<TestEntity.TestEntity> GetAllPandya()
        {
            List<TestEntity.TestEntity> listPandya = new List<TestEntity.TestEntity>();
            //for sql server
            string connectionString = "Data Source=tcsrmsweb;Initial Catalog=rms_db;Persist Security Info=True;User ID=sa;Password=rms1010";

            //for Oracle
            //string connectionString = "Data Source=MIS;User ID=rms_apps;Password=rmsapps";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string sqlquery = "select * from rms_bill_trans where convert(char(8),booking_date,112)='20171220' ";
            SqlCommand sqlCommand = new SqlCommand(sqlquery, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                listPandya.Add(new TestEntity.TestEntity()
                {
                    getHouseNo = (string)sqlDataReader["house_awb_no"],
                    getMasterProduct = (string)sqlDataReader["master_product"],
                    getBookingStaff = (string)sqlDataReader["booking_staff_code"]
                }
                );
            }
            sqlConnection.Close();
            return listPandya;
        }

        public List<TestEntity.TestEntity> GetAllPandyaByCn(string cn)
        {
            List<TestEntity.TestEntity> listPandya = new List<TestEntity.TestEntity>();
            //for sql server
            string connectionString = "Data Source=tcsrmsweb;Initial Catalog=rms_db;Persist Security Info=True;User ID=sa;Password=rms1010";

            //for Oracle
            //string connectionString = "Data Source=MIS;User ID=rms_apps;Password=rmsapps";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string sqlquery = "select * from rms_bill_trans where house_awb_no='" + cn + "'";
            SqlCommand sqlCommand = new SqlCommand(sqlquery, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                listPandya.Add(new TestEntity.TestEntity()
                {
                    getHouseNo = (string)sqlDataReader["house_awb_no"],
                    getMasterProduct = (string)sqlDataReader["master_product"],
                    getBookingStaff = (string)sqlDataReader["booking_staff_code"]
                }
                );
            }
            sqlConnection.Close();
            return listPandya;
        }


        public List<TestEntity.TestEntity> GetAllPandyaOracleDB(string cn)
        {
            List<TestEntity.TestEntity> listPandya = new List<TestEntity.TestEntity>();
            //for sql server
           // string connectionString = "Data Source=tcsrmsweb;Initial Catalog=rms_db;Persist Security Info=True;User ID=sa;Password=rms1010";

            //for Oracle
            string connectionString = "Data Source=MIS;User ID=rms_apps;Password=rmsapps";

            OracleConnection oracleConnection = new OracleConnection(connectionString);
            oracleConnection.Open();
            string sqlquery = "select * from rms_bill_trans where CNSG_NO = '"+cn+"'";
            OracleCommand sqlCommand = new OracleCommand(sqlquery, oracleConnection);
            OracleDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                listPandya.Add(new TestEntity.TestEntity()
                {
                    getHouseNo = (string)sqlDataReader["CNSG_NO"],
                    getMasterProduct = (string)sqlDataReader["MASTER_PROD"],
                    getBookingStaff = (string)sqlDataReader["BOOKING_STAFF_CODE"]
                }
                );
            }
            oracleConnection.Close();
            return listPandya;
        }
    }
}
