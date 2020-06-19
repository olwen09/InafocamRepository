using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class TracingStudyPlanDevelopment
    {
        public long Id { get; set; }
        public long? ScholarshipProgramTracingId { get; set; }
        public long? SubjectMatterId { get; set; }
        public long? TeacherId { get; set; }
        public long? AssignedTeacherId { get; set; }
        public long? HigherTitleSupportMatterId { get; set; }
        public double? ScoreAverageStudents { get; set; }
        public int? ApprovedStudentsQuantity { get; set; }
        public int? ReprovedStudentsQuantity { get; set; }
        public int? DesertedStudentsQuantity { get; set; }
        public short? HigherTitleMatchAssignedMatter { get; set; }
        public long? SubjectMatterScoreReportFileId { get; set; }
        public TimeSpan? SubjectMatterTimeStart { get; set; }
        public TimeSpan? SubjectMatterTimeEnd { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? CreationUserId { get; set; }
        public long? UpgradeUserId { get; set; }
        public long? StatusId { get; set; }

        public virtual Teacher AssignedTeacher { get; set; }
        public virtual TeacherEducation HigherTitleSupportMatter { get; set; }
        public virtual ScholarshipProgramTracing ScholarshipProgramTracing { get; set; }
        public virtual Status Status { get; set; }
        public virtual SubjectMatter SubjectMatter { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
