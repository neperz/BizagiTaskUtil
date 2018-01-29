using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BizagiServicesClient
{

    [XmlRoot(ElementName = "idArea")]
    public class IdArea
    {
        [XmlElement(ElementName = "areaName")]
        public string AreaName { get; set; }
        [XmlElement(ElementName = "areaDescription")]
        public string AreaDescription { get; set; }
        [XmlElement(ElementName = "areaDisplayName")]
        public string AreaDisplayName { get; set; }
        [XmlElement(ElementName = "idArea")]
        public string IdAreaIn { get; set; }
        [XmlAttribute(AttributeName = "entityName")]
        public string EntityName { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
    }

    [XmlRoot(ElementName = "idTimeZone")]
    public class IdTimeZone
    {
        [XmlElement(ElementName = "idBATimeZone")]
        public string IdBATimeZone { get; set; }
        [XmlElement(ElementName = "tzName")]
        public string TzName { get; set; }
        [XmlElement(ElementName = "tzDisplayName")]
        public string TzDisplayName { get; set; }
        [XmlAttribute(AttributeName = "entityName")]
        public string EntityName { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
    }

    [XmlRoot(ElementName = "language")]
    public class Language
    {
        [XmlElement(ElementName = "idLGLanguage")]
        public string IdLGLanguage { get; set; }
        [XmlElement(ElementName = "language")]
        public string LanguageIn { get; set; }
        [XmlElement(ElementName = "CultureDisplayName")]
        public string CultureDisplayName { get; set; }
        [XmlElement(ElementName = "CultureName")]
        public string CultureName { get; set; }
        [XmlElement(ElementName = "State")]
        public string State { get; set; }
        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
        [XmlAttribute(AttributeName = "entityName")]
        public string EntityName { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
    }

    [XmlRoot(ElementName = "idLocation")]
    public class IdLocation
    {
        [XmlElement(ElementName = "idOrg")]
        public string IdOrg { get; set; }
        [XmlElement(ElementName = "locDisplayName")]
        public string LocDisplayName { get; set; }
        [XmlElement(ElementName = "idLocation")]
        public string IdLocationIn { get; set; }
        [XmlElement(ElementName = "idWorkingTimeSchema")]
        public string IdWorkingTimeSchema { get; set; }
        [XmlElement(ElementName = "locDescription")]
        public string LocDescription { get; set; }
        [XmlElement(ElementName = "idTimeZone")]
        public string IdTimeZone { get; set; }
        [XmlElement(ElementName = "locName")]
        public string LocName { get; set; }
        [XmlElement(ElementName = "costLocation")]
        public string CostLocation { get; set; }
        [XmlAttribute(AttributeName = "entityName")]
        public string EntityName { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
    }

    [XmlRoot(ElementName = "userStartPage")]
    public class UserStartPage
    {
        [XmlElement(ElementName = "idStartPage")]
        public string IdStartPage { get; set; }
        [XmlElement(ElementName = "startPageValue")]
        public string StartPageValue { get; set; }
        [XmlAttribute(AttributeName = "entityName")]
        public string EntityName { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
    }

    [XmlRoot(ElementName = "idWorkingTimeSchema")]
    public class IdWorkingTimeSchema
    {
        [XmlElement(ElementName = "wtsName")]
        public string WtsName { get; set; }
        [XmlElement(ElementName = "idWorkingTimeSchema")]
        public string IdWorkingTimeSchemaIn { get; set; }
        [XmlAttribute(AttributeName = "entityName")]
        public string EntityName { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
    }

    [XmlRoot(ElementName = "ROLE")]
    public class ROLE
    {
        [XmlElement(ElementName = "roleDisplayName")]
        public string RoleDisplayName { get; set; }
        [XmlElement(ElementName = "roleDescription")]
        public string RoleDescription { get; set; }
        [XmlElement(ElementName = "idRole")]
        public string IdRole { get; set; }
        [XmlElement(ElementName = "roleName")]
        public string RoleName { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
    }

    [XmlRoot(ElementName = "Roles")]
    public class Roles
    {
        [XmlElement(ElementName = "ROLE")]
        public List<ROLE> ROLE { get; set; }
    }

    [XmlRoot(ElementName = "ORGPOSITION")]
    public class ORGPOSITION
    {
        [XmlElement(ElementName = "idPosition")]
        public string IdPosition { get; set; }
        [XmlElement(ElementName = "posName")]
        public string PosName { get; set; }
        [XmlElement(ElementName = "idOrg")]
        public string IdOrg { get; set; }
        [XmlElement(ElementName = "posDisplayName")]
        public string PosDisplayName { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
        [XmlElement(ElementName = "idParentPosition")]
        public string IdParentPosition { get; set; }
        [XmlElement(ElementName = "costPosition")]
        public string CostPosition { get; set; }
        [XmlElement(ElementName = "posDescription")]
        public string PosDescription { get; set; }
    }

    [XmlRoot(ElementName = "Positions")]
    public class Positions
    {
        [XmlElement(ElementName = "ORGPOSITION")]
        public List<ORGPOSITION> ORGPOSITION { get; set; }
    }

    [XmlRoot(ElementName = "ORG")]
    public class ORG
    {
        [XmlElement(ElementName = "idWorkingTimeSchema")]
        public string IdWorkingTimeSchema { get; set; }
        [XmlElement(ElementName = "orgCreationDate")]
        public string OrgCreationDate { get; set; }
        [XmlElement(ElementName = "idOrg")]
        public string IdOrg { get; set; }
        [XmlElement(ElementName = "idHolidaySchema")]
        public string IdHolidaySchema { get; set; }
        [XmlElement(ElementName = "orgName")]
        public string OrgName { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
    }

    [XmlRoot(ElementName = "Organizations")]
    public class Organizations
    {
        [XmlElement(ElementName = "ORG")]
        public ORG ORG { get; set; }
    }

    [XmlRoot(ElementName = "WFUSER")]
    public class WFUSER
    {
        [XmlElement(ElementName = "idArea")]
        public IdArea IdArea { get; set; }
        [XmlElement(ElementName = "enabled")]
        public string Enabled { get; set; }
        [XmlElement(ElementName = "userName")]
        public string UserName { get; set; }
        [XmlElement(ElementName = "idTimeZone")]
        public IdTimeZone IdTimeZone { get; set; }
        [XmlElement(ElementName = "language")]
        public Language Language { get; set; }
        [XmlElement(ElementName = "fullName")]
        public string FullName { get; set; }
        [XmlElement(ElementName = "notifByEmail")]
        public string NotifByEmail { get; set; }
        [XmlElement(ElementName = "idLocation")]
        public IdLocation IdLocation { get; set; }
        [XmlElement(ElementName = "CreatedCasesSkipAssigRules")]
        public string CreatedCasesSkipAssigRules { get; set; }
        [XmlElement(ElementName = "domain")]
        public string Domain { get; set; }
        [XmlElement(ElementName = "userStartPage")]
        public UserStartPage UserStartPage { get; set; }
        [XmlElement(ElementName = "idUser")]
        public string IdUser { get; set; }
        [XmlElement(ElementName = "contactEmail")]
        public string ContactEmail { get; set; }
        [XmlElement(ElementName = "notifByMessenger")]
        public string NotifByMessenger { get; set; }
        [XmlElement(ElementName = "idWorkingTimeSchema")]
        public IdWorkingTimeSchema IdWorkingTimeSchema { get; set; }
        [XmlElement(ElementName = "notifByCell")]
        public string NotifByCell { get; set; }
        [XmlElement(ElementName = "enabledForAssignation")]
        public string EnabledForAssignation { get; set; }
        [XmlElement(ElementName = "userPicture")]
        public string UserPicture { get; set; }
        [XmlElement(ElementName = "offlineForms")]
        public string OfflineForms { get; set; }
        [XmlElement(ElementName = "DelegateEnabled")]
        public string DelegateEnabled { get; set; }
        [XmlElement(ElementName = "Roles")]
        public Roles Roles { get; set; }
        [XmlElement(ElementName = "Positions")]
        public Positions Positions { get; set; }
        [XmlElement(ElementName = "Organizations")]
        public Organizations Organizations { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
        [XmlElement(ElementName = "idBossUser")]
        public IdBossUser IdBossUser { get; set; }
        [XmlElement(ElementName = "idDelegate")]
        public IdDelegate IdDelegate { get; set; }
        [XmlElement(ElementName = "Ramal")]
        public string Ramal { get; set; }
        [XmlElement(ElementName = "CPF")]
        public string CPF { get; set; }
        [XmlElement(ElementName = "Skills")]
        public Skills Skills { get; set; }
        [XmlElement(ElementName = "IDDynamics")]
        public string IDDynamics { get; set; }
    }

    [XmlRoot(ElementName = "idBossUser")]
    public class IdBossUser
    {
        [XmlElement(ElementName = "idArea")]
        public string IdArea { get; set; }
        [XmlElement(ElementName = "enabled")]
        public string Enabled { get; set; }
        [XmlElement(ElementName = "userName")]
        public string UserName { get; set; }
        [XmlElement(ElementName = "fullName")]
        public string FullName { get; set; }
        [XmlElement(ElementName = "notifByEmail")]
        public string NotifByEmail { get; set; }
        [XmlElement(ElementName = "idLocation")]
        public string IdLocation { get; set; }
        [XmlElement(ElementName = "CreatedCasesSkipAssigRules")]
        public string CreatedCasesSkipAssigRules { get; set; }
        [XmlElement(ElementName = "domain")]
        public string Domain { get; set; }
        [XmlElement(ElementName = "userStartPage")]
        public string UserStartPage { get; set; }
        [XmlElement(ElementName = "idBossUser")]
        public string IdBossUserIn { get; set; }
        [XmlElement(ElementName = "idUser")]
        public string IdUser { get; set; }
        [XmlElement(ElementName = "contactEmail")]
        public string ContactEmail { get; set; }
        [XmlElement(ElementName = "enabledForAssignation")]
        public string EnabledForAssignation { get; set; }
        [XmlElement(ElementName = "offlineForms")]
        public string OfflineForms { get; set; }
        [XmlAttribute(AttributeName = "entityName")]
        public string EntityName { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
        [XmlElement(ElementName = "userPicture")]
        public string UserPicture { get; set; }
        [XmlElement(ElementName = "idDelegate")]
        public string IdDelegate { get; set; }
        [XmlElement(ElementName = "Ramal")]
        public string Ramal { get; set; }
        [XmlElement(ElementName = "CPF")]
        public string CPF { get; set; }
    }

    [XmlRoot(ElementName = "idDelegate")]
    public class IdDelegate
    {
        [XmlElement(ElementName = "idArea")]
        public string IdArea { get; set; }
        [XmlElement(ElementName = "enabled")]
        public string Enabled { get; set; }
        [XmlElement(ElementName = "userName")]
        public string UserName { get; set; }
        [XmlElement(ElementName = "Ramal")]
        public string Ramal { get; set; }
        [XmlElement(ElementName = "idTimeZone")]
        public string IdTimeZone { get; set; }
        [XmlElement(ElementName = "language")]
        public string Language { get; set; }
        [XmlElement(ElementName = "fullName")]
        public string FullName { get; set; }
        [XmlElement(ElementName = "notifByEmail")]
        public string NotifByEmail { get; set; }
        [XmlElement(ElementName = "idLocation")]
        public string IdLocation { get; set; }
        [XmlElement(ElementName = "CreatedCasesSkipAssigRules")]
        public string CreatedCasesSkipAssigRules { get; set; }
        [XmlElement(ElementName = "domain")]
        public string Domain { get; set; }
        [XmlElement(ElementName = "userStartPage")]
        public string UserStartPage { get; set; }
        [XmlElement(ElementName = "idBossUser")]
        public string IdBossUser { get; set; }
        [XmlElement(ElementName = "idUser")]
        public string IdUser { get; set; }
        [XmlElement(ElementName = "CPF")]
        public string CPF { get; set; }
        [XmlElement(ElementName = "contactEmail")]
        public string ContactEmail { get; set; }
        [XmlElement(ElementName = "enabledForAssignation")]
        public string EnabledForAssignation { get; set; }
        [XmlElement(ElementName = "userPicture")]
        public string UserPicture { get; set; }
        [XmlElement(ElementName = "offlineForms")]
        public string OfflineForms { get; set; }
        [XmlAttribute(AttributeName = "entityName")]
        public string EntityName { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
    }

    [XmlRoot(ElementName = "SKILL")]
    public class SKILL
    {
        [XmlElement(ElementName = "idSkill")]
        public string IdSkill { get; set; }
        [XmlElement(ElementName = "skillName")]
        public string SkillName { get; set; }
        [XmlElement(ElementName = "skillDisplayName")]
        public string SkillDisplayName { get; set; }
        [XmlElement(ElementName = "skillDescription")]
        public string SkillDescription { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
    }

    [XmlRoot(ElementName = "Skills")]
    public class Skills
    {
        [XmlElement(ElementName = "SKILL")]
        public List<SKILL> SKILL { get; set; }
    }

    [XmlRoot(ElementName = "Entities")]
    public class EntitiesWfUser
    {
        [XmlElement(ElementName = "WFUSER")]
        public List<WFUSER> WFUSER { get; set; }
    }

    [XmlRoot(ElementName = "BizAgiWSResponse")]
    public class BizAgiWSResponse
    {
        [XmlElement(ElementName = "Entities")]
        public EntitiesWfUser Entities { get; set; }
    }

}
