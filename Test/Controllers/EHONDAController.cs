using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestEntity;
using TestBAL;
using Newtonsoft.Json;

namespace Test.Controllers
{
    [RoutePrefix("api/EHonda")]
    public class EHONDAController : ApiController
    {
        [HttpGet]
        [Route("GetCustomerInformationByNumber/{customerNumber}")]
        public string GetCustomerInformationBynumber(string customerNumber)
        {
            List<EHonda> listEHonda = new List<EHonda>();
            EHondaBAL ehondaBAL = new EHondaBAL();
            listEHonda = ehondaBAL.
                GetCustomerInformationByNumber(customerNumber);
            string sJSONResponse = JsonConvert.SerializeObject(listEHonda);


            return sJSONResponse;
        }




    }
}
