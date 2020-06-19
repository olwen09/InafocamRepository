using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class Status
    {
        public Status()
        {
            Address = new HashSet<Address>();
            AddressType = new HashSet<AddressType>();
            Agent = new HashSet<Agent>();
            AgentType = new HashSet<AgentType>();
            City = new HashSet<City>();
            Communication = new HashSet<Communication>();
            Company = new HashSet<Company>();
            CompanyType = new HashSet<CompanyType>();
            Contact = new HashSet<Contact>();
            ContactAddress = new HashSet<ContactAddress>();
            ContactCommunication = new HashSet<ContactCommunication>();
            ContactType = new HashSet<ContactType>();
            Country = new HashSet<Country>();
            DocumentType = new HashSet<DocumentType>();
            EducationType = new HashSet<EducationType>();
            File = new HashSet<File>();
            FileType = new HashSet<FileType>();
            Menu = new HashSet<Menu>();
            MenuType = new HashSet<MenuType>();
            Object = new HashSet<Object>();
            ObjectMapping = new HashSet<ObjectMapping>();
            Office = new HashSet<Office>();
            Province = new HashSet<Province>();
            Schedule = new HashSet<Schedule>();
            ScholarshipLevel = new HashSet<ScholarshipLevel>();
            ScholarshipProgram = new HashSet<ScholarshipProgram>();
            ScholarshipProgramTracing = new HashSet<ScholarshipProgramTracing>();
            ScholarshipProgramTracingAgreement = new HashSet<ScholarshipProgramTracingAgreement>();
            ScholarshipProgramTracingAgreementFile = new HashSet<ScholarshipProgramTracingAgreementFile>();
            ScholarshipProgramTracingCourse = new HashSet<ScholarshipProgramTracingCourse>();
            ScholarshipProgramTracingCourseFile = new HashSet<ScholarshipProgramTracingCourseFile>();
            ScholarshipProgramTracingPractice = new HashSet<ScholarshipProgramTracingPractice>();
            ScholarshipProgramTracingPracticePlanning = new HashSet<ScholarshipProgramTracingPracticePlanning>();
            ScholarshipProgramTracingQualitySystem = new HashSet<ScholarshipProgramTracingQualitySystem>();
            ScholarshipProgramTracingStudentPractice = new HashSet<ScholarshipProgramTracingStudentPractice>();
            ScholarshipProgramTracingStudentSupport = new HashSet<ScholarshipProgramTracingStudentSupport>();
            ScholarshipProgramUniversity = new HashSet<ScholarshipProgramUniversity>();
            ScholarshipProgramUniversityAgent = new HashSet<ScholarshipProgramUniversityAgent>();
            ScholarshipProgramUniversityAgreement = new HashSet<ScholarshipProgramUniversityAgreement>();
            ScholarshipProgramUniversitySubjectMatter = new HashSet<ScholarshipProgramUniversitySubjectMatter>();
            SubjectMatter = new HashSet<SubjectMatter>();
            Teacher = new HashSet<Teacher>();
            TeacherEducation = new HashSet<TeacherEducation>();
            TeacherFile = new HashSet<TeacherFile>();
            TeacherFileType = new HashSet<TeacherFileType>();
            TeacherHiringType = new HashSet<TeacherHiringType>();
            TeacherResearch = new HashSet<TeacherResearch>();
            TracingStudyPlanDevelopment = new HashSet<TracingStudyPlanDevelopment>();
            University = new HashSet<University>();
            User = new HashSet<User>();
            UserRole = new HashSet<UserRole>();
            UserUniversity = new HashSet<UserUniversity>();
        }

        public long StatusId { get; set; }
        public string StatusName { get; set; }
        public long? TableId { get; set; }
        public string TableName { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<AddressType> AddressType { get; set; }
        public virtual ICollection<Agent> Agent { get; set; }
        public virtual ICollection<AgentType> AgentType { get; set; }
        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<Communication> Communication { get; set; }
        public virtual ICollection<Company> Company { get; set; }
        public virtual ICollection<CompanyType> CompanyType { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }
        public virtual ICollection<ContactAddress> ContactAddress { get; set; }
        public virtual ICollection<ContactCommunication> ContactCommunication { get; set; }
        public virtual ICollection<ContactType> ContactType { get; set; }
        public virtual ICollection<Country> Country { get; set; }
        public virtual ICollection<DocumentType> DocumentType { get; set; }
        public virtual ICollection<EducationType> EducationType { get; set; }
        public virtual ICollection<File> File { get; set; }
        public virtual ICollection<FileType> FileType { get; set; }
        public virtual ICollection<Menu> Menu { get; set; }
        public virtual ICollection<MenuType> MenuType { get; set; }
        public virtual ICollection<Object> Object { get; set; }
        public virtual ICollection<ObjectMapping> ObjectMapping { get; set; }
        public virtual ICollection<Office> Office { get; set; }
        public virtual ICollection<Province> Province { get; set; }
        public virtual ICollection<Schedule> Schedule { get; set; }
        public virtual ICollection<ScholarshipLevel> ScholarshipLevel { get; set; }
        public virtual ICollection<ScholarshipProgram> ScholarshipProgram { get; set; }
        public virtual ICollection<ScholarshipProgramTracing> ScholarshipProgramTracing { get; set; }
        public virtual ICollection<ScholarshipProgramTracingAgreement> ScholarshipProgramTracingAgreement { get; set; }
        public virtual ICollection<ScholarshipProgramTracingAgreementFile> ScholarshipProgramTracingAgreementFile { get; set; }
        public virtual ICollection<ScholarshipProgramTracingCourse> ScholarshipProgramTracingCourse { get; set; }
        public virtual ICollection<ScholarshipProgramTracingCourseFile> ScholarshipProgramTracingCourseFile { get; set; }
        public virtual ICollection<ScholarshipProgramTracingPractice> ScholarshipProgramTracingPractice { get; set; }
        public virtual ICollection<ScholarshipProgramTracingPracticePlanning> ScholarshipProgramTracingPracticePlanning { get; set; }
        public virtual ICollection<ScholarshipProgramTracingQualitySystem> ScholarshipProgramTracingQualitySystem { get; set; }
        public virtual ICollection<ScholarshipProgramTracingStudentPractice> ScholarshipProgramTracingStudentPractice { get; set; }
        public virtual ICollection<ScholarshipProgramTracingStudentSupport> ScholarshipProgramTracingStudentSupport { get; set; }
        public virtual ICollection<ScholarshipProgramUniversity> ScholarshipProgramUniversity { get; set; }
        public virtual ICollection<ScholarshipProgramUniversityAgent> ScholarshipProgramUniversityAgent { get; set; }
        public virtual ICollection<ScholarshipProgramUniversityAgreement> ScholarshipProgramUniversityAgreement { get; set; }
        public virtual ICollection<ScholarshipProgramUniversitySubjectMatter> ScholarshipProgramUniversitySubjectMatter { get; set; }
        public virtual ICollection<SubjectMatter> SubjectMatter { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }
        public virtual ICollection<TeacherEducation> TeacherEducation { get; set; }
        public virtual ICollection<TeacherFile> TeacherFile { get; set; }
        public virtual ICollection<TeacherFileType> TeacherFileType { get; set; }
        public virtual ICollection<TeacherHiringType> TeacherHiringType { get; set; }
        public virtual ICollection<TeacherResearch> TeacherResearch { get; set; }
        public virtual ICollection<TracingStudyPlanDevelopment> TracingStudyPlanDevelopment { get; set; }
        public virtual ICollection<University> University { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
        public virtual ICollection<UserUniversity> UserUniversity { get; set; }
    }
}
