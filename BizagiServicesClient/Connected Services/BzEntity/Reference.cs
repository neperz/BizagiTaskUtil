﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BizagiServicesClient.BzEntity {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BzEntity.EntityManagerSOASoap")]
    public interface EntityManagerSOASoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEntitiesAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getEntitiesAsString(string entitiesInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEntitiesAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getEntitiesAsStringAsync(string entitiesInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEntitiesUsingSchemaAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getEntitiesUsingSchemaAsString(string entitiesInfo, string schema);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEntitiesUsingSchemaAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getEntitiesUsingSchemaAsStringAsync(string entitiesInfo, string schema);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/saveEntityAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string saveEntityAsString(string entityInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/saveEntityAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> saveEntityAsStringAsync(string entityInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEntitySchemaStr", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getEntitySchemaStr(string entityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEntitySchemaStr", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getEntitySchemaStrAsync(string entityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cleanTestData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode cleanTestData(System.Xml.XmlNode testCaseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cleanTestData", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> cleanTestDataAsync(System.Xml.XmlNode testCaseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCaseLog", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getCaseLog(System.Xml.XmlNode caseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCaseLog", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getCaseLogAsync(System.Xml.XmlNode caseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEntityFormLog", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getEntityFormLog(System.Xml.XmlNode caseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEntityFormLog", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getEntityFormLogAsync(System.Xml.XmlNode caseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEntityLog", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getEntityLog(System.Xml.XmlNode caseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEntityLog", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getEntityLogAsync(System.Xml.XmlNode caseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEntities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getEntities(System.Xml.XmlNode entitiesInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEntities", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getEntitiesAsync(System.Xml.XmlNode entitiesInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCaseDataUsingSchemaLite", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getCaseDataUsingSchemaLite(int idCase, System.Xml.XmlNode xsd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCaseDataUsingSchemaLite", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getCaseDataUsingSchemaLiteAsync(int idCase, System.Xml.XmlNode xsd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCaseDataUsingSchemaLiteAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getCaseDataUsingSchemaLiteAsString(int idCase, string sxsd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCaseDataUsingSchemaLiteAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getCaseDataUsingSchemaLiteAsStringAsync(int idCase, string sxsd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCaseDataUsingSchema", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getCaseDataUsingSchema(string idCase, string idWorkItem, System.Xml.XmlNode xsd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCaseDataUsingSchema", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getCaseDataUsingSchemaAsync(string idCase, string idWorkItem, System.Xml.XmlNode xsd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCaseDataUsingSchemaAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getCaseDataUsingSchemaAsString(string idCase, string idWorkItem, string sxsd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCaseDataUsingSchemaAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getCaseDataUsingSchemaAsStringAsync(string idCase, string idWorkItem, string sxsd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCaseDataUsingXPaths", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getCaseDataUsingXPaths(System.Xml.XmlNode xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCaseDataUsingXPaths", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getCaseDataUsingXPathsAsync(System.Xml.XmlNode xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCaseDataUsingXPathsAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getCaseDataUsingXPathsAsString(string sXml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCaseDataUsingXPathsAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getCaseDataUsingXPathsAsStringAsync(string sXml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEntitiesUsingSchema", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getEntitiesUsingSchema(System.Xml.XmlNode entitiesInfo, System.Xml.XmlNode schema);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEntitiesUsingSchema", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getEntitiesUsingSchemaAsync(System.Xml.XmlNode entitiesInfo, System.Xml.XmlNode schema);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEntitySchema", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getEntitySchema(string entityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEntitySchema", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getEntitySchemaAsync(string entityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/replicateEntity", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode replicateEntity(string entityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/replicateEntity", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> replicateEntityAsync(string entityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/replicateAll", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode replicateAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/replicateAll", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> replicateAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/saveEntity", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode saveEntity(System.Xml.XmlNode entityInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/saveEntity", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> saveEntityAsync(System.Xml.XmlNode entityInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/saveEntityWithKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode saveEntityWithKey(object oEntityKey, System.Xml.XmlNode entityInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/saveEntityWithKey", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> saveEntityWithKeyAsync(object oEntityKey, System.Xml.XmlNode entityInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/saveEntityWithKeyAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string saveEntityWithKeyAsString(object oEntityKey, string entityInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/saveEntityWithKeyAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> saveEntityWithKeyAsStringAsync(object oEntityKey, string entityInfo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EntityManagerSOASoapChannel : BizagiServicesClient.BzEntity.EntityManagerSOASoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EntityManagerSOASoapClient : System.ServiceModel.ClientBase<BizagiServicesClient.BzEntity.EntityManagerSOASoap>, BizagiServicesClient.BzEntity.EntityManagerSOASoap {
        
        public EntityManagerSOASoapClient() {
        }
        
        public EntityManagerSOASoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EntityManagerSOASoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EntityManagerSOASoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EntityManagerSOASoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string getEntitiesAsString(string entitiesInfo) {
            return base.Channel.getEntitiesAsString(entitiesInfo);
        }
        
        public System.Threading.Tasks.Task<string> getEntitiesAsStringAsync(string entitiesInfo) {
            return base.Channel.getEntitiesAsStringAsync(entitiesInfo);
        }
        
        public string getEntitiesUsingSchemaAsString(string entitiesInfo, string schema) {
            return base.Channel.getEntitiesUsingSchemaAsString(entitiesInfo, schema);
        }
        
        public System.Threading.Tasks.Task<string> getEntitiesUsingSchemaAsStringAsync(string entitiesInfo, string schema) {
            return base.Channel.getEntitiesUsingSchemaAsStringAsync(entitiesInfo, schema);
        }
        
        public string saveEntityAsString(string entityInfo) {
            return base.Channel.saveEntityAsString(entityInfo);
        }
        
        public System.Threading.Tasks.Task<string> saveEntityAsStringAsync(string entityInfo) {
            return base.Channel.saveEntityAsStringAsync(entityInfo);
        }
        
        public string getEntitySchemaStr(string entityName) {
            return base.Channel.getEntitySchemaStr(entityName);
        }
        
        public System.Threading.Tasks.Task<string> getEntitySchemaStrAsync(string entityName) {
            return base.Channel.getEntitySchemaStrAsync(entityName);
        }
        
        public System.Xml.XmlNode cleanTestData(System.Xml.XmlNode testCaseInfo) {
            return base.Channel.cleanTestData(testCaseInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> cleanTestDataAsync(System.Xml.XmlNode testCaseInfo) {
            return base.Channel.cleanTestDataAsync(testCaseInfo);
        }
        
        public System.Xml.XmlNode getCaseLog(System.Xml.XmlNode caseInfo) {
            return base.Channel.getCaseLog(caseInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getCaseLogAsync(System.Xml.XmlNode caseInfo) {
            return base.Channel.getCaseLogAsync(caseInfo);
        }
        
        public System.Xml.XmlNode getEntityFormLog(System.Xml.XmlNode caseInfo) {
            return base.Channel.getEntityFormLog(caseInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getEntityFormLogAsync(System.Xml.XmlNode caseInfo) {
            return base.Channel.getEntityFormLogAsync(caseInfo);
        }
        
        public System.Xml.XmlNode getEntityLog(System.Xml.XmlNode caseInfo) {
            return base.Channel.getEntityLog(caseInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getEntityLogAsync(System.Xml.XmlNode caseInfo) {
            return base.Channel.getEntityLogAsync(caseInfo);
        }
        
        public System.Xml.XmlNode getEntities(System.Xml.XmlNode entitiesInfo) {
            return base.Channel.getEntities(entitiesInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getEntitiesAsync(System.Xml.XmlNode entitiesInfo) {
            return base.Channel.getEntitiesAsync(entitiesInfo);
        }
        
        public System.Xml.XmlNode getCaseDataUsingSchemaLite(int idCase, System.Xml.XmlNode xsd) {
            return base.Channel.getCaseDataUsingSchemaLite(idCase, xsd);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getCaseDataUsingSchemaLiteAsync(int idCase, System.Xml.XmlNode xsd) {
            return base.Channel.getCaseDataUsingSchemaLiteAsync(idCase, xsd);
        }
        
        public string getCaseDataUsingSchemaLiteAsString(int idCase, string sxsd) {
            return base.Channel.getCaseDataUsingSchemaLiteAsString(idCase, sxsd);
        }
        
        public System.Threading.Tasks.Task<string> getCaseDataUsingSchemaLiteAsStringAsync(int idCase, string sxsd) {
            return base.Channel.getCaseDataUsingSchemaLiteAsStringAsync(idCase, sxsd);
        }
        
        public System.Xml.XmlNode getCaseDataUsingSchema(string idCase, string idWorkItem, System.Xml.XmlNode xsd) {
            return base.Channel.getCaseDataUsingSchema(idCase, idWorkItem, xsd);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getCaseDataUsingSchemaAsync(string idCase, string idWorkItem, System.Xml.XmlNode xsd) {
            return base.Channel.getCaseDataUsingSchemaAsync(idCase, idWorkItem, xsd);
        }
        
        public string getCaseDataUsingSchemaAsString(string idCase, string idWorkItem, string sxsd) {
            return base.Channel.getCaseDataUsingSchemaAsString(idCase, idWorkItem, sxsd);
        }
        
        public System.Threading.Tasks.Task<string> getCaseDataUsingSchemaAsStringAsync(string idCase, string idWorkItem, string sxsd) {
            return base.Channel.getCaseDataUsingSchemaAsStringAsync(idCase, idWorkItem, sxsd);
        }
        
        public System.Xml.XmlNode getCaseDataUsingXPaths(System.Xml.XmlNode xml) {
            return base.Channel.getCaseDataUsingXPaths(xml);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getCaseDataUsingXPathsAsync(System.Xml.XmlNode xml) {
            return base.Channel.getCaseDataUsingXPathsAsync(xml);
        }
        
        public string getCaseDataUsingXPathsAsString(string sXml) {
            return base.Channel.getCaseDataUsingXPathsAsString(sXml);
        }
        
        public System.Threading.Tasks.Task<string> getCaseDataUsingXPathsAsStringAsync(string sXml) {
            return base.Channel.getCaseDataUsingXPathsAsStringAsync(sXml);
        }
        
        public System.Xml.XmlNode getEntitiesUsingSchema(System.Xml.XmlNode entitiesInfo, System.Xml.XmlNode schema) {
            return base.Channel.getEntitiesUsingSchema(entitiesInfo, schema);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getEntitiesUsingSchemaAsync(System.Xml.XmlNode entitiesInfo, System.Xml.XmlNode schema) {
            return base.Channel.getEntitiesUsingSchemaAsync(entitiesInfo, schema);
        }
        
        public System.Xml.XmlNode getEntitySchema(string entityName) {
            return base.Channel.getEntitySchema(entityName);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getEntitySchemaAsync(string entityName) {
            return base.Channel.getEntitySchemaAsync(entityName);
        }
        
        public System.Xml.XmlNode replicateEntity(string entityName) {
            return base.Channel.replicateEntity(entityName);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> replicateEntityAsync(string entityName) {
            return base.Channel.replicateEntityAsync(entityName);
        }
        
        public System.Xml.XmlNode replicateAll() {
            return base.Channel.replicateAll();
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> replicateAllAsync() {
            return base.Channel.replicateAllAsync();
        }
        
        public System.Xml.XmlNode saveEntity(System.Xml.XmlNode entityInfo) {
            return base.Channel.saveEntity(entityInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> saveEntityAsync(System.Xml.XmlNode entityInfo) {
            return base.Channel.saveEntityAsync(entityInfo);
        }
        
        public System.Xml.XmlNode saveEntityWithKey(object oEntityKey, System.Xml.XmlNode entityInfo) {
            return base.Channel.saveEntityWithKey(oEntityKey, entityInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> saveEntityWithKeyAsync(object oEntityKey, System.Xml.XmlNode entityInfo) {
            return base.Channel.saveEntityWithKeyAsync(oEntityKey, entityInfo);
        }
        
        public string saveEntityWithKeyAsString(object oEntityKey, string entityInfo) {
            return base.Channel.saveEntityWithKeyAsString(oEntityKey, entityInfo);
        }
        
        public System.Threading.Tasks.Task<string> saveEntityWithKeyAsStringAsync(object oEntityKey, string entityInfo) {
            return base.Channel.saveEntityWithKeyAsStringAsync(oEntityKey, entityInfo);
        }
    }
}