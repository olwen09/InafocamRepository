using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class ScholarshipProgramUniversity
    {
        public ScholarshipProgramUniversity()
        {
            ScholarshipProgramTracing = new HashSet<ScholarshipProgramTracing>();
            ScholarshipProgramUniversityAgent = new HashSet<ScholarshipProgramUniversityAgent>();
            ScholarshipProgramUniversityAgreement = new HashSet<ScholarshipProgramUniversityAgreement>();
            ScholarshipProgramUniversitySubjectMatter = new HashSet<ScholarshipProgramUniversitySubjectMatter>();
        }

        public long ScholarshipProgramUniversityId { get; set; }
        public long? ScholarshipLevelId { get; set; }
        public long? ScholarshipProgramId { get; set; }
        public long? UniversityId { get; set; }
        public long? ScatProgramId { get; set; }
        public string ScatProgramCode { get; set; }
        public int? ActiveStudents { get; set; }
        public string ContractNumber { get; set; }
        public long? CoordinatorId { get; set; }
        public long? TechnicalId { get; set; }
        public DateTime? AnnouncementStartDate { get; set; }
        public DateTime? AnnouncementEndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Agent Coordinator { get; set; }
        public virtual ScholarshipLevel ScholarshipLevel { get; set; }
        public virtual ScholarshipProgram ScholarshipProgram { get; set; }
        public virtual Status Status { get; set; }
        public virtual Agent Technical { get; set; }
        public virtual University University { get; set; }
        public virtual ICollection<ScholarshipProgramTracing> ScholarshipProgramTracing { get; set; }
        public virtual ICollection<ScholarshipProgramUniversityAgent> ScholarshipProgramUniversityAgent { get; set; }
        public virtual ICollection<ScholarshipProgramUniversityAgreement> ScholarshipProgramUniversityAgreement { get; set; }
        public virtual ICollection<ScholarshipProgramUniversitySubjectMatter> ScholarshipProgramUniversitySubjectMatter { get; set; }
    }
}
