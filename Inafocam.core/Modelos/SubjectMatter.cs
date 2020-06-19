using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class SubjectMatter
    {
        public SubjectMatter()
        {
            ScholarshipProgramUniversitySubjectMatter = new HashSet<ScholarshipProgramUniversitySubjectMatter>();
            TracingStudyPlanDevelopment = new HashSet<TracingStudyPlanDevelopment>();
        }

        public long SubjectMatterId { get; set; }
        public string SubjectMatterCode { get; set; }
        public string SubjectMatterName { get; set; }
        public long? CreationUserId { get; set; }
        public long? UpgradeUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual User CreationUser { get; set; }
        public virtual Status Status { get; set; }
        public virtual User UpgradeUser { get; set; }
        public virtual ICollection<ScholarshipProgramUniversitySubjectMatter> ScholarshipProgramUniversitySubjectMatter { get; set; }
        public virtual ICollection<TracingStudyPlanDevelopment> TracingStudyPlanDevelopment { get; set; }
    }
}
