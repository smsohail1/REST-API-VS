using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEntity;
using TestDAL;

namespace TestBAL
{
    public class TestBAL
    {
        public List<TestEntity.TestEntity> GetAllPandya()
        {
            TestDAL.TestDAL pandyaDal = new TestDAL.TestDAL();
            List<TestEntity.TestEntity> listPandya = pandyaDal.GetAllPandya();
            return listPandya;
        }

        public List<TestEntity.TestEntity> GetAllPandyaByCn(string cn)
        {
            TestDAL.TestDAL pandyaDal = new TestDAL.TestDAL();
            List<TestEntity.TestEntity> listPandya = pandyaDal.GetAllPandyaByCn(cn);
            return listPandya;
        }

        public List<TestEntity.TestEntity> GetAllPandyaOracleDB(string cn)
        {
            TestDAL.TestDAL pandyaDal = new TestDAL.TestDAL();
            List<TestEntity.TestEntity> listPandya = pandyaDal.GetAllPandyaOracleDB(cn);
           return listPandya;
        }

    }
}
