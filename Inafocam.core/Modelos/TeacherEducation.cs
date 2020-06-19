using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class TeacherEducation
    {
        public TeacherEducation()
        {
            Teacher = new HashSet<Teacher>();
            TracingStudyPlanDevelopment = new HashSet<TracingStudyPlanDevelopment>();
        }

        public long TeacherEducationId { get; set; }
        public long TeacherId { get; set; }
        public string TeacherEducationTitle { get; set; }
        public long? EducationTypeId { get; set; }
        public DateTime? TeacherEducationFinishDate { get; set; }
        public string TeacherEducationInstitution { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual EducationType EducationType { get; set; }
        public virtual Status Status { get; set; }
        public virtual Teacher TeacherNavigation { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }
        public virtual ICollection<TracingStudyPlanDevelopment> TracingStudyPlanDevelopment { get; set; }
    }
}
