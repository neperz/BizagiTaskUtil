using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace BizagiServicesClient
{
    /* 
     Licensed under the Apache License, Version 2.0

     http://www.apache.org/licenses/LICENSE-2.0
     */


        [XmlRoot(ElementName = "savedMessage")]
        public class SavedMessage
        {
            [XmlElement(ElementName = "Entities")]
            public string Entities { get; set; }
        }

        [XmlRoot(ElementName = "processWorkflowClass")]
        public class ProcessWorkflowClass
        {
            [XmlElement(ElementName = "workflowClassId")]
            public string WorkflowClassId { get; set; }
            [XmlElement(ElementName = "workflowClassName")]
            public string WorkflowClassName { get; set; }
            [XmlElement(ElementName = "workflowClassDisplayName")]
            public string WorkflowClassDisplayName { get; set; }
            [XmlElement(ElementName = "workflowClassDescription")]
            public string WorkflowClassDescription { get; set; }
            [XmlElement(ElementName = "workflowClassHelpText")]
            public string WorkflowClassHelpText { get; set; }
            [XmlElement(ElementName = "workflowClassHelpURL")]
            public string WorkflowClassHelpURL { get; set; }
            [XmlElement(ElementName = "workflowClassDisplayOrder")]
            public string WorkflowClassDisplayOrder { get; set; }
            [XmlElement(ElementName = "workflowClassCreationDate")]
            public string WorkflowClassCreationDate { get; set; }
            [XmlElement(ElementName = "workflowClassGlobalForm")]
            public string WorkflowClassGlobalForm { get; set; }
            [XmlElement(ElementName = "workflowClassAllocationPrinciple")]
            public string WorkflowClassAllocationPrinciple { get; set; }
            [XmlElement(ElementName = "workflowClassProcessType")]
            public string WorkflowClassProcessType { get; set; }
            [XmlElement(ElementName = "workflowClassDisplay")]
            public string WorkflowClassDisplay { get; set; }
            [XmlElement(ElementName = "workflowClassUseParentRadicationNumber")]
            public string WorkflowClassUseParentRadicationNumber { get; set; }
            [XmlElement(ElementName = "workflowClassSupportsScopes")]
            public string WorkflowClassSupportsScopes { get; set; }
            [XmlElement(ElementName = "caseAccessType")]
            public string CaseAccessType { get; set; }
            [XmlElement(ElementName = "guidWfClass")]
            public string GuidWfClass { get; set; }
        }

        [XmlRoot(ElementName = "processError")]
        public class ProcessError
        {
            [XmlElement(ElementName = "errorCode")]
            public string ErrorCode { get; set; }
            [XmlElement(ElementName = "errorMessage")]
            public string ErrorMessage { get; set; }
        }

        [XmlRoot(ElementName = "IdAdhocTask")]
        public class IdAdhocTask
        {
            [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
            public string Nil { get; set; }
        }

        [XmlRoot(ElementName = "task")]
        public class Task
        {
            [XmlElement(ElementName = "taskId")]
            public string TaskId { get; set; }
            [XmlElement(ElementName = "taskName")]
            public string TaskName { get; set; }
            [XmlElement(ElementName = "taskDisplayName")]
            public string TaskDisplayName { get; set; }
            [XmlElement(ElementName = "taskDescription")]
            public string TaskDescription { get; set; }
            [XmlElement(ElementName = "taskHelpText")]
            public string TaskHelpText { get; set; }
            [XmlElement(ElementName = "taskEstimatedDuration")]
            public string TaskEstimatedDuration { get; set; }
            [XmlElement(ElementName = "taskType")]
            public string TaskType { get; set; }
            [XmlElement(ElementName = "taskCost")]
            public string TaskCost { get; set; }
            [XmlElement(ElementName = "taskPriority")]
            public string TaskPriority { get; set; }
            [XmlElement(ElementName = "taskTransactional")]
            public string TaskTransactional { get; set; }
            [XmlElement(ElementName = "taskCompensation")]
            public string TaskCompensation { get; set; }
            [XmlElement(ElementName = "taskTimerEventDuration")]
            public string TaskTimerEventDuration { get; set; }
            [XmlElement(ElementName = "AllowsReassign")]
            public string AllowsReassign { get; set; }
            [XmlElement(ElementName = "SendNotification")]
            public string SendNotification { get; set; }
            [XmlElement(ElementName = "SendAlarms")]
            public string SendAlarms { get; set; }
            [XmlElement(ElementName = "ExtendedEstimatedDuration")]
            public string ExtendedEstimatedDuration { get; set; }
            [XmlElement(ElementName = "Form")]
            public string Form { get; set; }
            [XmlElement(ElementName = "IsAsynchTask")]
            public string IsAsynchTask { get; set; }
            [XmlElement(ElementName = "NumberOfRetries")]
            public string NumberOfRetries { get; set; }
            [XmlElement(ElementName = "RetryInterval")]
            public string RetryInterval { get; set; }
            [XmlElement(ElementName = "ShowFeedback")]
            public string ShowFeedback { get; set; }
            [XmlElement(ElementName = "TimeoutSeconds")]
            public string TimeoutSeconds { get; set; }
            [XmlElement(ElementName = "Guid")]
            public string Guid { get; set; }
            [XmlElement(ElementName = "tskMobileAccess")]
            public string TskMobileAccess { get; set; }
            [XmlElement(ElementName = "tskMessageAfterProcess")]
            public string TskMessageAfterProcess { get; set; }
            [XmlElement(ElementName = "allowReleaseActivity")]
            public string AllowReleaseActivity { get; set; }
            [XmlElement(ElementName = "IdActivity")]
            public string IdActivity { get; set; }
            [XmlElement(ElementName = "AllowEditionActivity")]
            public string AllowEditionActivity { get; set; }
            [XmlElement(ElementName = "IdAdhocTask")]
            public IdAdhocTask IdAdhocTask { get; set; }

            [XmlIgnore]
            public string workItemId { get; set; }
            [XmlIgnore]
            public string workItemState { get; set; }
            [XmlIgnore]
            public string workItemEntryDate { get; set; }
            [XmlIgnore]
            public string workItemDuration { get; set; }
            [XmlIgnore]
            public string workItemEstimatedSolutionDate { get; set; }
    }

        [XmlRoot(ElementName = "workItem")]
        public class WorkItem
        {
            [XmlElement(ElementName = "workItemId")]
            public string WorkItemId { get; set; }
            [XmlElement(ElementName = "workItemState")]
            public string WorkItemState { get; set; }
            [XmlElement(ElementName = "workItemEntryDate")]
            public string WorkItemEntryDate { get; set; }
            [XmlElement(ElementName = "workItemDuration")]
            public string WorkItemDuration { get; set; }
            [XmlElement(ElementName = "workItemSubprocesses")]
            public string WorkItemSubprocesses { get; set; }
            [XmlElement(ElementName = "workItemEstimatedSolutionDate")]
            public string WorkItemEstimatedSolutionDate { get; set; }
            [XmlElement(ElementName = "workItemSolutionDate")]
            public string WorkItemSolutionDate { get; set; }
            [XmlElement(ElementName = "task")]
            public Task Task { get; set; }
            [XmlElement(ElementName = "Guid")]
            public string Guid { get; set; }
        }

        [XmlRoot(ElementName = "CurrentWorkItems")]
        public class CurrentWorkItems
        {
            [XmlElement(ElementName = "workItem")]
            public WorkItem WorkItem { get; set; }
        }

        [XmlRoot(ElementName = "process")]
        public class Process
        {
            [XmlElement(ElementName = "processId")]
            public string ProcessId { get; set; }
            [XmlElement(ElementName = "caseGuid")]
            public string CaseGuid { get; set; }
            [XmlElement(ElementName = "processRadNumber")]
            public string ProcessRadNumber { get; set; }
            [XmlElement(ElementName = "savedMessage")]
            public SavedMessage SavedMessage { get; set; }
            [XmlElement(ElementName = "processCreationDate")]
            public string ProcessCreationDate { get; set; }
            [XmlElement(ElementName = "processSolutionDate")]
            public string ProcessSolutionDate { get; set; }
            [XmlElement(ElementName = "processWorkflowClass")]
            public ProcessWorkflowClass ProcessWorkflowClass { get; set; }
            [XmlElement(ElementName = "processError")]
            public ProcessError ProcessError { get; set; }
            [XmlElement(ElementName = "CurrentWorkItems")]
            public CurrentWorkItems CurrentWorkItems { get; set; }
        }

        [XmlRoot(ElementName = "processes")]
        public class Processes
        {
        internal string xml;

        [XmlElement(ElementName = "process")]
        public List<Process> Process { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
    }

    

}