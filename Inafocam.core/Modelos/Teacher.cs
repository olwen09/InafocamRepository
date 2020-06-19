using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class Teacher
    {
        public Teacher()
        {
            ScholarshipProgramUniversitySubjectMatterPredictedTeacher = new HashSet<ScholarshipProgramUniversitySubjectMatter>();
            ScholarshipProgramUniversitySubjectMatterTeacher = new HashSet<ScholarshipProgramUniversitySubjectMatter>();
            TeacherEducation = new HashSet<TeacherEducation>();
            TeacherFile = new HashSet<TeacherFile>();
            TeacherResearch = new HashSet<TeacherResearch>();
            TracingStudyPlanDevelopmentAssignedTeacher = new HashSet<TracingStudyPlanDevelopment>();
            TracingStudyPlanDevelopmentTeacher = new HashSet<TracingStudyPlanDevelopment>();
        }

        public long TeacherId { get; set; }
        public long? ContactId { get; set; }
        public long? HigherTeacherEducationId { get; set; }
        public long? TeacherHiringTypeId { get; set; }
        public string TeacherCategory { get; set; }
        public DateTime? TeacherJobStartDate { get; set; }
        public short? TeacherIsPac { get; set; }
        public short? TeacherHasAdminFunctions { get; set; }
        public short? TeacherWorkForOtherInstitutions { get; set; }
        public short? TeacherMatchHigherTitle { get; set; }
        public int? TeacherResearchProcess { get; set; }
        public int? TeacherResearchPublished { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual TeacherEducation HigherTeacherEducation { get; set; }
        public virtual Status Status { get; set; }
        public virtual TeacherHiringType TeacherHiringType { get; set; }
        public virtual ICollection<ScholarshipProgramUniversitySubjectMatter> ScholarshipProgramUniversitySubjectMatterPredictedTeacher { get; set; }
        public virtual ICollection<ScholarshipProgramUniversitySubjectMatter> ScholarshipProgramUniversitySubjectMatterTeacher { get; set; }
        public virtual ICollection<TeacherEducation> TeacherEducation { get; set; }
        public virtual ICollection<TeacherFile> TeacherFile { get; set; }
        public virtual ICollection<TeacherResearch> TeacherResearch { get; set; }
        public virtual ICollection<TracingStudyPlanDevelopment> TracingStudyPlanDevelopmentAssignedTeacher { get; set; }
        public virtual ICollection<TracingStudyPlanDevelopment> TracingStudyPlanDevelopmentTeacher { get; set; }
    }
}
