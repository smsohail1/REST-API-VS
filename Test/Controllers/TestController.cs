using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestEntity;
using TestDAL;
using TestBAL;
using Newtonsoft.Json;

namespace Test.Controllers
{
    [RoutePrefix("api/Pandya")]//Baseurl
    public class TestController : ApiController
    {
        //[HttpPost]
        [HttpGet]
        [Route("GetPandyaRealName")]
        public string GetName()
        {
            return "My Name is Sohail rana";
        }

        [HttpGet]
        [Route("GetPandyaRealName/{realName}")]
        public string GetName(string realName)
        {
            return "My Name is Sohail rana but my real name is " + realName;
        }

        [HttpGet]
        [Route("GetAllPandya")]
        public string GetAllPandyaBhaJee()
        {
            TestBAL.TestBAL pandyabal = new TestBAL.TestBAL();
            List<TestEntity.TestEntity> listPandya = pandyabal.GetAllPandya();
            string sJSONResponse = JsonConvert.SerializeObject(listPandya);
            return sJSONResponse;
        }

        [HttpGet]
        [Route("GetAllPandya/{cn}")]
        public string GetAllPandyaBhaJee(string cn)
        {
            TestBAL.TestBAL pandyabal = new TestBAL.TestBAL();
            List<TestEntity.TestEntity> listPandya = pandyabal.GetAllPandyaByCn(cn);
            string sJSONResponse = JsonConvert.SerializeObject(listPandya);
            return sJSONResponse;
        }

          [HttpGet]
        [Route("GetOracleData/{cn}")]
        public string GetAllPandyaOracleDB(string cn)
        {
            TestBAL.TestBAL pandyabal = new TestBAL.TestBAL();
            List<TestEntity.TestEntity> listPandya = pandyabal.GetAllPandyaOracleDB(cn);
            string sJSONResponse = JsonConvert.SerializeObject(listPandya);
            return sJSONResponse;
        }
    }
}
