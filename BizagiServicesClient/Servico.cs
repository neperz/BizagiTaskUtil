using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BizagiServicesClient
{
    public class Servico
    {
      

        public Processes GetCaseInfo(string caseNumber)
        {
            var ps = new Processes();
            var cli = new BZ.WorkflowEngineSOASoapClient();
            string caseFilter = "<BizAgiWSParam>";// +
            //"<domain>compline.com.br</domain>" +
            //"<userName>SOA</userName>";
            if (!string.IsNullOrEmpty(caseNumber))
                caseFilter += "<radNumber>" + caseNumber + "</radNumber>";
            caseFilter += "</BizAgiWSParam>";
            var xmlInfo = cli.getCasesAsString(caseFilter);

            var serializer = new XmlSerializer(typeof(Processes));

            using (TextReader reader = new StringReader(xmlInfo))
            {
                ps = (Processes)serializer.Deserialize(reader);
            }
            ps.xml = xmlInfo;
            return ps;
        }

        public List<WFUSER> GetUsuarios(string outFile)
        {
            var client = new BzEntity.EntityManagerSOASoapClient();
            BizAgiWSResponse pData = new BizAgiWSResponse();

            var xmlRequest = "<?xml version=\"1.0\" encoding=\"utf-8\"?><BizAgiWSParam>" +
                     "<EntityData><EntityName>WFUSER</EntityName>" +
                     //"<Filters><![CDATA[idArea = '" + idArea + "']]></Filters>" +
                     "</EntityData></BizAgiWSParam>";

            var data = client.getEntitiesAsString(xmlRequest);
//            var dataFile = @"D:\Projetos\PrevSulUtil\PrevSulProverManager.Domain\BizagiPrevSul.Domain\BizagiUsersBackupProducao_25012018_1555.xml";
            File.WriteAllText(outFile, data);

            var serializer = new XmlSerializer(typeof(BizAgiWSResponse));


            using (TextReader reader = new StringReader(data))
            {
                pData = (BizAgiWSResponse)serializer.Deserialize(reader);
            }
            return pData.Entities.WFUSER;

        }

        public Processes GetCaseInfoByID(string idCase, string user)
        {
            var ps = new Processes();
            var cli = new BZ.WorkflowEngineSOASoapClient();
            string caseFilter = "<BizAgiWSParam>" +
            "<userName>" + user + "</userName>" +
            "<idCase>" + idCase + "</idCase>" +
            "</BizAgiWSParam>";
            var xmlInfo = cli.getCasesAsString(caseFilter);

            var serializer = new XmlSerializer(typeof(Processes));

            using (TextReader reader = new StringReader(xmlInfo))
            {
                ps = (Processes)serializer.Deserialize(reader);
            }
            ps.xml = xmlInfo;
            return ps;
        }

        public Processes PerformActivity(string caseNumber, string tksName, string idCase, string idTks)
        {
            var pa = new Processes();

            string pActivity = "<BizAgiWSParam>" +
              "<domain>compline.com.br</domain>" +
              "<userName>SOA</userName>" +
              "<ActivityData>" +
                "<radNumber>"+ caseNumber + "</radNumber>" +
                "<taskName>"+ tksName + "</taskName> " +
              "</ActivityData>" +
              "<Entities>" +
              "</Entities> " +
            "</BizAgiWSParam>";
            var cli = new BZ.WorkflowEngineSOASoapClient();
            var xmlInfo = cli.performActivityAsString(pActivity);

            var serializer = new XmlSerializer(typeof(Processes));

            using (TextReader reader = new StringReader(xmlInfo))
            {
                pa = (Processes)serializer.Deserialize(reader);
            }
            pa.xml = xmlInfo;
            return pa;


        }

    }
}
