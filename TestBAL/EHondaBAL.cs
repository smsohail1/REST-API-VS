using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEntity;
using TestDAL;

namespace TestBAL
{
   public class EHondaBAL
    {
        public List<EHonda> GetCustomerInformationByNumber(string customerNumber)
        {
            EHondaDAL ehondaDAL = new EHondaDAL();
            List<EHonda> listHonda = ehondaDAL.GetEHondaByCustomerNumber(customerNumber);
            return listHonda;
        }
    }
}
