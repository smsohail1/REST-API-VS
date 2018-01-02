using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEntity;
using System.Data;
using System.Data.SqlClient;
using TestDAL.Common;


namespace TestDAL
{
    public class EHondaDAL
    {
        public List<EHonda> GetEHondaByCustomerNumber(string customerNumber)
        {
            List<EHonda> listEHonda = new List<EHonda>();
            try
            {

                string query = "select * from rms_ref_customer_info where cus_no='" + customerNumber + "'";
                DataSet dtEhonda = DatabaseConfiguration.GetDataSetUsingQuery(query);
                foreach (DataRow dataRow in dtEhonda.Tables[0].Rows)
                {
                    listEHonda.Add(new EHonda() { CUSTOMER_NUMBER = (string)dataRow["cus_no"], Name = (string)dataRow["customer_name"], CustomerPhone = (string)dataRow["customer_phone"] });

                }

                return listEHonda;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }

        }
    }
}
