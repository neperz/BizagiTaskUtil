using Microsoft.VisualStudio.TestTools.UnitTesting;
using BizagiServicesClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizagiServicesClient.Tests
{
    [TestClass()]
    public class ServicoTests
    {
        [TestMethod()]
        public void GetCaseInfoTest()
        {
            var bc = new BizagiServicesClient.Servico();

            var pCaseNumber = "OUV467-2017";
           
            var x = bc.GetCaseInfo(pCaseNumber);
            var pCaseID = x.Process[0].ProcessId;
            
            var pTkName = x.Process[0].CurrentWorkItems.WorkItem.Task.TaskName;
            var pTkID = x.Process[0].CurrentWorkItems.WorkItem.Task.TaskId;

            var pd = bc.PerformActivity(pCaseNumber, pTkName, pCaseID, pTkID);
            Console.Write(x);
            Assert.Fail();
        }
    }
}