using System;
using System.Collections.Generic;


namespace Inafocam.core.Modelos
{
    public partial class User  
    {
        public User()
        {
            AddressCreationUser = new HashSet<Address>();
            AddressUpgradeUser = new HashSet<Address>();
            AgentCreationUser = new HashSet<Agent>();
            AgentUpgradeUser = new HashSet<Agent>();
            AgentUser = new HashSet<Agent>();
            CommunicationCreationUser = new HashSet<Communication>();
            CommunicationUpgradeUser = new HashSet<Communication>();
            CompanyCreationUser = new HashSet<Company>();
            CompanyManager = new HashSet<Company>();
            CompanyOwner = new HashSet<Company>();
            CompanyUpgradeUser = new HashSet<Company>();
            ContactCreationUser = new HashSet<Contact>();
            ContactUpgradeUser = new HashSet<Contact>();
            FileCreationUser = new HashSet<File>();
            FileUpgradeUser = new HashSet<File>();
            InverseCreationUser = new HashSet<User>();
            InverseUpgradeUser = new HashSet<User>();
            OfficeCreationUser = new HashSet<Office>();
            OfficeManager = new HashSet<Office>();
            OfficeUpgradeUser = new HashSet<Office>();
            ScheduleCreationUser = new HashSet<Schedule>();
            ScheduleUpdatingUser = new HashSet<Schedule>();
            ScholarshipProgramTracingAgreementCommentedUser = new HashSet<ScholarshipProgramTracingAgreement>();
            ScholarshipProgramTracingAgreementCreationUser = new HashSet<ScholarshipProgramTracingAgreement>();
            ScholarshipProgramTracingAgreementUpgradeUser = new HashSet<ScholarshipProgramTracingAgreement>();
            ScholarshipProgramTracingCreationUser = new HashSet<ScholarshipProgramTracing>();
            ScholarshipProgramTracingUpgradeUser = new HashSet<ScholarshipProgramTracing>();
            ScholarshipProgramUniversityAgreementCreationUser = new HashSet<ScholarshipProgramUniversityAgreement>();
            ScholarshipProgramUniversityAgreementUpgradeUser = new HashSet<ScholarshipProgramUniversityAgreement>();
            SubjectMatterCreationUser = new HashSet<SubjectMatter>();
            SubjectMatterUpgradeUser = new HashSet<SubjectMatter>();
            UserMapRole = new HashSet<UserMapRole>();
            UserRoleCreationUser = new HashSet<UserRole>();
            UserRoleUpgradeUser = new HashSet<UserRole>();
            UserUniversity = new HashSet<UserUniversity>();
        }

        public long UserId { get; set; }
        public long? CompanyId { get; set; }
        public long? OfficeId { get; set; }
        public long? ContactId { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public long? UserRoleId { get; set; }
        public short? UserExpirePassword { get; set; }
        public DateTime? UserDateExpirePassword { get; set; }
        public long? UserScheduleId { get; set; }
        public long? CreationUserId { get; set; }
        public long? UpgradeUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual User CreationUser { get; set; }
        public virtual Office Office { get; set; }
        public virtual Status Status { get; set; }
        public virtual User UpgradeUser { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual Schedule UserSchedule { get; set; }
        public virtual ICollection<Address> AddressCreationUser { get; set; }
        public virtual ICollection<Address> AddressUpgradeUser { get; set; }
        public virtual ICollection<Agent> AgentCreationUser { get; set; }
        public virtual ICollection<Agent> AgentUpgradeUser { get; set; }
        public virtual ICollection<Agent> AgentUser { get; set; }
        public virtual ICollection<Communication> CommunicationCreationUser { get; set; }
        public virtual ICollection<Communication> CommunicationUpgradeUser { get; set; }
        public virtual ICollection<Company> CompanyCreationUser { get; set; }
        public virtual ICollection<Company> CompanyManager { get; set; }
        public virtual ICollection<Company> CompanyOwner { get; set; }
        public virtual ICollection<Company> CompanyUpgradeUser { get; set; }
        public virtual ICollection<Contact> ContactCreationUser { get; set; }
        public virtual ICollection<Contact> ContactUpgradeUser { get; set; }
        public virtual ICollection<File> FileCreationUser { get; set; }
        public virtual ICollection<File> FileUpgradeUser { get; set; }
        public virtual ICollection<User> InverseCreationUser { get; set; }
        public virtual ICollection<User> InverseUpgradeUser { get; set; }
        public virtual ICollection<Office> OfficeCreationUser { get; set; }
        public virtual ICollection<Office> OfficeManager { get; set; }
        public virtual ICollection<Office> OfficeUpgradeUser { get; set; }
        public virtual ICollection<Schedule> ScheduleCreationUser { get; set; }
        public virtual ICollection<Schedule> ScheduleUpdatingUser { get; set; }
        public virtual ICollection<ScholarshipProgramTracingAgreement> ScholarshipProgramTracingAgreementCommentedUser { get; set; }
        public virtual ICollection<ScholarshipProgramTracingAgreement> ScholarshipProgramTracingAgreementCreationUser { get; set; }
        public virtual ICollection<ScholarshipProgramTracingAgreement> ScholarshipProgramTracingAgreementUpgradeUser { get; set; }
        public virtual ICollection<ScholarshipProgramTracing> ScholarshipProgramTracingCreationUser { get; set; }
        public virtual ICollection<ScholarshipProgramTracing> ScholarshipProgramTracingUpgradeUser { get; set; }
        public virtual ICollection<ScholarshipProgramUniversityAgreement> ScholarshipProgramUniversityAgreementCreationUser { get; set; }
        public virtual ICollection<ScholarshipProgramUniversityAgreement> ScholarshipProgramUniversityAgreementUpgradeUser { get; set; }
        public virtual ICollection<SubjectMatter> SubjectMatterCreationUser { get; set; }
        public virtual ICollection<SubjectMatter> SubjectMatterUpgradeUser { get; set; }
        public virtual ICollection<UserMapRole> UserMapRole { get; set; }
        public virtual ICollection<UserRole> UserRoleCreationUser { get; set; }
        public virtual ICollection<UserRole> UserRoleUpgradeUser { get; set; }
        public virtual ICollection<UserUniversity> UserUniversity { get; set; }
    }
}
